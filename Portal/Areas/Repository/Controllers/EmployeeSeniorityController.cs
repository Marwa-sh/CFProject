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
    public partial class EmployeeSeniorityController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EmployeeSeniority", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EmployeeSeniority", "ModuleNamePlural");
		
	    public EmployeeSeniorityController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of EmployeeSeniorityVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(EmployeeSeniorityVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = EmployeeSeniorityVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  employee)
        {
            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSeniorityVwViewModel employeeSeniorityVwViewModel = new EmployeeSeniorityVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// employeeSeniorityVwViewModel.Instance = EmployeeSeniorityVwServices.Get(employee.Value, db);
            employeeSeniorityVwViewModel.Instance = EmployeeSeniorityVwServices.GetChildren(employee.Value, db);
            if (employeeSeniorityVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(employeeSeniorityVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
			return View();
        }

        // POST: employeeSeniorityVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Employee, ServiceInDays")] EmployeeSeniority employeeSeniority)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EmployeeSeniorityServices.Insert(CurrentUser.Id, employeeSeniority, db);
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
            return View(employeeSeniority);
        }

        // GET: EmployeeSeniority/Edit/5
        public ActionResult Edit(Nullable<int>  employee)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeSeniority employeeSeniority = EmployeeSeniorityServices.Get(employee.Value, db);
            if (employeeSeniority == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", employeeSeniority.Employee);
            return View(employeeSeniority);
        }

        // POST: EmployeeSeniority/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Employee, ServiceInDays")] EmployeeSeniority employeeSeniority)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EmployeeSeniorityServices.Update(CurrentUser.Id, employeeSeniority, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", employeeSeniority.Employee);
            return View(employeeSeniority);
        }
        // GET: EmployeeSeniority/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            EmployeeSeniority employeeSeniority = EmployeeSeniorityServices.Get(id.Value, db);
            if (employeeSeniority == null)
            {
                return HttpNotFound();
            }
            return View(employeeSeniority);
        }

        // POST: EmployeeSeniority/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  employee)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            EmployeeSeniorityServices.Delete(CurrentUser.Id, employee, db);
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
            // return View(employeeSeniority);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

