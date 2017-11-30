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
    public partial class GrantDecisionController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantDecision", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantDecision", "ModuleNamePlural");
		
	    public GrantDecisionController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of GrantDecisionVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GrantDecisionVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.GrantTypeGroup = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
                Model.List = GrantDecisionVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<GrantDecisionVw>();
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
            GrantDecisionVwViewModel grantDecisionVwViewModel = new GrantDecisionVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// grantDecisionVwViewModel.Instance = GrantDecisionVwServices.Get(id.Value, db);
            grantDecisionVwViewModel.Instance = GrantDecisionVwServices.GetChildren(id.Value, db);
            if (grantDecisionVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.GrantVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Grant", "ModuleNamePlural");
            // grantDecisionVwViewModel.GrantVwViewModel.List = GrantVwServices.GetByGrantDecisionId(id.Value, db);
            grantDecisionVwViewModel.GrantVwViewModel.List = grantDecisionVwViewModel.Instance.GrantVwList;
            
            
            return View(grantDecisionVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name");
			return View();
        }

        // POST: grantDecisionVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Number, Year, GrantTypeGroup, Date, CersNumber, CersDate, PaymentNumber, PaymentDate, Notes, TableNumber, TableDate, BaseNumber, BaseDate, AdditionalClause, AdditionalIntroduction")] GrantDecision grantDecision)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantDecisionServices.Insert(CurrentUser.Id, grantDecision, db);
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

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name");
            return View(grantDecision);
        }

        // GET: GrantDecision/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantDecision grantDecision = GrantDecisionServices.Get(id.Value, db);
            if (grantDecision == null)
            {
                return HttpNotFound();
            }

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name", grantDecision.GrantTypeGroup);
            return View(grantDecision);
        }

        // POST: GrantDecision/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Number, Year, GrantTypeGroup, Date, CersNumber, CersDate, PaymentNumber, PaymentDate, Notes, TableNumber, TableDate, BaseNumber, BaseDate, AdditionalClause, AdditionalIntroduction")] GrantDecision grantDecision)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantDecisionServices.Update(CurrentUser.Id, grantDecision, db);
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

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name", grantDecision.GrantTypeGroup);
            return View(grantDecision);
        }
        // GET: GrantDecision/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            GrantDecision grantDecision = GrantDecisionServices.Get(id.Value, db);
            if (grantDecision == null)
            {
                return HttpNotFound();
            }
            return View(grantDecision);
        }

        // POST: GrantDecision/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GrantDecisionServices.Delete(CurrentUser.Id, id, db);
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
            // return View(grantDecision);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

