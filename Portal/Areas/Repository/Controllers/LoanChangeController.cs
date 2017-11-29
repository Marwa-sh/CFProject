using System;
using System.Net;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Configuration;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using Cf.Controllers;

namespace Portal.Areas.Repository.Controllers
{
    public partial class LoanChangeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanChange", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanChange", "ModuleNamePlural");
		
	    public LoanChangeController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of LoanChangeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanChangeVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = LoanChangeVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<LoanChangeVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  loan)
        {
            if (loan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanChangeVwViewModel loanChangeVwViewModel = new LoanChangeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// loanChangeVwViewModel.Instance = LoanChangeVwServices.Get(loan.Value, db);
            loanChangeVwViewModel.Instance = LoanChangeVwServices.GetChildren(loan.Value, db);
            if (loanChangeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(loanChangeVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name");
            ViewBag.FromLoanList = new SelectList(LoanServices.List(db), "Product", "Name");
			return View();
        }

        // POST: loanChangeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Loan, FromLoan")] LoanChange loanChange)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanChangeServices.Insert(CurrentUser.Id, loanChange, db);
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

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name");
            ViewBag.FromLoanList = new SelectList(LoanServices.List(db), "Product", "Name");
            return View(loanChange);
        }

        // GET: LoanChange/Edit/5
        public ActionResult Edit(Nullable<int>  loan)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (loan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanChange loanChange = LoanChangeServices.Get(loan.Value, db);
            if (loanChange == null)
            {
                return HttpNotFound();
            }

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name", loanChange.Loan);
            ViewBag.FromLoanList = new SelectList(LoanServices.List(db), "Product", "Name", loanChange.FromLoan);
            return View(loanChange);
        }

        // POST: LoanChange/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Loan, FromLoan")] LoanChange loanChange)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanChangeServices.Update(CurrentUser.Id, loanChange, db);
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

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name", loanChange.Loan);
            ViewBag.FromLoanList = new SelectList(LoanServices.List(db), "Product", "Name", loanChange.FromLoan);
            return View(loanChange);
        }
        // GET: LoanChange/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            LoanChange loanChange = LoanChangeServices.Get(id.Value, db);
            if (loanChange == null)
            {
                return HttpNotFound();
            }
            return View(loanChange);
        }

        // POST: LoanChange/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  loan)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            LoanChangeServices.Delete(CurrentUser.Id, loan, db);
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
            // return View(loanChange);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

