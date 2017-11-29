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
    public partial class ExceptionalAmountController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");
		
	    public ExceptionalAmountController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ExceptionalAmountVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ExceptionalAmountVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = ExceptionalAmountVwServices.List(db);
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
            ExceptionalAmountVwViewModel exceptionalAmountVwViewModel = new ExceptionalAmountVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// exceptionalAmountVwViewModel.Instance = ExceptionalAmountVwServices.Get(id.Value, db);
            exceptionalAmountVwViewModel.Instance = ExceptionalAmountVwServices.GetChildren(id.Value, db);
            if (exceptionalAmountVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(exceptionalAmountVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name");
            ViewBag.LoanRequestList = new SelectList(LoanRequestServices.List(db), "Request", "Name");
			return View();
        }

        // POST: exceptionalAmountVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, LoanRequest, SubNumber, Amount, Notes, ExceptionalAmountType")] ExceptionalAmount exceptionalAmount)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ExceptionalAmountServices.Insert(CurrentUser.Id, exceptionalAmount, db);
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

            ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name");
            ViewBag.LoanRequestList = new SelectList(LoanRequestServices.List(db), "Request", "Name");
            return View(exceptionalAmount);
        }

        // GET: ExceptionalAmount/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExceptionalAmount exceptionalAmount = ExceptionalAmountServices.Get(id.Value, db);
            if (exceptionalAmount == null)
            {
                return HttpNotFound();
            }

            ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name", exceptionalAmount.ExceptionalAmountType);
            ViewBag.LoanRequestList = new SelectList(LoanRequestServices.List(db), "Request", "Name", exceptionalAmount.LoanRequest);
            return View(exceptionalAmount);
        }

        // POST: ExceptionalAmount/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, LoanRequest, SubNumber, Amount, Notes, ExceptionalAmountType")] ExceptionalAmount exceptionalAmount)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ExceptionalAmountServices.Update(CurrentUser.Id, exceptionalAmount, db);
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

            ViewBag.ExceptionalAmountTypeList = new SelectList(ExceptionalAmountTypeServices.List(db), "Id", "Name", exceptionalAmount.ExceptionalAmountType);
            ViewBag.LoanRequestList = new SelectList(LoanRequestServices.List(db), "Request", "Name", exceptionalAmount.LoanRequest);
            return View(exceptionalAmount);
        }
        // GET: ExceptionalAmount/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ExceptionalAmount exceptionalAmount = ExceptionalAmountServices.Get(id.Value, db);
            if (exceptionalAmount == null)
            {
                return HttpNotFound();
            }
            return View(exceptionalAmount);
        }

        // POST: ExceptionalAmount/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ExceptionalAmountServices.Delete(CurrentUser.Id, id, db);
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
            // return View(exceptionalAmount);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

