using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PublicPortal.Areas.User.Controllers
{
    public class EmployeeWarrantsController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string employeeWarrants = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeWarrants");


        public EmployeeWarrantsController()
        {
            #region ViewBags
            ViewBag.EmployeeWarrants = employeeWarrants;
            #endregion
        }
        // GET: User/EmployeeLoans
        public ActionResult Index()
        {
            ViewBag.EmployeeWarrants = employeeWarrants;
            WarrantVwViewModel model = new WarrantVwViewModel();
            WarrantVwFilter filter = new WarrantVwFilter();
            filter.EmployeeId = int.Parse(CurrentUser.UserName);
            model.List = WarrantVwServices.Get(filter, db);
            return View(model);
        }

        public ActionResult Details(Nullable<int> id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WarrantVwViewModel warrantVwViewModel = new WarrantVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

            // warrantVwViewModel.Instance = WarrantVwServices.Get(id.Value, db);
            warrantVwViewModel.Instance = WarrantVwServices.GetChildren(id.Value, db);
            if (warrantVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            return View(warrantVwViewModel);
        }

    }
}