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
    public class EmployeeSubscriptionsController :BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string employeeSubscriptions = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeSubscriptions");

        public EmployeeSubscriptionsController()
        {
            #region ViewBags
            ViewBag.EmployeeSubscriptions = employeeSubscriptions;
            #endregion
        }

        // GET: User/EmployeeGrants
        public ActionResult Index()
        {
            ViewBag.EmployeeSubscriptions = employeeSubscriptions;
            SubscriptionVwViewModel model = new SubscriptionVwViewModel();
            SubscriptionVwFilter filter = new SubscriptionVwFilter();
            filter.EmployeeId = int.Parse(CurrentUser.UserName);
            model.List = SubscriptionVwServices.Get(filter, db);
            return View(model);
        }

        public ActionResult Details(Nullable<int> id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubscriptionVwViewModel subscriptionVwViewModel = new SubscriptionVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

            // subscriptionVwViewModel.Instance = SubscriptionVwServices.Get(id.Value, db);
            subscriptionVwViewModel.Instance = SubscriptionVwServices.GetChildren(id.Value, db);
            if (subscriptionVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            return View(subscriptionVwViewModel);
        }

    }
}