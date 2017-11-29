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
    public partial class InstallmentDecreaseController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "InstallmentDecrease", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "InstallmentDecrease", "ModuleNamePlural");
		
	    public InstallmentDecreaseController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of InstallmentDecreaseVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(InstallmentDecreaseVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = InstallmentDecreaseVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<InstallmentDecreaseVw>();
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
            InstallmentDecreaseVwViewModel installmentDecreaseVwViewModel = new InstallmentDecreaseVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// installmentDecreaseVwViewModel.Instance = InstallmentDecreaseVwServices.Get(id.Value, db);
            installmentDecreaseVwViewModel.Instance = InstallmentDecreaseVwServices.GetChildren(id.Value, db);
            if (installmentDecreaseVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(installmentDecreaseVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.InstallmentDecreaseOrderList = new SelectList(InstallmentDecreaseOrderServices.List(db), "Id", "CersNumber");
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
			return View();
        }

        // POST: installmentDecreaseVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, InstallmentDecreaseOrder, Employee, Department, DecreaseAmount, NewInstallmentAmount, Notes")] InstallmentDecrease installmentDecrease)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InstallmentDecreaseServices.Insert(CurrentUser.Id, installmentDecrease, db);
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
            ViewBag.InstallmentDecreaseOrderList = new SelectList(InstallmentDecreaseOrderServices.List(db), "Id", "CersNumber");
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
            return View(installmentDecrease);
        }

        // GET: InstallmentDecrease/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InstallmentDecrease installmentDecrease = InstallmentDecreaseServices.Get(id.Value, db);
            if (installmentDecrease == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", installmentDecrease.Employee);
            ViewBag.InstallmentDecreaseOrderList = new SelectList(InstallmentDecreaseOrderServices.List(db), "Id", "CersNumber", installmentDecrease.InstallmentDecreaseOrder);
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", installmentDecrease.Department);
            return View(installmentDecrease);
        }

        // POST: InstallmentDecrease/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, InstallmentDecreaseOrder, Employee, Department, DecreaseAmount, NewInstallmentAmount, Notes")] InstallmentDecrease installmentDecrease)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InstallmentDecreaseServices.Update(CurrentUser.Id, installmentDecrease, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", installmentDecrease.Employee);
            ViewBag.InstallmentDecreaseOrderList = new SelectList(InstallmentDecreaseOrderServices.List(db), "Id", "CersNumber", installmentDecrease.InstallmentDecreaseOrder);
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", installmentDecrease.Department);
            return View(installmentDecrease);
        }
        // GET: InstallmentDecrease/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            InstallmentDecrease installmentDecrease = InstallmentDecreaseServices.Get(id.Value, db);
            if (installmentDecrease == null)
            {
                return HttpNotFound();
            }
            return View(installmentDecrease);
        }

        // POST: InstallmentDecrease/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            InstallmentDecreaseServices.Delete(CurrentUser.Id, id, db);
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
            // return View(installmentDecrease);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

