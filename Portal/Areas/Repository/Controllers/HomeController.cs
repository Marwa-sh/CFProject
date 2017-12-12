
using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.ViewModels;
using Portal.Models;
// using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.Repository.Controllers
{
    public class HomeController : Controller
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Employee", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Employee", "ModuleNamePlural");
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

        private string newLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "NewLoanRequests");
        private string validLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ValidLoanRequests");
        private string approvedLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ApprovedLoanRequests");
        private string exceptionalLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ExceptionalLoanRequests");
        private string rejectedLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "RejectedLoanRequests");
        private string executedLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ExecutedLoanRequests");


        public HomeController()
        {
            ViewBag.NewLoanRequests = newLoanRequests;
            ViewBag.ValidLoanRequests = validLoanRequests;
            ViewBag.ApprovedLoanRequests = approvedLoanRequests;
            ViewBag.ExceptionalLoanRequests = exceptionalLoanRequests;
            ViewBag.RejectedLoanRequests = rejectedLoanRequests;
            ViewBag.ExecutedLoanRequests = executedLoanRequests;
        }


        public ActionResult Index()
        {
            // Call Monthly Balance Function 
            MonthlyBalanceSumFilter filter = new MonthlyBalanceSumFilter();
            DateTime Now = System.DateTime.Now.AddYears(-3);
            filter.MinMonth = System.DateTime.Now.AddYears(-4);
            filter.MaxMonth = Now;

            List<MonthlyBalanceSumResult> result= DbServices.MonthlyBalanceSum(filter);
            result=result.OrderBy(c => c.Month).ToList();
            List<string> Months = new List<string>();
            List<decimal> paidAmounts = new List<decimal>();
            List<decimal> incomingAmounts = new List<decimal>();
             
            foreach (MonthlyBalanceSumResult line in result)
            {                 
                Months.Add(line.Month.Date.ToString("MMMM"));
                paidAmounts.Add(line.AllLoans.Value);
                incomingAmounts.Add(line.AllPayments.Value);
            }
       
            var months = String.Join(",", Months);
            ViewBag.Months = months;
      
            var paid = String.Join(",", paidAmounts);
            ViewBag.PaidAmounts = paid;

            var incoming = String.Join(",", incomingAmounts);
            ViewBag.IncomingAmounts = incoming;

            // 

            RequestStatisticsFilter filterRequest = new RequestStatisticsFilter();
            filterRequest.MinDate = System.DateTime.Now.AddYears(-3);
            filterRequest.MaxDate = System.DateTime.Now;
            List<RequestStatisticsResult> resultRequest = DbServices.RequestStatistics(filterRequest);

            foreach (RequestStatisticsResult item in resultRequest)
            {
                if (item.RequestStatusId == RequestStatusEnum.New.GetHashCode())
                {
                    ViewBag.NewRequestCount = item.RequestCount;
                    ViewBag.NewRequestSum = item.RequestSum;
                    continue;
                }
                //else
                //{
                //    ViewBag.NewRequestCount = 0;
                //    ViewBag.NewRequestSum = 0;
                //    continue;
                //}
                if (item.RequestStatusId == RequestStatusEnum.Executed.GetHashCode())
                {
                    ViewBag.ExecutedRequestCount = item.RequestCount;
                    ViewBag.ExecutedRequestSum = item.RequestSum;
                    continue;
                }
                //else
                //{
                //    ViewBag.ExecutedRequestCount = 0;
                //    ViewBag.ExecutedRequestSum =0;
                //    continue;
                //}
                if (item.RequestStatusId == RequestStatusEnum.FinanciallyApproved.GetHashCode())
                {
                    ViewBag.FinanciallyApprovedRequestCount = item.RequestCount;
                    ViewBag.FinanciallyApprovedRequestSum = item.RequestSum;
                    continue;
                }
                //else
                //{
                //    ViewBag.FinanciallyApprovedRequestCount = 0;
                //    ViewBag.FinanciallyApprovedRequestSum = 0;
                //    continue;
                //}
                if (item.RequestStatusId == RequestStatusEnum.Canceled.GetHashCode())
                {
                    ViewBag.CanceledRequestCount = item.RequestCount;
                    ViewBag.CanceledRequestSum = item.RequestSum;
                    continue;
                }
                //else
                //{
                //    ViewBag.CanceledRequestCount = 0;
                //    ViewBag.CanceledRequestSum = 0;
                //    continue;
                //}
            }


            return View();
        }
       
        public ActionResult Profile()
        {
            //var id = Convert.ToInt32(CfMembership.Users.user.UserName);
            //ViewBag.ModuleName = moduleName;
            //ViewBag.Action = details;
            //ViewBag.Details = details;
            //ViewBag.Update = update;
            //ViewBag.Back = back;
            //ViewBag.Details = details;

            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            //EmployeeVwViewModel employeeVwViewModel = new EmployeeVwViewModel();

            //Db db = new Db(ConfigurationManager.ConnectionStrings["CfDatabase"].ConnectionString);

            //employeeVwViewModel.Instance = EmployeeVwServices.Get(id, db);
            //if (employeeVwViewModel.Instance == null)
            //{
            //    return HttpNotFound();
            //}


            //@ViewBag.CashPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "CashPayment", "ModuleNamePlural");
            //employeeVwViewModel.CashPaymentVwViewModel.List = CashPaymentVwServices.GetByEmployeeId(id, db);

            //@ViewBag.GrantDemandVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantDemand", "ModuleNamePlural");
            //employeeVwViewModel.GrantDemandVwViewModel.List = GrantDemandVwServices.GetByEmployeeId(id, db);

            //@ViewBag.GrantPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantPayment", "ModuleNamePlural");
            //employeeVwViewModel.GrantPaymentVwViewModel.List = GrantPaymentVwServices.GetByEmployeeId(id, db);

            //@ViewBag.LoanCardVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanCard", "ModuleNamePlural");
            //employeeVwViewModel.LoanCardVwViewModel.List = LoanCardVwServices.GetByEmployeeId(id, db);

            //@ViewBag.LoanCardGuarantorVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanCardGuarantor", "ModuleNamePlural");
            //employeeVwViewModel.LoanCardGuarantorVwViewModel.List = LoanCardGuarantorVwServices.GetByEmployeeId(id, db);

            //@ViewBag.LoanDemandVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDemand", "ModuleNamePlural");
            //employeeVwViewModel.LoanDemandVwViewModel.List = LoanDemandVwServices.GetByEmployeeId(id, db);

            //@ViewBag.LoanDemandGuarantorVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDemandGuarantor", "ModuleNamePlural");
            //employeeVwViewModel.LoanDemandGuarantorVwViewModel.List = LoanDemandGuarantorVwServices.GetByEmployeeId(id, db);

            //@ViewBag.MonthlyBalanceVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "MonthlyBalance", "ModuleNamePlural");
            //employeeVwViewModel.MonthlyBalanceVwViewModel.List = MonthlyBalanceVwServices.GetByEmployeeId(id, db);

            //@ViewBag.OldLoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "OldLoan", "ModuleNamePlural");
            //employeeVwViewModel.OldLoanVwViewModel.List = OldLoanVwServices.GetByEmployeeId(id, db);

            //@ViewBag.PayOrderVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "PayOrder", "ModuleNamePlural");
            //employeeVwViewModel.PayOrderVwViewModel.List = PayOrderVwServices.GetByEmployeeId(id, db);

            //@ViewBag.SubscriptionVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Subscription", "ModuleNamePlural");
            //employeeVwViewModel.SubscriptionVwViewModel.List = SubscriptionVwServices.GetByEmployeeId(id, db);

            //return View(employeeVwViewModel);

            return View();
        }


    

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {

            if (Session["user"] != null)
            {
                return RedirectToAction("AccessDenied", "Home" ,new  { area="Repository"});
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();            
        }
        [AllowAnonymous]
        public ActionResult AccessDenied()
        {

            return View();
        }


        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]

        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            UserManagement u = new UserManagement();
            u.login(model.Username, model.Password);
            if (Session["user"] == null)
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
            else
            {
                var x = Session["user"] as CfMembership.User;
                Session["userName"] = x.fName + " " + x.lName;
                Session["userId"] = x.Id;
                return RedirectToAction("Index","Home", new { area="Repository" });

            }

        }


        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]

        public async Task<ActionResult> LogOff()
        {


            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true

            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home", new { area = "Repository" });
            }
            else
            {
                Session["user"] = null;
                Session["userName"] = null;
                return RedirectToAction("Login" , "Home", new { area = "Repository" });

            }

        }
    }
}