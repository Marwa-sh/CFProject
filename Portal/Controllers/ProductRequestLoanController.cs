using Cf.Data;
using Cf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Portal.ViewModels;
using System.Data;
using Cf.Controllers;
using Cf.Services.Exceptions;
using System.Net;
using Cf.ViewModels;

namespace Portal.Controllers
{
    public class ProductRequestLoanController  : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleNamePlural");
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


        private string  TitleGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string  TitleExceptionalAount = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");
        private string LoanDecision = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleName");
        // GET: ProductRequestLoan
        public ActionResult Index(ManageLoanDecision Model)
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
            Db db = new Db(DbServices.ConnectionString);

            //User.


            //Model.LoanRequestVwViewModel.Filter.RequestRequestStatusId;
            Model.LoanRequestVwViewModel.List = LoanRequestVwServices.Get(Model.LoanRequestVwViewModel.Filter, db);
            if (Model.LoanRequestVwViewModel.Filter.HasCriteria)
            {
                Model.LoanRequestVwViewModel.List = LoanRequestVwServices.Get(Model.LoanRequestVwViewModel.Filter, db);
            }
            else
                Model.LoanRequestVwViewModel.List = new List<LoanRequestVw>();

            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name");

            ViewBag.LoanDecision = LoanDecision;

            return View(Model);
             
        }

        // GET: ProductRequestLoan/Details/5
        public ActionResult Details(int? id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
            ViewBag.Insert = insert;
            ViewBag.Delete = delete;

            ViewBag.TitleGuarantor = TitleGuarantor;
            ViewBag.TitleExceptionalAount = TitleExceptionalAount;
            // Details Of Products

            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
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

            // Request
            RequestVwViewModel requestVwViewModel = new RequestVwViewModel();
            requestVwViewModel.Instance = RequestVwServices.GetChildren(id.Value, db);
            if (requestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            // Loan Request
            LoanRequestVwViewModel loanRequestVwViewModel = new LoanRequestVwViewModel();
            loanRequestVwViewModel.Instance = LoanRequestVwServices.GetChildren(id.Value, db);
            if (loanRequestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            // RefundableProduct
            RefundableProductVwViewModel refundableProductVwViewModel = new RefundableProductVwViewModel();
            refundableProductVwViewModel.Instance = RefundableProductVwServices.GetChildren(id.Value, db);
            if (refundableProductVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            refundableProductVwViewModel.GuarantorVwViewModel.List = refundableProductVwViewModel.Instance.GuarantorVwList;
             
            ProductRequestLoanViewModel vm = new ProductRequestLoanViewModel();
            vm.ProductVwViewModel = productVwViewModel;
            vm.RequestVwViewModel = requestVwViewModel;
            vm.LoanRequestVwViewModel = loanRequestVwViewModel;
            vm.RefundableProductVwViewModel = refundableProductVwViewModel;

            vm.ExceptionalAmountVwViewModel.List = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value);




            return View(vm);
        }

        // GET: ProductRequestLoan/Create
        public ActionResult Create()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            Db db = new Db(DbServices.ConnectionString);

            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name");
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
              
            // For Request
            //We need to customise the droplist for two options
            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db).Where((c=>(c.Id==0 || c.Id==2 ))), "Id", "Name");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
            //ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name");

            // For Loan Request
            //ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
            return View();
        }

        // POST: ProductRequestLoan/Create
        [HttpPost]
        public ActionResult Create(ProductRequestLoanViewModel model)
        {
            int productId=0;
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
                        model.Product.Amount = model.Request.Amount;
                        Product p = ProductServices.Insert(CurrentUser.Id, model.Product, db);
                        productId = p.Id;

                        //2-Add Request                        
                        model.Request.Product = p.Id;
                        model.Request.RequestStatus = 1; // قيد المعالجة
                        model.Request.Cost = 5;
                        Request r = RequestServices.Insert(CurrentUser.Id, model.Request, db);

                        //3-Add LoanRequest
                        model.LoanRequest.Request = p.Id;
                        LoanRequestServices.Insert(CurrentUser.Id, model.LoanRequest, db);

                        //4- Add RefundableProduct

                        model.RefundableProduct.Product = p.Id;
                        RefundableProductServices.Insert(CurrentUser.Id, model.RefundableProduct, db);

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
                return RedirectToAction("Details" , new   { id= productId });
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductRequestLoan/Edit/5
        public ActionResult Edit(int ? id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;

            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = ProductServices.Get(id.Value, db);
            if (product == null)
            {
                return HttpNotFound();
            }

            Request request = RequestServices.Get(id.Value, db);
            if (request == null)
            {
                return HttpNotFound();
            }

            LoanRequest loanRequest = LoanRequestServices.Get(id.Value, db);
            if (loanRequest == null)
            {
                return HttpNotFound();
            }

            RefundableProduct refundableProduct = RefundableProductServices.Get(id.Value, db);
            if (refundableProduct == null)
            {
                return HttpNotFound();
            }
            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name",product.Employee);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", product.ProductType);

            // For Request
            //We need to customise the droplist for two options
            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db).Where((c => (c.Id == 0 || c.Id == 2))), "Id", "Name");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes",request.Product);
            //ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name",request.RequestStatus);


            ProductRequestLoanViewModel vm = new ProductRequestLoanViewModel();
            vm.Product = product;
            vm.Request = request;
            vm.LoanRequest = loanRequest;
            vm.RefundableProduct = refundableProduct;

            return View(vm);
        }

        // POST: ProductRequestLoan/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductRequestLoanViewModel model)
        {
            Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
                try
                {
                    // 1- Add Prouct
                    // set the Amount of the Produt the same as Request
                    model.Product.Amount = model.Request.Amount;
                    Product p = ProductServices.Insert(CurrentUser.Id, model.Product, db);
                    ProductServices.Update(CurrentUser.Id, model.Product, db);

                    //2-Add Request                        
                    model.Request.Product = p.Id;
                    model.Request.RequestStatus = 1; // قيد المعالجة
                    model.Request.Cost = 5;
                    Request r = RequestServices.Insert(CurrentUser.Id, model.Request, db);
  
                    //3-Add LoanRequest
                    model.LoanRequest.Request = model.Product.Id;                   
                    LoanRequestServices.Update(CurrentUser.Id, model.LoanRequest, db);

                    //4- Add RefundableProduct

                    model.RefundableProduct.Product = model.Product.Id;
                    RefundableProductServices.Update(CurrentUser.Id, model.RefundableProduct, db);

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
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", model.Product.Employee);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", model.Product.ProductType);

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

        #region Guarantor - Statement
        public ActionResult CreateGuarantorWithStatement(int ? id )
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            Db db = new Db(DbServices.ConnectionString);
            if(id!=null)
            {
                ViewBag.ProductId = id.Value;
            }
           
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.GuarantorStatusList = new SelectList(GuarantorStatusServices.List(db), "Id", "Name");
            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name");
            return PartialView();// View();
        }
        [HttpPost]
        public ActionResult CreateGuarantorWithStatement(GuarantorWithStatmentViewModel model)
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                if (!(db.Connection.State == ConnectionState.Open)) db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();

                if (ModelState.IsValid)
                {
                    try
                    {
                        // 1- Add Guaratntor
                        Guarantor g = GuarantorServices.Insert(CurrentUser.Id, model.Guarantor, db);

                        //2-Add GuarantorStatement                        
                        model.GuarantorStatement.Guarantor = g.Id;
                        GuarantorStatement gs = GuarantorStatementServices.Insert(CurrentUser.Id, model.GuarantorStatement, db);

                        
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
                return RedirectToAction("Details", new   { id= model .Guarantor.RefundableProduct});
            }
            catch
            {
                return View("Details");
            }

            
             
        }

        public ActionResult EditGuarantorWithStatement(int? id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guarantor guarantor = GuarantorServices.Get(id.Value, db);
            if (guarantor == null)
            {
                return HttpNotFound();
            }

            
            GuarantorStatement guarantorStatement = GuarantorStatementServices.Get(guarantor.Id, db);
            if (guarantorStatement == null)
            {
                return HttpNotFound();
            }

            
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", guarantor.Employee);
            ViewBag.GuarantorStatusList = new SelectList(GuarantorStatusServices.List(db), "Id", "Name", guarantor.GuarantorStatus);
            ViewBag.ProductId = guarantor.RefundableProduct;
            GuarantorWithStatmentViewModel vm = new GuarantorWithStatmentViewModel();
            vm.Guarantor = guarantor;
            vm.GuarantorStatement = guarantorStatement;


            return PartialView(vm);
        }

        [HttpPost]
        public ActionResult EditGuarantorWithStatement(GuarantorWithStatmentViewModel model)
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                if (!(db.Connection.State == ConnectionState.Open)) db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();

                if (ModelState.IsValid)
                {
                    try
                    {
                        // 1- Update Guaratntor
                        GuarantorServices.Update(CurrentUser.Id, model.Guarantor, db);
                        
                        //2-Update GuarantorStatement                        
                        model.GuarantorStatement.Guarantor = model.Guarantor.Id;
                        GuarantorStatementServices.Update(CurrentUser.Id, model.GuarantorStatement, db);

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
                return RedirectToAction("Details", new { id = model.Guarantor.RefundableProduct });
            }
            catch
            {
                return View();
            }
             
        }


        // GET: Guarantor/Delete/5
        public ActionResult DeleteGuarantorWithStatement(Nullable<int> id)
        {
            //ViewBag.ModuleName = moduleName;
            ViewBag.Title = delete;
            ViewBag.Delete = delete;
            ViewBag.Yes = yes;
            ViewBag.No = no;
            ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Action = delete;

            ViewBag.TitleGuarantor = TitleGuarantor;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Guarantor guarantor = GuarantorServices.Get(id.Value, db);
            if (guarantor == null)
            {
                return HttpNotFound();
            }
            return PartialView(guarantor);
        }

        // POST: Guarantor/Delete/5
        [HttpPost, ActionName("DeleteGuarantorWithStatement")]
        public ActionResult DeleteConfirmedGuarantorWithStatement(int id)
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                GuarantorStatementServices.Delete(CurrentUser.Id,id, db);
                GuarantorServices.Delete(CurrentUser.Id, id, db);
                TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "DeleteConfirmed");
                // return RedirectToAction("Index");
            }
            catch (CfException cfex)
            {
                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
            }
            catch (Exception ex)
            {
                TempData["Failure"] = ex.Message;
            }
            //return RedirectToAction("Details", new { id = model.Guarantor.RefundableProduct });
            // return View(guarantor);
            return RedirectToAction("Index");

        }


        #endregion

        #region

        public ActionResult createExceptionalAmount(int ? id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            try
            {
                Db db = new Db(DbServices.ConnectionString);

                if(id!=null)
                {
                    ViewBag.LoanRequestId = id;
                }
                ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name");
                
                return PartialView();
            }
            catch (CfException exc)
            {
                
            }
            catch (Exception exc)
            {            
                
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult createExceptionalAmount(ExceptionalAmount model )
        {
            Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
                try
                {
                    ExceptionalAmountServices.Insert(CurrentUser.Id, model, db);
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
                return RedirectToAction("Details", new { id = model.LoanRequest });
            }

            ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name");
            ViewBag.LoanRequestList = new SelectList(LoanRequestServices.List(db), "Request", "Name");
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return   View("Details",new { id = model.LoanRequest });

        }

        public ActionResult editExceptionalAmount(int? id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExceptionalAmount exceptionalAmount = ExceptionalAmountServices.Get(id.Value, db);
            if (exceptionalAmount == null)
            {
                return HttpNotFound();
            }

            ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name", exceptionalAmount.ExceptionalAmountType);
             
            return PartialView(exceptionalAmount);
        }
        [HttpPost]
        public ActionResult editExceptionalAmount(ExceptionalAmount model)
        {
            Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
                try
                {
                    ExceptionalAmountServices.Update(CurrentUser.Id, model, db);
                    TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "UpdateConfirmed");
                    return RedirectToAction("Details", new { id = model.LoanRequest });
                }
                catch (CfException cfex)
                {
                    TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
                }
                catch (Exception ex)
                {
                    TempData["Failure"] = ex.Message;
                }
                return RedirectToAction("Details", new { id = model.LoanRequest });
            }

            ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name", model.ExceptionalAmountType);
            
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View("Details", new { id = model.LoanRequest });
        }

        // GET: Guarantor/Delete/5
        public ActionResult DeleteExceptionalAmount(Nullable<int> id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Title = delete;
            ViewBag.Delete = delete;
            ViewBag.Yes = yes;
            ViewBag.No = no;
            ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Action = delete;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ExceptionalAmount expAmount = ExceptionalAmountServices.Get(id.Value, db);
            if (expAmount == null)
            {
                return HttpNotFound();
            }
            return PartialView(expAmount);
        }

        // POST: Guarantor/Delete/5
        [HttpPost, ActionName("DeleteExceptionalAmount")]
        public ActionResult DeleteConfirmedExceptionalAmount(int id)
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                ExceptionalAmountServices.Delete(CurrentUser.Id, id, db);
                TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "DeleteConfirmed");
                // return RedirectToAction("Index");
            }
            catch (CfException cfex)
            {
                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
            }
            catch (Exception ex)
            {
                TempData["Failure"] = ex.Message;
            }
            // return View(guarantor);
            return RedirectToAction("Index");

        }


        #endregion

        #region Manage Loan Decisions 

        [HttpPost]
        public ActionResult CreateLoanDecision(LoanDecision model)
        {

            return View();
        }

        #endregion



        // GET: ProductRequestLoan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductRequestLoan/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
