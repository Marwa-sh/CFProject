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
    public partial class IncomingLoanController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "IncomingLoan", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "IncomingLoan", "ModuleNamePlural");
		
	    public IncomingLoanController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of IncomingLoanVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(IncomingLoanVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.LoanProductProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
                Model.List = IncomingLoanVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<IncomingLoanVw>();
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
            IncomingLoanVwViewModel incomingLoanVwViewModel = new IncomingLoanVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// incomingLoanVwViewModel.Instance = IncomingLoanVwServices.Get(loan.Value, db);
            incomingLoanVwViewModel.Instance = IncomingLoanVwServices.GetChildren(loan.Value, db);
            if (incomingLoanVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(incomingLoanVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name");
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
			return View();
        }

        // POST: incomingLoanVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Loan, MainWorkPlace")] IncomingLoan incomingLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                IncomingLoanServices.Insert(CurrentUser.Id, incomingLoan, db);
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
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
            return View(incomingLoan);
        }

        // GET: IncomingLoan/Edit/5
        public ActionResult Edit(Nullable<int>  loan)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (loan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IncomingLoan incomingLoan = IncomingLoanServices.Get(loan.Value, db);
            if (incomingLoan == null)
            {
                return HttpNotFound();
            }

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name", incomingLoan.Loan);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", incomingLoan.MainWorkPlace);
            return View(incomingLoan);
        }

        // POST: IncomingLoan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Loan, MainWorkPlace")] IncomingLoan incomingLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                IncomingLoanServices.Update(CurrentUser.Id, incomingLoan, db);
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

            ViewBag.LoanList = new SelectList(LoanServices.List(db), "Product", "Name", incomingLoan.Loan);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", incomingLoan.MainWorkPlace);
            return View(incomingLoan);
        }
        // GET: IncomingLoan/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            IncomingLoan incomingLoan = IncomingLoanServices.Get(id.Value, db);
            if (incomingLoan == null)
            {
                return HttpNotFound();
            }
            return View(incomingLoan);
        }

        // POST: IncomingLoan/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  loan)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            IncomingLoanServices.Delete(CurrentUser.Id, loan, db);
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
            // return View(incomingLoan);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

