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
    public class RolePrivilegesController : Controller
    {
        private CfIdentityEntities1 db = new CfIdentityEntities1();

        // GET: RolePrivileges
        public ActionResult Index()
        {
            var rolePrivileges = db.RolePrivileges.Include(r => r.Privilege).Include(r => r.Role);
            return View(rolePrivileges.ToList());
        }

        // GET: RolePrivileges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolePrivilege rolePrivilege = db.RolePrivileges.Find(id);
            if (rolePrivilege == null)
            {
                return HttpNotFound();
            }
            return View(rolePrivilege);
        }

        // GET: RolePrivileges/Create
        public ActionResult Create()
        {
            ViewBag.PrivilegeId = new SelectList(db.Privileges, "Id", "Name");
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "Name");
            return View();
        }

        // POST: RolePrivileges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoleId,PrivilegeId")] RolePrivilege rolePrivilege)
        {
            if (ModelState.IsValid)
            {
                db.RolePrivileges.Add(rolePrivilege);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PrivilegeId = new SelectList(db.Privileges, "Id", "Name", rolePrivilege.PrivilegeId);
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "Name", rolePrivilege.RoleId);
            return View(rolePrivilege);
        }

        // GET: RolePrivileges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolePrivilege rolePrivilege = db.RolePrivileges.Find(id);
            if (rolePrivilege == null)
            {
                return HttpNotFound();
            }
            ViewBag.PrivilegeId = new SelectList(db.Privileges, "Id", "Name", rolePrivilege.PrivilegeId);
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "Name", rolePrivilege.RoleId);
            return View(rolePrivilege);
        }

        // POST: RolePrivileges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RoleId,PrivilegeId")] RolePrivilege rolePrivilege)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rolePrivilege).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PrivilegeId = new SelectList(db.Privileges, "Id", "Name", rolePrivilege.PrivilegeId);
            ViewBag.RoleId = new SelectList(db.Roles, "Id", "Name", rolePrivilege.RoleId);
            return View(rolePrivilege);
        }

        // GET: RolePrivileges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RolePrivilege rolePrivilege = db.RolePrivileges.Find(id);
            if (rolePrivilege == null)
            {
                return HttpNotFound();
            }
            return View(rolePrivilege);
        }

        // POST: RolePrivileges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RolePrivilege rolePrivilege = db.RolePrivileges.Find(id);
            db.RolePrivileges.Remove(rolePrivilege);
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
