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
    public partial class MonthlyBalanceController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "MonthlyBalance", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "MonthlyBalance", "ModuleNamePlural");
		
	    public MonthlyBalanceController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of MonthlyBalanceVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(MonthlyBalanceVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
                Model.List = MonthlyBalanceVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<MonthlyBalanceVw>();
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
            MonthlyBalanceVwViewModel monthlyBalanceVwViewModel = new MonthlyBalanceVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// monthlyBalanceVwViewModel.Instance = MonthlyBalanceVwServices.Get(id.Value, db);
            monthlyBalanceVwViewModel.Instance = MonthlyBalanceVwServices.GetChildren(id.Value, db);
            if (monthlyBalanceVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(monthlyBalanceVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
			return View();
        }

        // POST: monthlyBalanceVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, PaymentGroup, Month, Opening, NormalLoans, IncomingLoans, Restitution, OutgoingLoans, SalaryPayment, CashPayment")] MonthlyBalance monthlyBalance)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                MonthlyBalanceServices.Insert(CurrentUser.Id, monthlyBalance, db);
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
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            return View(monthlyBalance);
        }

        // GET: MonthlyBalance/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MonthlyBalance monthlyBalance = MonthlyBalanceServices.Get(id.Value, db);
            if (monthlyBalance == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", monthlyBalance.Employee);
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", monthlyBalance.PaymentGroup);
            return View(monthlyBalance);
        }

        // POST: MonthlyBalance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, PaymentGroup, Month, Opening, NormalLoans, IncomingLoans, Restitution, OutgoingLoans, SalaryPayment, CashPayment")] MonthlyBalance monthlyBalance)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                MonthlyBalanceServices.Update(CurrentUser.Id, monthlyBalance, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", monthlyBalance.Employee);
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", monthlyBalance.PaymentGroup);
            return View(monthlyBalance);
        }
        // GET: MonthlyBalance/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            MonthlyBalance monthlyBalance = MonthlyBalanceServices.Get(id.Value, db);
            if (monthlyBalance == null)
            {
                return HttpNotFound();
            }
            return View(monthlyBalance);
        }

        // POST: MonthlyBalance/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            MonthlyBalanceServices.Delete(CurrentUser.Id, id, db);
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
            // return View(monthlyBalance);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

