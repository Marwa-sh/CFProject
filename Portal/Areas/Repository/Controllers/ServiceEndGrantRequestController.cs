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
    public partial class ServiceEndGrantRequestController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ServiceEndGrantRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ServiceEndGrantRequest", "ModuleNamePlural");
		
	    public ServiceEndGrantRequestController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ServiceEndGrantRequestVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ServiceEndGrantRequestVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
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
            return View(serviceEndGrantRequest);
        }

        // GET: ServiceEndGrantRequest/Edit/5
        public ActionResult Edit(Nullable<int>  grantRequest)
        {
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
            return View(serviceEndGrantRequest);
        }
        // GET: ServiceEndGrantRequest/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
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

