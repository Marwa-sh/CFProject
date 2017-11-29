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
    public partial class ProductTypeAvailabilityController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductTypeAvailability", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductTypeAvailability", "ModuleNamePlural");
		
	    public ProductTypeAvailabilityController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ProductTypeAvailabilityVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ProductTypeAvailabilityVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = ProductTypeAvailabilityVwServices.List(db);
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
            ProductTypeAvailabilityVwViewModel productTypeAvailabilityVwViewModel = new ProductTypeAvailabilityVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// productTypeAvailabilityVwViewModel.Instance = ProductTypeAvailabilityVwServices.Get(id.Value, db);
            productTypeAvailabilityVwViewModel.Instance = ProductTypeAvailabilityVwServices.GetChildren(id.Value, db);
            if (productTypeAvailabilityVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(productTypeAvailabilityVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name");
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
			return View();
        }

        // POST: productTypeAvailabilityVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, ProductType, Availability")] ProductTypeAvailability productTypeAvailability)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProductTypeAvailabilityServices.Insert(CurrentUser.Id, productTypeAvailability, db);
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

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name");
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            return View(productTypeAvailability);
        }

        // GET: ProductTypeAvailability/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductTypeAvailability productTypeAvailability = ProductTypeAvailabilityServices.Get(id.Value, db);
            if (productTypeAvailability == null)
            {
                return HttpNotFound();
            }

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name", productTypeAvailability.Availability);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", productTypeAvailability.ProductType);
            return View(productTypeAvailability);
        }

        // POST: ProductTypeAvailability/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, ProductType, Availability")] ProductTypeAvailability productTypeAvailability)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProductTypeAvailabilityServices.Update(CurrentUser.Id, productTypeAvailability, db);
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

            ViewBag.AvailabilityList = new SelectList(AvailabilityServices.List(db), "Id", "Name", productTypeAvailability.Availability);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", productTypeAvailability.ProductType);
            return View(productTypeAvailability);
        }
        // GET: ProductTypeAvailability/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ProductTypeAvailability productTypeAvailability = ProductTypeAvailabilityServices.Get(id.Value, db);
            if (productTypeAvailability == null)
            {
                return HttpNotFound();
            }
            return View(productTypeAvailability);
        }

        // POST: ProductTypeAvailability/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ProductTypeAvailabilityServices.Delete(CurrentUser.Id, id, db);
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
            // return View(productTypeAvailability);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

