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
    public partial class LoanRequestController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleNamePlural");
		
	    public LoanRequestController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of LoanRequestVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanRequestVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name");
            ViewBag.ProductTypeList = new SelectList(LoanTypeVwServices.List(db), "ProductTypeId", "ProductTypeName");

            if (Model.Filter.HasCriteria)
	        {
                Model.List = LoanRequestVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<LoanRequestVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  request)
        {
            if (request == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanRequestVwViewModel loanRequestVwViewModel = new LoanRequestVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// loanRequestVwViewModel.Instance = LoanRequestVwServices.Get(request.Value, db);
            loanRequestVwViewModel.Instance = LoanRequestVwServices.GetChildren(request.Value, db);
            if (loanRequestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.ExceptionalAmountVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");
            // loanRequestVwViewModel.ExceptionalAmountVwViewModel.List = ExceptionalAmountVwServices.GetByLoanRequestId(request.Value, db);
            loanRequestVwViewModel.ExceptionalAmountVwViewModel.List = loanRequestVwViewModel.Instance.ExceptionalAmountVwList;
            
            
            return View(loanRequestVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
			return View();
        }

        // POST: loanRequestVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Request, NetIncome, TotalDeduction")] LoanRequest loanRequest)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanRequestServices.Insert(CurrentUser.Id, loanRequest, db);
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

            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
            return View(loanRequest);
        }

        // GET: LoanRequest/Edit/5
        public ActionResult Edit(Nullable<int>  request)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (request == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanRequest loanRequest = LoanRequestServices.Get(request.Value, db);
            if (loanRequest == null)
            {
                return HttpNotFound();
            }

            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment", loanRequest.Request);
            return View(loanRequest);
        }

        // POST: LoanRequest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Request, NetIncome, TotalDeduction")] LoanRequest loanRequest)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanRequestServices.Update(CurrentUser.Id, loanRequest, db);
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

            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment", loanRequest.Request);
            return View(loanRequest);
        }
        // GET: LoanRequest/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            LoanRequest loanRequest = LoanRequestServices.Get(id.Value, db);
            if (loanRequest == null)
            {
                return HttpNotFound();
            }
            return View(loanRequest);
        }

        // POST: LoanRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  request)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            LoanRequestServices.Delete(CurrentUser.Id, request, db);
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
            // return View(loanRequest);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

