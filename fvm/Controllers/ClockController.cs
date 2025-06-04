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
    public class ClockController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Clock/
        //public ActionResult Index()
        //{
        //    var clocks = db.Clocks.Include(c => c.Contact).Include(c => c.Equipment).Include(c => c.Route);
        //    return View(clocks.ToList());
        //}

        // GET: /Clock/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.clocksequence = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var clocks = from s in db.Clocks.Include(c => c.Contact).Include(c => c.Equipment).Include(c => c.Route)
                         where s.ClockInactive == null
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                clocks = clocks.Where(s => s.Route.RouteDesignator.ToString().Contains(searchString)
                                        || s.Equipment.EquipmentDesignator.ToString().Contains(searchString)
                                        || s.ClockRunDesignator.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    clocks = clocks.OrderBy(s => s.Route.RouteDesignator).ThenBy(s => s.ClockTime);
                    break;
                //case "calendardate_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                //case "contactdesignator":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactdesignator_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                //    break;
                //case "contactschooldistrict":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactschooldistrict_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                //    break;
            }
            return View(clocks);
        }

        // GET: /Clock/
        public ActionResult Contact(string sortOrder, string searchString)
        {
            ViewBag.clocksequence = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var clocks = from s in db.Clocks.Include(c => c.Contact).Include(c => c.Equipment).Include(c => c.Route)
                            where s.ClockInactive == null
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                clocks = clocks.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.ClockTime.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    clocks = clocks.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.ClockTime);
                    break;
                //case "calendardate_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                //case "contactdesignator":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactdesignator_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                //    break;
                //case "contactschooldistrict":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactschooldistrict_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                //    break;
            }
            return View(clocks);
        }

        // GET: /Clock/
        public ActionResult Time(string sortOrder, string searchString)
        {
            ViewBag.clocksequence = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var clocks = from s in db.Clocks.Include(c => c.Contact).Include(c => c.Equipment).Include(c => c.Route)
                         //where s.ClockTime >= DateTime.Now
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                clocks = clocks.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.ClockTime.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    clocks = clocks.OrderBy(s => s.ClockTime);
                    break;
                //case "calendardate_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                //case "contactdesignator":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactdesignator_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                //    break;
                //case "contactschooldistrict":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactschooldistrict_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                //    break;
            }
            return View(clocks);
        }

        // GET: /Clock/
        public ActionResult Clock(string sortOrder, string searchString)
        {
            ViewBag.clocksequence = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var clocks = from s in db.Clocks.Include(c => c.Contact).Include(c => c.Equipment).Include(c => c.Route)
                         where s.ClockTime >= DateTime.Now
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                clocks = clocks.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.ClockTime.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    clocks = clocks.OrderBy(s => s.ClockTime);
                    break;
                //case "calendardate_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                //case "contactdesignator":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactdesignator_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                //    break;
                //case "contactschooldistrict":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactschooldistrict_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                //    break;
            }
            return View(clocks);
        }

        // GET: /Clock/
        public ActionResult Equipment(string sortOrder, string searchString)
        {
            ViewBag.clocksequence = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            //ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            //ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var clocks = from s in db.Clocks.Include(c => c.Contact).Include(c => c.Equipment).Include(c => c.Route)
                         where s.ClockInactive == null
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                clocks = clocks.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.ClockTime.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    clocks = clocks.OrderBy(s => s.Equipment.EquipmentType).ThenBy(s => s.Equipment.EquipmentDesignator);
                    break;
                //case "calendardate_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                //case "contactdesignator":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactdesignator_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                //    break;
                //case "contactschooldistrict":
                //    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                //    break;
                //case "contactschooldistrict_desc":
                //    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                //    break;
            }
            return View(clocks);
        }

        // GET: /Clock/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clock clock = db.Clocks.Find(id);
            if (clock == null)
            {
                return HttpNotFound();
            }
            return View(clock);
        }

        // GET: /Clock/Create
        public ActionResult Create()
        {
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator");
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator");
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator");
            return View();
        }

        // POST: /Clock/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClockID,ContactID,EquipmentID,RouteID,ClockRunDesignator,ClockTime,ClockTimeAMPM,ClockDayOfWeek")] Clock clock)
        {
            if (ModelState.IsValid)
            {
                db.Clocks.Add(clock);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", clock.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", clock.EquipmentID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", clock.RouteID);
            return View(clock);
        }

        // GET: /Clock/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clock clock = db.Clocks.Find(id);
            if (clock == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", clock.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", clock.EquipmentID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", clock.RouteID);
            return View(clock);
        }

        // POST: /Clock/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClockID,ContactID,EquipmentID,RouteID,ClockRunDesignator,ClockTime,ClockTimeAMPM,ClockDayOfWeek    ")] Clock clock)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clock).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", clock.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", clock.EquipmentID);
            ViewBag.RouteID = new SelectList(db.Routes, "RouteID", "RouteDesignator", clock.RouteID);
            return View(clock);
        }

        // GET: /Clock/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clock clock = db.Clocks.Find(id);
            if (clock == null)
            {
                return HttpNotFound();
            }
            return View(clock);
        }

        // POST: /Clock/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Clock clock = db.Clocks.Find(id);
            db.Clocks.Remove(clock);
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
