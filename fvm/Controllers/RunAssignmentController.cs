using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fvm.Models;
using fvm.DAL;

namespace fvm.Controllers
{
    public class RunAssignmentController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /RunAssignment/
        public ActionResult Index()
        {
            var runassignments = db.RunAssignments.Include(r => r.Route).Include(r => r.Run);
            return View(runassignments.ToList());
        }

        // GET: /RunAssignment/
        public ActionResult NorthportEastNorthport(string sortOrder, string searchString)
        {
            ViewBag.runassignmentreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runassignmentreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runassignments = from s in db.RunAssignments
                         where s.Route.RouteDistrict == "Northport - East Northport"
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runassignments = runassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                                        || s.Route.RouteDistrict.Contains(searchString)
                                        || s.Route.RouteDistrict.Contains(searchString)
                                        || s.Route.RouteDesignator.Contains(searchString)
                    //|| s.ContactDesignator.Contains(searchString)
                                        );

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runassignments = runassignments.OrderBy(s => s.Route.RouteDesignator);
                    break;
                //case "runreportam_desc":
                //    runs = runs.OrderByDescending(s => s.RunTimeReportAM);
                //    break;
                //case "runreportpm":
                //    runs = runs.OrderBy(s => s.RunTimeReportPM);
                //    break;
                //case "routereportpm_desc":
                //    runs = runs.OrderByDescending(s => s.RunTimeReportPM);
                //    break;
            }
            return View(runassignments.ToList());
        }

        // GET: /RunAssignment/
        public ActionResult SouthHuntington(string sortOrder, string searchString)
        {
            ViewBag.runassignmentreportam = String.IsNullOrEmpty(sortOrder) ? "runassignmentreportam_desc" : "";
            ViewBag.runassignmentreportpm = sortOrder == "routereportpm" ? "runassignmentreportpm_desc" : "runassignmentreportpm";

            var runassignments = from s in db.RunAssignments
                         where s.Route.RouteDistrict == "South Huntington"
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runassignments = runassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                                        || s.Route.RouteDistrict.Contains(searchString)
                                        || s.Route.RouteDistrict.Contains(searchString)
                                        || s.Route.RouteDesignator.Contains(searchString)
                                        || s.Route.RouteDesignator2.Contains(searchString)
                    //|| s.ContactDesignator.Contains(searchString)
                                        );

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runassignments = runassignments.OrderBy(s => s.Route.RouteDesignator);
                    break;
                //case "runreportam_desc":
                //    runs = runs.OrderByDescending(s => s.RunTimeReportAM);
                //    break;
                //case "runreportpm":
                //    runs = runs.OrderBy(s => s.RunTimeReportPM);
                //    break;
                //case "routereportpm_desc":
                //    runs = runs.OrderByDescending(s => s.RunTimeReportPM);
                //    break;
            }
            return View(runassignments.ToList());
        }

        // GET: /RunAssignment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RunAssignment runassignment = db.RunAssignments.Find(id);
            if (runassignment == null)
            {
                return HttpNotFound();
            }
            return View(runassignment);
        }

        // GET: /RunAssignment/Create
        public ActionResult Create()
        {
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator");
            ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator");
            return View();
        }

        // POST: /RunAssignment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="RunAssignmentID,RouteID,RunID")] RunAssignment runassignment)
        {
            if (ModelState.IsValid)
            {
                db.RunAssignments.Add(runassignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", runassignment.RouteID);
            ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator", runassignment.RunID);
            return View(runassignment);
        }

        // GET: /RunAssignment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RunAssignment runassignment = db.RunAssignments.Find(id);
            if (runassignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", runassignment.RouteID);
            ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator", runassignment.RunID);
            return View(runassignment);
        }

        // POST: /RunAssignment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="RunAssignmentID,RouteID,RunID")] RunAssignment runassignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(runassignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", runassignment.RouteID);
            ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator", runassignment.RunID);
            return View(runassignment);
        }

        // GET: /RunAssignment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RunAssignment runassignment = db.RunAssignments.Find(id);
            if (runassignment == null)
            {
                return HttpNotFound();
            }
            return View(runassignment);
        }

        // POST: /RunAssignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RunAssignment runassignment = db.RunAssignments.Find(id);
            db.RunAssignments.Remove(runassignment);
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
