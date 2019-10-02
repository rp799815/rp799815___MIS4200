using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using rp799815_MIS4200.DAL;
using rp799815_MIS4200.Models;

namespace rp799815_MIS4200.Controllers
{
    public class CourseDetailsController : Controller
    {
        private MIS4200Context db = new MIS4200Context();

        // GET: CourseDetails
        public ActionResult Index()
        {
            var courseDetail = db.CourseDetail.Include(c => c.Course).Include(c => c.Student);
            return View(courseDetail.ToList());
        }

        // GET: CourseDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetails courseDetails = db.CourseDetail.Find(id);
            if (courseDetails == null)
            {
                return HttpNotFound();
            }
            return View(courseDetails);
        }

        // GET: CourseDetails/Create
        public ActionResult Create()
        {
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName");
            ViewBag.studentID = new SelectList(db.Students, "studentID", "studentFirstName");
            return View();
        }

        // POST: CourseDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "courseDetailID,courseName,description,hours,startDate,courseID,studentID")] CourseDetails courseDetails)
        {
            if (ModelState.IsValid)
            {
                db.CourseDetail.Add(courseDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", courseDetails.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "studentFirstName", courseDetails.studentID);
            return View(courseDetails);
        }

        // GET: CourseDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetails courseDetails = db.CourseDetail.Find(id);
            if (courseDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", courseDetails.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "studentFirstName", courseDetails.studentID);
            return View(courseDetails);
        }

        // POST: CourseDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "courseDetailID,courseName,description,hours,startDate,courseID,studentID")] CourseDetails courseDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseID = new SelectList(db.Courses, "courseID", "courseName", courseDetails.courseID);
            ViewBag.studentID = new SelectList(db.Students, "studentID", "studentFirstName", courseDetails.studentID);
            return View(courseDetails);
        }

        // GET: CourseDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseDetails courseDetails = db.CourseDetail.Find(id);
            if (courseDetails == null)
            {
                return HttpNotFound();
            }
            return View(courseDetails);
        }

        // POST: CourseDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseDetails courseDetails = db.CourseDetail.Find(id);
            db.CourseDetail.Remove(courseDetails);
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
