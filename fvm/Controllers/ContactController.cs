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
    public class ContactController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Contact/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           where s.ContactInactive == null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                || s.ContactDesignator2.Contains(searchString)
                                                || s.ContactNameFirst.Contains(searchString)
                                                || s.ContactTag.Contains(searchString)
                                                || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;
            }
            return View(contacts);
        }

        //{
        //    return View(db.Contacts.ToList());
        //}

        // GET: /Contact/
        public ActionResult Employee(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            //ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           where s.ContactCategory == "Employee"
                              && s.ContactInactive == null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                || s.ContactDesignator2.Contains(searchString)
                                                || s.ContactNameFirst.Contains(searchString)
                                                || s.ContactTag.Contains(searchString)
                                                || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactNameFirst).ThenBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;

            }
            return View(contacts);
        }

        // GET: /Contact/
        public ActionResult EmployeeInactive(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           where s.ContactCategory == "Employee"
                              && s.ContactInactive != null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                || s.ContactDesignator2.Contains(searchString)
                                                || s.ContactNameFirst.Contains(searchString)
                                                || s.ContactTag.Contains(searchString)
                                                || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactNameFirst).ThenBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;
            }
            return View(contacts);
        }

        // GET: /Contact/
        public ActionResult Corporate(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           where s.ContactCategory == "ABA"
                              && s.ContactInactive == null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                 || s.ContactDesignator2.Contains(searchString)
                                                 || s.ContactNameFirst.Contains(searchString)
                                                 || s.ContactTag.Contains(searchString)
                                                 || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactNameFirst).ThenBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;

            }
            return View(contacts);
        }

        // GET: /Contact/
        public ActionResult Emergency(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           where s.ContactEmergency != null
                              && s.ContactInactive == null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                || s.ContactDesignator2.Contains(searchString)
                                                || s.ContactNameFirst.Contains(searchString)
                                                || s.ContactTag.Contains(searchString)
                                                || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactNameFirst).ThenBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;

            }
            return View(contacts);
        }



        // GET: /Contact/
        public ActionResult Client(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           where s.ContactCategory == "Client"
                              && s.ContactInactive == null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                || s.ContactDesignator2.Contains(searchString)
                                                || s.ContactNameFirst.Contains(searchString)
                                                || s.ContactTag.Contains(searchString)
                                                || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;

            }
            return View(contacts);
        }

        // GET: /Contact/
        public ActionResult Vendor(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           where s.ContactCategory == "Vendor"
                              && s.ContactInactive == null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                || s.ContactDesignator2.Contains(searchString)
                                                || s.ContactNameFirst.Contains(searchString)
                                                || s.ContactTag.Contains(searchString)
                                                || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;

            }
            return View(contacts);
        }

        // GET: /Contact/
        public ActionResult All(string sortOrder, string searchString)
        {
            ViewBag.contactdesignator = String.IsNullOrEmpty(sortOrder) ? "contactdesignator_desc" : "";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";
            ViewBag.contactaddresscitytown = sortOrder == "contactaddresscitytown" ? "contactaddresscitytown_desc" : "contactaddresscitytown";

            var contacts = from s in db.Contacts
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                contacts = contacts.Where(s => s.ContactDesignator.Contains(searchString)
                                                || s.ContactDesignator2.Contains(searchString)
                                                || s.ContactNameFirst.Contains(searchString)
                                                || s.ContactTag.Contains(searchString)
                                                || s.ContactSchoolDistrict.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    contacts = contacts.OrderBy(s => s.ContactDesignator);
                    break;
                //case "date_desc":
                //    calendars = calendars.OrderByDescending(s => s.CalendarDate);
                //    break;
                case "contactschooldistrict":
                    contacts = contacts.OrderBy(s => s.ContactSchoolDistrict).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactschooldistrict_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactSchoolDistrict);
                    break;
                case "contactaddresscitytown":
                    contacts = contacts.OrderBy(s => s.ContactAddressCityTown).ThenBy(s => s.ContactDesignator);
                    break;
                case "contactaddresscitytown_desc":
                    contacts = contacts.OrderByDescending(s => s.ContactAddressCityTown);
                    break;
            }
            return View(contacts);
        }

        // GET: /Contact/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: /Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Contact/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ContactID,ContactDesignator,ContactCategory,ContactTitle,ContactLicense,ContactDesignator2,ContactNameFirst,ContactTag,ContactEmployeeID,ContactDateHire,ContactDatePick,ContactDateSeniority,ContactSchoolDistrict,ContactPhoneLabel1,ContactPhoneAreaCode1,ContactPhone1,ContactEmergency,ContactNote,ContactPhoneLabel2,ContactPhoneAreaCode2,ContactPhone2,ContactPhoneLabel3,ContactPhoneAreaCode3,ContactPhone3,ContactWirelessCarrier,ContactAddressStreetNumber1,ContactAddressStreet1,ContactAddressStreetType1,ContactAddressStreetNumber2,ContactAddressStreet2,ContactAddressStreetType2,ContactAddressCityTown,ContactAddressZipCode,ContactEmail,ContactWebsite,ContactCalendarOneSheet,ContactCalendarWebsite,ContactCalendarPublished,ContactWebsiteCalendar,ContactCalendar,ContactAddressDirections,ContactAddressMap,ContactSelect,ContactInactive,ContactTimeArriveAM,ContactTimeArrivePM")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // GET: /Contact/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: /Contact/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ContactID,ContactDesignator,ContactCategory,ContactTitle,ContactLicense,ContactDesignator2,ContactNameFirst,ContactTag,ContactEmployeeID,ContactDateHire,ContactDatePick,ContactDateSeniority,ContactSchoolDistrict,ContactPhoneLabel1,ContactPhoneAreaCode1,ContactPhone1,ContactEmergency,ContactNote,ContactPhoneLabel2,ContactPhoneAreaCode2,ContactPhone2,ContactPhoneLabel3,ContactPhoneAreaCode3,ContactPhone3,ContactWirelessCarrier,ContactAddressStreetNumber1,ContactAddressStreet1,ContactAddressStreetType1,ContactAddressStreetNumber2,ContactAddressStreet2,ContactAddressStreetType2,ContactAddressCityTown,ContactAddressZipCode,ContactEmail,ContactWebsite,ContactCalendarOneSheet,ContactCalendarWebsite,ContactCalendarPublished,ContactWebsiteCalendar,ContactCalendar,ContactAddressDirections,ContactAddressMap,ContactSelect,ContactInactive,ContactTimeArriveAM,ContactTimeArrivePM")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: /Contact/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: /Contact/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
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
