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
    public partial class HealthLoanDecisionController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "HealthLoanDecision", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "HealthLoanDecision", "ModuleNamePlural");
		
	    public HealthLoanDecisionController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of HealthLoanDecisionVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(HealthLoanDecisionVwViewModel Model)
        {
            if (Model.Filter.HasCriteria)
	        {
				Db db = new Db(DbServices.ConnectionString);
                Model.List = HealthLoanDecisionVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<HealthLoanDecisionVw>();
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
            HealthLoanDecisionVwViewModel healthLoanDecisionVwViewModel = new HealthLoanDecisionVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// healthLoanDecisionVwViewModel.Instance = HealthLoanDecisionVwServices.Get(id.Value, db);
            healthLoanDecisionVwViewModel.Instance = HealthLoanDecisionVwServices.GetChildren(id.Value, db);
            if (healthLoanDecisionVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.HealthLoanDecisionFirstPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "HealthLoanDecisionFirstPayment", "ModuleNamePlural");
            // healthLoanDecisionVwViewModel.HealthLoanDecisionFirstPaymentVwViewModel.List = HealthLoanDecisionFirstPaymentVwServices.GetByHealthLoanDecisionId(id.Value, db);
            healthLoanDecisionVwViewModel.HealthLoanDecisionFirstPaymentVwViewModel.List = healthLoanDecisionVwViewModel.Instance.HealthLoanDecisionFirstPaymentVwList;
            
            
            return View(healthLoanDecisionVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: healthLoanDecisionVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Number, Year, Date, CersNumber, CersDate, PaymentNumber, PaymentDate, Notes")] HealthLoanDecision healthLoanDecision)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                HealthLoanDecisionServices.Insert(CurrentUser.Id, healthLoanDecision, db);
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

            return View(healthLoanDecision);
        }

        // GET: HealthLoanDecision/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HealthLoanDecision healthLoanDecision = HealthLoanDecisionServices.Get(id.Value, db);
            if (healthLoanDecision == null)
            {
                return HttpNotFound();
            }

            return View(healthLoanDecision);
        }

        // POST: HealthLoanDecision/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Number, Year, Date, CersNumber, CersDate, PaymentNumber, PaymentDate, Notes")] HealthLoanDecision healthLoanDecision)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                HealthLoanDecisionServices.Update(CurrentUser.Id, healthLoanDecision, db);
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

            return View(healthLoanDecision);
        }
        // GET: HealthLoanDecision/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            HealthLoanDecision healthLoanDecision = HealthLoanDecisionServices.Get(id.Value, db);
            if (healthLoanDecision == null)
            {
                return HttpNotFound();
            }
            return View(healthLoanDecision);
        }

        // POST: HealthLoanDecision/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            HealthLoanDecisionServices.Delete(CurrentUser.Id, id, db);
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
            // return View(healthLoanDecision);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

