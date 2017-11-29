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
    public partial class PaymentGroupController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "PaymentGroup", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "PaymentGroup", "ModuleNamePlural");
		
	    public PaymentGroupController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of PaymentGroupVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(PaymentGroupVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = PaymentGroupVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<byte>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentGroupVwViewModel paymentGroupVwViewModel = new PaymentGroupVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// paymentGroupVwViewModel.Instance = PaymentGroupVwServices.Get(id.Value, db);
            paymentGroupVwViewModel.Instance = PaymentGroupVwServices.GetChildren(id.Value, db);
            if (paymentGroupVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.ProductTypeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductType", "ModuleNamePlural");
            // paymentGroupVwViewModel.ProductTypeVwViewModel.List = ProductTypeVwServices.GetByPaymentGroupId(id.Value, db);
            paymentGroupVwViewModel.ProductTypeVwViewModel.List = paymentGroupVwViewModel.Instance.ProductTypeVwList;
            
            
            return View(paymentGroupVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: paymentGroupVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] PaymentGroup paymentGroup)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                PaymentGroupServices.Insert(CurrentUser.Id, paymentGroup, db);
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

            return View(paymentGroup);
        }

        // GET: PaymentGroup/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentGroup paymentGroup = PaymentGroupServices.Get(id.Value, db);
            if (paymentGroup == null)
            {
                return HttpNotFound();
            }

            return View(paymentGroup);
        }

        // POST: PaymentGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] PaymentGroup paymentGroup)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                PaymentGroupServices.Update(CurrentUser.Id, paymentGroup, db);
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

            return View(paymentGroup);
        }
        // GET: PaymentGroup/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            PaymentGroup paymentGroup = PaymentGroupServices.Get(id.Value, db);
            if (paymentGroup == null)
            {
                return HttpNotFound();
            }
            return View(paymentGroup);
        }

        // POST: PaymentGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            PaymentGroupServices.Delete(CurrentUser.Id, id, db);
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
            // return View(paymentGroup);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

