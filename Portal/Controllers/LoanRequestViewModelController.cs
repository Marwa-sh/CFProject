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
    public class LoanRequestViewModelController : BaseController
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


        public LoanRequestViewModelController()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;

            
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Insert = insert;
            ViewBag.Delete = delete;
           
        }

        #region Index Loan Request       
        public ActionResult Index()
        {
            return View();
        }
        #endregion


        #region Create Loan Request        
        [HttpGet]
        public ActionResult Create()
        {

            Db db = new Db(DbServices.ConnectionString);
            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name");
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");

            // For Request
            //We need to customise the droplist for two options
            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db).Where((c => (c.Id == 0 || c.Id == 2))), "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(LoanRequestViewModel model)
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
                        Product p = ProductServices.Insert(CurrentUser.Id, model.RequestProduct, db);
                        productId = p.Id;

                        //2-Add Request                        
                        model.Request.Product = p.Id;
                        model.Request.RequestStatus = (int) RequestStatusEnum.New;
                        model.Request.Cost = 5;
                        Request r = RequestServices.Insert(CurrentUser.Id, model.Request, db);

                        //3-Add LoanRequest
                        model.LoanRequest.Request = p.Id;
                        LoanRequestServices.Insert(CurrentUser.Id, model.LoanRequest, db);

                        //4- Add RefundableProduct

                        model.RequestProductProductRefundableProduct.Product = p.Id;
                        RefundableProductServices.Insert(CurrentUser.Id, model.RequestProductProductRefundableProduct, db);

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

        #region Edit Loan Request
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = ProductServices.Get(id.Value, db);
            Request request = RequestServices.Get(id.Value, db);
            LoanRequest loanRequest = LoanRequestServices.Get(id.Value, db);
            RefundableProduct refundableProduct = RefundableProductServices.Get(id.Value, db);

            if (product == null || request == null || loanRequest == null || refundableProduct == null)
            {
                return HttpNotFound();
            } 
 
            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name", product.Employee);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", product.ProductType);

            // For Request
            //We need to customise the droplist for two options
            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db).Where((c => (c.Id == 0 || c.Id == 2))), "Id", "Name");

            LoanRequestViewModel vm = new LoanRequestViewModel();            
            vm.RequestProduct = product;
            vm.Request = request;
            vm.LoanRequest = loanRequest;
            vm.RequestProductProductRefundableProduct = refundableProduct;

            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(LoanRequestViewModel model)
        {
            Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
                try
                {
                    // 1- Add Prouct
                    // set the Amount of the Produt the same as Request
                    model.RequestProduct.Amount = model.Request.Amount;
                    Product p = ProductServices.Insert(CurrentUser.Id, model.RequestProduct, db);
                    ProductServices.Update(CurrentUser.Id, model.RequestProduct, db);

                    //2-Add Request                        
                    model.Request.Product = p.Id;
                    model.Request.RequestStatus = (int)RequestStatusEnum.New;
                    model.Request.Cost = 5;
                    Request r = RequestServices.Insert(CurrentUser.Id, model.Request, db);

                    //3-Add LoanRequest
                    model.LoanRequest.Request = model.RequestProduct.Id;
                    LoanRequestServices.Update(CurrentUser.Id, model.LoanRequest, db);

                    //4- Add RefundableProduct

                    model.RequestProductProductRefundableProduct.Product = model.RequestProduct.Id;
                    RefundableProductServices.Update(CurrentUser.Id, model.RequestProductProductRefundableProduct, db);

                    TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "UpdateConfirmed");

                    return RedirectToAction("Index", "LoanRequest");
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

            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", model.RequestProduct.Employee);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", model.RequestProduct.ProductType);

            // For Request
            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db), "Id", "Name", model.Request.BypassStatus);
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", model.Request.Product);
            ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name", model.Request.RequestStatus);

            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;


            return View(model);
        }

        #endregion

        #region Details Loan Request

        public ActionResult Details(int? id)
        {
            ViewBag.TitleGuarantor = TitleGuarantor;
            ViewBag.TitleExceptionalAount = TitleExceptionalAount;
            
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
            //// Request
            //RequestVwViewModel requestVwViewModel = new RequestVwViewModel();
            //requestVwViewModel.Instance = RequestVwServices.GetChildren(id.Value, db);
            //if (requestVwViewModel.Instance == null)
            //{
            //    return HttpNotFound();
            //}

            //// Loan Request
            //LoanRequestVwViewModel loanRequestVwViewModel = new LoanRequestVwViewModel();
            //loanRequestVwViewModel.Instance = LoanRequestVwServices.GetChildren(id.Value, db);
            //if (loanRequestVwViewModel.Instance == null)
            //{
            //    return HttpNotFound();
            //}

            //// RefundableProduct
            //RefundableProductVwViewModel refundableProductVwViewModel = new RefundableProductVwViewModel();
            //refundableProductVwViewModel.Instance = RefundableProductVwServices.GetChildren(id.Value, db);
            //if (refundableProductVwViewModel.Instance == null)
            //{
            //    return HttpNotFound();
            //}

            //refundableProductVwViewModel.GuarantorVwViewModel.List = refundableProductVwViewModel.Instance.GuarantorVwList;

            //LoanRequestViewModel vm = new LoanRequestViewModel();
            //vm.ProductVwViewModel = productVwViewModel;
            //vm.RequestVwViewModel = requestVwViewModel;
            //vm.LoanRequestVwViewModel = loanRequestVwViewModel;
            //vm.RefundableProductVwViewModel = refundableProductVwViewModel;

            //vm.ExceptionalAmountVwViewModel.List = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value);




            return View(productVwViewModel);
        }

        #endregion






    }
}