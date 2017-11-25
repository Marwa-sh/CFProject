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
            return View();
        }
    }
}