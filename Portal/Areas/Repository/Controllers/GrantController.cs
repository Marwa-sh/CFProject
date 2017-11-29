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
    public partial class GrantController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Grant", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Grant", "ModuleNamePlural");
		
	    public GrantController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of GrantVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GrantVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = GrantVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<GrantVw>();
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
            GrantVwViewModel grantVwViewModel = new GrantVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// grantVwViewModel.Instance = GrantVwServices.Get(product.Value, db);
            grantVwViewModel.Instance = GrantVwServices.GetChildren(product.Value, db);
            if (grantVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.GrantDeductionVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantDeduction", "ModuleName");
            if (grantVwViewModel.Instance.GrantDeductionVw != null)
                grantVwViewModel.GrantDeductionVwViewModel.List.Add(grantVwViewModel.Instance.GrantDeductionVw);
                // grantVwViewModel.GrantDeductionVwViewModel.Instance = grantVwViewModel.Instance.GrantDeductionVw;

            @ViewBag.GrantPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantPayment", "ModuleNamePlural");
            // grantVwViewModel.GrantPaymentVwViewModel.List = GrantPaymentVwServices.GetByGrantId(product.Value, db);
            grantVwViewModel.GrantPaymentVwViewModel.List = grantVwViewModel.Instance.GrantPaymentVwList;
            
            
            return View(grantVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GrantDecisionList = new SelectList(GrantDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
			return View();
        }

        // POST: grantVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Product, GrantDecision, Amount")] Grant grant)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantServices.Insert(CurrentUser.Id, grant, db);
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

            ViewBag.GrantDecisionList = new SelectList(GrantDecisionServices.List(db), "Id", "CersNumber");
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
            return View(grant);
        }

        // GET: Grant/Edit/5
        public ActionResult Edit(Nullable<int>  product)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grant grant = GrantServices.Get(product.Value, db);
            if (grant == null)
            {
                return HttpNotFound();
            }

            ViewBag.GrantDecisionList = new SelectList(GrantDecisionServices.List(db), "Id", "CersNumber", grant.GrantDecision);
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", grant.Product);
            return View(grant);
        }

        // POST: Grant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Product, GrantDecision, Amount")] Grant grant)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantServices.Update(CurrentUser.Id, grant, db);
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

            ViewBag.GrantDecisionList = new SelectList(GrantDecisionServices.List(db), "Id", "CersNumber", grant.GrantDecision);
            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", grant.Product);
            return View(grant);
        }
        // GET: Grant/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Grant grant = GrantServices.Get(id.Value, db);
            if (grant == null)
            {
                return HttpNotFound();
            }
            return View(grant);
        }

        // POST: Grant/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  product)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GrantServices.Delete(CurrentUser.Id, product, db);
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
            // return View(grant);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

