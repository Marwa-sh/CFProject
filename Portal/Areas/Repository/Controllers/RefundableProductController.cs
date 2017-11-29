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
    public partial class RefundableProductController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "RefundableProduct", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "RefundableProduct", "ModuleNamePlural");
		
	    public RefundableProductController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of RefundableProductVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(RefundableProductVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = RefundableProductVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<RefundableProductVw>();
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
            RefundableProductVwViewModel refundableProductVwViewModel = new RefundableProductVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// refundableProductVwViewModel.Instance = RefundableProductVwServices.Get(product.Value, db);
            refundableProductVwViewModel.Instance = RefundableProductVwServices.GetChildren(product.Value, db);
            if (refundableProductVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.GuarantorVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
            // refundableProductVwViewModel.GuarantorVwViewModel.List = GuarantorVwServices.GetByRefundableProductId(product.Value, db);
            refundableProductVwViewModel.GuarantorVwViewModel.List = refundableProductVwViewModel.Instance.GuarantorVwList;
            

            @ViewBag.InstallmentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Installment", "ModuleNamePlural");
            // refundableProductVwViewModel.InstallmentVwViewModel.List = InstallmentVwServices.GetByRefundableProductId(product.Value, db);
            refundableProductVwViewModel.InstallmentVwViewModel.List = refundableProductVwViewModel.Instance.InstallmentVwList;
            
            
            return View(refundableProductVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
			return View();
        }

        // POST: refundableProductVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Product, PaymentPeriod, Installment, NetAmount, ProfitAmount, SyrianPoundRounds")] RefundableProduct refundableProduct)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                RefundableProductServices.Insert(CurrentUser.Id, refundableProduct, db);
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

            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes");
            return View(refundableProduct);
        }

        // GET: RefundableProduct/Edit/5
        public ActionResult Edit(Nullable<int>  product)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RefundableProduct refundableProduct = RefundableProductServices.Get(product.Value, db);
            if (refundableProduct == null)
            {
                return HttpNotFound();
            }

            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", refundableProduct.Product);
            return View(refundableProduct);
        }

        // POST: RefundableProduct/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Product, PaymentPeriod, Installment, NetAmount, ProfitAmount, SyrianPoundRounds")] RefundableProduct refundableProduct)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                RefundableProductServices.Update(CurrentUser.Id, refundableProduct, db);
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

            ViewBag.ProductList = new SelectList(ProductServices.List(db), "Id", "Notes", refundableProduct.Product);
            return View(refundableProduct);
        }
        // GET: RefundableProduct/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            RefundableProduct refundableProduct = RefundableProductServices.Get(id.Value, db);
            if (refundableProduct == null)
            {
                return HttpNotFound();
            }
            return View(refundableProduct);
        }

        // POST: RefundableProduct/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  product)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            RefundableProductServices.Delete(CurrentUser.Id, product, db);
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
            // return View(refundableProduct);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

