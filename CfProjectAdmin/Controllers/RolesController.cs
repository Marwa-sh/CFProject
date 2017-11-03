using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CfProjectAdmin.Models;

namespace CfProjectAdmin.Controllers
{
    public class RolesController : BaseController
    {
        private CfIdentityEntities1 db = new CfIdentityEntities1();
        [AllowAnonymous]
        // GET: Roles
        public ActionResult Index()
        {
            var roles = db.Roles.Include(r => r.UserRoles);
            return View(roles.ToList());
        }
        [AllowAnonymous]
        // GET: Roles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }
        [AllowAnonymous]
        // GET: Roles/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.UserRoles, "Id", "Id");
            return View();
        }

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Create([Bind(Include = "Name")] Role role)
        {
            if (ModelState.IsValid)
            {
                role.Id = db.Roles.OrderByDescending(c => c.Id).Select(c => c.Id).FirstOrDefault() + 1;
                db.Roles.Add(role);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.UserRoles, "Id", "Id", role.Id);
            return View(role);
        }
        [AllowAnonymous]
        // GET: Roles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.UserRoles, "Id", "Id", role.Id);
            return View(role);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Edit([Bind(Include = "Id,Name")] Role role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(role).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.UserRoles, "Id", "Id", role.Id);
            return View(role);
        }

        [AllowAnonymous]
        public ActionResult EditPrivileges(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = db.Roles.Find(id);

            if (role == null)
            {
                return HttpNotFound();
            }

            RolePrivilegesModel u = new RolePrivilegesModel();
            u.role = role;
            u.AllPrivileges = db.Privileges.ToList();
            u.RolePrivileges = (from s in db.Privileges join ur in db.RolePrivileges on s.Id equals ur.PrivilegeId where ur.RoleId == id select s).ToList();
            u.SelectedRole = u.RolePrivileges.Select(c => c.Id).ToArray();
            u.id = 1;
            return View(u);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 

        [HttpPost]
        [AllowAnonymous]
        public ActionResult EditPrivileges(int RoleId, int[] SelectedGroups)
        {
            if (ModelState.IsValid)
            {
                List<int> RolePrivileges = (from s in db.Privileges join ur in db.RolePrivileges on s.Id equals ur.PrivilegeId where ur.RoleId == RoleId select s.Id).ToList();

                foreach (int i in SelectedGroups)
                {
                    if (!RolePrivileges.Contains(i))
                    {
                        RolePrivilege ur = new RolePrivilege();

                        ur.RoleId = RoleId;
                        ur.PrivilegeId = i;
                        ur.Id = db.RolePrivileges.OrderByDescending(c => c.Id).Select(c => c.Id).FirstOrDefault() + 1;
                        db.RolePrivileges.Add(ur);
                        db.SaveChanges();
                    }

                }
                foreach (int j in RolePrivileges)
                {
                    if (!SelectedGroups.Contains(j))
                    {
                        RolePrivilege ur = db.RolePrivileges.Where(c => c.RoleId == RoleId && c.PrivilegeId == j).FirstOrDefault();

                        db.RolePrivileges.Remove(ur);
                        db.SaveChanges();
                    }

                }
                //db.Entry(user).State = EntityState.Modified;
                //db.SaveChanges();
                //return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }




        // GET: Roles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Role role = db.Roles.Find(id);
            if (role == null)
            {
                return HttpNotFound();
            }
            return View(role);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Role role = db.Roles.Find(id);
            db.Roles.Remove(role);
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
