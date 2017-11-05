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
    public class InstallmentDecreaseOrderController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "InstallmentDecreaseOrder", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "InstallmentDecreaseOrder", "ModuleNamePlural");
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
		
	    public InstallmentDecreaseOrderController()
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
        /// Returns a list of InstallmentDecreaseOrderVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(InstallmentDecreaseOrderVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = InstallmentDecreaseOrderVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<InstallmentDecreaseOrderVw>();
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
            InstallmentDecreaseOrderVwViewModel installmentDecreaseOrderVwViewModel = new InstallmentDecreaseOrderVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// installmentDecreaseOrderVwViewModel.Instance = InstallmentDecreaseOrderVwServices.Get(id.Value, db);
            installmentDecreaseOrderVwViewModel.Instance = InstallmentDecreaseOrderVwServices.GetChildren(id.Value, db);
            if (installmentDecreaseOrderVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.InstallmentDecreaseVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "InstallmentDecrease", "ModuleNamePlural");
            // installmentDecreaseOrderVwViewModel.InstallmentDecreaseVwViewModel.List = InstallmentDecreaseVwServices.GetByInstallmentDecreaseOrderId(id.Value, db);
            installmentDecreaseOrderVwViewModel.InstallmentDecreaseVwViewModel.List = installmentDecreaseOrderVwViewModel.Instance.InstallmentDecreaseVwList;
            
            
            return View(installmentDecreaseOrderVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: installmentDecreaseOrderVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Month, CersNumber, CersDate, Notes")] InstallmentDecreaseOrder installmentDecreaseOrder)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InstallmentDecreaseOrderServices.Insert(CurrentUser.Id, installmentDecreaseOrder, db);
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

            return View(installmentDecreaseOrder);
        }

        // GET: InstallmentDecreaseOrder/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InstallmentDecreaseOrder installmentDecreaseOrder = InstallmentDecreaseOrderServices.Get(id.Value, db);
            if (installmentDecreaseOrder == null)
            {
                return HttpNotFound();
            }

            return View(installmentDecreaseOrder);
        }

        // POST: InstallmentDecreaseOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Month, CersNumber, CersDate, Notes")] InstallmentDecreaseOrder installmentDecreaseOrder)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InstallmentDecreaseOrderServices.Update(CurrentUser.Id, installmentDecreaseOrder, db);
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

            return View(installmentDecreaseOrder);
        }
        // GET: InstallmentDecreaseOrder/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            InstallmentDecreaseOrder installmentDecreaseOrder = InstallmentDecreaseOrderServices.Get(id.Value, db);
            if (installmentDecreaseOrder == null)
            {
                return HttpNotFound();
            }
            return View(installmentDecreaseOrder);
        }

        // POST: InstallmentDecreaseOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            InstallmentDecreaseOrderServices.Delete(CurrentUser.Id, id, db);
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
            // return View(installmentDecreaseOrder);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

