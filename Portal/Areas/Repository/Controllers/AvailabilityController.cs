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
    public partial class AvailabilityController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Availability", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Availability", "ModuleNamePlural");
		
	    public AvailabilityController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of AvailabilityVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(AvailabilityVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = AvailabilityVwServices.List(db);
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
            AvailabilityVwViewModel availabilityVwViewModel = new AvailabilityVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// availabilityVwViewModel.Instance = AvailabilityVwServices.Get(id.Value, db);
            availabilityVwViewModel.Instance = AvailabilityVwServices.GetChildren(id.Value, db);
            if (availabilityVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.AvailabilityCeilingVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "AvailabilityCeiling", "ModuleNamePlural");
            // availabilityVwViewModel.AvailabilityCeilingVwViewModel.List = AvailabilityCeilingVwServices.GetByAvailabilityId(id.Value, db);
            availabilityVwViewModel.AvailabilityCeilingVwViewModel.List = availabilityVwViewModel.Instance.AvailabilityCeilingVwList;
            

            @ViewBag.ProductTypeAvailabilityVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductTypeAvailability", "ModuleNamePlural");
            // availabilityVwViewModel.ProductTypeAvailabilityVwViewModel.List = ProductTypeAvailabilityVwServices.GetByAvailabilityId(id.Value, db);
            availabilityVwViewModel.ProductTypeAvailabilityVwViewModel.List = availabilityVwViewModel.Instance.ProductTypeAvailabilityVwList;
            
            
            return View(availabilityVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: availabilityVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name, MinSeniority, MinReusePeriod")] Availability availability)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                AvailabilityServices.Insert(CurrentUser.Id, availability, db);
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

            return View(availability);
        }

        // GET: Availability/Edit/5
        public ActionResult Edit(Nullable<short>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Availability availability = AvailabilityServices.Get(id.Value, db);
            if (availability == null)
            {
                return HttpNotFound();
            }

            return View(availability);
        }

        // POST: Availability/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, MinSeniority, MinReusePeriod")] Availability availability)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                AvailabilityServices.Update(CurrentUser.Id, availability, db);
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

            return View(availability);
        }
        // GET: Availability/Delete/5
        public ActionResult Delete(Nullable<short> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Availability availability = AvailabilityServices.Get(id.Value, db);
            if (availability == null)
            {
                return HttpNotFound();
            }
            return View(availability);
        }

        // POST: Availability/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(short  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            AvailabilityServices.Delete(CurrentUser.Id, id, db);
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
            // return View(availability);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

