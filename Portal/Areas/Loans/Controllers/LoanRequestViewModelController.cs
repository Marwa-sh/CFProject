﻿using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.Loans.Controllers
{
    public class LoanRequestViewModelController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequestViewModel", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequestViewModel", "ModuleNamePlural");
        private string approve = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Approve");

        private string validateDiscover = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "ValidateDiscover");

        private string TitleGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string TitleExceptionalAount = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");

        private string exceptionalIncome = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "ExceptionalIncome");
        private string exceptionalDeduction = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "ExceptionalDeduction");
        private string netDeduction = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "NetDeduction");


        private string LoanDecision = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleName");
        private string discover = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Discover");

        private string loan = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Loan", "ModuleName");
        private string employee = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Employee", "ModuleName");

        private string exceeds = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EmployeeCalculator", "AmountExceeds");
        private string good = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EmployeeCalculator", "AmountAccepted");
        private string result = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Result");

        private string amountSituationAccepted = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "AmountSituationAccepted");
        private string debtsSituationAccepted = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "DebtsSituationAccepted");
        private string installmentSituationAccepted = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "InstallmentSituationAccepted");

        private string amountSituationRejected = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "AmountSituationRejected");
        private string debtsSituationRejected = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "DebtsSituationRejected");
        private string installmentSituationRejected = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "InstallmentSituationRejected");


        public LoanRequestViewModelController()
        {
            ViewBag.Title = index;
            ViewBag.ModuleName = moduleName;

            ViewBag.ValidateDiscover = validateDiscover;
            ViewBag.Discover = discover;
            ViewBag.Loan = loan;
            ViewBag.Employee = employee;

            ViewBag.Action = update;
            ViewBag.Exceeds = exceeds;
            ViewBag.Good = good;
            ViewBag.Result = result;

            ViewBag.AmountSituationAccepted = amountSituationAccepted;
            ViewBag.DebtsSituationAccepted = debtsSituationAccepted;
            ViewBag.InstallmentSituationAccepted = installmentSituationAccepted;

            ViewBag.AmountSituationRejected = amountSituationRejected;
            ViewBag.DebtsSituationRejected = debtsSituationRejected;
            ViewBag.InstallmentSituationRejected = installmentSituationRejected;

        }

        #region Index Loan Request       
        public ActionResult Index(LoanRequestVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);

            ViewBag.ProductTypeList = new SelectList(LoanTypeVwServices.List(db), "ProductTypeId", "ProductTypeName");            
            ViewBag.RequestStatusList= new SelectList(RequestStatusServices.List(db), "Id", "Name");

            if (Model.Filter.HasCriteria)
            {
                Model.List = LoanRequestVwServices.Get(Model.Filter, db);
            }
            else
                Model.List = new List<LoanRequestVw>();
            return View(Model);
        }
        #endregion


        #region Create Loan Request        
        [HttpGet]
        public ActionResult Create()
        {
            try
            {                
                Db db = new Db(DbServices.ConnectionString);
                // For Product
                //ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name");

                //Just Show Loan Type            
                ViewBag.ProductTypeList = new SelectList(LoanTypeVwServices.List(db), "ProductTypeId", "ProductTypeName");

                // For Request
                //We need to customise the droplist for two options
                ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db).Where((c => (c.Id == 0 || c.Id == 2))), "Id", "Name");

            }
            catch (CfException cfex)
            {
                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
            }
            catch (Exception ex)
            {
                TempData["Failure"] = ex.Message;
            }
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
                        EmployeeProductCalculatorFilter f = new EmployeeProductCalculatorFilter();
                        f.EmployeeId = model.RequestProduct.Employee; f.ProductTypeId = (short)model.RequestProduct.ProductType;
                        f.Amount = (decimal)model.Request.Amount; f.Period = (short)model.RequestProductProductRefundableProduct.PaymentPeriod;
                        List<EmployeeProductCalculatorResult> result = db.EmployeeProductCalculator(f);
                        if (result.Count > 0)
                        {
                            model.RequestProductProductRefundableProduct.NetAmount = result[0].NetAmount.Value;
                            model.RequestProductProductRefundableProduct.ProfitAmount = result[0].ProfitAmount.Value;
                            model.RequestProductProductRefundableProduct.Installment = result[0].Installment.Value;
                        }
                        // 1- Add Prouct
                        // set the Amount of the Produt the same as Request
                        model.RequestProduct.Amount = model.Request.Amount;
                        Product p = ProductServices.Insert(CurrentUser.Id, model.RequestProduct, db);
                        productId = p.Id;

                        //2-Add Request                        
                        model.Request.Product = p.Id;
                        model.Request.RequestStatus = (int)RequestStatusEnum.New;
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
            catch (CfException cfex)
            {
                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
            }
            catch (Exception ex)
            {
                TempData["Failure"] = ex.Message;
            }
            return View();
        }

        #endregion

        #region Edit Loan Request
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            LoanRequestViewModel vm = new LoanRequestViewModel();
            try
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
                //ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name", product.Employee);
                ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", product.ProductType);

                // For Request
                //We need to customise the droplist for two options
                ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db).Where((c => (c.Id == 0 || c.Id == 2))), "Id", "Name");


                EmployeeProductCalculatorFilter f = new EmployeeProductCalculatorFilter();
                f.EmployeeId = product.Employee; f.ProductTypeId = (short)product.ProductType;
                f.Amount = (decimal)request.Amount; f.Period = (short)refundableProduct.PaymentPeriod;
                EmployeeProductCalculatorResult result = db.EmployeeProductCalculatorFirstOrDefault(f);
                if (result != null)
                {
                    ViewBag.Calculations = result;
                }
                
                vm.RequestProduct = product;
                vm.Request = request;
                vm.LoanRequest = loanRequest;
                vm.RequestProductProductRefundableProduct = refundableProduct;

            }
            catch (CfException cfex)
            {
                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
            }
            catch (Exception ex)
            {
                TempData["Failure"] = ex.Message;
            }
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
                    EmployeeProductCalculatorFilter f = new EmployeeProductCalculatorFilter();
                    f.EmployeeId = model.RequestProduct.Employee; f.ProductTypeId = (short)model.RequestProduct.ProductType;
                    f.Amount = (decimal)model.Request.Amount; f.Period = (short)model.RequestProductProductRefundableProduct.PaymentPeriod;
                    List<EmployeeProductCalculatorResult> result = db.EmployeeProductCalculator(f);
                    if (result.Count > 0)
                    {
                        model.RequestProductProductRefundableProduct.NetAmount = result[0].NetAmount.Value;
                        model.RequestProductProductRefundableProduct.ProfitAmount = result[0].ProfitAmount.Value;
                        model.RequestProductProductRefundableProduct.Installment = result[0].Installment.Value;
                    }
                    // 1- Add Prouct
                    // set the Amount of the Produt the same as Request
                    //model.RequestProduct.Amount = model.Request.Amount;
                    ProductServices.Update(CurrentUser.Id, model.RequestProduct, db);
                    ProductServices.Update(CurrentUser.Id, model.RequestProduct, db);

                    //2-Add Request                        
                    //model.Request.Product = model.RequestProduct.Id;
                    // model.Request.RequestStatus = (int)RequestStatusEnum.New;
                    //model.Request.Cost = 5;
                    RequestServices.Update(CurrentUser.Id, model.Request, db);

                    //3-Add LoanRequest
                    //model.LoanRequest.Request = model.RequestProduct.Id;
                    LoanRequestServices.Update(CurrentUser.Id, model.LoanRequest, db);

                    //4- Add RefundableProduct

                    //model.RequestProductProductRefundableProduct.Product = model.RequestProduct.Id;
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


            return View(model);
        }

        #endregion

        #region Details Loan Request

        public ActionResult Details(int? id)
        {
            ViewBag.TitleGuarantor = TitleGuarantor;
            ViewBag.TitleExceptionalAount = TitleExceptionalAount;
            ViewBag.ExceptionalIncome = exceptionalIncome;
            ViewBag.ExceptionalDeduction = exceptionalDeduction;
            ViewBag.NetDeduction = netDeduction;

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
            productVwViewModel.RequestVwViewModel.LoanRequestVwViewModel.Instance = LoanRequestVwServices.Get(id.Value);
            productVwViewModel.RefundableProductVwViewModel.Instance = RefundableProductVwServices.Get(id.Value);

            List<GuarantorVw> Guarantors = GuarantorVwServices.GetByRefundableProductProductId(id.Value);
            productVwViewModel.RefundableProductVwViewModel.GuarantorVwViewModel.List = Guarantors;


            productVwViewModel.RequestVwViewModel.LoanRequestVwViewModel.ExceptionalAmountVwViewModel.List = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value);

            List<ExceptionalAmountVw> NetDeduction = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value).Where(c => c.ExceptionalAmountTypeId == (int)ExceptionalAmountTypeEnum.NetDeduction).ToList();
            List<ExceptionalAmountVw> ExceptionalIncome = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value).Where(c => c.ExceptionalAmountTypeId == (int)ExceptionalAmountTypeEnum.ExceptionalIncome).ToList();
            List<ExceptionalAmountVw> ExceptionalDeduction = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value).Where(c => c.ExceptionalAmountTypeId == (int)ExceptionalAmountTypeEnum.ExceptionalDeduction).ToList();

            ViewBag.NetDeductionList = NetDeduction;
            ViewBag.ExceptionalIncomeList = ExceptionalIncome;
            ViewBag.ExceptionalDeductionList = ExceptionalDeduction;

            // Calculate Solvency and Boundries

            EmployeeProductCalculatorFilter f = new EmployeeProductCalculatorFilter()
            {
                EmployeeId = productVwViewModel.Instance.EmployeeId,
                ProductTypeId = productVwViewModel.Instance.ProductTypeId,
                Amount = productVwViewModel.RequestVwViewModel.Instance.Amount,
                Period = productVwViewModel.RefundableProductVwViewModel.Instance.PaymentPeriod
            };

            EmployeeProductCalculatorResult result = db.EmployeeProductCalculatorFirstOrDefault(f);
            if (result != null)
            {
                GetEmployeeSolvencyFilter filter = new GetEmployeeSolvencyFilter()
                {
                    EmployeeId = productVwViewModel.Instance.EmployeeId,
                    Amount = productVwViewModel.RequestVwViewModel.Instance.Amount,
                    Date = System.DateTime.Now,
                    Installment = result.Installment,
                    GrossSalary = productVwViewModel.RequestVwViewModel.LoanRequestVwViewModel.Instance.NetIncome,
                    NetSalary = productVwViewModel.RequestVwViewModel.LoanRequestVwViewModel.Instance.NetIncome
                };
                GetEmployeeSolvencyResult solvencyResult = db.GetEmployeeSolvencyFirstOrDefault(filter);
                ViewBag.Calculator = result;
                ViewBag.Solvency = solvencyResult;
            }


            return View(productVwViewModel);
        }

        #endregion


        #region  Calculate Employee Product
        public ActionResult EmployeeCalculator()
        {

            Db db = new Db(DbServices.ConnectionString);
            // For Product
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name");

            //ToDo: Just Show Loan Type

            List<LoanType> l = LoanTypeServices.List(db);
            List<ProductType> f = ProductTypeServices.List(db);


            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");

            return View();
        }


        #endregion

        [HttpPost]
        public JsonResult Calculate(int employeeId, int productTypeId, float amount, int period, float netAmount, float deductions)
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                EmployeeProductCalculatorFilter f = new EmployeeProductCalculatorFilter()
                {
                    EmployeeId = employeeId,
                    ProductTypeId = (short)productTypeId,
                    Amount = (decimal)amount,
                    Period = (short)period
                };

                EmployeeProductCalculatorResult result = db.EmployeeProductCalculatorFirstOrDefault(f);
                if (result == null)
                {
                    return Json(new { error="Error", message = "Invalide Id" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    GetEmployeeSolvencyFilter filter = new GetEmployeeSolvencyFilter()
                    {
                        EmployeeId = employeeId,
                        Amount = (decimal)amount,
                        Date = System.DateTime.Now,
                        Installment = result.Installment,
                        GrossSalary = (decimal)netAmount,
                        NetSalary = (decimal)netAmount

                    };
                    GetEmployeeSolvencyResult solvencyResult = db.GetEmployeeSolvencyFirstOrDefault(filter);

                    return Json(new { Calculator = result, Solevency = solvencyResult }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (CfException cfex)
            {
                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
            }
            catch (Exception ex)
            {
                TempData["Failure"] = ex.Message;
            }

            return Json("Error", JsonRequestBehavior.AllowGet);
        }



        #region Guarantor - Statement
        public ActionResult CreateGuarantorWithStatement(int? id)
        {
            Db db = new Db(DbServices.ConnectionString);
            if (id != null)
            {
                ViewBag.ProductId = id.Value;
            }
            else
            {
                RedirectToAction("Index");
            }
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name");
            return PartialView();
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
                        model.Guarantor.GuarantorStatus = (int)GuarantorStatusEnum.New;
                        // 1- Add Guaratntor
                        Guarantor g = GuarantorServices.Insert(CurrentUser.Id, model.Guarantor, db);

                        //2-Add GuarantorStatement                        
                        model.GuarantorStatement.Guarantor = g.Id;
                        GuarantorStatement gs = GuarantorStatementServices.Insert(CurrentUser.Id, model.GuarantorStatement, db);

                        Request r = db.RequestGet(model.Guarantor.RefundableProduct);
                        RefundableProduct rp = db.RefundableProductGet(model.Guarantor.RefundableProduct);

                        //Calculate Solvency 
                        GetEmployeeSolvencyFilter filter = new GetEmployeeSolvencyFilter()
                        {
                            EmployeeId = model.Guarantor.Employee,
                            Amount = r.Amount,
                            Date = r.Date,
                            Installment = rp.Installment,
                            GrossSalary = model.GuarantorStatement.GrossSalary,
                            NetSalary = model.GuarantorStatement.NetSalary
                        };
                        GetEmployeeSolvencyResult solvencyResult = db.GetEmployeeSolvencyFirstOrDefault(filter);

                        // update notes field at Guarantor
                        string result = getResult(solvencyResult);
                        g.Notes = result;
                        GuarantorServices.Update(CurrentUser.Id, g, db);

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
                return View("Details");
            }



        }

        private string getResult(GetEmployeeSolvencyResult solvencyResult)
        {
            string result = "";
            if (solvencyResult.IncomeSolvency < solvencyResult.MaxAllowedDebt)
            {
                result += debtsSituationAccepted + ".";
            }
            else
            {
                result += debtsSituationRejected + ".";
            }
            if (solvencyResult.NetSalarySolvency > 0)
            {
                result += installmentSituationAccepted + ".";
            }
            else
            {
                result += installmentSituationRejected + ". ";
            }

            return result;
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


            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "Id_Name", guarantor.Employee);
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
                return RedirectToAction("Details", new { id = model.Guarantor.RefundableProduct });
            }
            catch
            {
                return View();
            }

        }


        // GET: Guarantor/Delete/5
        public ActionResult DeleteGuarantorWithStatement(Nullable<int> id, int ProductId)
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
            ViewBag.ProductId = ProductId;
            return PartialView(guarantor);
        }

        // POST: Guarantor/Delete/5
        [HttpPost, ActionName("DeleteGuarantorWithStatement")]
        public ActionResult DeleteConfirmedGuarantorWithStatement(int id, int ProductId)
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                GuarantorStatementServices.Delete(CurrentUser.Id, id, db);
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

            //return RedirectToAction("Index");
            return RedirectToAction("Details", new { id = ProductId });
        }


        #endregion

        #region ExceptionalAmount

        public ActionResult createExceptionalAmount(int? id, string Type)
        {

            try
            {
                Db db = new Db(DbServices.ConnectionString);

                if (id != null)
                {
                    ViewBag.LoanRequestId = id;
                }
                ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name", Type);
                ViewBag.Type = Type;

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
        public ActionResult createExceptionalAmount(ExceptionalAmount model)
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
            return View("Details", new { id = model.LoanRequest });

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
        public ActionResult DeleteExceptionalAmount(Nullable<int> id, int ProductId)
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
            ViewBag.ProductId = ProductId;
            return PartialView(expAmount);
        }

        // POST: Guarantor/Delete/5
        [HttpPost, ActionName("DeleteExceptionalAmount")]
        public ActionResult DeleteConfirmedExceptionalAmount(int id, int ProductId)
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
            //return RedirectToAction("Index");
            return RedirectToAction("Details", new { id = ProductId });

        }


        #endregion




    }
}