﻿using System;
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
    public class GradesController : Controller
    {
        private CollegeContext db = new CollegeContext();

        // GET: Grades
        public ActionResult Index()
        {
            var grades = db.Grades.Include(g => g.Student).Include(g => g.Subjects);
            return View(grades.ToList());
        }

        // GET: Grades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grades grades = db.Grades.Find(id);
            if (grades == null)
            {
                return HttpNotFound();
            }
            return View(grades);
        }

        // GET: Grades/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Person, "ID", "Name");
            ViewBag.SubjectsId = new SelectList(db.Subjects, "ID", "Name");
            return View();
        }

        // POST: Grades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Grade,SubjectsId,StudentId")] Grades grades)
        {
            if (ModelState.IsValid)
            {
                db.Grades.Add(grades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Person, "ID", "Name", grades.StudentId);
            ViewBag.SubjectsId = new SelectList(db.Subjects, "ID", "Name", grades.SubjectsId);
            return View(grades);
        }

        // GET: Grades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grades grades = db.Grades.Find(id);
            if (grades == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Person, "ID", "Name", grades.StudentId);
            ViewBag.SubjectsId = new SelectList(db.Subjects, "ID", "Name", grades.SubjectsId);
            return View(grades);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Grade,SubjectsId,StudentId")] Grades grades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Person, "ID", "Name", grades.StudentId);
            ViewBag.SubjectsId = new SelectList(db.Subjects, "ID", "Name", grades.SubjectsId);
            return View(grades);
        }

        // GET: Grades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grades grades = db.Grades.Find(id);
            if (grades == null)
            {
                return HttpNotFound();
            }
            return View(grades);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grades grades = db.Grades.Find(id);
            db.Grades.Remove(grades);
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
