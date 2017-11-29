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
    public partial class LoanGenerationStatusController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanGenerationStatus", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanGenerationStatus", "ModuleNamePlural");
		
	    public LoanGenerationStatusController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of LoanGenerationStatusVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanGenerationStatusVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = LoanGenerationStatusVwServices.List(db);
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
            LoanGenerationStatusVwViewModel loanGenerationStatusVwViewModel = new LoanGenerationStatusVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// loanGenerationStatusVwViewModel.Instance = LoanGenerationStatusVwServices.Get(id.Value, db);
            loanGenerationStatusVwViewModel.Instance = LoanGenerationStatusVwServices.GetChildren(id.Value, db);
            if (loanGenerationStatusVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(loanGenerationStatusVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: loanGenerationStatusVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] LoanGenerationStatus loanGenerationStatus)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanGenerationStatusServices.Insert(CurrentUser.Id, loanGenerationStatus, db);
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

            return View(loanGenerationStatus);
        }

        // GET: LoanGenerationStatus/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanGenerationStatus loanGenerationStatus = LoanGenerationStatusServices.Get(id.Value, db);
            if (loanGenerationStatus == null)
            {
                return HttpNotFound();
            }

            return View(loanGenerationStatus);
        }

        // POST: LoanGenerationStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] LoanGenerationStatus loanGenerationStatus)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanGenerationStatusServices.Update(CurrentUser.Id, loanGenerationStatus, db);
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

            return View(loanGenerationStatus);
        }
        // GET: LoanGenerationStatus/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            LoanGenerationStatus loanGenerationStatus = LoanGenerationStatusServices.Get(id.Value, db);
            if (loanGenerationStatus == null)
            {
                return HttpNotFound();
            }
            return View(loanGenerationStatus);
        }

        // POST: LoanGenerationStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            LoanGenerationStatusServices.Delete(CurrentUser.Id, id, db);
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
            // return View(loanGenerationStatus);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

