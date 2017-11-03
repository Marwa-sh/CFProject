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
    public class ServiceEndGrantRequestController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ServiceEndGrantRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ServiceEndGrantRequest", "ModuleNamePlural");
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

        /// <summary>
        /// Returns a list of ServiceEndGrantRequestVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ServiceEndGrantRequestVwViewModel Model)
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
			ViewBag.FilterOptions = filterOptions;
			
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = ServiceEndGrantRequestVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<ServiceEndGrantRequestVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  grantRequest)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
			ViewBag.Insert = insert;
			ViewBag.Delete = delete;
            
            if (grantRequest == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceEndGrantRequestVwViewModel serviceEndGrantRequestVwViewModel = new ServiceEndGrantRequestVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// serviceEndGrantRequestVwViewModel.Instance = ServiceEndGrantRequestVwServices.Get(grantRequest.Value, db);
            serviceEndGrantRequestVwViewModel.Instance = ServiceEndGrantRequestVwServices.GetChildren(grantRequest.Value, db);
            if (serviceEndGrantRequestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(serviceEndGrantRequestVwViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GrantRequestList = new SelectList(GrantRequestServices.List(db), "Request", "Description");
			return View();
        }

        // POST: serviceEndGrantRequestVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "GrantRequest, AverageIncome, GrantPercentage, ServiceInMonthes")] ServiceEndGrantRequest serviceEndGrantRequest)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ServiceEndGrantRequestServices.Insert(CurrentUser.Id, serviceEndGrantRequest, db);
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

            ViewBag.GrantRequestList = new SelectList(GrantRequestServices.List(db), "Request", "Description");
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View(serviceEndGrantRequest);
        }

        // GET: ServiceEndGrantRequest/Edit/5
        public ActionResult Edit(Nullable<int>  grantRequest)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            Db db = new Db(DbServices.ConnectionString);

            if (grantRequest == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceEndGrantRequest serviceEndGrantRequest = ServiceEndGrantRequestServices.Get(grantRequest.Value, db);
            if (serviceEndGrantRequest == null)
            {
                return HttpNotFound();
            }

            ViewBag.GrantRequestList = new SelectList(GrantRequestServices.List(db), "Request", "Description", serviceEndGrantRequest.GrantRequest);
            return View(serviceEndGrantRequest);
        }

        // POST: ServiceEndGrantRequest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "GrantRequest, AverageIncome, GrantPercentage, ServiceInMonthes")] ServiceEndGrantRequest serviceEndGrantRequest)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ServiceEndGrantRequestServices.Update(CurrentUser.Id, serviceEndGrantRequest, db);
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

            ViewBag.GrantRequestList = new SelectList(GrantRequestServices.List(db), "Request", "Description", serviceEndGrantRequest.GrantRequest);
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View(serviceEndGrantRequest);
        }
        // GET: ServiceEndGrantRequest/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = delete;
			ViewBag.Delete = delete;
			ViewBag.Yes = yes;
			ViewBag.No = no;
			ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Action = delete;

			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ServiceEndGrantRequest serviceEndGrantRequest = ServiceEndGrantRequestServices.Get(id.Value, db);
            if (serviceEndGrantRequest == null)
            {
                return HttpNotFound();
            }
            return View(serviceEndGrantRequest);
        }

        // POST: ServiceEndGrantRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  grantRequest)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ServiceEndGrantRequestServices.Delete(CurrentUser.Id, grantRequest, db);
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
            // return View(serviceEndGrantRequest);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

