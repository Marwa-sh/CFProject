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
    public partial class InsuranceTypeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "InsuranceType", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "InsuranceType", "ModuleNamePlural");
		
	    public InsuranceTypeController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of InsuranceTypeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(InsuranceTypeVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = InsuranceTypeVwServices.List(db);
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
            InsuranceTypeVwViewModel insuranceTypeVwViewModel = new InsuranceTypeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// insuranceTypeVwViewModel.Instance = InsuranceTypeVwServices.Get(id.Value, db);
            insuranceTypeVwViewModel.Instance = InsuranceTypeVwServices.GetChildren(id.Value, db);
            if (insuranceTypeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.HealthLoanDecisionFirstPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "HealthLoanDecisionFirstPayment", "ModuleNamePlural");
            // insuranceTypeVwViewModel.HealthLoanDecisionFirstPaymentVwViewModel.List = HealthLoanDecisionFirstPaymentVwServices.GetByInsuranceTypeId(id.Value, db);
            insuranceTypeVwViewModel.HealthLoanDecisionFirstPaymentVwViewModel.List = insuranceTypeVwViewModel.Instance.HealthLoanDecisionFirstPaymentVwList;
            
            
            return View(insuranceTypeVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: insuranceTypeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] InsuranceType insuranceType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InsuranceTypeServices.Insert(CurrentUser.Id, insuranceType, db);
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

            return View(insuranceType);
        }

        // GET: InsuranceType/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InsuranceType insuranceType = InsuranceTypeServices.Get(id.Value, db);
            if (insuranceType == null)
            {
                return HttpNotFound();
            }

            return View(insuranceType);
        }

        // POST: InsuranceType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] InsuranceType insuranceType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                InsuranceTypeServices.Update(CurrentUser.Id, insuranceType, db);
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

            return View(insuranceType);
        }
        // GET: InsuranceType/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            InsuranceType insuranceType = InsuranceTypeServices.Get(id.Value, db);
            if (insuranceType == null)
            {
                return HttpNotFound();
            }
            return View(insuranceType);
        }

        // POST: InsuranceType/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            InsuranceTypeServices.Delete(CurrentUser.Id, id, db);
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
            // return View(insuranceType);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

