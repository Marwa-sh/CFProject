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
    public class EventLogErrorController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EventLogError", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EventLogError", "ModuleNamePlural");
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
		
	    public EventLogErrorController()
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
        /// Returns a list of EventLogErrorVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(EventLogErrorVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = EventLogErrorVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<EventLogErrorVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<long>  eventLog)
        {
            if (eventLog == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventLogErrorVwViewModel eventLogErrorVwViewModel = new EventLogErrorVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// eventLogErrorVwViewModel.Instance = EventLogErrorVwServices.Get(eventLog.Value, db);
            eventLogErrorVwViewModel.Instance = EventLogErrorVwServices.GetChildren(eventLog.Value, db);
            if (eventLogErrorVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(eventLogErrorVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EventLogList = new SelectList(EventLogServices.List(db), "Id", "Name");
			return View();
        }

        // POST: eventLogErrorVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "EventLog, Number, Message, StackTrace")] EventLogError eventLogError)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EventLogErrorServices.Insert(CurrentUser.Id, eventLogError, db);
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

            ViewBag.EventLogList = new SelectList(EventLogServices.List(db), "Id", "Name");
            return View(eventLogError);
        }

        // GET: EventLogError/Edit/5
        public ActionResult Edit(Nullable<long>  eventLog)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (eventLog == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventLogError eventLogError = EventLogErrorServices.Get(eventLog.Value, db);
            if (eventLogError == null)
            {
                return HttpNotFound();
            }

            ViewBag.EventLogList = new SelectList(EventLogServices.List(db), "Id", "Name", eventLogError.EventLog);
            return View(eventLogError);
        }

        // POST: EventLogError/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "EventLog, Number, Message, StackTrace")] EventLogError eventLogError)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EventLogErrorServices.Update(CurrentUser.Id, eventLogError, db);
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

            ViewBag.EventLogList = new SelectList(EventLogServices.List(db), "Id", "Name", eventLogError.EventLog);
            return View(eventLogError);
        }
        // GET: EventLogError/Delete/5
        public ActionResult Delete(Nullable<long> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            EventLogError eventLogError = EventLogErrorServices.Get(id.Value, db);
            if (eventLogError == null)
            {
                return HttpNotFound();
            }
            return View(eventLogError);
        }

        // POST: EventLogError/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long  eventLog)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            EventLogErrorServices.Delete(CurrentUser.Id, eventLog, db);
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
            // return View(eventLogError);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

