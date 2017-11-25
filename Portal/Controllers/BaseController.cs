using CfMembership;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


using System.Web.Routing;
using static System.Collections.Specialized.BitVector32;

namespace Cf.Controllers
{
    public class UserManagement
    {

        public   CfIdentityEntities E = new CfIdentityEntities();
        public  void login(string username, string password)
        {


            HttpContext.Current.Session["user"] = E.Users.Where(c => c.UserName == username && c.Password == password).FirstOrDefault();

        }

        public  bool IsAllow(string controller, string action)
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
        
        public int CurrentUserId
        {
            get
            {
                if(Session["userId"]==null)
                {
                    Session["userId"] = -1;
                }
                return (int)Session["userId"];
            }

        }

        public User CurrentUser
        {
            get
            {
              
                return  Session["user"] as CfMembership.User;
            }

        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);
            var rd = requestContext.RouteData;
            string currentAction = rd.GetRequiredString("action");
            string currentController = rd.GetRequiredString("controller");
            Session["backAction"] = Session["currentAction"];
            Session["backController"] = Session["currentController"];
            Session["currentAction"] = currentAction;
            Session["currentController"] = currentController;
            if (currentAction != "Edit") {
                UserManagement u = new UserManagement();
                if (!u.IsAllow(currentController, currentAction) && currentController != "Home")
                {
                    requestContext.HttpContext.Response.Clear();
                    if (!Response.IsRequestBeingRedirected)
                        requestContext.HttpContext.Response.Redirect(Url.Action("AccessDenied", "Home" , new { Area="Repository" }));
                    requestContext.HttpContext.Response.End();

                }
            }

            
        }












    }
}
