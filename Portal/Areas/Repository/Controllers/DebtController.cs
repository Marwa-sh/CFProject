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
    public partial class DebtController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Debt", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Debt", "ModuleNamePlural");
		
	    public DebtController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of DebtVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(DebtVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.EmployeeDepartmentSalaryWorkPlaceId = new SelectList(SalaryWorkPlaceServices.List(db), "Id", "Name");
            ViewBag.Issuer = new SelectList(IssuerServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {				
                Model.List = DebtVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<DebtVw>();
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
            DebtVwViewModel debtVwViewModel = new DebtVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// debtVwViewModel.Instance = DebtVwServices.Get(id.Value, db);
            debtVwViewModel.Instance = DebtVwServices.GetChildren(id.Value, db);
            if (debtVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.WarrantVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Warrant", "ModuleNamePlural");
            // debtVwViewModel.WarrantVwViewModel.List = WarrantVwServices.GetByDebtId(id.Value, db);
            debtVwViewModel.WarrantVwViewModel.List = debtVwViewModel.Instance.WarrantVwList;
            
            
            return View(debtVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.IssuerList = new SelectList(IssuerServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
			return View();
        }

        // POST: debtVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, Amount, Issuer, ReferenceNumber, Date, PeriodInMonths, ExceptionalPayment, IsActive, Notes, IssueDescription, Installment")] Debt debt)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                DebtServices.Insert(CurrentUser.Id, debt, db);
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

            ViewBag.IssuerList = new SelectList(IssuerServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            return View(debt);
        }

        // GET: Debt/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Debt debt = DebtServices.Get(id.Value, db);
            if (debt == null)
            {
                return HttpNotFound();
            }

            ViewBag.IssuerList = new SelectList(IssuerServices.List(db), "Id", "Name", debt.Issuer);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", debt.Employee);
            return View(debt);
        }

        // POST: Debt/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, Amount, Issuer, ReferenceNumber, Date, PeriodInMonths, ExceptionalPayment, IsActive, Notes, IssueDescription, Installment")] Debt debt)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                DebtServices.Update(CurrentUser.Id, debt, db);
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

            ViewBag.IssuerList = new SelectList(IssuerServices.List(db), "Id", "Name", debt.Issuer);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", debt.Employee);
            return View(debt);
        }
        // GET: Debt/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Debt debt = DebtServices.Get(id.Value, db);
            if (debt == null)
            {
                return HttpNotFound();
            }
            return View(debt);
        }

        // POST: Debt/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            DebtServices.Delete(CurrentUser.Id, id, db);
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
            // return View(debt);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

