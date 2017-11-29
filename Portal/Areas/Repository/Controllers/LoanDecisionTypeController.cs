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
    public partial class LoanDecisionTypeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecisionType", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecisionType", "ModuleNamePlural");
		
	    public LoanDecisionTypeController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of LoanDecisionTypeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanDecisionTypeVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = LoanDecisionTypeVwServices.List(db);
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
            LoanDecisionTypeVwViewModel loanDecisionTypeVwViewModel = new LoanDecisionTypeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// loanDecisionTypeVwViewModel.Instance = LoanDecisionTypeVwServices.Get(id.Value, db);
            loanDecisionTypeVwViewModel.Instance = LoanDecisionTypeVwServices.GetChildren(id.Value, db);
            if (loanDecisionTypeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(loanDecisionTypeVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: loanDecisionTypeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] LoanDecisionType loanDecisionType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanDecisionTypeServices.Insert(CurrentUser.Id, loanDecisionType, db);
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

            return View(loanDecisionType);
        }

        // GET: LoanDecisionType/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanDecisionType loanDecisionType = LoanDecisionTypeServices.Get(id.Value, db);
            if (loanDecisionType == null)
            {
                return HttpNotFound();
            }

            return View(loanDecisionType);
        }

        // POST: LoanDecisionType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] LoanDecisionType loanDecisionType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanDecisionTypeServices.Update(CurrentUser.Id, loanDecisionType, db);
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

            return View(loanDecisionType);
        }
        // GET: LoanDecisionType/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            LoanDecisionType loanDecisionType = LoanDecisionTypeServices.Get(id.Value, db);
            if (loanDecisionType == null)
            {
                return HttpNotFound();
            }
            return View(loanDecisionType);
        }

        // POST: LoanDecisionType/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            LoanDecisionTypeServices.Delete(CurrentUser.Id, id, db);
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
            // return View(loanDecisionType);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

