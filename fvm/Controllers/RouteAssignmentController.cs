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
    public class RouteAssignmentController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /RouteAssignment/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.routeassignment = String.IsNullOrEmpty(sortOrder) ? "routeassignment_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var routeassignments = from s in db.RouteAssignments.Include(c => c.Contact).Include(e => e.Equipment)
                                   where s.Contact.ContactTitle != "Monitor"
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routeassignments = routeassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                                                            || s.Equipment.EquipmentDesignator.Contains(searchString));

                //routeassignments = routeassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                //                 || s.Route.RouteDistrict.Contains(searchString)
                //                 || s.Contact.ContactDesignator.Contains(searchString)
                //                 || s.Contact.ContactDesignator2.Contains(searchString)
                //                 || s.Contact.ContactNameFirst.Contains(searchString)
                //                 || s.Equipment.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                routeassignments = routeassignments.OrderBy(s => s.RouteAssignmentReplacement).OrderByDescending(s => s.Equipment.EquipmentDOT).ThenByDescending(s => s.Equipment.EquipmentDown).ThenBy(s => s.Equipment.EquipmentType).ThenBy(s => s.Equipment.EquipmentDesignator).ThenByDescending(s => s.RouteAssignmentReplacement);
                break;
            }
            return View(routeassignments.ToList());
        }

        // GET: /RouteAssignment/
        public ActionResult IndexAltSearch(string sortOrder, string searchString)
        {
            ViewBag.routeassignment = String.IsNullOrEmpty(sortOrder) ? "routeassignment_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var routeassignments = from s in db.RouteAssignments.Include(c => c.Contact).Include(e => e.Equipment)
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routeassignments = routeassignments.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.Contact.ContactDesignator2.Contains(searchString)
                                                || s.Contact.ContactNameFirst.Contains(searchString)
                                                || s.Equipment.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    routeassignments = routeassignments.OrderBy(s => s.RouteAssignmentReplacement).OrderByDescending(s => s.Equipment.EquipmentDOT).ThenByDescending(s => s.Equipment.EquipmentDown).ThenBy(s => s.Equipment.EquipmentType).ThenBy(s => s.Equipment.EquipmentDesignator).ThenByDescending(s => s.RouteAssignmentReplacement);
                    break;
            }
            return View(routeassignments.ToList());
        }

        public ActionResult Theta(string sortOrder, string searchString)
        {
            ViewBag.routeassignment = String.IsNullOrEmpty(sortOrder) ? "routeassignment_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var routeassignments = from s in db.RouteAssignments.Include(c => c.Contact).Include(e => e.Equipment)
                                   where s.Equipment.EquipmentDown == "Down"
                                      || s.Equipment.EquipmentDOT == "DOT"
                                   select s;

            //s.Contact.ContactTitle != "Monitor"

            if (!String.IsNullOrEmpty(searchString))
            {
                routeassignments = routeassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                                                            || s.Equipment.EquipmentDesignator.Contains(searchString));

                //routeassignments = routeassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                //                 || s.Route.RouteDistrict.Contains(searchString)
                //                 || s.Contact.ContactDesignator.Contains(searchString)
                //                 || s.Contact.ContactDesignator2.Contains(searchString)
                //                 || s.Contact.ContactNameFirst.Contains(searchString)
                //                 || s.Equipment.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    routeassignments = routeassignments.OrderBy(s => s.RouteAssignmentReplacement).OrderByDescending(s => s.Equipment.EquipmentDOT).ThenByDescending(s => s.Equipment.EquipmentDown).ThenBy(s => s.Equipment.EquipmentType).ThenBy(s => s.Equipment.EquipmentDesignator).ThenByDescending(s => s.RouteAssignmentReplacement);
                    break;
            }
            return View(routeassignments.ToList());
        }

            // GET: /Route/
            public ActionResult NorthportEastNorthport(string sortOrder, string searchString)
            {
                ViewBag.routeassignmentreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
                ViewBag.routeassignmentreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

                var routeassignments = from s in db.RouteAssignments
                                       where s.Route.RouteDistrict == "Northport - East Northport"
                                       select s;

                if (!String.IsNullOrEmpty(searchString))
                {
                    routeassignments = routeassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                                                                || s.Equipment.EquipmentDesignator.Contains(searchString));

                    // || s.Contact.ContactDesignator.Contains(searchString)
                    // || s.Contact.ContactDesignator2.Contains(searchString)
                    // || s.Contact.ContactNameFirst.Contains(searchString)                                                
                }
                switch (sortOrder)
                {
                    default:
                        routeassignments = routeassignments.OrderBy(s => s.Route.RouteDesignator);
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
                return View(routeassignments.ToList());
            }

            // GET: /Route/
            public ActionResult NorthportEastNorthportAltSearch(string sortOrder, string searchString)
        {
            ViewBag.routeassignmentreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.routeassignmentreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var routeassignments = from s in db.RouteAssignments
                                   where s.Route.RouteDistrict == "Northport - East Northport"
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routeassignments = routeassignments.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                  || s.Contact.ContactDesignator2.Contains(searchString)
                                  || s.Contact.ContactNameFirst.Contains(searchString)
                                  || s.Equipment.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    routeassignments = routeassignments.OrderBy(s => s.Route.RouteDesignator);
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
            return View(routeassignments.ToList());
        }

        // GET: /Route/
        public ActionResult SouthHuntington(string sortOrder, string searchString)
        {
            ViewBag.routereportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.routereportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var routeassignments = from s in db.RouteAssignments
                                   where s.Route.RouteDistrict == "South Huntington"
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routeassignments = routeassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                                                            || s.Equipment.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    routeassignments = routeassignments.OrderBy(s => s.Route.RouteDesignator);
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
            return View(routeassignments.ToList());
        }

        // GET: /Route/
        public ActionResult SouthHuntingtonAltSearch(string sortOrder, string searchString)
        {
            ViewBag.routereportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.routereportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var routeassignments = from s in db.RouteAssignments
                                   where s.Route.RouteDistrict == "South Huntington"
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routeassignments = routeassignments.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.Contact.ContactDesignator2.Contains(searchString)
                                                || s.Contact.ContactNameFirst.Contains(searchString)
                                                || s.Equipment.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    routeassignments = routeassignments.OrderBy(s => s.Route.RouteDesignator);
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
            return View(routeassignments.ToList());
        }

        // ________________________________________________

        //public ActionResult Index()
        //{
        //    var routeassignments = db.RouteAssignments.Include(r => r.Contact).Include(r => r.Equipment).Include(r => r.Route);
        //    return View(routeassignments.ToList());
        //}

        // ________________________________________________

        public ActionResult Report(string sortOrder, string searchString)
        {
            ViewBag.routereportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.routereportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var routeassignments = from s in db.RouteAssignments.Include(c => c.Contact).Include(e => e.Equipment)
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routeassignments = routeassignments.Where(s => s.Route.RouteDesignator.Contains(searchString)
                                                || s.Contact.ContactDesignator.Contains(searchString)
                                                || s.Contact.ContactDesignator2.Contains(searchString)
                                                || s.Contact.ContactNameFirst.Contains(searchString)
                                                || s.Equipment.EquipmentDesignator.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    routeassignments = routeassignments.OrderBy(s => s.Route.RouteTimeReportAM);
                    break;
                case "routereportam_desc":
                    routeassignments = routeassignments.OrderByDescending(s => s.Route.RouteTimeReportAM);
                    break;
                case "routereportpm":
                    routeassignments = routeassignments.OrderBy(s => s.Route.RouteTimeReportPM);
                    break;
                case "routereportpm_desc":
                    routeassignments = routeassignments.OrderByDescending(s => s.Route.RouteTimeReportPM);
                    break;
            }
            return View(routeassignments.ToList());
        }

        // GET: /RouteAssignment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RouteAssignment routeassignment = db.RouteAssignments.Find(id);
            if (routeassignment == null)
            {
                return HttpNotFound();
            }
            return View(routeassignment);
        }

        // GET: /RouteAssignment/Create
        public ActionResult Create()
        {
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator");
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator");
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator");
            
            //ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator");

            //ViewBag.RunID = db.Runs.Select(a => new SelectListItem
            //{
            //    Value = a.RunID.ToString(),
            //    Text = a.RunDesignator + " " + a.RunTimeArriveHr + " " + a.RunTimeArriveMin
            //}
            //).ToList();

            return View();
        }

        // POST: /RouteAssignment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include= "RouteAssignmentID,RouteID,ContactID,EquipmentID,RunID,RouteAssignmentReplacement,RouteAssignmentReplacementType")] RouteAssignment routeassignment)
        {
            if (ModelState.IsValid)
            {
                db.RouteAssignments.Add(routeassignment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", routeassignment.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", routeassignment.EquipmentID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", routeassignment.RouteID);
            //ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator");

            //ViewBag.RunID = db.Runs.Select(a => new SelectListItem
            //{
            //    Value = a.RunID.ToString(),
            //    Text = a.RunDesignator + " " + a.RunTimeArriveHr + " " + a.RunTimeArriveMin
            //}
            //).ToList(); 
            
            return View(routeassignment);
        }

        // GET: /RouteAssignment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RouteAssignment routeassignment = db.RouteAssignments.Find(id);
            if (routeassignment == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", routeassignment.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", routeassignment.EquipmentID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", routeassignment.RouteID);

            //ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator");

            //ViewBag.RunID = db.Runs.Select(a => new SelectListItem
            //{
            //    Value = a.RunID.ToString(),
            //    Text = a.RunDesignator + " " + a.RunTimeArriveHr + " " + a.RunTimeArriveMin
            //}
            //).ToList();

            return View(routeassignment);
        }

        // POST: /RouteAssignment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include= "RouteAssignmentID,RouteID,ContactID,EquipmentID,RunID,RouteAssignmentReplacement,RouteAssignmentReplacementType")] RouteAssignment routeassignment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(routeassignment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", routeassignment.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", routeassignment.EquipmentID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", routeassignment.RouteID);

            //ViewBag.RunID = new SelectList(db.Runs, "RunID", "RunDesignator");

            //ViewBag.RunID = db.Runs.Select(a => new SelectListItem
            //{
            //    Value = a.RunID.ToString(),
            //    Text = a.RunDesignator + " " + a.RunTimeArriveHr + " " + a.RunTimeArriveMin
            //}
            //).ToList();

            return View(routeassignment);
        }

        // GET: /RouteAssignment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RouteAssignment routeassignment = db.RouteAssignments.Find(id);
            if (routeassignment == null)
            {
                return HttpNotFound();
            }
            return View(routeassignment);
        }

        // POST: /RouteAssignment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RouteAssignment routeassignment = db.RouteAssignments.Find(id);
            db.RouteAssignments.Remove(routeassignment);
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
