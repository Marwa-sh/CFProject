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
    public partial class ExceptionalAmountTypeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmountType", "ModuleNamePlural");
		
	    public ExceptionalAmountTypeController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ExceptionalAmountTypeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ExceptionalAmountTypeVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = ExceptionalAmountTypeVwServices.List(db);
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
            ExceptionalAmountTypeVwViewModel exceptionalAmountTypeVwViewModel = new ExceptionalAmountTypeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// exceptionalAmountTypeVwViewModel.Instance = ExceptionalAmountTypeVwServices.Get(id.Value, db);
            exceptionalAmountTypeVwViewModel.Instance = ExceptionalAmountTypeVwServices.GetChildren(id.Value, db);
            if (exceptionalAmountTypeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(exceptionalAmountTypeVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: exceptionalAmountTypeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name, IsIncome")] ExceptionalAmountType exceptionalAmountType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ExceptionalAmountTypeServices.Insert(CurrentUser.Id, exceptionalAmountType, db);
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

            return View(exceptionalAmountType);
        }

        // GET: ExceptionalAmountType/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ExceptionalAmountType exceptionalAmountType = ExceptionalAmountTypeServices.Get(id.Value, db);
            if (exceptionalAmountType == null)
            {
                return HttpNotFound();
            }

            return View(exceptionalAmountType);
        }

        // POST: ExceptionalAmountType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, IsIncome")] ExceptionalAmountType exceptionalAmountType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ExceptionalAmountTypeServices.Update(CurrentUser.Id, exceptionalAmountType, db);
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

            return View(exceptionalAmountType);
        }
        // GET: ExceptionalAmountType/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ExceptionalAmountType exceptionalAmountType = ExceptionalAmountTypeServices.Get(id.Value, db);
            if (exceptionalAmountType == null)
            {
                return HttpNotFound();
            }
            return View(exceptionalAmountType);
        }

        // POST: ExceptionalAmountType/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ExceptionalAmountTypeServices.Delete(CurrentUser.Id, id, db);
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
            // return View(exceptionalAmountType);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

