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
    public partial class TransitoryIncomingLoanController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "TransitoryIncomingLoan", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "TransitoryIncomingLoan", "ModuleNamePlural");
		
	    public TransitoryIncomingLoanController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of TransitoryIncomingLoanVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(TransitoryIncomingLoanVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.MainWorkPlaceList = new SelectList(MainWorkPlaceServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
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
            return View(transitoryIncomingLoan);
        }

        // GET: TransitoryIncomingLoan/Edit/5
        public ActionResult Edit(Nullable<int>  employee)
        {
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
            return View(transitoryIncomingLoan);
        }
        // GET: TransitoryIncomingLoan/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
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

