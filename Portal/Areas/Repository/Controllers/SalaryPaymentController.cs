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
    public partial class SalaryPaymentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryPayment", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryPayment", "ModuleNamePlural");
		
	    public SalaryPaymentController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of SalaryPaymentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(SalaryPaymentVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.PaymentPaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            ViewBag.PaymentPaymentStatusList = new SelectList(PaymentStatusServices.List(db), "Id", "Name");

            if (Model.Filter.HasCriteria)
	        {
                Model.List = SalaryPaymentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<SalaryPaymentVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  payment)
        {
            if (payment == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryPaymentVwViewModel salaryPaymentVwViewModel = new SalaryPaymentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// salaryPaymentVwViewModel.Instance = SalaryPaymentVwServices.Get(payment.Value, db);
            salaryPaymentVwViewModel.Instance = SalaryPaymentVwServices.GetChildren(payment.Value, db);
            if (salaryPaymentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(salaryPaymentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes");
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
			return View();
        }

        // POST: salaryPaymentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Payment, Department, Balance")] SalaryPayment salaryPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SalaryPaymentServices.Insert(CurrentUser.Id, salaryPayment, db);
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

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes");
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
            return View(salaryPayment);
        }

        // GET: SalaryPayment/Edit/5
        public ActionResult Edit(Nullable<int>  payment)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (payment == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryPayment salaryPayment = SalaryPaymentServices.Get(payment.Value, db);
            if (salaryPayment == null)
            {
                return HttpNotFound();
            }

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", salaryPayment.Payment);
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", salaryPayment.Department);
            return View(salaryPayment);
        }

        // POST: SalaryPayment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Payment, Department, Balance")] SalaryPayment salaryPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SalaryPaymentServices.Update(CurrentUser.Id, salaryPayment, db);
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

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", salaryPayment.Payment);
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", salaryPayment.Department);
            return View(salaryPayment);
        }
        // GET: SalaryPayment/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            SalaryPayment salaryPayment = SalaryPaymentServices.Get(id.Value, db);
            if (salaryPayment == null)
            {
                return HttpNotFound();
            }
            return View(salaryPayment);
        }

        // POST: SalaryPayment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  payment)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            SalaryPaymentServices.Delete(CurrentUser.Id, payment, db);
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
            // return View(salaryPayment);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

