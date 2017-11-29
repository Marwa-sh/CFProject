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
    public partial class GrantPaymentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantPayment", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantPayment", "ModuleNamePlural");
		
	    public GrantPaymentController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of GrantPaymentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GrantPaymentVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = GrantPaymentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<GrantPaymentVw>();
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
            GrantPaymentVwViewModel grantPaymentVwViewModel = new GrantPaymentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// grantPaymentVwViewModel.Instance = GrantPaymentVwServices.Get(id.Value, db);
            grantPaymentVwViewModel.Instance = GrantPaymentVwServices.GetChildren(id.Value, db);
            if (grantPaymentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(grantPaymentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name");
            ViewBag.GrantPaymentOrderList = new SelectList(GrantPaymentOrderServices.List(db), "Id", "Notes");
			return View();
        }

        // POST: grantPaymentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, GrantPaymentOrder, SubNumber, Grant, Amount, Notes")] GrantPayment grantPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantPaymentServices.Insert(CurrentUser.Id, grantPayment, db);
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

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name");
            ViewBag.GrantPaymentOrderList = new SelectList(GrantPaymentOrderServices.List(db), "Id", "Notes");
            return View(grantPayment);
        }

        // GET: GrantPayment/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantPayment grantPayment = GrantPaymentServices.Get(id.Value, db);
            if (grantPayment == null)
            {
                return HttpNotFound();
            }

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name", grantPayment.Grant);
            ViewBag.GrantPaymentOrderList = new SelectList(GrantPaymentOrderServices.List(db), "Id", "Notes", grantPayment.GrantPaymentOrder);
            return View(grantPayment);
        }

        // POST: GrantPayment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, GrantPaymentOrder, SubNumber, Grant, Amount, Notes")] GrantPayment grantPayment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantPaymentServices.Update(CurrentUser.Id, grantPayment, db);
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

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name", grantPayment.Grant);
            ViewBag.GrantPaymentOrderList = new SelectList(GrantPaymentOrderServices.List(db), "Id", "Notes", grantPayment.GrantPaymentOrder);
            return View(grantPayment);
        }
        // GET: GrantPayment/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            GrantPayment grantPayment = GrantPaymentServices.Get(id.Value, db);
            if (grantPayment == null)
            {
                return HttpNotFound();
            }
            return View(grantPayment);
        }

        // POST: GrantPayment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GrantPaymentServices.Delete(CurrentUser.Id, id, db);
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
            // return View(grantPayment);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

