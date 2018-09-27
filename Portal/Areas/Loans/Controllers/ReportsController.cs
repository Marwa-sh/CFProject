using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using Cf.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.Loans.Controllers
{
    public class ReportsController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string reportLoansBetweenTwoDates = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportLoansBetweenTwoDates");
        private string reportPaymentsBetweenTwoDates = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportPaymentsBetweenTwoDates");
        private string reportSubscriptionsBetweenTwoDates = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportSubscriptionsBetweenTwoDates");
        private string reportBalance = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "ReportBalance");
        private string print = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Reports", "Print");

        private string newAmounts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "NewAmounts");
        private string finishedAmounts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "FinishedAmounts");
        private string equalAmounts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "EqualAmounts");
        private string diffAmountsMore = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "DiffAmountsMore");
        private string diffAmountsLess = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "DiffAmountsLess");
        private string reportLoansVw = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "ReportLoansVw");
        public ReportsController()
        {
            #region ViewBags
            ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
            ViewBag.ReportPaymentsBetweenTwoDates = reportPaymentsBetweenTwoDates;
            ViewBag.ReportSubscriptionsBetweenTwoDates = reportSubscriptionsBetweenTwoDates;
            ViewBag.NewAmounts = newAmounts;
            ViewBag.FinishedAmounts = finishedAmounts;
            ViewBag.EqualAmounts = equalAmounts;
            ViewBag.DiffAmountsMore = diffAmountsMore;
            ViewBag.DiffAmountsLess = diffAmountsLess;
            ViewBag.ReportBalance = reportBalance;
            ViewBag.ReportLoansVw = reportLoansVw;
            ViewBag.Print = print;
            #endregion
        }

        #region Index
        public ActionResult Index()
        {
            return View();
        }
        #endregion

        #region ReportLoansBetweenTwoDates  

        public ActionResult ReportLoansBetweenTwoDates()
        {
            ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
            return View("_FilterReportLoansBetweenTwoDates");
        }

        [HttpPost]
        public ActionResult ReportLoansBetweenTwoDates(string operationType, ReportLoansBetweenTwoDatesFilter model)
        {
            try
            {
                if(operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportLoansBetweenTwoDates", model);
                }
                List<ReportLoansBetweenTwoDatesResult> result = DbServices.ReportLoansBetweenTwoDates(model, db);

                return PartialView("ReportLoansBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
                return View();
            }
        }

        #endregion

        #region ReportPaymentsBetweenTwoDates  

        public ActionResult ReportPaymentsBetweenTwoDates()
        {
            ViewBag.ReportPaymentsBetweenTwoDates = reportPaymentsBetweenTwoDates;
            return View("_FilterReportPaymentsBetweenTwoDates");
        }

        [HttpPost]
        public ActionResult ReportPaymentsBetweenTwoDates(string operationType, ReportPaymentsBetweenTwoDatesFilter model)
        {
            try
            {
                if(model.PaymentDiff == null)
                {
                    model.PaymentDiff = 0;
                }
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportPaymentsBetweenTwoDates", model);
                }
                List<ReportPaymentsBetweenTwoDatesResult> result = DbServices.ReportPaymentsBetweenTwoDates(model, db);

                return PartialView("ReportPaymentsBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportPaymentsBetweenTwoDates = reportPaymentsBetweenTwoDates;
                return View();
            }
        }

        #endregion

        #region ReportSubscriptionsBetweenTwoDates  

        public ActionResult ReportSubscriptionsBetweenTwoDates()
        {
            ViewBag.ReportSubscriptionsBetweenTwoDates = reportSubscriptionsBetweenTwoDates;
            return View("_FilterReportSubscriptionsBetweenTwoDates");
        }

        [HttpPost]
        public ActionResult ReportSubscriptionsBetweenTwoDates(string operationType, ReportSubscriptionsBetweenTwoDatesFilter model)
        {
            try
            {
                if (model.SubscriptionDiff == null)
                {
                    model.SubscriptionDiff = 0;
                }
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportSubscriptionsBetweenTwoDates", model);
                }
                List<ReportSubscriptionsBetweenTwoDatesResult> result = DbServices.ReportSubscriptionsBetweenTwoDates(model, db);

                return PartialView("ReportSubscriptionsBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportSubscriptionsBetweenTwoDates = reportSubscriptionsBetweenTwoDates;
                return View();
            }
        }

        #endregion


        #region Reports Printing
        [HttpGet]
        public ActionResult PrintReportLoansBetweenTwoDates(ReportLoansBetweenTwoDatesFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportLoansBetweenTwoDatesResult> result = DbServices.ReportLoansBetweenTwoDates(model, db);
                 
                return PartialView(result);
            }
            catch (CfException exc)
            {                
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportPaymentsBetweenTwoDates(ReportPaymentsBetweenTwoDatesFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportPaymentsBetweenTwoDatesResult> result = DbServices.ReportPaymentsBetweenTwoDates(model, db);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportSubscriptionsBetweenTwoDates(ReportSubscriptionsBetweenTwoDatesFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportSubscriptionsBetweenTwoDatesResult> result = DbServices.ReportSubscriptionsBetweenTwoDates(model, db);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportLoansVw(LoanExtendedVwFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<LoanExtendedVw> result = db.Get(model);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult PrintReportBalance(ReportMonthlyBalanceSumFilter model)
        {
            try
            {
                ViewBag.Title = "Report";
                List<ReportMonthlyBalanceSumResult> result = DbServices.ReportMonthlyBalanceSum(model, db);

                return PartialView(result);
            }
            catch (CfException exc)
            {
                return View();
            }
        }
        #endregion

        #region ReportLoansVw
        public ActionResult ReportLoansVw()
        {
            ViewBag.ReportLoansVw = reportLoansVw;
            return View("_FilterReportLoansVw");
        }

        [HttpPost]
        public ActionResult ReportLoansVw(string operationType, LoanExtendedVwFilter model)
        {
            try
            {                 
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportLoansVw", model);
                }
                List<LoanExtendedVw> result = db.Get(model);

                return PartialView("ReportLoansVwResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportLoansVw = reportLoansVw;
                return View();
            }
        }

        #endregion

        #region ReportBalance  

        public ActionResult ReportBalance()
        {
            ViewBag.ReportBalance = reportBalance;
            return View("_FilterReportBalance");
        }

        [HttpPost]
        public ActionResult ReportBalance(string operationType, ReportMonthlyBalanceSumFilter model)
        {
            try
            {
                if (operationType != null && operationType == "print")
                {
                    return RedirectToAction("PrintReportBalance", model);
                }
                List<ReportMonthlyBalanceSumResult> result = DbServices.ReportMonthlyBalanceSum(model, db);

                return PartialView("ReportBalanceResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportLoansBetweenTwoDates = reportLoansBetweenTwoDates;
                return View();
            }
        }

        #endregion
    }
}

