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
    public class MainWorkPlaceController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "MainWorkPlace", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "MainWorkPlace", "ModuleNamePlural");
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
		
	    public MainWorkPlaceController()
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
        /// Returns a list of MainWorkPlaceVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(MainWorkPlaceVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = MainWorkPlaceVwServices.List(db);
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
            MainWorkPlaceVwViewModel mainWorkPlaceVwViewModel = new MainWorkPlaceVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// mainWorkPlaceVwViewModel.Instance = MainWorkPlaceVwServices.Get(id.Value, db);
            mainWorkPlaceVwViewModel.Instance = MainWorkPlaceVwServices.GetChildren(id.Value, db);
            if (mainWorkPlaceVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.SalaryWorkPlaceVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryWorkPlace", "ModuleNamePlural");
            // mainWorkPlaceVwViewModel.SalaryWorkPlaceVwViewModel.List = SalaryWorkPlaceVwServices.GetByMainWorkPlaceId(id.Value, db);
            mainWorkPlaceVwViewModel.SalaryWorkPlaceVwViewModel.List = mainWorkPlaceVwViewModel.Instance.SalaryWorkPlaceVwList;
            
            
            return View(mainWorkPlaceVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: mainWorkPlaceVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] MainWorkPlace mainWorkPlace)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                MainWorkPlaceServices.Insert(CurrentUser.Id, mainWorkPlace, db);
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

            return View(mainWorkPlace);
        }

        // GET: MainWorkPlace/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MainWorkPlace mainWorkPlace = MainWorkPlaceServices.Get(id.Value, db);
            if (mainWorkPlace == null)
            {
                return HttpNotFound();
            }

            return View(mainWorkPlace);
        }

        // POST: MainWorkPlace/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] MainWorkPlace mainWorkPlace)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                MainWorkPlaceServices.Update(CurrentUser.Id, mainWorkPlace, db);
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

            return View(mainWorkPlace);
        }
        // GET: MainWorkPlace/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            MainWorkPlace mainWorkPlace = MainWorkPlaceServices.Get(id.Value, db);
            if (mainWorkPlace == null)
            {
                return HttpNotFound();
            }
            return View(mainWorkPlace);
        }

        // POST: MainWorkPlace/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            MainWorkPlaceServices.Delete(CurrentUser.Id, id, db);
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
            // return View(mainWorkPlace);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

