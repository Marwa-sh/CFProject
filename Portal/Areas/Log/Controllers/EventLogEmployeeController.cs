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
    [RouteArea("Log")]
    public class EventLogEmployeeController : Controller
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

        /// <summary>
        /// Returns a list of EventLogVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(EventLogVwViewModel Model)
        {
            ViewBag.Title = index;
            ViewBag.ModuleName = moduleName;
            ViewBag.Insert = insert;
            ViewBag.Update = update;
            ViewBag.Delete = delete;
            ViewBag.Details = details;
            ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Yes = yes;
            ViewBag.No = no;
            ViewBag.Search = search;
            Db db = new Db(DbServices.ConnectionString);
            if (Model.Filter.HasCriteria)
            {
                Model.Filter.EventCategoryNameContains = "Employee";
                Model.Filter.EventSourceNameContains = "Employee";
                Model.List = EventLogVwServices.Get(Model.Selector, db);
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
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
            ViewBag.Details = details;
            
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


            @ViewBag.EventLogErrorVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EventLogError", "ModuleNamePlural");
            // EventLogErrorVw eventLogErrorVw = EventLogErrorVwServices.Get(id.Value, db);
            // if (eventLogErrorVw != null)
            //     eventLogVwViewModel.EventLogErrorVwViewModel.List.Add(eventLogErrorVw);
            if (eventLogVwViewModel.Instance.EventLogErrorVw != null)
                // eventLogVwViewModel.EventLogErrorVwViewModel.List.Add(eventLogVwViewModel.Instance.EventLogErrorVw);
                eventLogVwViewModel.EventLogErrorVwViewModel.Instance = eventLogVwViewModel.Instance.EventLogErrorVw;
            
            return View(eventLogVwViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            Db db = new Db(DbServices.ConnectionString);

            ViewBag.EventCategory = new SelectList(EventCategoryServices.List(db), "Id", "Name");
            ViewBag.EventSource = new SelectList(EventSourceServices.List(db), "Id", "Name");
            ViewBag.EventStatus = new SelectList(EventStatusServices.List(db), "Id", "Name");
            return View();
        }

        // POST: eventLogVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, EventSource, EventCategory, EventStatus, Parameters, Date, User")] EventLog eventLog)
        {
            if (ModelState.IsValid)
            {
                Db db = new Db(DbServices.ConnectionString);
                EventLogServices.Insert(0, eventLog, db);
                return RedirectToAction("Index");
            }

            return View(eventLog);
        }

        // GET: EventLog/Edit/5
        public ActionResult Edit(Nullable<long>  id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
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

            ViewBag.EventCategory = new SelectList(EventCategoryServices.List(db), "Id", "Name", eventLog.EventCategory);
            ViewBag.EventSource = new SelectList(EventSourceServices.List(db), "Id", "Name", eventLog.EventSource);
            ViewBag.EventStatus = new SelectList(EventStatusServices.List(db), "Id", "Name", eventLog.EventStatus);
            return View(eventLog);
        }

        // POST: EventLog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id, EventSource, EventCategory, EventStatus, Parameters, Date, User")] EventLog eventLog)
        {
            if (ModelState.IsValid)
            {
                Db db = new Db(DbServices.ConnectionString);
                EventLogServices.Update(0, eventLog, db);
                return RedirectToAction("Index");
            }
            return View(eventLog);
        }
        // GET: EventLog/Delete/5
        public ActionResult Delete(Nullable<long>  id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = delete;
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
            return View(eventLog);
        }

        // POST: EventLog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long  id)
        {
            Db db = new Db(DbServices.ConnectionString);
            EventLogServices.Delete(0, id, db);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

