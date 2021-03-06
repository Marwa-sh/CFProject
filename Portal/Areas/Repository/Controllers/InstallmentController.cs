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
    public partial class InstallmentController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Installment", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Installment", "ModuleNamePlural");
		
	    public InstallmentController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of InstallmentVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(InstallmentVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            if (Model.Filter.HasCriteria)
	        {
                Model.List = InstallmentVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<InstallmentVw>();
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
            InstallmentVwViewModel installmentVwViewModel = new InstallmentVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// installmentVwViewModel.Instance = InstallmentVwServices.Get(id.Value, db);
            installmentVwViewModel.Instance = InstallmentVwServices.GetChildren(id.Value, db);
            if (installmentVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.SettlementVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Settlement", "ModuleNamePlural");
            // installmentVwViewModel.SettlementVwViewModel.List = SettlementVwServices.GetByInstallmentId(id.Value, db);
            installmentVwViewModel.SettlementVwViewModel.List = installmentVwViewModel.Instance.SettlementVwList;
            
            
            return View(installmentVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name");
			return View();
        }

        // POST: installmentVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, RefundableProduct, SubNumber, DueDate, DueCapital, DueProfit, Notes")] Installment installment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InstallmentServices.Insert(CurrentUser.Id, installment, db);
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

            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name");
            return View(installment);
        }

        // GET: Installment/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Installment installment = InstallmentServices.Get(id.Value, db);
            if (installment == null)
            {
                return HttpNotFound();
            }

            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name", installment.RefundableProduct);
            return View(installment);
        }

        // POST: Installment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, RefundableProduct, SubNumber, DueDate, DueCapital, DueProfit, Notes")] Installment installment)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InstallmentServices.Update(CurrentUser.Id, installment, db);
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

            ViewBag.RefundableProductList = new SelectList(RefundableProductServices.List(db), "Product", "Name", installment.RefundableProduct);
            return View(installment);
        }
        // GET: Installment/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Installment installment = InstallmentServices.Get(id.Value, db);
            if (installment == null)
            {
                return HttpNotFound();
            }
            return View(installment);
        }

        // POST: Installment/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            InstallmentServices.Delete(CurrentUser.Id, id, db);
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
            // return View(installment);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

