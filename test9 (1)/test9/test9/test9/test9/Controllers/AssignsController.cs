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
    public class AssignsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Assigns
        public ActionResult Index()
        {
            var assigns = db.Assigns.Include(a => a.Course).Include(a => a.Trainee);
            return View(assigns.ToList());
        }

        // GET: Assigns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assign assign = db.Assigns.Find(id);
            if (assign == null)
            {
                return HttpNotFound();
            }
            return View(assign);
        }




        public ActionResult GetCourse(string id)
        {
            var course = db.Assigns.Where(t => t.Id == id).ToList();
            return View(course);

        }
        // GET: Assigns/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName");
            ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "Email");
            return View();
        }

        // POST: Assigns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssignID,CourseID,Id")] Assign assign)
        {
            if (ModelState.IsValid)
            {
                db.Assigns.Add(assign);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName", assign.CourseID);
            ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "Email", assign.Id);
            return View(assign);
        }

        // GET: Assigns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assign assign = db.Assigns.Find(id);
            if (assign == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName", assign.CourseID);
            ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "Email", assign.Id);
            return View(assign);
        }

        // POST: Assigns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssignID,CourseID,Id")] Assign assign)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assign).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName", assign.CourseID);
            ViewBag.Id = new SelectList(db.ApplicationUsers, "Id", "Email", assign.Id);
            return View(assign);
        }

        // GET: Assigns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assign assign = db.Assigns.Find(id);
            if (assign == null)
            {
                return HttpNotFound();
            }
            return View(assign);
        }

        // POST: Assigns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Assign assign = db.Assigns.Find(id);
            db.Assigns.Remove(assign);
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
