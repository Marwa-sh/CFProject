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
    public partial class SubscriptionController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Subscription", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Subscription", "ModuleNamePlural");
		
	    public SubscriptionController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of SubscriptionVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(SubscriptionVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.SubscriptionTypeList = new SelectList(SubscriptionTypeServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
                Model.List = SubscriptionVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<SubscriptionVw>();
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
            SubscriptionVwViewModel subscriptionVwViewModel = new SubscriptionVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// subscriptionVwViewModel.Instance = SubscriptionVwServices.Get(id.Value, db);
            subscriptionVwViewModel.Instance = SubscriptionVwServices.GetChildren(id.Value, db);
            if (subscriptionVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(subscriptionVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.SubscriptionTypeList = new SelectList(SubscriptionTypeServices.List(db), "Id", "Name");
			return View();
        }

        // POST: subscriptionVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, Month, Department, SubscriptionType, Amount, Notes, IsFixed")] Subscription subscription)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SubscriptionServices.Insert(CurrentUser.Id, subscription, db);
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

            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.SubscriptionTypeList = new SelectList(SubscriptionTypeServices.List(db), "Id", "Name");
            return View(subscription);
        }

        // GET: Subscription/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subscription subscription = SubscriptionServices.Get(id.Value, db);
            if (subscription == null)
            {
                return HttpNotFound();
            }

            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", subscription.Department);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", subscription.Employee);
            ViewBag.SubscriptionTypeList = new SelectList(SubscriptionTypeServices.List(db), "Id", "Name", subscription.SubscriptionType);
            return View(subscription);
        }

        // POST: Subscription/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, Month, Department, SubscriptionType, Amount, Notes, IsFixed")] Subscription subscription)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SubscriptionServices.Update(CurrentUser.Id, subscription, db);
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

            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", subscription.Department);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", subscription.Employee);
            ViewBag.SubscriptionTypeList = new SelectList(SubscriptionTypeServices.List(db), "Id", "Name", subscription.SubscriptionType);
            return View(subscription);
        }
        // GET: Subscription/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Subscription subscription = SubscriptionServices.Get(id.Value, db);
            if (subscription == null)
            {
                return HttpNotFound();
            }
            return View(subscription);
        }

        // POST: Subscription/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            SubscriptionServices.Delete(CurrentUser.Id, id, db);
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
            // return View(subscription);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

