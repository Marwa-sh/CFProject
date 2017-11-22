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
    public partial class GuarantorStatementController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GuarantorStatement", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GuarantorStatement", "ModuleNamePlural");
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
		
	    public GuarantorStatementController()
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
        /// Returns a list of GuarantorStatementVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GuarantorStatementVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = GuarantorStatementVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  guarantor)
        {
            if (guarantor == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuarantorStatementVwViewModel guarantorStatementVwViewModel = new GuarantorStatementVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// guarantorStatementVwViewModel.Instance = GuarantorStatementVwServices.Get(guarantor.Value, db);
            guarantorStatementVwViewModel.Instance = GuarantorStatementVwServices.GetChildren(guarantor.Value, db);
            if (guarantorStatementVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(guarantorStatementVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GuarantorList = new SelectList(GuarantorServices.List(db), "Id", "Notes");
			return View();
        }

        // POST: guarantorStatementVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Guarantor, GrossSalary, DeductionsAmount, NetSalary, ExceptionalIncome")] GuarantorStatement guarantorStatement)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GuarantorStatementServices.Insert(CurrentUser.Id, guarantorStatement, db);
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

            ViewBag.GuarantorList = new SelectList(GuarantorServices.List(db), "Id", "Notes");
            return View(guarantorStatement);
        }

        // GET: GuarantorStatement/Edit/5
        public ActionResult Edit(Nullable<int>  guarantor)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (guarantor == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuarantorStatement guarantorStatement = GuarantorStatementServices.Get(guarantor.Value, db);
            if (guarantorStatement == null)
            {
                return HttpNotFound();
            }

            ViewBag.GuarantorList = new SelectList(GuarantorServices.List(db), "Id", "Notes", guarantorStatement.Guarantor);
            return View(guarantorStatement);
        }

        // POST: GuarantorStatement/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Guarantor, GrossSalary, DeductionsAmount, NetSalary, ExceptionalIncome")] GuarantorStatement guarantorStatement)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GuarantorStatementServices.Update(CurrentUser.Id, guarantorStatement, db);
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

            ViewBag.GuarantorList = new SelectList(GuarantorServices.List(db), "Id", "Notes", guarantorStatement.Guarantor);
            return View(guarantorStatement);
        }
        // GET: GuarantorStatement/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            GuarantorStatement guarantorStatement = GuarantorStatementServices.Get(id.Value, db);
            if (guarantorStatement == null)
            {
                return HttpNotFound();
            }
            return View(guarantorStatement);
        }

        // POST: GuarantorStatement/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  guarantor)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GuarantorStatementServices.Delete(CurrentUser.Id, guarantor, db);
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
            // return View(guarantorStatement);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

