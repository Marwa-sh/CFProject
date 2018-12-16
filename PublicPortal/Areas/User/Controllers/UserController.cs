using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PublicPortal.Areas.User.Controllers
{
    public class UserController : BaseController
    {
        Db db = new Db(DbServices.ConnectionString);
        private string employeeLoans = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeLoans");
        private string employeeGrants = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeGrants");
        private string employeeDebts = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeDebts");
        private string employeeWarrants = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeWarrants");
        private string employeeSubscriptions = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "EmployeeSubscriptions");
        private string employee = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Employee");

        public UserController()
        {
            #region ViewBags
            ViewBag.EmployeeLoans = employeeLoans;
            ViewBag.EmployeeGrants = employeeGrants;
            ViewBag.EmployeeDebts = employeeDebts;
            ViewBag.EmployeeWarrants = employeeWarrants;
            ViewBag.EmployeeSubscriptions = employeeSubscriptions;
            #endregion
        }
        // GET: User/User
        public ActionResult Index()
        {
            return View();
        }
        
    }
}