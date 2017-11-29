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
    public partial class SubscriptionTypeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SubscriptionType", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SubscriptionType", "ModuleNamePlural");
		
	    public SubscriptionTypeController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of SubscriptionTypeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(SubscriptionTypeVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = SubscriptionTypeVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<byte>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriptionTypeVwViewModel subscriptionTypeVwViewModel = new SubscriptionTypeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// subscriptionTypeVwViewModel.Instance = SubscriptionTypeVwServices.Get(id.Value, db);
            subscriptionTypeVwViewModel.Instance = SubscriptionTypeVwServices.GetChildren(id.Value, db);
            if (subscriptionTypeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(subscriptionTypeVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: subscriptionTypeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] SubscriptionType subscriptionType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SubscriptionTypeServices.Insert(CurrentUser.Id, subscriptionType, db);
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

            return View(subscriptionType);
        }

        // GET: SubscriptionType/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriptionType subscriptionType = SubscriptionTypeServices.Get(id.Value, db);
            if (subscriptionType == null)
            {
                return HttpNotFound();
            }

            return View(subscriptionType);
        }

        // POST: SubscriptionType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] SubscriptionType subscriptionType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SubscriptionTypeServices.Update(CurrentUser.Id, subscriptionType, db);
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

            return View(subscriptionType);
        }
        // GET: SubscriptionType/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            SubscriptionType subscriptionType = SubscriptionTypeServices.Get(id.Value, db);
            if (subscriptionType == null)
            {
                return HttpNotFound();
            }
            return View(subscriptionType);
        }

        // POST: SubscriptionType/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            SubscriptionTypeServices.Delete(CurrentUser.Id, id, db);
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
            // return View(subscriptionType);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

