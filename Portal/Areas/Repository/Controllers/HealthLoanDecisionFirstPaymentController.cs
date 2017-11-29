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
    public partial class HealthLoanDecisionFirstPaymentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "HealthLoanDecisionFirstPayment", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "HealthLoanDecisionFirstPayment", "ModuleNamePlural");
		
	    public HealthLoanDecisionFirstPaymentController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of HealthLoanDecisionFirstPaymentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(HealthLoanDecisionFirstPaymentVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = HealthLoanDecisionFirstPaymentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<HealthLoanDecisionFirstPaymentVw>();
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
            HealthLoanDecisionFirstPaymentVwViewModel healthLoanDecisionFirstPaymentVwViewModel = new HealthLoanDecisionFirstPaymentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// healthLoanDecisionFirstPaymentVwViewModel.Instance = HealthLoanDecisionFirstPaymentVwServices.Get(id.Value, db);
            healthLoanDecisionFirstPaymentVwViewModel.Instance = HealthLoanDecisionFirstPaymentVwServices.GetChildren(id.Value, db);
            if (healthLoanDecisionFirstPaymentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(healthLoanDecisionFirstPaymentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.HealthLoanDecisionList = new SelectList(HealthLoanDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.InsuranceTypeList = new SelectList(InsuranceTypeServices.List(db), "Id", "Name");
			return View();
        }

        // POST: healthLoanDecisionFirstPaymentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, PaymentDate, PaymentAmount, PaymentNotes, InvoiceDate, InvoiceAmount, InvoiceNotes, InsuranceDate, InsuranceAmount, InsuranceType, InsuranceNotes, BoardDate, BoardAmount, BoardType, BoardNotes, DirectPaymentDate, DirectPaymentAmount, DirectPaymentNotes, PaymentStatus, Notes, Department, HealthLoanDecision, RequestCost, LoanRequest")] HealthLoanDecisionFirstPayment healthLoanDecisionFirstPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                HealthLoanDecisionFirstPaymentServices.Insert(CurrentUser.Id, healthLoanDecisionFirstPayment, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.HealthLoanDecisionList = new SelectList(HealthLoanDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.InsuranceTypeList = new SelectList(InsuranceTypeServices.List(db), "Id", "Name");
            return View(healthLoanDecisionFirstPayment);
        }

        // GET: HealthLoanDecisionFirstPayment/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HealthLoanDecisionFirstPayment healthLoanDecisionFirstPayment = HealthLoanDecisionFirstPaymentServices.Get(id.Value, db);
            if (healthLoanDecisionFirstPayment == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", healthLoanDecisionFirstPayment.Employee);
            ViewBag.HealthLoanDecisionList = new SelectList(HealthLoanDecisionServices.List(db), "Id", "CersNumber", healthLoanDecisionFirstPayment.HealthLoanDecision);
            ViewBag.InsuranceTypeList = new SelectList(InsuranceTypeServices.List(db), "Id", "Name", healthLoanDecisionFirstPayment.InsuranceType);
            return View(healthLoanDecisionFirstPayment);
        }

        // POST: HealthLoanDecisionFirstPayment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, PaymentDate, PaymentAmount, PaymentNotes, InvoiceDate, InvoiceAmount, InvoiceNotes, InsuranceDate, InsuranceAmount, InsuranceType, InsuranceNotes, BoardDate, BoardAmount, BoardType, BoardNotes, DirectPaymentDate, DirectPaymentAmount, DirectPaymentNotes, PaymentStatus, Notes, Department, HealthLoanDecision, RequestCost, LoanRequest")] HealthLoanDecisionFirstPayment healthLoanDecisionFirstPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                HealthLoanDecisionFirstPaymentServices.Update(CurrentUser.Id, healthLoanDecisionFirstPayment, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", healthLoanDecisionFirstPayment.Employee);
            ViewBag.HealthLoanDecisionList = new SelectList(HealthLoanDecisionServices.List(db), "Id", "CersNumber", healthLoanDecisionFirstPayment.HealthLoanDecision);
            ViewBag.InsuranceTypeList = new SelectList(InsuranceTypeServices.List(db), "Id", "Name", healthLoanDecisionFirstPayment.InsuranceType);
            return View(healthLoanDecisionFirstPayment);
        }
        // GET: HealthLoanDecisionFirstPayment/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            HealthLoanDecisionFirstPayment healthLoanDecisionFirstPayment = HealthLoanDecisionFirstPaymentServices.Get(id.Value, db);
            if (healthLoanDecisionFirstPayment == null)
            {
                return HttpNotFound();
            }
            return View(healthLoanDecisionFirstPayment);
        }

        // POST: HealthLoanDecisionFirstPayment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            HealthLoanDecisionFirstPaymentServices.Delete(CurrentUser.Id, id, db);
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
            // return View(healthLoanDecisionFirstPayment);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

