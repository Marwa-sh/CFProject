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
    public partial class PayOrderController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "PayOrder", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "PayOrder", "ModuleNamePlural");
		
	    public PayOrderController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of PayOrderVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(PayOrderVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
                Model.List = PayOrderVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<PayOrderVw>();
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
            PayOrderVwViewModel payOrderVwViewModel = new PayOrderVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// payOrderVwViewModel.Instance = PayOrderVwServices.Get(id.Value, db);
            payOrderVwViewModel.Instance = PayOrderVwServices.GetChildren(id.Value, db);
            if (payOrderVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(payOrderVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
			return View();
        }

        // POST: payOrderVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, Number, Date, VoucherNumber, VoucherDate, PaymentNumber, PaymentDate, AccountingDocumentNumber, AccountingDocumentDate, PaymentGroup, PaidAmount, IsProfit, IsFixed, Notes")] PayOrder payOrder)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                PayOrderServices.Insert(CurrentUser.Id, payOrder, db);
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

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            return View(payOrder);
        }

        // GET: PayOrder/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PayOrder payOrder = PayOrderServices.Get(id.Value, db);
            if (payOrder == null)
            {
                return HttpNotFound();
            }

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", payOrder.PaymentGroup);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", payOrder.Employee);
            return View(payOrder);
        }

        // POST: PayOrder/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, Number, Date, VoucherNumber, VoucherDate, PaymentNumber, PaymentDate, AccountingDocumentNumber, AccountingDocumentDate, PaymentGroup, PaidAmount, IsProfit, IsFixed, Notes")] PayOrder payOrder)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                PayOrderServices.Update(CurrentUser.Id, payOrder, db);
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

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", payOrder.PaymentGroup);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", payOrder.Employee);
            return View(payOrder);
        }
        // GET: PayOrder/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            PayOrder payOrder = PayOrderServices.Get(id.Value, db);
            if (payOrder == null)
            {
                return HttpNotFound();
            }
            return View(payOrder);
        }

        // POST: PayOrder/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            PayOrderServices.Delete(CurrentUser.Id, id, db);
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
            // return View(payOrder);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

