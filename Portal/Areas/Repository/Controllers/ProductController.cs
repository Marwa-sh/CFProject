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
    public partial class ProductController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Product", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Product", "ModuleNamePlural");
		
	    public ProductController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ProductVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ProductVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = ProductVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<ProductVw>();
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
            ProductVwViewModel productVwViewModel = new ProductVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// productVwViewModel.Instance = ProductVwServices.Get(id.Value, db);
            productVwViewModel.Instance = ProductVwServices.GetChildren(id.Value, db);
            if (productVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.GrantVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Grant", "ModuleName");
            if (productVwViewModel.Instance.GrantVw != null)
                productVwViewModel.GrantVwViewModel.List.Add(productVwViewModel.Instance.GrantVw);
                // productVwViewModel.GrantVwViewModel.Instance = productVwViewModel.Instance.GrantVw;

            @ViewBag.LoanVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Loan", "ModuleName");
            if (productVwViewModel.Instance.LoanVw != null)
                productVwViewModel.LoanVwViewModel.List.Add(productVwViewModel.Instance.LoanVw);
                // productVwViewModel.LoanVwViewModel.Instance = productVwViewModel.Instance.LoanVw;

            @ViewBag.RefundableProductVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "RefundableProduct", "ModuleName");
            if (productVwViewModel.Instance.RefundableProductVw != null)
                productVwViewModel.RefundableProductVwViewModel.List.Add(productVwViewModel.Instance.RefundableProductVw);
                // productVwViewModel.RefundableProductVwViewModel.Instance = productVwViewModel.Instance.RefundableProductVw;

            @ViewBag.RequestVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Request", "ModuleName");
            if (productVwViewModel.Instance.RequestVw != null)
                productVwViewModel.RequestVwViewModel.List.Add(productVwViewModel.Instance.RequestVw);
                // productVwViewModel.RequestVwViewModel.Instance = productVwViewModel.Instance.RequestVw;
            
            return View(productVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName");
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
			return View();
        }

        // POST: productVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Employee, ProductType, Amount, Notes")] Product product)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProductServices.Insert(CurrentUser.Id, product, db);
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
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            return View(product);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = ProductServices.Get(id.Value, db);
            if (product == null)
            {
                return HttpNotFound();
            }

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", product.Employee);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", product.ProductType);
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Employee, ProductType, Amount, Notes")] Product product)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProductServices.Update(CurrentUser.Id, product, db);
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

            ViewBag.EmployeeList = new SelectList(EmployeeServices.List(db), "Id", "FirstName", product.Employee);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name", product.ProductType);
            return View(product);
        }
        // GET: Product/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Product product = ProductServices.Get(id.Value, db);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ProductServices.Delete(CurrentUser.Id, id, db);
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
            // return View(product);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

