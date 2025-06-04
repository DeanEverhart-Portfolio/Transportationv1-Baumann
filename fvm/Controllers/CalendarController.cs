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
    public class CalendarController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Calendar/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            DateTime SevenDays = DateTime.Today.AddDays(7);

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where (s.CalendarDateStart >= DateTime.Today & s.CalendarDateStart <= SevenDays)
                                && s.CalendarDatePublish == null
                                && s.CalendarInactive == null
                                || s.CalendarDisplay != null
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderBy(s => s.CalendarDisplay).ThenBy(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult School(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart >= DateTime.Today
                            && s.CalendarDatePublish == null
                            && s.Contact.ContactCategory == "Client"
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderBy(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult Employee(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart >= DateTime.Today
                            && s.CalendarDatePublish == null
                            && s.Contact.ContactCategory == "Employee"
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderBy(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        public ActionResult EmployeeOffice(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart >= DateTime.Today
                            && s.CalendarDatePublish == null
                            && s.Contact.ContactTitle == "Office"
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderBy(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult All(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart >= DateTime.Today
                            //&& s.CalendarDatePublish == null
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderBy(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult Publish(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart >= DateTime.Today
                               && (s.Contact.ContactCategory == "Client"
                               || s.Contact.ContactCategory == "Holiday"
                               || s.CalendarDateCategory == "Professional Development")
                               && s.CalendarDatePublish == null
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderBy(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult PublishCOVID19(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart >= DateTime.Today
                               && (s.CalendarDateAdditionalInformation == "Covid-19"
                               && s.CalendarDatePublish == null)
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderBy(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        //____________________________________________ Past ______________________________________________

        // GET: /Calendar/
        public ActionResult Past(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart <= DateTime.Today
                            && s.CalendarDatePublish == null
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderBy(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult PastAll(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart <= DateTime.Today
                            //&& s.CalendarDatePublish == null
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderBy(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult PastEmployee(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart <= DateTime.Today
                            && s.CalendarDatePublish == null
                            && s.Contact.ContactCategory == "Employee"
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderBy(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        // GET: /Calendar/
        public ActionResult PastSchool(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var calendars = from s in db.Calendars.Include(c => c.Contact)
                            where s.CalendarDateStart <= DateTime.Today
                            && s.CalendarDatePublish == null
                            && s.Contact.ContactCategory == "Client"
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                calendars = calendars.Where(s => s.Contact.ContactDesignator.Contains(searchString)
                                                || s.CalendarDateStart.ToString().Contains(searchString)
                                                || s.CalendarDateItem.Contains(searchString)
                                                || s.CalendarDateCategory.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    calendars = calendars.OrderByDescending(s => s.CalendarDateStart).ThenBy(s => s.CalendarDateCategory).ThenBy(s => s.Contact.ContactDesignator);
                    break;
                case "calendardate_desc":
                    calendars = calendars.OrderBy(s => s.CalendarDateStart);
                    break;
                case "contactdesignator":
                    calendars = calendars.OrderBy(s => s.Contact.ContactDesignator).ThenBy(s => s.CalendarDate);
                    break;
                case "contactdesignator_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactDesignator);
                    break;
                case "contactschooldistrict":
                    calendars = calendars.OrderBy(s => s.Contact.ContactSchoolDistrict).ThenBy(s => s.CalendarDate);
                    break;
                case "contactschooldistrict_desc":
                    calendars = calendars.OrderByDescending(s => s.Contact.ContactSchoolDistrict);
                    break;
            }
            return View(calendars);
        }

        //{
        //    var calendars = db.Calendars.Include(c => c.Contact);
        //    return View(calendars.ToList());
        //}


        // GET: /Calendar/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calendar calendar = db.Calendars.Find(id);
            if (calendar == null)
            {
                return HttpNotFound();
            }
            return View(calendar);
        }

        // GET: /Calendar/Create
        public ActionResult Create()
        {
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator");
            return View();
        }

        // POST: /Calendar/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CalendarID,ContactID,CalendarDateDayOfWeek,CalendarDateItem,CalendarDateCategory,CalendarDateStart,CalendarDateEnd1,CalendarDateEnd2,CalendarDateReturn,CalendarDateAdditionalInformation,CalendarDateTimeDismissalText,CalendarDateDayOfWeekReturn,CalendarDatePublish,CalendarSelect,CalendarInactive,CalendarDate,CalendarDateHoliday,CalendarDateSchoolEvent,CalendarDateTimeDismissal,CalendarDateFirst,CalendarDateLast,CalendarDisplay")] Calendar calendar)
        {
            if (ModelState.IsValid)
            {
                db.Calendars.Add(calendar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", calendar.ContactID);
            return View(calendar);
        }

        // GET: /Calendar/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calendar calendar = db.Calendars.Find(id);
            if (calendar == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", calendar.ContactID);
            return View(calendar);
        }

        // POST: /Calendar/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CalendarID,ContactID,CalendarDateDayOfWeek,CalendarDateItem,CalendarDateCategory,CalendarDateStart,CalendarDateEnd1,CalendarDateEnd2,CalendarDateReturn,CalendarDateAdditionalInformation,CalendarDateTimeDismissalText,CalendarDateDayOfWeekReturn,CalendarDatePublish,CalendarSelect,CalendarInactive,CalendarDate,CalendarDateHoliday,CalendarDateSchoolEvent,CalendarDateTimeDismissal,CalendarDateFirst,CalendarDateLast,CalendarDisplay")] Calendar calendar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calendar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", calendar.ContactID);
            return View(calendar);
        }

        // GET: /Calendar/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calendar calendar = db.Calendars.Find(id);
            if (calendar == null)
            {
                return HttpNotFound();
            }
            return View(calendar);
        }

        // POST: /Calendar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calendar calendar = db.Calendars.Find(id);
            db.Calendars.Remove(calendar);
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
