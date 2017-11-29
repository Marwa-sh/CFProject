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
    public partial class CashPaymentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "CashPayment", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "CashPayment", "ModuleNamePlural");
		
	    public CashPaymentController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of CashPaymentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(CashPaymentVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = CashPaymentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<CashPaymentVw>();
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
            CashPaymentVwViewModel cashPaymentVwViewModel = new CashPaymentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// cashPaymentVwViewModel.Instance = CashPaymentVwServices.Get(payment.Value, db);
            cashPaymentVwViewModel.Instance = CashPaymentVwServices.GetChildren(payment.Value, db);
            if (cashPaymentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(cashPaymentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes");
			return View();
        }

        // POST: cashPaymentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Payment, Number, ReceiptNumber, ReceiptDate, FeeAmount")] CashPayment cashPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                CashPaymentServices.Insert(CurrentUser.Id, cashPayment, db);
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
            return View(cashPayment);
        }

        // GET: CashPayment/Edit/5
        public ActionResult Edit(Nullable<int>  payment)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (payment == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CashPayment cashPayment = CashPaymentServices.Get(payment.Value, db);
            if (cashPayment == null)
            {
                return HttpNotFound();
            }

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", cashPayment.Payment);
            return View(cashPayment);
        }

        // POST: CashPayment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Payment, Number, ReceiptNumber, ReceiptDate, FeeAmount")] CashPayment cashPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                CashPaymentServices.Update(CurrentUser.Id, cashPayment, db);
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

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", cashPayment.Payment);
            return View(cashPayment);
        }
        // GET: CashPayment/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            CashPayment cashPayment = CashPaymentServices.Get(id.Value, db);
            if (cashPayment == null)
            {
                return HttpNotFound();
            }
            return View(cashPayment);
        }

        // POST: CashPayment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  payment)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            CashPaymentServices.Delete(CurrentUser.Id, payment, db);
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
            // return View(cashPayment);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

