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
    public partial class GuarantorController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
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
		
	    public GuarantorController()
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
        /// Returns a list of GuarantorVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GuarantorVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = GuarantorVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<GuarantorVw>();
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
            GuarantorVwViewModel guarantorVwViewModel = new GuarantorVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// guarantorVwViewModel.Instance = GuarantorVwServices.Get(id.Value, db);
            guarantorVwViewModel.Instance = GuarantorVwServices.GetChildren(id.Value, db);
            if (guarantorVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.GuarantorStatementVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GuarantorStatement", "ModuleName");
            if (guarantorVwViewModel.Instance.GuarantorStatementVw != null)
                guarantorVwViewModel.GuarantorStatementVwViewModel.List.Add(guarantorVwViewModel.Instance.GuarantorStatementVw);
                // guarantorVwViewModel.GuarantorStatementVwViewModel.Instance = guarantorVwViewModel.Instance.GuarantorStatementVw;
            
            return View(guarantorVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.GuarantorStatusList = new SelectList(GuarantorStatusServices.List(db), "Id", "Name");
            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name");
			return View();
        }

        // POST: guarantorVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, RefundableProduct, SubNumber, Employee, GuarantorStatus, Notes")] Guarantor guarantor)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GuarantorServices.Insert(CurrentUser.Id, guarantor, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.GuarantorStatusList = new SelectList(GuarantorStatusServices.List(db), "Id", "Name");
            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name");
            return View(guarantor);
        }

        // GET: Guarantor/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Guarantor guarantor = GuarantorServices.Get(id.Value, db);
            if (guarantor == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", guarantor.Employee);
            ViewBag.GuarantorStatusList = new SelectList(GuarantorStatusServices.List(db), "Id", "Name", guarantor.GuarantorStatus);
            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name", guarantor.RefundableProduct);
            return View(guarantor);
        }

        // POST: Guarantor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, RefundableProduct, SubNumber, Employee, GuarantorStatus, Notes")] Guarantor guarantor)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GuarantorServices.Update(CurrentUser.Id, guarantor, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", guarantor.Employee);
            ViewBag.GuarantorStatusList = new SelectList(GuarantorStatusServices.List(db), "Id", "Name", guarantor.GuarantorStatus);
            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name", guarantor.RefundableProduct);
            return View(guarantor);
        }
        // GET: Guarantor/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Guarantor guarantor = GuarantorServices.Get(id.Value, db);
            if (guarantor == null)
            {
                return HttpNotFound();
            }
            return View(guarantor);
        }

        // POST: Guarantor/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GuarantorServices.Delete(CurrentUser.Id, id, db);
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
            // return View(guarantor);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

