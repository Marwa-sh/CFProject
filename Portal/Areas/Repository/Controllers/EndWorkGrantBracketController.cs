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
    public partial class EndWorkGrantBracketController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EndWorkGrantBracket", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "EndWorkGrantBracket", "ModuleNamePlural");
		
	    public EndWorkGrantBracketController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of EndWorkGrantBracketVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(EndWorkGrantBracketVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = EndWorkGrantBracketVwServices.List(db);
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<byte>  fromYear)
        {
            if (fromYear == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndWorkGrantBracketVwViewModel endWorkGrantBracketVwViewModel = new EndWorkGrantBracketVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// endWorkGrantBracketVwViewModel.Instance = EndWorkGrantBracketVwServices.Get(fromYear.Value, db);
            endWorkGrantBracketVwViewModel.Instance = EndWorkGrantBracketVwServices.GetChildren(fromYear.Value, db);
            if (endWorkGrantBracketVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            
            return View(endWorkGrantBracketVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: endWorkGrantBracketVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "FromYear, Percentage")] EndWorkGrantBracket endWorkGrantBracket)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EndWorkGrantBracketServices.Insert(CurrentUser.Id, endWorkGrantBracket, db);
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

            return View(endWorkGrantBracket);
        }

        // GET: EndWorkGrantBracket/Edit/5
        public ActionResult Edit(Nullable<byte>  fromYear)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (fromYear == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EndWorkGrantBracket endWorkGrantBracket = EndWorkGrantBracketServices.Get(fromYear.Value, db);
            if (endWorkGrantBracket == null)
            {
                return HttpNotFound();
            }

            return View(endWorkGrantBracket);
        }

        // POST: EndWorkGrantBracket/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "FromYear, Percentage")] EndWorkGrantBracket endWorkGrantBracket)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EndWorkGrantBracketServices.Update(CurrentUser.Id, endWorkGrantBracket, db);
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

            return View(endWorkGrantBracket);
        }
        // GET: EndWorkGrantBracket/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            EndWorkGrantBracket endWorkGrantBracket = EndWorkGrantBracketServices.Get(id.Value, db);
            if (endWorkGrantBracket == null)
            {
                return HttpNotFound();
            }
            return View(endWorkGrantBracket);
        }

        // POST: EndWorkGrantBracket/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  fromYear)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            EndWorkGrantBracketServices.Delete(CurrentUser.Id, fromYear, db);
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
            // return View(endWorkGrantBracket);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

