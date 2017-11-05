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
    public class RequestController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Request", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Request", "ModuleNamePlural");
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
		
	    public RequestController()
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
        /// Returns a list of RequestVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(RequestVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = RequestVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<RequestVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  product)
        {
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RequestVwViewModel requestVwViewModel = new RequestVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// requestVwViewModel.Instance = RequestVwServices.Get(product.Value, db);
            requestVwViewModel.Instance = RequestVwServices.GetChildren(product.Value, db);
            if (requestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.DownPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "DownPayment", "ModuleNamePlural");
            // requestVwViewModel.DownPaymentVwViewModel.List = DownPaymentVwServices.GetByRequestId(product.Value, db);
            requestVwViewModel.DownPaymentVwViewModel.List = requestVwViewModel.Instance.DownPaymentVwList;
            

            @ViewBag.GrantRequestVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantRequest", "ModuleName");
            if (requestVwViewModel.Instance.GrantRequestVw != null)
                requestVwViewModel.GrantRequestVwViewModel.List.Add(requestVwViewModel.Instance.GrantRequestVw);
                // requestVwViewModel.GrantRequestVwViewModel.Instance = requestVwViewModel.Instance.GrantRequestVw;

            @ViewBag.LoanRequestVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleName");
            if (requestVwViewModel.Instance.LoanRequestVw != null)
                requestVwViewModel.LoanRequestVwViewModel.List.Add(requestVwViewModel.Instance.LoanRequestVw);
                // requestVwViewModel.LoanRequestVwViewModel.Instance = requestVwViewModel.Instance.LoanRequestVw;
            
            return View(requestVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db), "Id", "Name");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
            ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name");
			return View();
        }

        // POST: requestVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Product, Date, Amount, Attachment, Cost, RequestStatus, BypassStatus, Notes")] Request request)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                RequestServices.Insert(CurrentUser.Id, request, db);
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

            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db), "Id", "Name");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
            ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name");
            return View(request);
        }

        // GET: Request/Edit/5
        public ActionResult Edit(Nullable<int>  product)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = RequestServices.Get(product.Value, db);
            if (request == null)
            {
                return HttpNotFound();
            }

            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db), "Id", "Name", request.BypassStatus);
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", request.Product);
            ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name", request.RequestStatus);
            return View(request);
        }

        // POST: Request/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Product, Date, Amount, Attachment, Cost, RequestStatus, BypassStatus, Notes")] Request request)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                RequestServices.Update(CurrentUser.Id, request, db);
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

            ViewBag.BypassStatusList = new SelectList(BypassStatusServices.List(db), "Id", "Name", request.BypassStatus);
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", request.Product);
            ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name", request.RequestStatus);
            return View(request);
        }
        // GET: Request/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Request request = RequestServices.Get(id.Value, db);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Request/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  product)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            RequestServices.Delete(CurrentUser.Id, product, db);
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
            // return View(request);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

