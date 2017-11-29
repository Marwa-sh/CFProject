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
    public partial class OutgoingLoanController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "OutgoingLoan", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "OutgoingLoan", "ModuleNamePlural");
		
	    public OutgoingLoanController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of OutgoingLoanVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(OutgoingLoanVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = OutgoingLoanVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<OutgoingLoanVw>();
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
            OutgoingLoanVwViewModel outgoingLoanVwViewModel = new OutgoingLoanVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// outgoingLoanVwViewModel.Instance = OutgoingLoanVwServices.Get(loan.Value, db);
            outgoingLoanVwViewModel.Instance = OutgoingLoanVwServices.GetChildren(loan.Value, db);
            if (outgoingLoanVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(outgoingLoanVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name");
            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
			return View();
        }

        // POST: outgoingLoanVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Loan, LoanDecision, MainWorkPlace, ApprovedAmount, NetAmount, ProfitAmount")] OutgoingLoan outgoingLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                OutgoingLoanServices.Insert(CurrentUser.Id, outgoingLoan, db);
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
            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
            return View(outgoingLoan);
        }

        // GET: OutgoingLoan/Edit/5
        public ActionResult Edit(Nullable<int>  loan)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (loan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OutgoingLoan outgoingLoan = OutgoingLoanServices.Get(loan.Value, db);
            if (outgoingLoan == null)
            {
                return HttpNotFound();
            }

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name", outgoingLoan.Loan);
            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber", outgoingLoan.LoanDecision);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", outgoingLoan.MainWorkPlace);
            return View(outgoingLoan);
        }

        // POST: OutgoingLoan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Loan, LoanDecision, MainWorkPlace, ApprovedAmount, NetAmount, ProfitAmount")] OutgoingLoan outgoingLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                OutgoingLoanServices.Update(CurrentUser.Id, outgoingLoan, db);
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

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name", outgoingLoan.Loan);
            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber", outgoingLoan.LoanDecision);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", outgoingLoan.MainWorkPlace);
            return View(outgoingLoan);
        }
        // GET: OutgoingLoan/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            OutgoingLoan outgoingLoan = OutgoingLoanServices.Get(id.Value, db);
            if (outgoingLoan == null)
            {
                return HttpNotFound();
            }
            return View(outgoingLoan);
        }

        // POST: OutgoingLoan/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  loan)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            OutgoingLoanServices.Delete(CurrentUser.Id, loan, db);
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
            // return View(outgoingLoan);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

