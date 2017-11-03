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
    public class TransitoryIncomingLoanController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "TransitoryIncomingLoan", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "TransitoryIncomingLoan", "ModuleNamePlural");
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
        /// Returns a list of TransitoryIncomingLoanVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(TransitoryIncomingLoanVwViewModel Model)
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
                Model.List = TransitoryIncomingLoanVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<TransitoryIncomingLoanVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  employee)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
			ViewBag.Insert = insert;
			ViewBag.Delete = delete;
            
            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransitoryIncomingLoanVwViewModel transitoryIncomingLoanVwViewModel = new TransitoryIncomingLoanVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// transitoryIncomingLoanVwViewModel.Instance = TransitoryIncomingLoanVwServices.Get(employee.Value, db);
            transitoryIncomingLoanVwViewModel.Instance = TransitoryIncomingLoanVwServices.GetChildren(employee.Value, db);
            if (transitoryIncomingLoanVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(transitoryIncomingLoanVwViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
			return View();
        }

        // POST: transitoryIncomingLoanVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Employee, MainWorkPlace, ApprovedAmount, Installment, Notes, IsVerified")] TransitoryIncomingLoan transitoryIncomingLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                TransitoryIncomingLoanServices.Insert(CurrentUser.Id, transitoryIncomingLoan, db);
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
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View(transitoryIncomingLoan);
        }

        // GET: TransitoryIncomingLoan/Edit/5
        public ActionResult Edit(Nullable<int>  employee)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            Db db = new Db(DbServices.ConnectionString);

            if (employee == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransitoryIncomingLoan transitoryIncomingLoan = TransitoryIncomingLoanServices.Get(employee.Value, db);
            if (transitoryIncomingLoan == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", transitoryIncomingLoan.Employee);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", transitoryIncomingLoan.MainWorkPlace);
            return View(transitoryIncomingLoan);
        }

        // POST: TransitoryIncomingLoan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Employee, MainWorkPlace, ApprovedAmount, Installment, Notes, IsVerified")] TransitoryIncomingLoan transitoryIncomingLoan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                TransitoryIncomingLoanServices.Update(CurrentUser.Id, transitoryIncomingLoan, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", transitoryIncomingLoan.Employee);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name", transitoryIncomingLoan.MainWorkPlace);
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View(transitoryIncomingLoan);
        }
        // GET: TransitoryIncomingLoan/Delete/5
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
            TransitoryIncomingLoan transitoryIncomingLoan = TransitoryIncomingLoanServices.Get(id.Value, db);
            if (transitoryIncomingLoan == null)
            {
                return HttpNotFound();
            }
            return View(transitoryIncomingLoan);
        }

        // POST: TransitoryIncomingLoan/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  employee)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            TransitoryIncomingLoanServices.Delete(CurrentUser.Id, employee, db);
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
            // return View(transitoryIncomingLoan);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

