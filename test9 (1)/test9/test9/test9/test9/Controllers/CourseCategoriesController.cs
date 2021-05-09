using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test9.Models;

namespace test9.Controllers
{
    public class CourseCategoriesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CourseCategories
        public ActionResult Index()
        {
            return View(db.CourseCategories.ToList());
        }

        // GET: CourseCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseCategories courseCategories = db.CourseCategories.Find(id);
            if (courseCategories == null)
            {
                return HttpNotFound();
            }
            return View(courseCategories);
        }

        // GET: CourseCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseCatID,CourseCatName,CourseCatDes")] CourseCategories courseCategories)
        {
            if (ModelState.IsValid)
            {
                db.CourseCategories.Add(courseCategories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(courseCategories);
        }

        // GET: CourseCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseCategories courseCategories = db.CourseCategories.Find(id);
            if (courseCategories == null)
            {
                return HttpNotFound();
            }
            return View(courseCategories);
        }

        // POST: CourseCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseCatID,CourseCatName,CourseCatDes")] CourseCategories courseCategories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseCategories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(courseCategories);
        }

        // GET: CourseCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseCategories courseCategories = db.CourseCategories.Find(id);
            if (courseCategories == null)
            {
                return HttpNotFound();
            }
            return View(courseCategories);
        }

        // POST: CourseCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseCategories courseCategories = db.CourseCategories.Find(id);
            db.CourseCategories.Remove(courseCategories);
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
