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
    public class PaymentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Payment", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Payment", "ModuleNamePlural");
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
		
	    public PaymentController()
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
        /// Returns a list of PaymentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(PaymentVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = PaymentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<PaymentVw>();
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
            PaymentVwViewModel paymentVwViewModel = new PaymentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// paymentVwViewModel.Instance = PaymentVwServices.Get(id.Value, db);
            paymentVwViewModel.Instance = PaymentVwServices.GetChildren(id.Value, db);
            if (paymentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.CashPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "CashPayment", "ModuleName");
            if (paymentVwViewModel.Instance.CashPaymentVw != null)
                paymentVwViewModel.CashPaymentVwViewModel.List.Add(paymentVwViewModel.Instance.CashPaymentVw);
                // paymentVwViewModel.CashPaymentVwViewModel.Instance = paymentVwViewModel.Instance.CashPaymentVw;

            @ViewBag.DownPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DownPayment", "ModuleName");
            if (paymentVwViewModel.Instance.DownPaymentVw != null)
                paymentVwViewModel.DownPaymentVwViewModel.List.Add(paymentVwViewModel.Instance.DownPaymentVw);
                // paymentVwViewModel.DownPaymentVwViewModel.Instance = paymentVwViewModel.Instance.DownPaymentVw;

            @ViewBag.SalaryPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "SalaryPayment", "ModuleName");
            if (paymentVwViewModel.Instance.SalaryPaymentVw != null)
                paymentVwViewModel.SalaryPaymentVwViewModel.List.Add(paymentVwViewModel.Instance.SalaryPaymentVw);
                // paymentVwViewModel.SalaryPaymentVwViewModel.Instance = paymentVwViewModel.Instance.SalaryPaymentVw;

            @ViewBag.SettlementVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Settlement", "ModuleNamePlural");
            // paymentVwViewModel.SettlementVwViewModel.List = SettlementVwServices.GetByPaymentId(id.Value, db);
            paymentVwViewModel.SettlementVwViewModel.List = paymentVwViewModel.Instance.SettlementVwList;
            
            
            return View(paymentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.CollectOrderList = new SelectList(CollectOrderServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            ViewBag.PaymentStatusList = new SelectList(PaymentStatusServices.List(db), "Id", "Name");
			return View();
        }

        // POST: paymentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, Date, PaymentGroup, Amount, Notes, PaymentStatus, CollectOrder")] Payment payment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                PaymentServices.Insert(CurrentUser.Id, payment, db);
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

            ViewBag.CollectOrderList = new SelectList(CollectOrderServices.List(db), "Id", "Name");
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            ViewBag.PaymentStatusList = new SelectList(PaymentStatusServices.List(db), "Id", "Name");
            return View(payment);
        }

        // GET: Payment/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Payment payment = PaymentServices.Get(id.Value, db);
            if (payment == null)
            {
                return HttpNotFound();
            }

            ViewBag.CollectOrderList = new SelectList(CollectOrderServices.List(db), "Id", "Name", payment.CollectOrder);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", payment.Employee);
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", payment.PaymentGroup);
            ViewBag.PaymentStatusList = new SelectList(PaymentStatusServices.List(db), "Id", "Name", payment.PaymentStatus);
            return View(payment);
        }

        // POST: Payment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, Date, PaymentGroup, Amount, Notes, PaymentStatus, CollectOrder")] Payment payment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                PaymentServices.Update(CurrentUser.Id, payment, db);
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

            ViewBag.CollectOrderList = new SelectList(CollectOrderServices.List(db), "Id", "Name", payment.CollectOrder);
            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", payment.Employee);
            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", payment.PaymentGroup);
            ViewBag.PaymentStatusList = new SelectList(PaymentStatusServices.List(db), "Id", "Name", payment.PaymentStatus);
            return View(payment);
        }
        // GET: Payment/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Payment payment = PaymentServices.Get(id.Value, db);
            if (payment == null)
            {
                return HttpNotFound();
            }
            return View(payment);
        }

        // POST: Payment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            PaymentServices.Delete(CurrentUser.Id, id, db);
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
            // return View(payment);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

