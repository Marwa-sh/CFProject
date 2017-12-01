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
    public class ResourceController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Resource", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Resource", "ModuleNamePlural");
		private string reloadResources = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Resource", "ReloadResources");

		public ResourceController()
    	{
			ResourceServices.ReloadResources();
			ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
            ViewBag.ReloadResources = reloadResources;
        }
		
        /// <summary>
        /// Returns a list of ResourceVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ResourceVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = ResourceVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<ResourceVw>();
            return View(Model);
        }

        /// <summary>
        /// Reload Resources
        /// </summary>
        /// <returns></returns>
        public ActionResult ReloadResources(ResourceVwViewModel Model)
        {
            ResourceServices.ReloadResources();
            if (Model.Filter.HasCriteria)
            {
                Db db = new Db(DbServices.ConnectionString);
                Model.List = ResourceVwServices.Get(Model.Filter, db);
            }
            else
                Model.List = new List<ResourceVw>();
            return View("Index", Model);
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
            ResourceVwViewModel resourceVwViewModel = new ResourceVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// resourceVwViewModel.Instance = ResourceVwServices.Get(id.Value, db);
            resourceVwViewModel.Instance = ResourceVwServices.GetChildren(id.Value, db);
            if (resourceVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(resourceVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: resourceVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Language, Module, Key, Value, IsEditable")] Resource resource)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ResourceServices.Insert(CurrentUser.Id, resource, db);
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

            return View(resource);
        }

        // GET: Resource/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Resource resource = ResourceServices.Get(id.Value, db);
            if (resource == null)
            {
                return HttpNotFound();
            }

            return View(resource);
        }

        // POST: Resource/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Language, Module, Key, Value, IsEditable")] Resource resource)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ResourceServices.Update(CurrentUser.Id, resource, db);
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

            return View(resource);
        }
        // GET: Resource/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Resource resource = ResourceServices.Get(id.Value, db);
            if (resource == null)
            {
                return HttpNotFound();
            }
            return View(resource);
        }

        // POST: Resource/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ResourceServices.Delete(CurrentUser.Id, id, db);
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
            // return View(resource);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

