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
    public class LoanRequestController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleNamePlural");
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
        /// Returns a list of LoanRequestVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanRequestVwViewModel Model)
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
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
			ViewBag.Insert = insert;
			ViewBag.Delete = delete;
            
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

        public ActionResult Create(int ? id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;

            ViewBag.RequestId = id;
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
            ViewBag.RequestId = loanRequest.Request;
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            //ViewBag.ProductId = 
            return View(loanRequest);
        }

        // GET: LoanRequest/Edit/5
        public ActionResult Edit(Nullable<int>  request)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
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
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = update;
            ViewBag.Update = update;
            ViewBag.Save = save;
            ViewBag.Back = back;
            return View(loanRequest);
        }
        // GET: LoanRequest/Delete/5
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

