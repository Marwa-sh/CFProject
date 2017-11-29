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
    public partial class AvailabilityCeilingController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "AvailabilityCeiling", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "AvailabilityCeiling", "ModuleNamePlural");
		
	    public AvailabilityCeilingController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of AvailabilityCeilingVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(AvailabilityCeilingVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = AvailabilityCeilingVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<short>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvailabilityCeilingVwViewModel availabilityCeilingVwViewModel = new AvailabilityCeilingVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// availabilityCeilingVwViewModel.Instance = AvailabilityCeilingVwServices.Get(id.Value, db);
            availabilityCeilingVwViewModel.Instance = AvailabilityCeilingVwServices.GetChildren(id.Value, db);
            if (availabilityCeilingVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(availabilityCeilingVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name");
			return View();
        }

        // POST: availabilityCeilingVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Availability, FromYear, MaxAmount")] AvailabilityCeiling availabilityCeiling)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                AvailabilityCeilingServices.Insert(CurrentUser.Id, availabilityCeiling, db);
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

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name");
            return View(availabilityCeiling);
        }

        // GET: AvailabilityCeiling/Edit/5
        public ActionResult Edit(Nullable<short>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AvailabilityCeiling availabilityCeiling = AvailabilityCeilingServices.Get(id.Value, db);
            if (availabilityCeiling == null)
            {
                return HttpNotFound();
            }

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name", availabilityCeiling.Availability);
            return View(availabilityCeiling);
        }

        // POST: AvailabilityCeiling/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Availability, FromYear, MaxAmount")] AvailabilityCeiling availabilityCeiling)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                AvailabilityCeilingServices.Update(CurrentUser.Id, availabilityCeiling, db);
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

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name", availabilityCeiling.Availability);
            return View(availabilityCeiling);
        }
        // GET: AvailabilityCeiling/Delete/5
        public ActionResult Delete(Nullable<short> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            AvailabilityCeiling availabilityCeiling = AvailabilityCeilingServices.Get(id.Value, db);
            if (availabilityCeiling == null)
            {
                return HttpNotFound();
            }
            return View(availabilityCeiling);
        }

        // POST: AvailabilityCeiling/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(short  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            AvailabilityCeilingServices.Delete(CurrentUser.Id, id, db);
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
            // return View(availabilityCeiling);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

