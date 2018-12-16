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
    public class EmployeeDebtsController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string employeeDebts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeDebts");

        public EmployeeDebtsController()
        {
            #region ViewBags
            ViewBag.EmployeeDebts = employeeDebts;
            #endregion
        }

        // GET: User/EmployeeGrants
        public ActionResult Index()
        {
            ViewBag.EmployeeDebts = employeeDebts;
            DebtVwViewModel model = new DebtVwViewModel();
            DebtVwFilter filter = new DebtVwFilter();
            filter.EmployeeId = int.Parse(CurrentUser.UserName);
            model.List = DebtVwServices.Get(filter, db);
            return View(model);
        }

        public ActionResult Details(Nullable<int> id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DebtVwViewModel debtVwViewModel = new DebtVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

            // debtVwViewModel.Instance = DebtVwServices.Get(id.Value, db);
            debtVwViewModel.Instance = DebtVwServices.GetChildren(id.Value, db);
            if (debtVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.WarrantVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Warrant", "ModuleNamePlural");
            //debtVwViewModel.WarrantVwViewModel.List = debtVwViewModel.Instance.WarrantVwList;


            return View(debtVwViewModel);
        }

    }
}