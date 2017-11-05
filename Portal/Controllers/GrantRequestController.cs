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
    public class GrantRequestController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantRequest", "ModuleNamePlural");
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
		
	    public GrantRequestController()
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
        /// Returns a list of GrantRequestVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GrantRequestVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = GrantRequestVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<GrantRequestVw>();
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
            GrantRequestVwViewModel grantRequestVwViewModel = new GrantRequestVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// grantRequestVwViewModel.Instance = GrantRequestVwServices.Get(request.Value, db);
            grantRequestVwViewModel.Instance = GrantRequestVwServices.GetChildren(request.Value, db);
            if (grantRequestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.ServiceEndGrantRequestVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ServiceEndGrantRequest", "ModuleName");
            if (grantRequestVwViewModel.Instance.ServiceEndGrantRequestVw != null)
                grantRequestVwViewModel.ServiceEndGrantRequestVwViewModel.List.Add(grantRequestVwViewModel.Instance.ServiceEndGrantRequestVw);
                // grantRequestVwViewModel.ServiceEndGrantRequestVwViewModel.Instance = grantRequestVwViewModel.Instance.ServiceEndGrantRequestVw;
            
            return View(grantRequestVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name");
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
			return View();
        }

        // POST: grantRequestVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Request, GrantType, Description, Amount, Notes, EventDate, IsFromOtherBranch")] GrantRequest grantRequest)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantRequestServices.Insert(CurrentUser.Id, grantRequest, db);
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

            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name");
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment");
            return View(grantRequest);
        }

        // GET: GrantRequest/Edit/5
        public ActionResult Edit(Nullable<int>  request)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (request == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantRequest grantRequest = GrantRequestServices.Get(request.Value, db);
            if (grantRequest == null)
            {
                return HttpNotFound();
            }

            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name", grantRequest.GrantType);
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment", grantRequest.Request);
            return View(grantRequest);
        }

        // POST: GrantRequest/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Request, GrantType, Description, Amount, Notes, EventDate, IsFromOtherBranch")] GrantRequest grantRequest)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantRequestServices.Update(CurrentUser.Id, grantRequest, db);
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

            ViewBag.GrantTypeList = new SelectList(GrantTypeServices.List(db), "Id", "Name", grantRequest.GrantType);
            ViewBag.RequestList = new SelectList(RequestServices.List(db), "Product", "Attachment", grantRequest.Request);
            return View(grantRequest);
        }
        // GET: GrantRequest/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            GrantRequest grantRequest = GrantRequestServices.Get(id.Value, db);
            if (grantRequest == null)
            {
                return HttpNotFound();
            }
            return View(grantRequest);
        }

        // POST: GrantRequest/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  request)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GrantRequestServices.Delete(CurrentUser.Id, request, db);
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
            // return View(grantRequest);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

