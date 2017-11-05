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
    public class LoanController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Loan", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Loan", "ModuleNamePlural");
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
		
	    public LoanController()
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
        /// Returns a list of LoanVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(LoanVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = LoanVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<LoanVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  product)
        {
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoanVwViewModel loanVwViewModel = new LoanVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// loanVwViewModel.Instance = LoanVwServices.Get(product.Value, db);
            loanVwViewModel.Instance = LoanVwServices.GetChildren(product.Value, db);
            if (loanVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.IncomingLoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "IncomingLoan", "ModuleName");
            if (loanVwViewModel.Instance.IncomingLoanVw != null)
                loanVwViewModel.IncomingLoanVwViewModel.List.Add(loanVwViewModel.Instance.IncomingLoanVw);
                // loanVwViewModel.IncomingLoanVwViewModel.Instance = loanVwViewModel.Instance.IncomingLoanVw;

            @ViewBag.LoanChangeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanChange", "ModuleName");
            if (loanVwViewModel.Instance.LoanChangeVw != null)
                loanVwViewModel.LoanChangeVwViewModel.List.Add(loanVwViewModel.Instance.LoanChangeVw);
                // loanVwViewModel.LoanChangeVwViewModel.Instance = loanVwViewModel.Instance.LoanChangeVw;

            @ViewBag.FromLoanChangeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanChange", "ModuleNamePlural");
            // loanVwViewModel.FromLoanChangeVwViewModel.List = LoanChangeVwServices.GetByLoanId(product.Value, db);
            loanVwViewModel.FromLoanChangeVwViewModel.List = loanVwViewModel.Instance.FromLoanChangeVwList;
            

            @ViewBag.OutgoingLoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "OutgoingLoan", "ModuleName");
            if (loanVwViewModel.Instance.OutgoingLoanVw != null)
                loanVwViewModel.OutgoingLoanVwViewModel.List.Add(loanVwViewModel.Instance.OutgoingLoanVw);
                // loanVwViewModel.OutgoingLoanVwViewModel.Instance = loanVwViewModel.Instance.OutgoingLoanVw;
            
            return View(loanVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.LoanGenerationStatusList = new SelectList(LoanGenerationStatusServices.List(db), "Id", "Name");
            ViewBag.LoanStatusList = new SelectList(LoanStatusServices.List(db), "Id", "Name");
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
			return View();
        }

        // POST: loanVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Product, LoanDecision, LoanType, LoanGenerationStatus, LoanStatus")] Loan loan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanServices.Insert(CurrentUser.Id, loan, db);
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

            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.LoanGenerationStatusList = new SelectList(LoanGenerationStatusServices.List(db), "Id", "Name");
            ViewBag.LoanStatusList = new SelectList(LoanStatusServices.List(db), "Id", "Name");
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
            return View(loan);
        }

        // GET: Loan/Edit/5
        public ActionResult Edit(Nullable<int>  product)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Loan loan = LoanServices.Get(product.Value, db);
            if (loan == null)
            {
                return HttpNotFound();
            }

            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber", loan.LoanDecision);
            ViewBag.LoanGenerationStatusList = new SelectList(LoanGenerationStatusServices.List(db), "Id", "Name", loan.LoanGenerationStatus);
            ViewBag.LoanStatusList = new SelectList(LoanStatusServices.List(db), "Id", "Name", loan.LoanStatus);
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name", loan.LoanType);
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", loan.Product);
            return View(loan);
        }

        // POST: Loan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Product, LoanDecision, LoanType, LoanGenerationStatus, LoanStatus")] Loan loan)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                LoanServices.Update(CurrentUser.Id, loan, db);
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

            ViewBag.LoanDecisionList = new SelectList(LoanDecisionServices.List(db), "Id", "CersNumber", loan.LoanDecision);
            ViewBag.LoanGenerationStatusList = new SelectList(LoanGenerationStatusServices.List(db), "Id", "Name", loan.LoanGenerationStatus);
            ViewBag.LoanStatusList = new SelectList(LoanStatusServices.List(db), "Id", "Name", loan.LoanStatus);
            ViewBag.LoanTypeList = new SelectList(LoanTypeServices.List(db), "ProductType", "Name", loan.LoanType);
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", loan.Product);
            return View(loan);
        }
        // GET: Loan/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Loan loan = LoanServices.Get(id.Value, db);
            if (loan == null)
            {
                return HttpNotFound();
            }
            return View(loan);
        }

        // POST: Loan/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  product)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            LoanServices.Delete(CurrentUser.Id, product, db);
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
            // return View(loan);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

