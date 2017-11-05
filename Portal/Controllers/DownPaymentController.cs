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
    public class DownPaymentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DownPayment", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DownPayment", "ModuleNamePlural");
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
		
	    public DownPaymentController()
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
        /// Returns a list of DownPaymentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(DownPaymentVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = DownPaymentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<DownPaymentVw>();
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
            DownPaymentVwViewModel downPaymentVwViewModel = new DownPaymentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// downPaymentVwViewModel.Instance = DownPaymentVwServices.Get(payment.Value, db);
            downPaymentVwViewModel.Instance = DownPaymentVwServices.GetChildren(payment.Value, db);
            if (downPaymentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(downPaymentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes");
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
			return View();
        }

        // POST: downPaymentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Payment, Request")] DownPayment downPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                DownPaymentServices.Insert(CurrentUser.Id, downPayment, db);
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
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
            return View(downPayment);
        }

        // GET: DownPayment/Edit/5
        public ActionResult Edit(Nullable<int>  payment)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (payment == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DownPayment downPayment = DownPaymentServices.Get(payment.Value, db);
            if (downPayment == null)
            {
                return HttpNotFound();
            }

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", downPayment.Payment);
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment", downPayment.Request);
            return View(downPayment);
        }

        // POST: DownPayment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Payment, Request")] DownPayment downPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                DownPaymentServices.Update(CurrentUser.Id, downPayment, db);
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

            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", downPayment.Payment);
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment", downPayment.Request);
            return View(downPayment);
        }
        // GET: DownPayment/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            DownPayment downPayment = DownPaymentServices.Get(id.Value, db);
            if (downPayment == null)
            {
                return HttpNotFound();
            }
            return View(downPayment);
        }

        // POST: DownPayment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  payment)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            DownPaymentServices.Delete(CurrentUser.Id, payment, db);
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
            // return View(downPayment);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

