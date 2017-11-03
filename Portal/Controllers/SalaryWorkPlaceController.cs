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
    public class SalaryWorkPlaceController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryWorkPlace", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryWorkPlace", "ModuleNamePlural");
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
        /// Returns a list of SalaryWorkPlaceVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(SalaryWorkPlaceVwViewModel Model)
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
                Model.List = SalaryWorkPlaceVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<SalaryWorkPlaceVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
			ViewBag.Insert = insert;
			ViewBag.Delete = delete;
            
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalaryWorkPlaceVwViewModel salaryWorkPlaceVwViewModel = new SalaryWorkPlaceVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// salaryWorkPlaceVwViewModel.Instance = SalaryWorkPlaceVwServices.Get(id.Value, db);
            salaryWorkPlaceVwViewModel.Instance = SalaryWorkPlaceVwServices.GetChildren(id.Value, db);
            if (salaryWorkPlaceVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.DepartmentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Department", "ModuleNamePlural");
            // salaryWorkPlaceVwViewModel.DepartmentVwViewModel.List = DepartmentVwServices.GetBySalaryWorkPlaceId(id.Value, db);
            salaryWorkPlaceVwViewModel.DepartmentVwViewModel.List = salaryWorkPlaceVwViewModel.Instance.DepartmentVwList;
            
            
            return View(salaryWorkPlaceVwViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
			return View();
        }

        // POST: salaryWorkPlaceVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name, MainWorkPlace")] SalaryWorkPlace salaryWorkPlace)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SalaryWorkPlaceServices.Insert(CurrentUser.Id, salaryWorkPlace, db);
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

            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View(salaryWorkPlace);
        }

        // GET: SalaryWorkPlace/Edit/5
        public ActionResult Edit(Nullable<int>  id)
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
            SalaryWorkPlace salaryWorkPlace = SalaryWorkPlaceServices.Get(id.Value, db);
            if (salaryWorkPlace == null)
            {
                return HttpNotFound();
            }

            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", salaryWorkPlace.MainWorkPlace);
            return View(salaryWorkPlace);
        }

        // POST: SalaryWorkPlace/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, MainWorkPlace")] SalaryWorkPlace salaryWorkPlace)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SalaryWorkPlaceServices.Update(CurrentUser.Id, salaryWorkPlace, db);
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

            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", salaryWorkPlace.MainWorkPlace);
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View(salaryWorkPlace);
        }
        // GET: SalaryWorkPlace/Delete/5
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
            SalaryWorkPlace salaryWorkPlace = SalaryWorkPlaceServices.Get(id.Value, db);
            if (salaryWorkPlace == null)
            {
                return HttpNotFound();
            }
            return View(salaryWorkPlace);
        }

        // POST: SalaryWorkPlace/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            SalaryWorkPlaceServices.Delete(CurrentUser.Id, id, db);
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
            // return View(salaryWorkPlace);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

