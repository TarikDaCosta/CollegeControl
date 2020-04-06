using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CollegeControl.Context;
using CollegeControl.Models;

namespace CollegeControl.Controllers
{
    public class SubjectsController : Controller
    {
        private CollegeContext db = new CollegeContext();

        // GET: Subjects
        public ActionResult Index()
        {
            var subjects = db.Subjects.Include(s => s.Courses).Include(s => s.Teachers);
            return View(subjects.ToList());
        }

        // GET: Subjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subjects subjects = db.Subjects.Find(id);
            if (subjects == null)
            {
                return HttpNotFound();
            }
            return View(subjects);
        }

        // GET: Subjects/Create
        public ActionResult Create()
        {
            ViewBag.CoursesId = new SelectList(db.Courses, "ID", "Name");
            ViewBag.TeachersId = new SelectList(db.Person, "ID", "Name");
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,CoursesId,TeachersId")] Subjects subjects)
        {
            if (ModelState.IsValid)
            {
                db.Subjects.Add(subjects);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CoursesId = new SelectList(db.Courses, "ID", "Name", subjects.CoursesId);
            ViewBag.TeachersId = new SelectList(db.Person, "ID", "Name", subjects.TeachersId);
            return View(subjects);
        }

        // GET: Subjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subjects subjects = db.Subjects.Find(id);
            if (subjects == null)
            {
                return HttpNotFound();
            }
            ViewBag.CoursesId = new SelectList(db.Courses, "ID", "Name", subjects.CoursesId);
            ViewBag.TeachersId = new SelectList(db.Person, "ID", "Name", subjects.TeachersId);
            return View(subjects);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,CoursesId,TeachersId")] Subjects subjects)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subjects).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CoursesId = new SelectList(db.Courses, "ID", "Name", subjects.CoursesId);
            ViewBag.TeachersId = new SelectList(db.Person, "ID", "Name", subjects.TeachersId);
            return View(subjects);
        }

        // GET: Subjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subjects subjects = db.Subjects.Find(id);
            if (subjects == null)
            {
                return HttpNotFound();
            }
            return View(subjects);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subjects subjects = db.Subjects.Find(id);
            db.Subjects.Remove(subjects);
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
