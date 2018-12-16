using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PublicPortal.Areas.User.Controllers
{
    public class EmployeeLoansController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string employeeLoans = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeLoans");
        
        
        public EmployeeLoansController()
        {
            #region ViewBags
            ViewBag.EmployeeLoans = employeeLoans;
            #endregion
        }
        // GET: User/EmployeeLoans
        public ActionResult Index()
        {
            ViewBag.EmployeeLoans = employeeLoans;
            LoanVwViewModel model = new LoanVwViewModel();
            LoanVwFilter filter = new LoanVwFilter();
            filter.ProductEmployeeId = int.Parse(CurrentUser.UserName);
            model.List = LoanVwServices.Get(filter, db);
            return View(model);
        }

        public ActionResult Details(Nullable<int> product)
        {
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanVwViewModel loanVwViewModel = new LoanVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

            // loanVwViewModel.Instance = LoanVwServices.Get(product.Value, db);
            loanVwViewModel.Instance = LoanVwServices.GetChildren(product.Value, db);
            if (loanVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.IncomingLoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "IncomingLoan", "ModuleName");
            //if (loanVwViewModel.Instance.IncomingLoanVw != null)
            //    loanVwViewModel.IncomingLoanVwViewModel.List.Add(loanVwViewModel.Instance.IncomingLoanVw);

            @ViewBag.LoanChangeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanChange", "ModuleName");
            //if (loanVwViewModel.Instance.LoanChangeVw != null)
            //    loanVwViewModel.LoanChangeVwViewModel.List.Add(loanVwViewModel.Instance.LoanChangeVw);

            @ViewBag.FromLoanChangeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanChange", "ModuleNamePlural");
            //loanVwViewModel.FromLoanChangeVwViewModel.List = loanVwViewModel.Instance.FromLoanChangeVwList;


            @ViewBag.OutgoingLoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "OutgoingLoan", "ModuleName");
            //if (loanVwViewModel.Instance.OutgoingLoanVw != null)
            //    loanVwViewModel.OutgoingLoanVwViewModel.List.Add(loanVwViewModel.Instance.OutgoingLoanVw);

            @ViewBag.InstallmentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Installment", "ModuleNamePlural");           
            //loanVwViewModel.InstallmentsResultList = DbServices.GetInstallments(loanVwViewModel.Instance.ProductId);


            return View(loanVwViewModel);
        }

    }
}