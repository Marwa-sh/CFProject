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
    public partial class EmployeeStatusController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EmployeeStatus", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EmployeeStatus", "ModuleNamePlural");
		
	    public EmployeeStatusController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of EmployeeStatusVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(EmployeeStatusVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = EmployeeStatusVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<byte>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeStatusVwViewModel employeeStatusVwViewModel = new EmployeeStatusVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// employeeStatusVwViewModel.Instance = EmployeeStatusVwServices.Get(id.Value, db);
            employeeStatusVwViewModel.Instance = EmployeeStatusVwServices.GetChildren(id.Value, db);
            if (employeeStatusVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(employeeStatusVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: employeeStatusVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name, IsActive")] EmployeeStatus employeeStatus)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EmployeeStatusServices.Insert(CurrentUser.Id, employeeStatus, db);
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

            return View(employeeStatus);
        }

        // GET: EmployeeStatus/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeStatus employeeStatus = EmployeeStatusServices.Get(id.Value, db);
            if (employeeStatus == null)
            {
                return HttpNotFound();
            }

            return View(employeeStatus);
        }

        // POST: EmployeeStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, IsActive")] EmployeeStatus employeeStatus)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EmployeeStatusServices.Update(CurrentUser.Id, employeeStatus, db);
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

            return View(employeeStatus);
        }
        // GET: EmployeeStatus/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            EmployeeStatus employeeStatus = EmployeeStatusServices.Get(id.Value, db);
            if (employeeStatus == null)
            {
                return HttpNotFound();
            }
            return View(employeeStatus);
        }

        // POST: EmployeeStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            EmployeeStatusServices.Delete(CurrentUser.Id, id, db);
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
            // return View(employeeStatus);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

