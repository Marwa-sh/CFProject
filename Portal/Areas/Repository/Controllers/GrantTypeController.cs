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
    public partial class GrantTypeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantType", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantType", "ModuleNamePlural");
		
	    public GrantTypeController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of GrantTypeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GrantTypeVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = GrantTypeVwServices.List(db);
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
            GrantTypeVwViewModel grantTypeVwViewModel = new GrantTypeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// grantTypeVwViewModel.Instance = GrantTypeVwServices.Get(id.Value, db);
            grantTypeVwViewModel.Instance = GrantTypeVwServices.GetChildren(id.Value, db);
            if (grantTypeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(grantTypeVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name");
			return View();
        }

        // POST: grantTypeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name, Amount, GrantTypeGroup")] GrantType grantType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantTypeServices.Insert(CurrentUser.Id, grantType, db);
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

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name");
            return View(grantType);
        }

        // GET: GrantType/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantType grantType = GrantTypeServices.Get(id.Value, db);
            if (grantType == null)
            {
                return HttpNotFound();
            }

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name", grantType.GrantTypeGroup);
            return View(grantType);
        }

        // POST: GrantType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name, Amount, GrantTypeGroup")] GrantType grantType)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantTypeServices.Update(CurrentUser.Id, grantType, db);
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

            ViewBag.GrantTypeGroupList = new SelectList(GrantTypeGroupServices.List(db), "Id", "Name", grantType.GrantTypeGroup);
            return View(grantType);
        }
        // GET: GrantType/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            GrantType grantType = GrantTypeServices.Get(id.Value, db);
            if (grantType == null)
            {
                return HttpNotFound();
            }
            return View(grantType);
        }

        // POST: GrantType/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GrantTypeServices.Delete(CurrentUser.Id, id, db);
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
            // return View(grantType);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

