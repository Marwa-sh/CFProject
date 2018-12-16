using Cf.Controllers;
using PublicPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PublicPortal.Areas.Public.Controllers
{
    public class HomeController : Controller
    {
        // GET: Public/Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {

            if (Session["user"] != null)
            {
                return RedirectToAction("AccessDenied", "Home", new { area = "Public" });
            }
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        [AllowAnonymous]
        public ActionResult AccessDenied()
        {
            return View();
        }


        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]

        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            UserManagement u = new UserManagement();
            u.login(model.Username, model.Password);
            if (Session["user"] == null)
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
            else
            {
                var x = Session["user"] as CfMembership.User;
                Session["userName"] = x.fName + " " + x.lName;
                Session["userId"] = x.Id;
                return RedirectToAction("Index", "User", new { area = "User" });

            }

        }


        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]

        public async Task<ActionResult> LogOff()
        {


            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true

            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Home", new { area = "Public" });
            }
            else
            {
                Session["user"] = null;
                Session["userName"] = null;
                return RedirectToAction("Login", "Home", new { area = "Public" });

            }

        }
    }
}