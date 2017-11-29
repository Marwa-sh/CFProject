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
    public partial class GrantTypeGroupController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantTypeGroup", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantTypeGroup", "ModuleNamePlural");
		
	    public GrantTypeGroupController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of GrantTypeGroupVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(GrantTypeGroupVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = GrantTypeGroupVwServices.List(db);
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
            GrantTypeGroupVwViewModel grantTypeGroupVwViewModel = new GrantTypeGroupVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// grantTypeGroupVwViewModel.Instance = GrantTypeGroupVwServices.Get(id.Value, db);
            grantTypeGroupVwViewModel.Instance = GrantTypeGroupVwServices.GetChildren(id.Value, db);
            if (grantTypeGroupVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.GrantTypeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantType", "ModuleNamePlural");
            // grantTypeGroupVwViewModel.GrantTypeVwViewModel.List = GrantTypeVwServices.GetByGrantTypeGroupId(id.Value, db);
            grantTypeGroupVwViewModel.GrantTypeVwViewModel.List = grantTypeGroupVwViewModel.Instance.GrantTypeVwList;
            
            
            return View(grantTypeGroupVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: grantTypeGroupVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] GrantTypeGroup grantTypeGroup)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantTypeGroupServices.Insert(CurrentUser.Id, grantTypeGroup, db);
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

            return View(grantTypeGroup);
        }

        // GET: GrantTypeGroup/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantTypeGroup grantTypeGroup = GrantTypeGroupServices.Get(id.Value, db);
            if (grantTypeGroup == null)
            {
                return HttpNotFound();
            }

            return View(grantTypeGroup);
        }

        // POST: GrantTypeGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] GrantTypeGroup grantTypeGroup)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                GrantTypeGroupServices.Update(CurrentUser.Id, grantTypeGroup, db);
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

            return View(grantTypeGroup);
        }
        // GET: GrantTypeGroup/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            GrantTypeGroup grantTypeGroup = GrantTypeGroupServices.Get(id.Value, db);
            if (grantTypeGroup == null)
            {
                return HttpNotFound();
            }
            return View(grantTypeGroup);
        }

        // POST: GrantTypeGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            GrantTypeGroupServices.Delete(CurrentUser.Id, id, db);
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
            // return View(grantTypeGroup);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

