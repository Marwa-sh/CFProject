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

namespace Portal.Areas.Loans.Controllers
{
    public class LoanReportController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "ModuleNamePlural");
        private string subscriptionReport = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "SubscriptionReport");
        private string paymentReport = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "PaymentReport");
        private string report = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "Report");
        private string requestStatistics = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "RequestStatistics");
        private string employeeLoans = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "EmployeeLoans");
        private string reportPayments = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "ReportPayments");
        private string reportSubscriptions = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanReport", "ReportSubscriptions");
        
        Db db = new Db(DbServices.ConnectionString);

        public LoanReportController()
        {
            #region ViewBags
            ViewBag.ModuleName = moduleName;
            ViewBag.Title = index;
            ViewBag.Report = report;
            ViewBag.SubscriptionReport = subscriptionReport;
            ViewBag.PaymentReport = paymentReport;
            ViewBag.RequestStatistics = requestStatistics;
            ViewBag.EmployeeLoans = employeeLoans;
            #endregion
        }
        // GET: Loans/LoanReport
        public ActionResult Index(LoanRequestVwViewModel model)
        { 
            EmployeeLoansReport report = new EmployeeLoansReport();

            Db db = new Db(DbServices.ConnectionString);
            List<GetRefundableProductsResult> result= db.GetRefundableProducts(model.Filter.RequestProductEmployeeId);


            List<string> LoansTypesNames = new List<string>();
            List<decimal> OriginalAmounts = new List<decimal>();
            List<decimal> RemainingAmounts = new List<decimal>();
            List<decimal> PaidAmounts = new List<decimal>();


            foreach (GetRefundableProductsResult item in result)
            {
                LoansTypesNames.Add(item.ProductId.ToString());
                OriginalAmounts.Add(item.DueAmount.Value);
                PaidAmounts.Add(item.PaidAmount.Value);
                RemainingAmounts.Add(item.DueAmount.Value- item.PaidAmount.Value);
            }


            //LoansTypesNames.Add("سلفة استثمارية");
            //LoansTypesNames.Add("سلفة دراسية");

            //OriginalAmounts.Add(30000);
            //OriginalAmounts.Add(50000);


            //RemainingAmounts.Add(20000);
            //RemainingAmounts.Add(15000);


            //PaidAmounts.Add(10000);
            //PaidAmounts.Add(35000);

            var loansTypesNames = String.Join(",", LoansTypesNames);
            ViewBag.LoansTypesNames = loansTypesNames;

            var remainingAmounts = String.Join(",", RemainingAmounts);
            ViewBag.RemainingAmounts = remainingAmounts;

            var paidAmounts = String.Join(",", PaidAmounts);
            ViewBag.PaidAmounts = paidAmounts;

          
            
            return View();
        }

        #region SubscriptionsBetweenDates
        public ActionResult SubscriptionsBetweenDates()
        {
            ViewBag.Title = subscriptionReport;
            return View();
        }
        [HttpPost]
        public ActionResult SubscriptionsBetweenDates(SubscriptionsBetweenTwoDatesFilter model)
        {
            SubscriptionsBetweenTwoDatesResult result = db.SubscriptionsBetweenTwoDates(model).FirstOrDefault();

            return PartialView("SubscriptionsBetweenDatesResult", result);
        }
        #endregion


        #region PaymentsBetweenTwoDates
        public ActionResult PaymentsBetweenTwoDates()
        {
            ViewBag.PaymentReport = paymentReport;
            return View();
        }
        [HttpPost]
        public ActionResult PaymentsBetweenTwoDates(PaymentBetweenTwoDatesFilter model)
        {
            try
            {
               
                PaymentBetweenTwoDatesResult result = db.PaymentBetweenTwoDates(model).FirstOrDefault();

                return PartialView("PaymentsBetweenTwoDatesResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.SubscriptionReport = subscriptionReport;
                return View();
            }
        }
        #endregion


        #region RequestStatistics
        public ActionResult RequestStatistics()
        {
            ViewBag.RequestStatistics = requestStatistics;
            return View();
        }

        [HttpPost]
        public ActionResult RequestStatistics(RequestStatisticsFilter model)
        {
            try
            {
                List<RequestStatisticsResult> result = db.RequestStatistics(model);
                return PartialView("RequestStatisticsResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.RequestStatistics = requestStatistics;
                return View();
            }
            
        }
        #endregion

        #region EmployeeLoans
        public ActionResult EmployeeLoans()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeLoans(EmployeeLoansFilter model)
        {
            try
            {
                List<EmployeeLoansResult> result = db.EmployeeLoans(model);
                return PartialView("EmployeeLoansResult", result);
            }
            catch (CfException exc)
            {
                return View();
                throw;
            }
        }
        #endregion

        #region ReportPayments
        public ActionResult ReportPayments()
        {
            ViewBag.ReportPayments = reportPayments;
            return View();
        }
        [HttpPost]
        public ActionResult ReportPayments(ReportPaymentsBetweenTwoDatesFilter filter)
        {
            try
            {
                List<ReportPaymentsBetweenTwoDatesResult> result = DbServices.ReportPaymentsBetweenTwoDates(filter, db);
                
                return PartialView("ReportPaymentsResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportPayments = reportPayments;
                return View();
            }
            
        }
        #endregion

        #region ReportSubscriptions
        public ActionResult ReportSubscriptions()
        {
            ViewBag.ReportSubscriptions = reportSubscriptions;
            return View();
        }
        [HttpPost]
        public ActionResult ReportSubscriptions(ReportSubscriptionsBetweenTwoDatesFilter filter)
        {
            try
            {
                List<ReportSubscriptionsBetweenTwoDatesResult> result = DbServices.ReportSubscriptionsBetweenTwoDates(filter, db);

                return PartialView("ReportSubscriptionsResult", result);
            }
            catch (CfException exc)
            {
                ViewBag.ReportSubscriptions = reportSubscriptions;
                return View();
            }

        }
        #endregion
    }
}