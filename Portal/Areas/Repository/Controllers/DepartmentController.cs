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
    public partial class DepartmentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Department", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Department", "ModuleNamePlural");
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
		
	    public DepartmentController()
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
        /// Returns a list of DepartmentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(DepartmentVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = DepartmentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<DepartmentVw>();
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
            DepartmentVwViewModel departmentVwViewModel = new DepartmentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// departmentVwViewModel.Instance = DepartmentVwServices.Get(id.Value, db);
            departmentVwViewModel.Instance = DepartmentVwServices.GetChildren(id.Value, db);
            if (departmentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(departmentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.SalaryWorkPlaceList = new SelectList(SalaryWorkPlaceServices.List(db), "Id", "Name");
			return View();
        }

        // POST: departmentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name, SalaryWorkPlace")] Department department)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                DepartmentServices.Insert(CurrentUser.Id, department, db);
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

            ViewBag.SalaryWorkPlaceList = new SelectList(SalaryWorkPlaceServices.List(db), "Id", "Name");
            return View(department);
        }

        // GET: Department/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department department = DepartmentServices.Get(id.Value, db);
            if (department == null)
            {
                return HttpNotFound();
            }

            ViewBag.SalaryWorkPlaceList = new SelectList(SalaryWorkPlaceServices.List(db), "Id", "Name", department.SalaryWorkPlace);
            return View(department);
        }

        // POST: Department/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, SalaryWorkPlace")] Department department)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                DepartmentServices.Update(CurrentUser.Id, department, db);
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

            ViewBag.SalaryWorkPlaceList = new SelectList(SalaryWorkPlaceServices.List(db), "Id", "Name", department.SalaryWorkPlace);
            return View(department);
        }
        // GET: Department/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Department department = DepartmentServices.Get(id.Value, db);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            DepartmentServices.Delete(CurrentUser.Id, id, db);
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
            // return View(department);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
