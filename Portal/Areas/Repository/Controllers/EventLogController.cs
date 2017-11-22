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
    public partial class EventLogController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EventLog", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EventLog", "ModuleNamePlural");
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
		
	    public EventLogController()
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
        /// Returns a list of EventLogVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(EventLogVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = EventLogVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<EventLogVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<long>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventLogVwViewModel eventLogVwViewModel = new EventLogVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// eventLogVwViewModel.Instance = EventLogVwServices.Get(id.Value, db);
            eventLogVwViewModel.Instance = EventLogVwServices.GetChildren(id.Value, db);
            if (eventLogVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(eventLogVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EventCategoryList = new SelectList(EventCategoryServices.List(db), "Id", "Name");
            ViewBag.EventSourceList = new SelectList(EventSourceServices.List(db), "Id", "Name");
            ViewBag.EventStatusList = new SelectList(EventStatusServices.List(db), "Id", "Name");
			return View();
        }

        // POST: eventLogVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, EventSource, EventCategory, EventStatus, Parameters, Date, User")] EventLog eventLog)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EventLogServices.Insert(CurrentUser.Id, eventLog, db);
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

            ViewBag.EventCategoryList = new SelectList(EventCategoryServices.List(db), "Id", "Name");
            ViewBag.EventSourceList = new SelectList(EventSourceServices.List(db), "Id", "Name");
            ViewBag.EventStatusList = new SelectList(EventStatusServices.List(db), "Id", "Name");
            return View(eventLog);
        }

        // GET: EventLog/Edit/5
        public ActionResult Edit(Nullable<long>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventLog eventLog = EventLogServices.Get(id.Value, db);
            if (eventLog == null)
            {
                return HttpNotFound();
            }

            ViewBag.EventCategoryList = new SelectList(EventCategoryServices.List(db), "Id", "Name", eventLog.EventCategory);
            ViewBag.EventSourceList = new SelectList(EventSourceServices.List(db), "Id", "Name", eventLog.EventSource);
            ViewBag.EventStatusList = new SelectList(EventStatusServices.List(db), "Id", "Name", eventLog.EventStatus);
            return View(eventLog);
        }

        // POST: EventLog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, EventSource, EventCategory, EventStatus, Parameters, Date, User")] EventLog eventLog)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EventLogServices.Update(CurrentUser.Id, eventLog, db);
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

            ViewBag.EventCategoryList = new SelectList(EventCategoryServices.List(db), "Id", "Name", eventLog.EventCategory);
            ViewBag.EventSourceList = new SelectList(EventSourceServices.List(db), "Id", "Name", eventLog.EventSource);
            ViewBag.EventStatusList = new SelectList(EventStatusServices.List(db), "Id", "Name", eventLog.EventStatus);
            return View(eventLog);
        }
        // GET: EventLog/Delete/5
        public ActionResult Delete(Nullable<long> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            EventLog eventLog = EventLogServices.Get(id.Value, db);
            if (eventLog == null)
            {
                return HttpNotFound();
            }
            return View(eventLog);
        }

        // POST: EventLog/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            EventLogServices.Delete(CurrentUser.Id, id, db);
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
            // return View(eventLog);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

