using CfProjectAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CfProjectAdmin.Controllers
{
    public class HomeController : BaseController
    {
       
        [AllowAnonymous]
        public ActionResult Index()
        {
         
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {

            if (Session["user"] != null)
            {
                return RedirectToAction("AccessDenied", "Home");
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
    
        public  async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            UserManagement.login(model.Username, model.Password);
            if (Session["user"] == null)
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
            else
            {
                var x = Session["user"] as CfMembership.User;
                Session["userName"] = x.fName+" "+x.lName;
                return RedirectToAction("Index");

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
                return RedirectToAction("Login");
            }
            else
            {
                Session["user"] = null;
                Session["userName"] = null;
                return RedirectToAction("Login");

            }

        }
    }
}