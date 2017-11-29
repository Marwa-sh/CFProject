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
    public partial class BypassStatusController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "BypassStatus", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "BypassStatus", "ModuleNamePlural");
		
	    public BypassStatusController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of BypassStatusVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(BypassStatusVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = BypassStatusVwServices.List(db);
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
            BypassStatusVwViewModel bypassStatusVwViewModel = new BypassStatusVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// bypassStatusVwViewModel.Instance = BypassStatusVwServices.Get(id.Value, db);
            bypassStatusVwViewModel.Instance = BypassStatusVwServices.GetChildren(id.Value, db);
            if (bypassStatusVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(bypassStatusVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: bypassStatusVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] BypassStatus bypassStatus)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                BypassStatusServices.Insert(CurrentUser.Id, bypassStatus, db);
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

            return View(bypassStatus);
        }

        // GET: BypassStatus/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BypassStatus bypassStatus = BypassStatusServices.Get(id.Value, db);
            if (bypassStatus == null)
            {
                return HttpNotFound();
            }

            return View(bypassStatus);
        }

        // POST: BypassStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] BypassStatus bypassStatus)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                BypassStatusServices.Update(CurrentUser.Id, bypassStatus, db);
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

            return View(bypassStatus);
        }
        // GET: BypassStatus/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            BypassStatus bypassStatus = BypassStatusServices.Get(id.Value, db);
            if (bypassStatus == null)
            {
                return HttpNotFound();
            }
            return View(bypassStatus);
        }

        // POST: BypassStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            BypassStatusServices.Delete(CurrentUser.Id, id, db);
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
            // return View(bypassStatus);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

