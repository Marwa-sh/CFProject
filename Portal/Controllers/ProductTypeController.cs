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
    public class ProductTypeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductType", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductType", "ModuleNamePlural");
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
		
	    public ProductTypeController()
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
        /// Returns a list of ProductTypeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ProductTypeVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = ProductTypeVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<short>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTypeVwViewModel productTypeVwViewModel = new ProductTypeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// productTypeVwViewModel.Instance = ProductTypeVwServices.Get(id.Value, db);
            productTypeVwViewModel.Instance = ProductTypeVwServices.GetChildren(id.Value, db);
            if (productTypeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.LoanTypeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanType", "ModuleName");
            if (productTypeVwViewModel.Instance.LoanTypeVw != null)
                productTypeVwViewModel.LoanTypeVwViewModel.List.Add(productTypeVwViewModel.Instance.LoanTypeVw);
                // productTypeVwViewModel.LoanTypeVwViewModel.Instance = productTypeVwViewModel.Instance.LoanTypeVw;

            @ViewBag.ProductTypeAvailabilityVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductTypeAvailability", "ModuleNamePlural");
            // productTypeVwViewModel.ProductTypeAvailabilityVwViewModel.List = ProductTypeAvailabilityVwServices.GetByProductTypeId(id.Value, db);
            productTypeVwViewModel.ProductTypeAvailabilityVwViewModel.List = productTypeVwViewModel.Instance.ProductTypeAvailabilityVwList;
            
            
            return View(productTypeVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            ViewBag.ProfitStrategyList = new SelectList(ProfitStrategyServices.List(db), "Id", "Name");
			return View();
        }

        // POST: productTypeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name, Rate, GuarantorsCount, AccountNumber, PrintLabel, ProfitStrategy, PaymentGroup, IsActive")] ProductType productType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProductTypeServices.Insert(CurrentUser.Id, productType, db);
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

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name");
            ViewBag.ProfitStrategyList = new SelectList(ProfitStrategyServices.List(db), "Id", "Name");
            return View(productType);
        }

        // GET: ProductType/Edit/5
        public ActionResult Edit(Nullable<short>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductType productType = ProductTypeServices.Get(id.Value, db);
            if (productType == null)
            {
                return HttpNotFound();
            }

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", productType.PaymentGroup);
            ViewBag.ProfitStrategyList = new SelectList(ProfitStrategyServices.List(db), "Id", "Name", productType.ProfitStrategy);
            return View(productType);
        }

        // POST: ProductType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, Rate, GuarantorsCount, AccountNumber, PrintLabel, ProfitStrategy, PaymentGroup, IsActive")] ProductType productType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProductTypeServices.Update(CurrentUser.Id, productType, db);
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

            ViewBag.PaymentGroupList = new SelectList(PaymentGroupServices.List(db), "Id", "Name", productType.PaymentGroup);
            ViewBag.ProfitStrategyList = new SelectList(ProfitStrategyServices.List(db), "Id", "Name", productType.ProfitStrategy);
            return View(productType);
        }
        // GET: ProductType/Delete/5
        public ActionResult Delete(Nullable<short> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ProductType productType = ProductTypeServices.Get(id.Value, db);
            if (productType == null)
            {
                return HttpNotFound();
            }
            return View(productType);
        }

        // POST: ProductType/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(short  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ProductTypeServices.Delete(CurrentUser.Id, id, db);
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
            // return View(productType);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

