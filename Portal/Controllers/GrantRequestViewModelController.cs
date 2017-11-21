using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class GrantRequestViewModelController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequestViewModel", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequestViewModel", "ModuleNamePlural");
        private string insert = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Insert");
        private string update = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Update");
        private string delete = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Delete");
        private string save = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Save");
        private string back = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Back");
        private string details = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Details");
        private string confirmDelete = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "ConfirmDelete");
        private string yes = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Yes");
        private string no = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "No");
        private string search = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Search");
        private string filterOptions = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "FilterOptions");
        private string approve = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Approve");

        private string TitleGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string TitleExceptionalAount = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");
        private string LoanDecision = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleName");
        private string noRecords = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "NoRecords");
        

        public GrantRequestViewModelController()
        {
            ViewBag.Title = index;
            ViewBag.ModuleName = moduleName;
            ViewBag.Insert = insert;
            ViewBag.Update = update;
            ViewBag.Delete = delete;
            ViewBag.Details = details;
            ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Yes = yes;
            ViewBag.No = no;
            ViewBag.Search = search;
            ViewBag.FilterOptions = filterOptions;
            ViewBag.Back = back;
            ViewBag.Save = save;
            ViewBag.NoRecords = noRecords;
        }



        #region Index Of Grant Request
        // GET: GrantRequestViewModel
        public ActionResult Index(GrantRequestVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
            {                 
                Db db = new Db(DbServices.ConnectionString);
                Model.List = GrantRequestVwServices.Get(Model.Filter, db);
            }
            else
                Model.List = new List<GrantRequestVw>();
            return View(Model);
            
        }

        #endregion

        #region Create Grant Request        
        [HttpGet]
        public ActionResult Create()
        {

            Db db = new Db(DbServices.ConnectionString);
            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name");

            //For Grant             
            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name");         

            return View();
        }

        [HttpPost]
        public ActionResult Create(GrantRequestViewModel  model)
        {
            //return View();
            int productId = 0;
            try
            {
                Db db = new Db(DbServices.ConnectionString);

                if (!(db.Connection.State == ConnectionState.Open)) db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();

                if (ModelState.IsValid)
                {
                    try
                    {
                        // 1- Add Prouct
                        // set the Amount of the Produt the same as Request
                        model.RequestProduct.Amount = model.Request.Amount;
                        model.RequestProduct.ProductType = 0;

                        Product p = ProductServices.Insert(CurrentUser.Id, model.RequestProduct, db);
                        productId = p.Id;

                        //2-Add Request                        
                        model.Request.Product = p.Id;
                        model.Request.RequestStatus = (int)RequestStatusEnum.New;
                        model.Request.Cost = 5;
                        Request r = RequestServices.Insert(CurrentUser.Id, model.Request, db);

                        //3-Add LoanRequest
                        model.GrantRequest.Request = p.Id;
                        model.GrantRequest.Amount = model.Request.Amount;
                       
                        GrantRequestServices.Insert(CurrentUser.Id, model.GrantRequest, db);
    
                        TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "InsertConfirmed");

                    }
                    catch (CfException cfex)
                    {
                        TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
                    }
                    catch (Exception ex)
                    {
                        TempData["Failure"] = ex.Message;
                    }
                }

                if (db.Transaction != null) db.Transaction.Commit();
                return RedirectToAction("Details", new { id = productId });
            }
            catch
            {
                return View();
            }
        }

        #endregion

        #region Details Grant Request

        public ActionResult Details(int? id)
        {
            @ViewBag.ServiceEndGrantRequestVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ServiceEndGrantRequest", "ModuleName");
            // Details Of Products
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Db db = new Db(DbServices.ConnectionString);

            // Product
            ProductVwViewModel productVwViewModel = new ProductVwViewModel();
            productVwViewModel.Instance = ProductVwServices.GetChildren(id.Value, db);
            if (productVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            productVwViewModel.RequestVwViewModel.Instance = RequestVwServices.Get(id.Value);
            productVwViewModel.RequestVwViewModel.GrantRequestVwViewModel.Instance = GrantRequestVwServices.Get(id.Value);


            productVwViewModel.RequestVwViewModel.GrantRequestVwViewModel.ServiceEndGrantRequestVwViewModel.Instance = ServiceEndGrantRequestVwServices.Get(id.Value);

          
            return View(productVwViewModel);
        }

        #endregion


        #region Edit Grant Request 
        public ActionResult Edit(int? id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = ProductServices.Get(id.Value, db);
            Request request = RequestServices.Get(id.Value, db);
            GrantRequest loanRequest = GrantRequestServices.Get(id.Value, db);

            if (product == null || request == null || loanRequest == null)
            {
                return HttpNotFound();
            }

            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name", product.Employee);

            //For Grant             
            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name");

            GrantRequestViewModel vm = new GrantRequestViewModel();
            vm.RequestProduct = product;
            vm.Request = request;
            vm.GrantRequest = loanRequest;

            return View(vm);
        }
        [HttpPost]
        public ActionResult Edit(GrantRequestViewModel model )
        {
            return View();
        }
        #endregion
    }
}