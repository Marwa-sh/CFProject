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
    public class LoanTypeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanType", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanType", "ModuleNamePlural");
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
		
	    public LoanTypeController()
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
        /// Returns a list of LoanTypeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanTypeVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = LoanTypeVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<LoanTypeVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<short>  productType)
        {
            if (productType == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanTypeVwViewModel loanTypeVwViewModel = new LoanTypeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// loanTypeVwViewModel.Instance = LoanTypeVwServices.Get(productType.Value, db);
            loanTypeVwViewModel.Instance = LoanTypeVwServices.GetChildren(productType.Value, db);
            if (loanTypeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.ClosingLoanTypeClosureVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanTypeClosure", "ModuleNamePlural");
            // loanTypeVwViewModel.ClosingLoanTypeClosureVwViewModel.List = LoanTypeClosureVwServices.GetByLoanTypeId(productType.Value, db);
            loanTypeVwViewModel.ClosingLoanTypeClosureVwViewModel.List = loanTypeVwViewModel.Instance.ClosingLoanTypeClosureVwList;
            

            @ViewBag.LoanTypeClosureVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanTypeClosure", "ModuleNamePlural");
            // loanTypeVwViewModel.LoanTypeClosureVwViewModel.List = LoanTypeClosureVwServices.GetByLoanTypeId(productType.Value, db);
            loanTypeVwViewModel.LoanTypeClosureVwViewModel.List = loanTypeVwViewModel.Instance.LoanTypeClosureVwList;
            
            
            return View(loanTypeVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
			return View();
        }

        // POST: loanTypeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "ProductType")] LoanType loanType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanTypeServices.Insert(CurrentUser.Id, loanType, db);
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

            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            return View(loanType);
        }
        // GET: LoanType/Delete/5
        public ActionResult Delete(Nullable<short> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            LoanType loanType = LoanTypeServices.Get(id.Value, db);
            if (loanType == null)
            {
                return HttpNotFound();
            }
            return View(loanType);
        }

        // POST: LoanType/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(short  productType)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            LoanTypeServices.Delete(CurrentUser.Id, productType, db);
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
            // return View(loanType);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

