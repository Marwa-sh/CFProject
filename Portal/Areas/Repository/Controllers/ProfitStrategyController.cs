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
    public partial class ProfitStrategyController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProfitStrategy", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProfitStrategy", "ModuleNamePlural");
		
	    public ProfitStrategyController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of ProfitStrategyVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(ProfitStrategyVwViewModel Model)
        {
			Db db = new Db(DbServices.ConnectionString);
            Model.List = ProfitStrategyVwServices.List(db);
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
            ProfitStrategyVwViewModel profitStrategyVwViewModel = new ProfitStrategyVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// profitStrategyVwViewModel.Instance = ProfitStrategyVwServices.Get(id.Value, db);
            profitStrategyVwViewModel.Instance = ProfitStrategyVwServices.GetChildren(id.Value, db);
            if (profitStrategyVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.ProductTypeVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ProductType", "ModuleNamePlural");
            // profitStrategyVwViewModel.ProductTypeVwViewModel.List = ProductTypeVwServices.GetByProfitStrategyId(id.Value, db);
            profitStrategyVwViewModel.ProductTypeVwViewModel.List = profitStrategyVwViewModel.Instance.ProductTypeVwList;
            
            
            return View(profitStrategyVwViewModel);
        }

        public ActionResult Create()
        {
			return View();
        }

        // POST: profitStrategyVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Name")] ProfitStrategy profitStrategy)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProfitStrategyServices.Insert(CurrentUser.Id, profitStrategy, db);
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

            return View(profitStrategy);
        }

        // GET: ProfitStrategy/Edit/5
        public ActionResult Edit(Nullable<byte>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfitStrategy profitStrategy = ProfitStrategyServices.Get(id.Value, db);
            if (profitStrategy == null)
            {
                return HttpNotFound();
            }

            return View(profitStrategy);
        }

        // POST: ProfitStrategy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, Name")] ProfitStrategy profitStrategy)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                ProfitStrategyServices.Update(CurrentUser.Id, profitStrategy, db);
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

            return View(profitStrategy);
        }
        // GET: ProfitStrategy/Delete/5
        public ActionResult Delete(Nullable<byte> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            ProfitStrategy profitStrategy = ProfitStrategyServices.Get(id.Value, db);
            if (profitStrategy == null)
            {
                return HttpNotFound();
            }
            return View(profitStrategy);
        }

        // POST: ProfitStrategy/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(byte  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            ProfitStrategyServices.Delete(CurrentUser.Id, id, db);
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
            // return View(profitStrategy);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

