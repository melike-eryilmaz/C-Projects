using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MelikeEryilmaz.Models;

namespace MelikeEryilmaz.Areas.Admin.Controllers
{
    public class AboutsController : Controller
    {
        private August_30_DbEntities db = new August_30_DbEntities();

        // GET: Admin/Abouts
        public ActionResult Index()
        {
            return View(db.Abouts.ToList());
        }

        // GET: Admin/Abouts/Details/5
        public ActionResult Details(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abouts abouts = db.Abouts.Find(id);
            if (abouts == null)
            {
                return HttpNotFound();
            }
            return View(abouts);
        }

        // GET: Admin/Abouts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Abouts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AboutId,AboutName,Description")] Abouts abouts)
        {
            if (ModelState.IsValid)
            {
                db.Abouts.Add(abouts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(abouts);
        }

        // GET: Admin/Abouts/Edit/5
        public ActionResult Edit(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abouts abouts = db.Abouts.Find(id);
            if (abouts == null)
            {
                return HttpNotFound();
            }
            return View(abouts);
        }

        // POST: Admin/Abouts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AboutId,AboutName,Description")] Abouts abouts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(abouts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(abouts);
        }

        // GET: Admin/Abouts/Delete/5
        public ActionResult Delete(byte? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Abouts abouts = db.Abouts.Find(id);
            if (abouts == null)
            {
                return HttpNotFound();
            }
            return View(abouts);
        }

        // POST: Admin/Abouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(byte id)
        {
            Abouts abouts = db.Abouts.Find(id);
            db.Abouts.Remove(abouts);
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
