using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTWeb_Cinema_0307.Models;
using LTWeb_Cinema_0307.Models.CinemaEntities;

namespace LTWeb_Cinema_0307.Areas.admin.Controllers
{
    public class ShowDaysController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShowDays
        public ActionResult Index()
        {
            return View(db.ShowDays.ToList());
        }

        // GET: ShowDays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowDay showDay = db.ShowDays.Find(id);
            if (showDay == null)
            {
                return HttpNotFound();
            }
            return View(showDay);
        }

        // GET: ShowDays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShowDays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Day")] ShowDay showDay)
        {
            if (ModelState.IsValid)
            {
                db.ShowDays.Add(showDay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(showDay);
        }

        // GET: ShowDays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowDay showDay = db.ShowDays.Find(id);
            if (showDay == null)
            {
                return HttpNotFound();
            }
            return View(showDay);
        }

        // POST: ShowDays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Day")] ShowDay showDay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(showDay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(showDay);
        }

        // GET: ShowDays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowDay showDay = db.ShowDays.Find(id);
            if (showDay == null)
            {
                return HttpNotFound();
            }
            return View(showDay);
        }

        // POST: ShowDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShowDay showDay = db.ShowDays.Find(id);
            db.ShowDays.Remove(showDay);
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
