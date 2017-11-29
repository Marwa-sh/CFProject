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
    public partial class GrantDeductionController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantDeduction", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantDeduction", "ModuleNamePlural");
		
	    public GrantDeductionController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of GrantDeductionVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GrantDeductionVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = GrantDeductionVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  grant)
        {
            if (grant == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantDeductionVwViewModel grantDeductionVwViewModel = new GrantDeductionVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// grantDeductionVwViewModel.Instance = GrantDeductionVwServices.Get(grant.Value, db);
            grantDeductionVwViewModel.Instance = GrantDeductionVwServices.GetChildren(grant.Value, db);
            if (grantDeductionVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(grantDeductionVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name");
			return View();
        }

        // POST: grantDeductionVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Grant, Amount, Description")] GrantDeduction grantDeduction)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantDeductionServices.Insert(CurrentUser.Id, grantDeduction, db);
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

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name");
            return View(grantDeduction);
        }

        // GET: GrantDeduction/Edit/5
        public ActionResult Edit(Nullable<int>  grant)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (grant == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantDeduction grantDeduction = GrantDeductionServices.Get(grant.Value, db);
            if (grantDeduction == null)
            {
                return HttpNotFound();
            }

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name", grantDeduction.Grant);
            return View(grantDeduction);
        }

        // POST: GrantDeduction/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Grant, Amount, Description")] GrantDeduction grantDeduction)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantDeductionServices.Update(CurrentUser.Id, grantDeduction, db);
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

            ViewBag.GrantList = new SelectList(GrantServices.List(db), "Product", "Name", grantDeduction.Grant);
            return View(grantDeduction);
        }
        // GET: GrantDeduction/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            GrantDeduction grantDeduction = GrantDeductionServices.Get(id.Value, db);
            if (grantDeduction == null)
            {
                return HttpNotFound();
            }
            return View(grantDeduction);
        }

        // POST: GrantDeduction/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  grant)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GrantDeductionServices.Delete(CurrentUser.Id, grant, db);
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
            // return View(grantDeduction);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

