using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.Loans.Controllers
{
    public class LoanDecisionViewModelController : BaseController
    {
        // GET: Loans/LoanDecisionViewModel
        public ActionResult Index()
        {
            return View();
        }


        #region Create Loan Decision Move to Employee
        public ActionResult LoanDeciosionMoveToEmployee(LoanDecisionViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.DecisionTypeList = new SelectList(LoanDecisionTypeServices.List(db), "Id", "Name");
            if (Model.Loans.Filter.HasCriteria)
            {
                Model.Loans.List = LoanVwServices.Get(Model.Loans.Filter, db);
            }
            else
                Model.Loans.List = new List<LoanVw>();
            return View(Model);
        }
        [HttpPost]
        public ActionResult LoanDeciosionMoveToEmployee(LoanDecisionViewModel model, int id)
        {

            return View();
        }
        #endregion


    }
}