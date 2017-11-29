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
    public partial class SettlementController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Settlement", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Settlement", "ModuleNamePlural");
		
	    public SettlementController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of SettlementVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(SettlementVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = SettlementVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<SettlementVw>();
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
            SettlementVwViewModel settlementVwViewModel = new SettlementVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// settlementVwViewModel.Instance = SettlementVwServices.Get(id.Value, db);
            settlementVwViewModel.Instance = SettlementVwServices.GetChildren(id.Value, db);
            if (settlementVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(settlementVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.InstallmentList = new SelectList(InstallmentServices.List(db), "Id", "Notes");
            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes");
			return View();
        }

        // POST: settlementVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Installment, Payment, Amount")] Settlement settlement)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SettlementServices.Insert(CurrentUser.Id, settlement, db);
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

            ViewBag.InstallmentList = new SelectList(InstallmentServices.List(db), "Id", "Notes");
            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes");
            return View(settlement);
        }

        // GET: Settlement/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Settlement settlement = SettlementServices.Get(id.Value, db);
            if (settlement == null)
            {
                return HttpNotFound();
            }

            ViewBag.InstallmentList = new SelectList(InstallmentServices.List(db), "Id", "Notes", settlement.Installment);
            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", settlement.Payment);
            return View(settlement);
        }

        // POST: Settlement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Installment, Payment, Amount")] Settlement settlement)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                SettlementServices.Update(CurrentUser.Id, settlement, db);
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

            ViewBag.InstallmentList = new SelectList(InstallmentServices.List(db), "Id", "Notes", settlement.Installment);
            ViewBag.PaymentList = new SelectList(PaymentServices.List(db), "Id", "Notes", settlement.Payment);
            return View(settlement);
        }
        // GET: Settlement/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Settlement settlement = SettlementServices.Get(id.Value, db);
            if (settlement == null)
            {
                return HttpNotFound();
            }
            return View(settlement);
        }

        // POST: Settlement/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            SettlementServices.Delete(CurrentUser.Id, id, db);
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
            // return View(settlement);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

