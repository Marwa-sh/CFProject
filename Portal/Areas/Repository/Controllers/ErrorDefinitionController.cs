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
    public partial class ErrorDefinitionController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ErrorDefinition", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ErrorDefinition", "ModuleNamePlural");
		
	    public ErrorDefinitionController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ErrorDefinitionVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ErrorDefinitionVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = ErrorDefinitionVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<ErrorDefinitionVw>();
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
            ErrorDefinitionVwViewModel errorDefinitionVwViewModel = new ErrorDefinitionVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// errorDefinitionVwViewModel.Instance = ErrorDefinitionVwServices.Get(id.Value, db);
            errorDefinitionVwViewModel.Instance = ErrorDefinitionVwServices.GetChildren(id.Value, db);
            if (errorDefinitionVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(errorDefinitionVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: errorDefinitionVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Message, LocalizedMessage, LikeExpression")] ErrorDefinition errorDefinition)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ErrorDefinitionServices.Insert(CurrentUser.Id, errorDefinition, db);
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

            return View(errorDefinition);
        }

        // GET: ErrorDefinition/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ErrorDefinition errorDefinition = ErrorDefinitionServices.Get(id.Value, db);
            if (errorDefinition == null)
            {
                return HttpNotFound();
            }

            return View(errorDefinition);
        }

        // POST: ErrorDefinition/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Message, LocalizedMessage, LikeExpression")] ErrorDefinition errorDefinition)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ErrorDefinitionServices.Update(CurrentUser.Id, errorDefinition, db);
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

            return View(errorDefinition);
        }
        // GET: ErrorDefinition/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ErrorDefinition errorDefinition = ErrorDefinitionServices.Get(id.Value, db);
            if (errorDefinition == null)
            {
                return HttpNotFound();
            }
            return View(errorDefinition);
        }

        // POST: ErrorDefinition/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ErrorDefinitionServices.Delete(CurrentUser.Id, id, db);
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
            // return View(errorDefinition);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

