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
    public class EmployeeGrantsController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string employeeGrants = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeGrants");

        public EmployeeGrantsController()
        {
            #region ViewBags
            ViewBag.EmployeeGrants = employeeGrants;
            #endregion
        }

        // GET: User/EmployeeGrants
        public ActionResult Index()
        {
            ViewBag.EmployeeGrants = employeeGrants;
            GrantVwViewModel model = new GrantVwViewModel();
            GrantVwFilter filter = new GrantVwFilter();
            filter.ProductEmployeeId = int.Parse(CurrentUser.UserName);
            model.List = GrantVwServices.Get(filter, db);
            return View(model);
        }

        public ActionResult Details(Nullable<int> product)
        {
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrantVwViewModel grantVwViewModel = new GrantVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

            // grantVwViewModel.Instance = GrantVwServices.Get(product.Value, db);
            grantVwViewModel.Instance = GrantVwServices.GetChildren(product.Value, db);
            if (grantVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.GrantDeductionVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantDeduction", "ModuleName");
            //if (grantVwViewModel.Instance.GrantDeductionVw != null)
            //    grantVwViewModel.GrantDeductionVwViewModel.List.Add(grantVwViewModel.Instance.GrantDeductionVw);
          
            @ViewBag.GrantPaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "GrantPayment", "ModuleNamePlural");           
            //grantVwViewModel.GrantPaymentVwViewModel.List = grantVwViewModel.Instance.GrantPaymentVwList;


            return View(grantVwViewModel);
        }

    }
}