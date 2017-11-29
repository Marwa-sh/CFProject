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
    public partial class IssuerController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Issuer", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Issuer", "ModuleNamePlural");
		
	    public IssuerController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of IssuerVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(IssuerVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = IssuerVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<byte>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IssuerVwViewModel issuerVwViewModel = new IssuerVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// issuerVwViewModel.Instance = IssuerVwServices.Get(id.Value, db);
            issuerVwViewModel.Instance = IssuerVwServices.GetChildren(id.Value, db);
            if (issuerVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(issuerVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: issuerVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] Issuer issuer)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                IssuerServices.Insert(CurrentUser.Id, issuer, db);
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

            return View(issuer);
        }

        // GET: Issuer/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Issuer issuer = IssuerServices.Get(id.Value, db);
            if (issuer == null)
            {
                return HttpNotFound();
            }

            return View(issuer);
        }

        // POST: Issuer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] Issuer issuer)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                IssuerServices.Update(CurrentUser.Id, issuer, db);
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

            return View(issuer);
        }
        // GET: Issuer/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Issuer issuer = IssuerServices.Get(id.Value, db);
            if (issuer == null)
            {
                return HttpNotFound();
            }
            return View(issuer);
        }

        // POST: Issuer/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            IssuerServices.Delete(CurrentUser.Id, id, db);
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
            // return View(issuer);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

