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
    public class SpecialCaseLoanController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SpecialCaseLoan", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SpecialCaseLoan", "ModuleNamePlural");
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
		
	    public SpecialCaseLoanController()
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
        /// Returns a list of SpecialCaseLoanVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(SpecialCaseLoanVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = SpecialCaseLoanVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<SpecialCaseLoanVw>();
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
            SpecialCaseLoanVwViewModel specialCaseLoanVwViewModel = new SpecialCaseLoanVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// specialCaseLoanVwViewModel.Instance = SpecialCaseLoanVwServices.Get(id.Value, db);
            specialCaseLoanVwViewModel.Instance = SpecialCaseLoanVwServices.GetChildren(id.Value, db);
            if (specialCaseLoanVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(specialCaseLoanVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name");
			return View();
        }

        // POST: specialCaseLoanVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, Date, LoanType, Amount, Notes")] SpecialCaseLoan specialCaseLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SpecialCaseLoanServices.Insert(CurrentUser.Id, specialCaseLoan, db);
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
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name");
            return View(specialCaseLoan);
        }

        // GET: SpecialCaseLoan/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecialCaseLoan specialCaseLoan = SpecialCaseLoanServices.Get(id.Value, db);
            if (specialCaseLoan == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", specialCaseLoan.Employee);
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name", specialCaseLoan.LoanType);
            return View(specialCaseLoan);
        }

        // POST: SpecialCaseLoan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, Date, LoanType, Amount, Notes")] SpecialCaseLoan specialCaseLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SpecialCaseLoanServices.Update(CurrentUser.Id, specialCaseLoan, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", specialCaseLoan.Employee);
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name", specialCaseLoan.LoanType);
            return View(specialCaseLoan);
        }
        // GET: SpecialCaseLoan/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            SpecialCaseLoan specialCaseLoan = SpecialCaseLoanServices.Get(id.Value, db);
            if (specialCaseLoan == null)
            {
                return HttpNotFound();
            }
            return View(specialCaseLoan);
        }

        // POST: SpecialCaseLoan/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            SpecialCaseLoanServices.Delete(CurrentUser.Id, id, db);
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
            // return View(specialCaseLoan);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

