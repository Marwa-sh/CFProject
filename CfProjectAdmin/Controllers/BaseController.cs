using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CfProjectAdmin.Models;

using System.Web.Routing;
using CfMembership;

namespace CfProjectAdmin.Controllers
{
    public class UserManagement
    {

        public static CfIdentityEntities E = new CfIdentityEntities();
        public static void login(string username, string password)
        {


            HttpContext.Current.Session["user"] = E.Users.Where(c => c.UserName == username && c.Password == password).FirstOrDefault();

        }

        public static bool IsAllow(string controller, string action)
        {


            if (HttpContext.Current.Session["user"] == null)
            {
                return false;
            }
            CfMembership.User uu = HttpContext.Current.Session["user"] as CfMembership.User;
            var x = from u in E.UserRoles
                    join r in E.Roles on u.RoleId equals r.Id
                    join rp in E.RolePrivileges on r.Id equals rp.RoleId
                    join
p in E.Privileges on rp.PrivilegeId equals p.Id
                    where
(p.Controller == controller && p.Action == action && u.UserId == uu.Id)
                    select p;
            if (x.Count() == 0 && uu.Id!=1)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
    public class BaseController : Controller
    {


        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            var rd = requestContext.RouteData;
            string currentAction = rd.GetRequiredString("action");
            string currentController = rd.GetRequiredString("controller");
           

            if (!UserManagement.IsAllow(currentController, currentAction)&& currentController!="Home")
            {
                requestContext.HttpContext.Response.Clear();
                if (!Response.IsRequestBeingRedirected)
                    requestContext.HttpContext.Response.Redirect(Url.Action("AccessDenied", "Home"));
                requestContext.HttpContext.Response.End();

            }
        }











    }
}
