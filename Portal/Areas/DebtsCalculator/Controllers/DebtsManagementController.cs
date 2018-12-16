using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.DebtsCalculator.Controllers
{
    public class DebtsManagementController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);

        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DebtsManagement", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DebtsManagement", "ModuleNamePlural");
        private string approve = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Approve");
        private string calculateDebts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DebtsManagement", "CalculateDebts");
        private string validateDiscover = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "ValidateDiscover");

        private string TitleGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string TitleExceptionalAount = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");

        private string exceptionalIncome = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "ExceptionalIncome");
        private string exceptionalDeduction = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "ExceptionalDeduction");
        private string netDeduction = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "NetDeduction");

        private string warrants = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DebtsManagement", "Warrants");
        private string debt = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DebtsManagement", "Debts");


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


        public DebtsManagementController()
        {
            ViewBag.Title = index;
            ViewBag.ModuleName = moduleName;

            ViewBag.CalculateDebts = calculateDebts;
            ViewBag.ValidateDiscover = validateDiscover;
            ViewBag.Discover = discover;
            ViewBag.Loan = loan;
            ViewBag.Employee = employee;
            ViewBag.Warrants = warrants;
            ViewBag.Debt = debt;

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


        // GET: DebtsCalculator/DebtsManagement
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddEmployeeDebtsAndWarrants()
        {
            return View();
        }

        public ActionResult EmployeeDebts()
        {
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                List<ProductType> f = ProductTypeServices.List(db);
                ViewBag.ProductTypeList = new SelectList(LoanTypeVwServices.List(db), "ProductTypeId", "ProductTypeName");

                ViewBag.IssuerList = new SelectList(IssuerServices.List(db), "Id", "Name");
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

        #region GetEmployeeSolvency
        [HttpGet]
        public ActionResult GetEmployeeSolvency()
        {
            return View();
        }
        [HttpPost]
        public JsonResult GetEmployeeSolvency(int employeeId, float amount, float installment, float netSalary, float grossSalary)
        {
            try
            {
                // get employee information

                EmployeeVw employee = EmployeeVwServices.Get(employeeId);
                if (employee == null)
                {
                    return Json(new { message = "الرقم الذاتي غير صحيح" }, JsonRequestBehavior.AllowGet);
                }

                GetEmployeeSolvencyFilter filter = new GetEmployeeSolvencyFilter()
                {
                    EmployeeId = employeeId,
                    Amount = (decimal)amount,
                    Date = System.DateTime.Now,
                    Installment =(decimal) installment,
                    GrossSalary = (decimal)grossSalary,
                    NetSalary = (decimal)netSalary
                };
                GetEmployeeSolvencyResult solvencyResult = db.GetEmployeeSolvencyFirstOrDefault(filter);
                
                return Json(new { Employee = employee, Solevency = solvencyResult }, JsonRequestBehavior.AllowGet);

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

        #endregion

        #region Calculate
        [HttpPost]
        public JsonResult Calculate(int employeeId, int productTypeId, float amount, int period, float netAmount, float deductions)
        {
            try
            {
                EmployeeVw employee = EmployeeVwServices.Get(employeeId);
                if (employee == null)
                {
                    return Json(new { status = false, message = "الرقم الذاتي غير صحيح" }, JsonRequestBehavior.AllowGet);
                }

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
                    return Json(new { status = false, message = "NoResult" }, JsonRequestBehavior.AllowGet);
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

                    return Json(new {status= true, Calculator = result, Solevency = solvencyResult }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (CfException cfex)
            {
                //TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
                return Json(new { status = false, message = cfex.ErrorDefinition.LocalizedMessage }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                //TempData["Failure"] = ex.Message;
                return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            
        }
        #endregion

        #region Create Debt
        [HttpPost]
        public JsonResult CreateDeb(Debt debt)
        {
            Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeeVw employee = EmployeeVwServices.Get(debt.Employee);
                    if (employee == null)
                    {
                        return Json(new { status = false, message = "الرقم الذاتي غير صحيح" }, JsonRequestBehavior.AllowGet);
                    }
                    if(debt.Date == null)
                    {
                        debt.Date = System.DateTime.Now;
                    }
                    debt = DebtServices.Insert(CurrentUser.Id, debt, db);
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
            else
            {
                string errorMsg = "";
                foreach (ModelState item in ModelState.Values)
                {
                    if (item.Errors.Count == 0)
                        continue;
                    else
                    {
                        for (int i = 0; i < item.Errors.Count; i++)
                        {
                            errorMsg += item.Errors[i].ErrorMessage + "\n";
                        }
                    }
                }
               
                return Json(new
                {
                    status= false,
                    message = errorMsg,                    
                }, JsonRequestBehavior.AllowGet);
            }
            return Json( new { status = true, Data = debt.Id }, JsonRequestBehavior.AllowGet);
        }
        //public string CreateDeb(Debt debt)
        //{
        //    Db db = new Db(DbServices.ConnectionString);
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            DebtServices.Insert(CurrentUser.Id, debt, db);
        //            TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "InsertConfirmed");
        //        }
        //        catch (CfException cfex)
        //        {
        //            TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
        //        }
        //        catch (Exception ex)
        //        {
        //            TempData["Failure"] = ex.Message;
        //        }
        //    }
        //    else
        //    {
        //        string errorMsg = "Modal is not valid";
        //        return errorMsg;
        //        //return Json(new
        //        //{
        //        //    error = errorMsg,
        //        //    data = 0
        //        //}, JsonRequestBehavior.AllowGet);
        //    }
        //    return ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "InsertConfirmed"); //new JsonResult() { Data = "Result" };
        //}

        #endregion


        #region Create Warrant
        [HttpPost]
        public ActionResult CreateWarrant(WarrantVwViewModel model)
        {
            WarrantVwViewModel Model = new WarrantVwViewModel();
            try
            {
                EmployeeVw employee = EmployeeVwServices.Get(model.Instance.DebtEmployeeId);
                if (employee == null)
                {
                    TempData["Failure"] = "الرقم الذاتي غير صحيح";
                    Model.List = WarrantVwServices.GetByDebtId(model.Instance.DebtId, db);
                    return PartialView("_WarrantsList", Model);                  
                }
                // check if this employee is not the debt employee
                Debt d = DebtServices.Get(model.Instance.DebtId, db);
                if(d != null)
                {
                    if(d.Employee == model.Instance.DebtEmployeeId)
                    {
                        TempData["Failure"] = "لا يمكن أن يكفل الموظف نفسه";
                        Model.List = WarrantVwServices.GetByDebtId(model.Instance.DebtId, db);
                        return PartialView("_WarrantsList", Model);
                    }
                }

                
                // check if this employee has been added as a garantaur
                Warrant ewarrant = WarrantServices.GetByDebt_EmployeeFirstOrNull(model.Instance.DebtId, model.Instance.DebtEmployeeId);
                if(ewarrant != null)
                {
                    TempData["Failure"] = "هذا الموظف هو كفيل حالياً لهذه المديونية";
                }
                else
                {
                    Warrant w = new Warrant()
                    {
                        Debt = model.Instance.DebtId,
                        Employee = model.Instance.DebtEmployeeId,
                        IsActive = model.Instance.IsActive,
                        Notes = model.Instance.Notes
                    };
                    w = WarrantServices.Insert(CurrentUserId, w, db);

                }

                Model.List = WarrantVwServices.GetByDebtId(model.Instance.DebtId, db);

                return PartialView("_WarrantsList", Model);
            }
            catch (CfException cfex)
            {
                TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
                //return Json(new { status = false, message = cfex.ErrorDefinition.LocalizedMessage }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                TempData["Failure"] = ex.Message;
                //return Json(new { status = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
            Model.List = WarrantVwServices.GetByDebtId(model.Instance.DebtId, db);
            return PartialView("_WarrantsList", Model);
        }

        #endregion 
    }
}