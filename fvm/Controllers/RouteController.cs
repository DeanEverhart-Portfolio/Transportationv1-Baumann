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
    public class RouteController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Route/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.routereportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.routereportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var routes = from s in db.Routes
                                   select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routes = routes.Where(s => s.RouteDesignator.Contains(searchString)
                                        || s.RouteDesignator2.Contains(searchString)
                                        || s.RouteDistrict.Contains(searchString));
                                                // || s.Contact.ContactDesignator.Contains(searchString)
                                                // || s.Contact.ContactDesignator2.Contains(searchString)
                                                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    routes = routes.OrderBy(s => s.RouteTimeReportAM);
                    break;
                case "routereportam_desc":
                    routes = routes.OrderByDescending(s => s.RouteTimeReportAM);
                    break;
                case "routereportpm":
                    routes = routes.OrderBy(s => s.RouteTimeReportPM);
                    break;
                case "routereportpm_desc":
                    routes = routes.OrderByDescending(s => s.RouteTimeReportPM);
                    break;
            }
            return View(routes.ToList());
        }

        // GET: /Route/
        public ActionResult NorthportEastNorthport(string sortOrder, string searchString)
        {
            ViewBag.routereportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.routereportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var routes = from s in db.Routes
                       where s.RouteDistrict == "Northport - East Northport"
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routes = routes.Where(s => s.RouteDesignator.Contains(searchString)
                                        || s.RouteDistrict.Contains(searchString)
                                        || s.RouteDistrict.Contains(searchString)
                                        || s.RouteDesignator.Contains(searchString)
                                        //|| s.ContactDesignator.Contains(searchString)
                                        );

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    routes = routes.OrderBy(s => s.RouteDesignator);
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
            return View(routes.ToList());
        }

        // GET: /Route/
        public ActionResult SouthHuntington(string sortOrder, string searchString)
        {
            ViewBag.routereportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.routereportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var routes = from s in db.Routes
                       where s.RouteDistrict == "South Huntington"
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                routes = routes.Where(s => s.RouteDesignator.Contains(searchString)
                                        || s.RouteDistrict.Contains(searchString)
                                        || s.RouteDistrict.Contains(searchString)
                                        || s.RouteDesignator.Contains(searchString)
                                        || s.RouteDesignator2.Contains(searchString));                                              
            }
            switch (sortOrder)
            {
                default:
                    routes = routes.OrderBy(s => s.RouteDesignator);
                    break;
            }
            return View(routes.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Route route = db.Routes.Find(id);
            if (route == null)
            {
                return HttpNotFound();
            }
            return View(route);
        }

        // GET: /Route/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Route/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RouteID,RouteDesignator,RouteDesignator2,RouteDistrict,RouteTimeReportAM,RouteTimeReportPM,RouteTimeArriveAM,RouteTimeArrivePM,RouteTimeShiftAM,RouteTimeShiftPM,RouteHardware,RouteSupervision,RouteMonitors,RouteSelect,RouteInactive")] Route route)
        {
            if (ModelState.IsValid)
            {
                db.Routes.Add(route);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(route);
        }

        // GET: /Route/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Route route = db.Routes.Find(id);
            if (route == null)
            {
                return HttpNotFound();
            }
            return View(route);
        }

        // POST: /Route/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RouteID,RouteDesignator,RouteDesignator2,RouteDistrict,RouteTimeReportAM,RouteTimeReportPM,RouteTimeArriveAM,RouteTimeArrivePM,RouteTimeShiftAM,RouteTimeShiftPM,RouteHardware,RouteSupervision,RouteMonitors,RouteSelect,RouteInactive")] Route route)
        {
            if (ModelState.IsValid)
            {
                db.Entry(route).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(route);
        }

        // GET: /Route/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Route route = db.Routes.Find(id);
            if (route == null)
            {
                return HttpNotFound();
            }
            return View(route);
        }

        // POST: /Route/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Route route = db.Routes.Find(id);
            db.Routes.Remove(route);
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
