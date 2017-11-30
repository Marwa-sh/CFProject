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
    public partial class ExternalGrantController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExternalGrant", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExternalGrant", "ModuleNamePlural");
		
	    public ExternalGrantController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ExternalGrantVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ExternalGrantVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.GrantType = new SelectList(GrantTypeServices.List(db),"Id","Name");

            if (Model.Filter.HasCriteria)
	        {
                Model.List = ExternalGrantVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<ExternalGrantVw>();
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
            ExternalGrantVwViewModel externalGrantVwViewModel = new ExternalGrantVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// externalGrantVwViewModel.Instance = ExternalGrantVwServices.Get(id.Value, db);
            externalGrantVwViewModel.Instance = ExternalGrantVwServices.GetChildren(id.Value, db);
            if (externalGrantVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(externalGrantVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name");
			return View();
        }

        // POST: externalGrantVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, RequestDate, GrantType, Description, Amount, CersNumber, CersDate, PaymentNumber, PaymentDate, Notes")] ExternalGrant externalGrant)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ExternalGrantServices.Insert(CurrentUser.Id, externalGrant, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name");
            return View(externalGrant);
        }

        // GET: ExternalGrant/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExternalGrant externalGrant = ExternalGrantServices.Get(id.Value, db);
            if (externalGrant == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", externalGrant.Employee);
            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name", externalGrant.GrantType);
            return View(externalGrant);
        }

        // POST: ExternalGrant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, RequestDate, GrantType, Description, Amount, CersNumber, CersDate, PaymentNumber, PaymentDate, Notes")] ExternalGrant externalGrant)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ExternalGrantServices.Update(CurrentUser.Id, externalGrant, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", externalGrant.Employee);
            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name", externalGrant.GrantType);
            return View(externalGrant);
        }
        // GET: ExternalGrant/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ExternalGrant externalGrant = ExternalGrantServices.Get(id.Value, db);
            if (externalGrant == null)
            {
                return HttpNotFound();
            }
            return View(externalGrant);
        }

        // POST: ExternalGrant/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ExternalGrantServices.Delete(CurrentUser.Id, id, db);
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
            // return View(externalGrant);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

