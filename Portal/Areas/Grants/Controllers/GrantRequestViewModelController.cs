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

namespace Portal.Areas.Grants.Controllers
{
    public class GrantRequestViewModelController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantRequestViewModel", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantRequestViewModel", "ModuleNamePlural");
        private string approve = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Approve");

        private string TitleGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string TitleExceptionalAount = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");
        private string LoanDecision = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleName");
        
        public GrantRequestViewModelController()
        {
            ViewBag.Title = index;
            ViewBag.ModuleName = moduleName;            
        }



        #region Index Of Grant Request
        // GET: GrantRequestViewModel
        public ActionResult Index(GrantRequestVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name");

            if (Model.Filter.HasCriteria)
            {                                 
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
                if (productId == 0)
                    return RedirectToAction("Index");
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
                return RedirectToAction("Index");
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
            int productId = model.RequestProduct.Id;
            try
            {
                Db db = new Db(DbServices.ConnectionString);

                if (!(db.Connection.State == ConnectionState.Open)) db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();

                if (ModelState.IsValid)
                {
                    try
                    {
                        // 1- Update Prouct                     
                        ProductServices.Update(CurrentUser.Id, model.RequestProduct, db);

                        //2- Update Request 
                        RequestServices.Update(CurrentUser.Id, model.Request, db);

                        //3- Update GrantRequest
                        GrantRequestServices.Update(CurrentUser.Id, model.GrantRequest, db);

                        TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "UpdateConfirmed");

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
                if (productId == 0)
                    return RedirectToAction("Index");
                return RedirectToAction("Details", new { id = productId });
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}