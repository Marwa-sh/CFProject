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

namespace CfProjectAdmin.Controllers
{
    public class UsersController : BaseController
    {
        private CfIdentityEntities1 db = new CfIdentityEntities1();

        //protected override void Initialize(RequestContext requestContext)
        //{
        //    base.Initialize(requestContext);
        //    var rd = requestContext.RouteData;
        //    string currentAction = rd.GetRequiredString("action");
        //    string currentController = rd.GetRequiredString("controller");


        //    if (!CfMembership.UserManahement.IsAllow(currentController, currentAction))
        //    {
        //        requestContext.HttpContext.Response.Clear();
        //        if (!Response.IsRequestBeingRedirected)
        //            requestContext.HttpContext.Response.Redirect(Url.Action("AccessDenied", "Home"));
        //        requestContext.HttpContext.Response.End();

        //    }
        //}
        // GET: Users
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
        [AllowAnonymous]
        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
        [AllowAnonymous]
        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Create([Bind(Include = "UserName,fName,lName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = db.Users.OrderByDescending(c => c.Id).Select(c => c.Id).FirstOrDefault() + 1;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }
        [AllowAnonymous]
        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Edit([Bind(Include = "Id,UserName,fName,lName,Password")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }





        [AllowAnonymous]
        public ActionResult EditRoles(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);

            if (user == null)
            {
                return HttpNotFound();
            }

            UserRolesModel u = new UserRolesModel();
            u.User = user;
            u.AllRole = db.Roles.ToList();
            u.UserRole = (from s in db.Roles join ur in db.UserRoles on s.Id equals ur.RoleId  where ur.UserId == id select s).ToList();
            u.SelectedRole = u.UserRole.Select(c => c.Id).ToArray();
            u.id = 1;
            return View(u);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        [AllowAnonymous]
        public ActionResult EditRoles(int UserId, int[] SelectedGroups)
        {
            if (ModelState.IsValid)
            {
                List<int> UserRole = (from s in db.Roles join ur in db.UserRoles on s.Id equals ur.RoleId where ur.UserId == UserId select s.Id).ToList();

                foreach (int i in SelectedGroups)
                {
                    if(!UserRole.Contains(i))
                    {
                        UserRole ur = new Models.UserRole();
                        ur.UserId = UserId;
                        ur.RoleId = i;
                       ur.Id = db.UserRoles.OrderByDescending(c => c.Id).Select(c=>c.Id).FirstOrDefault()+1;
                        db.UserRoles.Add(ur);
                        db.SaveChanges();
                    }
                   
                }
                foreach (int j in UserRole)
                {
                    if (!SelectedGroups.Contains(j))
                    {
                        UserRole ur = db.UserRoles.Where(c => c.RoleId == j && c.UserId == UserId).FirstOrDefault();

                        db.UserRoles.Remove(ur);
                        db.SaveChanges();
                    }

                }
                //db.Entry(user).State = EntityState.Modified;
                //db.SaveChanges();
                //return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }







        [AllowAnonymous]
        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Users/Delete/5
        [AllowAnonymous]
        [HttpPost, ActionName("Delete")]

        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
