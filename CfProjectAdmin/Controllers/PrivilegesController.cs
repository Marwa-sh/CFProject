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
    public class PrivilegesController : BaseController
    {
        private CfIdentityEntities1 db = new CfIdentityEntities1();
        [AllowAnonymous]
        // GET: Privileges
        public ActionResult Index()
        {
            return View(db.Privileges.ToList());
        }
        [AllowAnonymous]
        // GET: Privileges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Privilege privilege = db.Privileges.Find(id);
            if (privilege == null)
            {
                return HttpNotFound();
            }
            return View(privilege);
        }
        [AllowAnonymous]
        // GET: Privileges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Privileges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Create([Bind(Include = "Name,Controller,Action")] Privilege privilege)
        {
            if (ModelState.IsValid)
            {
                privilege.Id = db.Privileges.OrderByDescending(c => c.Id).Select(c=>c.Id).FirstOrDefault() + 1;
                db.Privileges.Add(privilege);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(privilege);
        }
        [AllowAnonymous]
        // GET: Privileges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Privilege privilege = db.Privileges.Find(id);
            if (privilege == null)
            {
                return HttpNotFound();
            }
            return View(privilege);
        }

        // POST: Privileges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Edit([Bind(Include = "Id,Name,Controller,Action")] Privilege privilege)
        {
            if (ModelState.IsValid)
            {
                db.Entry(privilege).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(privilege);
        }
        [AllowAnonymous]
        // GET: Privileges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Privilege privilege = db.Privileges.Find(id);
            if (privilege == null)
            {
                return HttpNotFound();
            }
            return View(privilege);
        }

        // POST: Privileges/Delete/5
        [HttpPost, ActionName("Delete")]
        [AllowAnonymous]
        public ActionResult DeleteConfirmed(int id)
        {
            Privilege privilege = db.Privileges.Find(id);
            db.Privileges.Remove(privilege);
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
