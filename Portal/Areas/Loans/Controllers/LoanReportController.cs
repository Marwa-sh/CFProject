using Cf.Controllers;
using Cf.Data;
using Cf.Services;
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

        public LoanReportController()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Title = index;
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
    }
}