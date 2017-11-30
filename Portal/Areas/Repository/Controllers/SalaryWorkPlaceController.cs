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
    public partial class SalaryWorkPlaceController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryWorkPlace", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryWorkPlace", "ModuleNamePlural");
		
	    public SalaryWorkPlaceController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of SalaryWorkPlaceVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(SalaryWorkPlaceVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
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
            return View(salaryWorkPlace);
        }

        // GET: SalaryWorkPlace/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
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
            return View(salaryWorkPlace);
        }
        // GET: SalaryWorkPlace/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
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

