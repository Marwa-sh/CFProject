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
    public partial class CollectOrderController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "CollectOrder", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "CollectOrder", "ModuleNamePlural");
		
	    public CollectOrderController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of CollectOrderVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(CollectOrderVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = CollectOrderVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<CollectOrderVw>();
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
            CollectOrderVwViewModel collectOrderVwViewModel = new CollectOrderVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// collectOrderVwViewModel.Instance = CollectOrderVwServices.Get(id.Value, db);
            collectOrderVwViewModel.Instance = CollectOrderVwServices.GetChildren(id.Value, db);
            if (collectOrderVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.PaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Payment", "ModuleNamePlural");
            // collectOrderVwViewModel.PaymentVwViewModel.List = PaymentVwServices.GetByCollectOrderId(id.Value, db);
            collectOrderVwViewModel.PaymentVwViewModel.List = collectOrderVwViewModel.Instance.PaymentVwList;
            
            
            return View(collectOrderVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: collectOrderVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Number, Date, AccountingDocumentNumber, AccountingDocumentDate")] CollectOrder collectOrder)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                CollectOrderServices.Insert(CurrentUser.Id, collectOrder, db);
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

            return View(collectOrder);
        }

        // GET: CollectOrder/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CollectOrder collectOrder = CollectOrderServices.Get(id.Value, db);
            if (collectOrder == null)
            {
                return HttpNotFound();
            }

            return View(collectOrder);
        }

        // POST: CollectOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Number, Date, AccountingDocumentNumber, AccountingDocumentDate")] CollectOrder collectOrder)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                CollectOrderServices.Update(CurrentUser.Id, collectOrder, db);
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

            return View(collectOrder);
        }
        // GET: CollectOrder/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            CollectOrder collectOrder = CollectOrderServices.Get(id.Value, db);
            if (collectOrder == null)
            {
                return HttpNotFound();
            }
            return View(collectOrder);
        }

        // POST: CollectOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            CollectOrderServices.Delete(CurrentUser.Id, id, db);
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
            // return View(collectOrder);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

