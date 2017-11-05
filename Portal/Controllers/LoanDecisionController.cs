using System;
using System.Net;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Configuration;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;

namespace Cf.Controllers
{
    public class LoanDecisionController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleNamePlural");
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
        private string filterOptions = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "FilterOptions");
        private string noRecords = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "NoRecords");
		
	    public LoanDecisionController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
            ViewBag.Insert = insert;
            ViewBag.Update = update;
            ViewBag.Delete = delete;
			ViewBag.Save = save;
            ViewBag.Back = back;
			ViewBag.Details = details;
            ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Yes = yes;
            ViewBag.No = no;
            ViewBag.Search = search;
			ViewBag.FilterOptions = filterOptions;
			ViewBag.NoRecords = noRecords;
		}
		
        /// <summary>
        /// Returns a list of LoanDecisionVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanDecisionVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = LoanDecisionVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<LoanDecisionVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanDecisionVwViewModel loanDecisionVwViewModel = new LoanDecisionVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// loanDecisionVwViewModel.Instance = LoanDecisionVwServices.Get(id.Value, db);
            loanDecisionVwViewModel.Instance = LoanDecisionVwServices.GetChildren(id.Value, db);
            if (loanDecisionVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.LoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Loan", "ModuleNamePlural");
            // loanDecisionVwViewModel.LoanVwViewModel.List = LoanVwServices.GetByLoanDecisionId(id.Value, db);
            loanDecisionVwViewModel.LoanVwViewModel.List = loanDecisionVwViewModel.Instance.LoanVwList;
            

            @ViewBag.OutgoingLoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "OutgoingLoan", "ModuleNamePlural");
            // loanDecisionVwViewModel.OutgoingLoanVwViewModel.List = OutgoingLoanVwServices.GetByLoanDecisionId(id.Value, db);
            loanDecisionVwViewModel.OutgoingLoanVwViewModel.List = loanDecisionVwViewModel.Instance.OutgoingLoanVwList;
            
            
            return View(loanDecisionVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.LoanDecisionTypeList = new SelectList(LoanDecisionTypeServices.List(db), "Id", "Name");
			return View();
        }

        // POST: loanDecisionVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Number, Year, Date, DeductionStartDate, CersNumber, CersDate, Notes, LoanDecisionType, PaymentNumber, PaymentDate, IsPaidFromSalary, Reason, AdditionalClause, AdditionalIntroduction")] LoanDecision loanDecision)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanDecisionServices.Insert(CurrentUser.Id, loanDecision, db);
					TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "InsertConfirmed");
					return RedirectToAction("Index");
				}
				catch(CfException cfex)
				{
					TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
				}
				catch(Exception ex)
				{
					TempData["Failure"] = ex.Message;
				}
            }

            ViewBag.LoanDecisionTypeList = new SelectList(LoanDecisionTypeServices.List(db), "Id", "Name");
            return View(loanDecision);
        }

        // GET: LoanDecision/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanDecision loanDecision = LoanDecisionServices.Get(id.Value, db);
            if (loanDecision == null)
            {
                return HttpNotFound();
            }

            ViewBag.LoanDecisionTypeList = new SelectList(LoanDecisionTypeServices.List(db), "Id", "Name", loanDecision.LoanDecisionType);
            return View(loanDecision);
        }

        // POST: LoanDecision/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Number, Year, Date, DeductionStartDate, CersNumber, CersDate, Notes, LoanDecisionType, PaymentNumber, PaymentDate, IsPaidFromSalary, Reason, AdditionalClause, AdditionalIntroduction")] LoanDecision loanDecision)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanDecisionServices.Update(CurrentUser.Id, loanDecision, db);
					TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "UpdateConfirmed");
					return RedirectToAction("Index");
				}
				catch(CfException cfex)
				{
					TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
				}
				catch(Exception ex)
				{
					TempData["Failure"] = ex.Message;
				}
            }

            ViewBag.LoanDecisionTypeList = new SelectList(LoanDecisionTypeServices.List(db), "Id", "Name", loanDecision.LoanDecisionType);
            return View(loanDecision);
        }
        // GET: LoanDecision/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            LoanDecision loanDecision = LoanDecisionServices.Get(id.Value, db);
            if (loanDecision == null)
            {
                return HttpNotFound();
            }
            return View(loanDecision);
        }

        // POST: LoanDecision/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            LoanDecisionServices.Delete(CurrentUser.Id, id, db);
				TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "DeleteConfirmed");
				// return RedirectToAction("Index");
			}
			catch(CfException cfex)
			{
				TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
			}
			catch(Exception ex)
			{
				TempData["Failure"] = ex.Message;
			}
            // return View(loanDecision);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

