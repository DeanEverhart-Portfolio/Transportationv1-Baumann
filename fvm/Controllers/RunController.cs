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
    public class RunController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Run/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.runreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runs = from s in db.Runs
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runs = runs.Where(s => s.RunDesignator.Contains(searchString)
                                        || s.Route.RouteDesignator.Contains(searchString));

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runs = runs.OrderBy(s => s.Route.RouteDesignator)./*ThenBy(s => s.RunDesignator).ThenBy(s => s.Contact.ContactDesignator).*/ThenBy(s => s.RunAMPM).ThenBy(s => s.RunSequence);
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
            return View(runs.ToList());
        }

        // GET: /Run/
        public ActionResult Standby(string sortOrder, string searchString)
        {
            ViewBag.runreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runs = from s in db.Runs
                       where s.RunDesignator == "Standby"
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runs = runs.Where(s => s.RunDesignator.Contains(searchString)
                                        || s.Route.RouteDesignator.Contains(searchString));

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runs = runs.OrderBy(s => s.Route.RouteDesignator)./*ThenBy(s => s.RunDesignator).ThenBy(s => s.Contact.ContactDesignator).*/ThenBy(s => s.RunAMPM).ThenBy(s => s.RunSequence);
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
            return View(runs.ToList());
        }

        // GET: /Run/
        public ActionResult IndexAltSearch(string sortOrder, string searchString)
        {
            ViewBag.runreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runs = from s in db.Runs
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runs = runs.Where(s => s.Contact.ContactDesignator.Contains(searchString));

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runs = runs.OrderBy(s => s.Route.RouteDesignator).ThenBy(s => s.RunDesignator).ThenBy(s => s.Contact.ContactDesignator).ThenBy(s => s.RunAMPM).ThenBy(s => s.RunSequence);
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
            return View(runs.ToList());
        }

        // GET: /Route/
        public ActionResult NorthportEastNorthport(string sortOrder, string searchString)
        {
            ViewBag.runreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runs = from s in db.Runs
                       where s.Route.RouteDistrict == "Northport - East Northport"
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runs = runs.Where(s => s.RunDesignator.Contains(searchString)
                                        || s.Route.RouteDesignator.Contains(searchString));

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runs = runs.OrderBy(s => s.Route.RouteDesignator).ThenBy(s => s.RunDesignator).ThenBy(s => s.Contact.ContactDesignator).ThenBy(s => s.RunAMPM).ThenBy(s => s.RunSequence);
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
            return View(runs.ToList());
        }

        // GET: /Route/
        public ActionResult NorthportEastNorthportAltSearch(string sortOrder, string searchString)
        {
            ViewBag.runreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runs = from s in db.Runs
                       where s.Route.RouteDistrict == "Northport - East Northport"
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runs = runs.Where(s => s.Contact.ContactDesignator.Contains(searchString));

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runs = runs.OrderBy(s => s.Route.RouteDesignator).ThenBy(s => s.RunDesignator).ThenBy(s => s.Contact.ContactDesignator).ThenBy(s => s.RunAMPM).ThenBy(s => s.RunSequence);
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
            return View(runs.ToList());
        }


        // GET: /Route/
        public ActionResult SouthHuntington(string sortOrder, string searchString)
        {
            ViewBag.runreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runs = from s in db.Runs
                       where s.Route.RouteDistrict == "South Huntington"
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runs = runs.Where(s => s.RunDesignator.Contains(searchString)
                                        || s.Route.RouteDesignator.Contains(searchString));

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runs = runs.OrderBy(s => s.Route.RouteDesignator).ThenBy(s => s.RunDesignator).ThenBy(s => s.Contact.ContactDesignator).ThenBy(s => s.RunAMPM).ThenBy(s => s.RunSequence);
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
            return View(runs.ToList());
        }

        // GET: /Route/
        public ActionResult SouthHuntingtonAltSearch(string sortOrder, string searchString)
        {
            ViewBag.runreportam = String.IsNullOrEmpty(sortOrder) ? "routereportam_desc" : "";
            ViewBag.runreportpm = sortOrder == "routereportpm" ? "routereportpm_desc" : "routereportpm";

            var runs = from s in db.Runs
                       where s.Route.RouteDistrict == "South Huntington"
                       select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                runs = runs.Where(s => s.Contact.ContactDesignator.Contains(searchString));

                // || s.Contact.ContactDesignator.Contains(searchString)
                // || s.Contact.ContactDesignator2.Contains(searchString)
                // || s.Contact.ContactNameFirst.Contains(searchString)                                                
            }
            switch (sortOrder)
            {
                default:
                    runs = runs.OrderBy(s => s.Route.RouteDesignator).ThenBy(s => s.RunAMPM).ThenBy(s => s.RunSequence);
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
            return View(runs.ToList());
        }

        // GET: /Run/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Run run = db.Runs.Find(id);
            if (run == null)
            {
                return HttpNotFound();
            }
            return View(run);
        }

        // GET: /Run/Create
        public ActionResult Create()
        {
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator");
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator");
            return View();
        }

        // POST: /Run/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RunID,RouteID,ContactID,RunDesignator,RunTime,RunAMPM,RunSequence,RunDayOfWeek,RunDistrict,RunHardware,RunSupervision,RunMonitors,RunSelect,RunInactive")] Run run)
        {
            if (ModelState.IsValid)
            {
                db.Runs.Add(run);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", run.ContactID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", run.RouteID);
            return View(run);
        }

        // GET: /Run/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Run run = db.Runs.Find(id);
            if (run == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", run.ContactID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", run.RouteID);
            return View(run);
        }

        // POST: /Run/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RunID,RouteID,ContactID,RunDesignator,RunTime,RunAMPM,RunSequence,RunDayOfWeek,RunDistrict,RunHardware,RunSupervision,RunMonitors,RunSelect,RunInactive")] Run run)
        {
            if (ModelState.IsValid)
            {
                db.Entry(run).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", run.ContactID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", run.RouteID);
            return View(run);
        }

        // GET: /Run/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Run run = db.Runs.Find(id);
            if (run == null)
            {
                return HttpNotFound();
            }
            return View(run);
        }

        // POST: /Run/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Run run = db.Runs.Find(id);
            db.Runs.Remove(run);
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
