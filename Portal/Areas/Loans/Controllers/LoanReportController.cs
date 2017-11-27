using Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.Loans.Controllers
{
    public class LoanReportController : Controller
    {
        // GET: Loans/LoanReport
        public ActionResult Index()
        {
            EmployeeLoansReport report = new EmployeeLoansReport();

            List<string> LoansTypesNames = new List<string>();
            List<decimal> OriginalAmounts = new List<decimal>();
            List<decimal> RemainingAmounts = new List<decimal>();
            List<decimal> PaidAmounts = new List<decimal>();

            LoansTypesNames.Add("سلفة استثمارية");
            LoansTypesNames.Add("سلفة دراسية");

            OriginalAmounts.Add(30000);
            OriginalAmounts.Add(50000);


            RemainingAmounts.Add(20000);
            RemainingAmounts.Add(15000);


            PaidAmounts.Add(10000);
            PaidAmounts.Add(35000);

            report.LoansTypesNames = LoansTypesNames;
            report.OriginalAmounts = OriginalAmounts;
            report.PaidAmounts = PaidAmounts;
            report.RemainingAmounts = RemainingAmounts;

            ViewBag.Names= "'January', 'February', 'March', 'April'";
            return View();
        }
    }
}