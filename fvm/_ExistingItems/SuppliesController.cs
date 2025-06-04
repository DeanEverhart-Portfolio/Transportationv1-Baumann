using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fvm.Areas.Office.Models;
using fvm.DAL;

namespace fvm.Areas.Office.Controllers
{
    public class SuppliesController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: Office/Supplies
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var supplies = from s in db.Supplies
                            select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                supplies = supplies.Where(s => s.SupplyDesignator.Contains(searchString)
                                                || s.SupplyCategory.Contains(searchString)
                                                || s.SupplyCategorySub.Contains(searchString)
                                                || s.SupplyModelNumber.Contains(searchString)
                                                || s.SupplySerialNumber.Contains(searchString)
                                                || s.SupplyTag.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    supplies = supplies.OrderBy(s => s.SupplyCategory).ThenBy(s => s.SupplyCategorySub).ThenBy(s => s.SupplyDesignator);
                    break;
                    //case "calendardate_desc":
                    //    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
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
            return View(supplies);
        }


        //public ActionResult Index()
        //{
        //    return View(db.Supplies.ToList());
        //}

        public ActionResult Menu(string sortOrder, string searchString)
        {
            return View(db.Supplies.ToList());
        }

        public ActionResult Selection(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var supplies = from s in db.Supplies
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                supplies = supplies.Where(s => s.SupplyDesignator.Contains(searchString)
                                                || s.SupplyCategory.Contains(searchString)
                                                || s.SupplyCategorySub.Contains(searchString)
                                                || s.SupplyModelNumber.Contains(searchString)
                                                || s.SupplySerialNumber.Contains(searchString)
                                                || s.SupplyTag.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    supplies = supplies.OrderBy(s => s.SupplyCategory).ThenBy(s => s.SupplyCategorySub).ThenBy(s => s.SupplyDesignator);
                    break;
                    //case "calendardate_desc":
                    //    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
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
            return View(supplies);
        }

        public ActionResult Order(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var supplies = from s in db.Supplies
                           where s.SupplyOrderQuantity != null
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                supplies = supplies.Where(s => s.SupplyDesignator.Contains(searchString)
                                                || s.SupplyCategory.Contains(searchString)
                                                || s.SupplyCategorySub.Contains(searchString)
                                                || s.SupplyModelNumber.Contains(searchString)
                                                || s.SupplySerialNumber.Contains(searchString)
                                                || s.SupplyTag.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    supplies = supplies.OrderBy(s => s.SupplyCategory).ThenBy(s => s.SupplyCategorySub).ThenBy(s => s.SupplyDesignator);
                    break;
                    //case "calendardate_desc":
                    //    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
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
            return View(supplies);
        }

        public ActionResult Fasteners(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var supplies = from s in db.Supplies
                           where s.SupplyCategory == "Connectors"
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                supplies = supplies.Where(s => s.SupplyDesignator.Contains(searchString)
                                                || s.SupplyCategory.Contains(searchString)
                                                || s.SupplyCategorySub.Contains(searchString)
                                                || s.SupplyModelNumber.Contains(searchString)
                                                || s.SupplySerialNumber.Contains(searchString)
                                                || s.SupplyTag.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    supplies = supplies.OrderBy(s => s.SupplyCategory).ThenBy(s => s.SupplyCategorySub).ThenBy(s => s.SupplyDesignator);
                    break;
                    //case "calendardate_desc":
                    //    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
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
            return View(supplies);
        }

        public ActionResult Packaging(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var supplies = from s in db.Supplies
                           where s.SupplyCategory == "Packaging"
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                supplies = supplies.Where(s => s.SupplyDesignator.Contains(searchString)
                                                || s.SupplyCategory.Contains(searchString)
                                                || s.SupplyCategorySub.Contains(searchString)
                                                || s.SupplyModelNumber.Contains(searchString)
                                                || s.SupplySerialNumber.Contains(searchString)
                                                || s.SupplyTag.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    supplies = supplies.OrderBy(s => s.SupplyCategory).ThenBy(s => s.SupplyCategorySub).ThenBy(s => s.SupplyDesignator);
                    break;
                    //case "calendardate_desc":
                    //    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
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
            return View(supplies);
        }

        public ActionResult Pens(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var supplies = from s in db.Supplies
                           where s.SupplyCategory == "Pens"
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                supplies = supplies.Where(s => s.SupplyDesignator.Contains(searchString)
                                                || s.SupplyCategory.Contains(searchString)
                                                || s.SupplyCategorySub.Contains(searchString)
                                                || s.SupplyModelNumber.Contains(searchString)
                                                || s.SupplySerialNumber.Contains(searchString)
                                                || s.SupplyTag.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    supplies = supplies.OrderBy(s => s.SupplyCategory).ThenBy(s => s.SupplyCategorySub).ThenBy(s => s.SupplyDesignator);
                    break;
                    //case "calendardate_desc":
                    //    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
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
            return View(supplies);
        }

        public ActionResult Stationary(string sortOrder, string searchString)
        {
            ViewBag.calendardate = String.IsNullOrEmpty(sortOrder) ? "calendardate_desc" : "";
            ViewBag.contactdesignator = sortOrder == "contactdesignator" ? "contactdesignator_desc" : "contactdesignator";
            ViewBag.contactschooldistrict = sortOrder == "contactschooldistrict" ? "contactschooldistrict_desc" : "contactschooldistrict";

            var supplies = from s in db.Supplies
                           where s.SupplyCategory == "Stationary"
                           select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                supplies = supplies.Where(s => s.SupplyDesignator.Contains(searchString)
                                                || s.SupplyCategory.Contains(searchString)
                                                || s.SupplyCategorySub.Contains(searchString)
                                                || s.SupplyModelNumber.Contains(searchString)
                                                || s.SupplySerialNumber.Contains(searchString)
                                                || s.SupplyTag.Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    supplies = supplies.OrderBy(s => s.SupplyCategory).ThenBy(s => s.SupplyCategorySub).ThenBy(s => s.SupplyDesignator);
                    break;
                    //case "calendardate_desc":
                    //    calendars = calendars.OrderByDescending(s => s.CalendarDateStart);
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
            return View(supplies);
        }

        // GET: Office/Supplies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supply supply = db.Supplies.Find(id);
            if (supply == null)
            {
                return HttpNotFound();
            }
            return View(supply);
        }

        // GET: Office/Supplies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Office/Supplies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SupplyID,SupplyDesignator,SupplyModelNumber,SupplyItemNumber,SupplyVariety,SupplyColor,SupplyDescription,SupplySize,SupplyDimensions,SupplyOrderQuantity,SupplyCount,SupplyPack,SupplyQuantity,SupplyPriceString,SupplyCategory,SupplyCategorySub,SupplyTag,SupplyNote,SupplyURLAccess")] Supply supply)
        {
            if (ModelState.IsValid)
            {
                db.Supplies.Add(supply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(supply);
        }

        // GET: Office/Supplies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supply supply = db.Supplies.Find(id);
            if (supply == null)
            {
                return HttpNotFound();
            }
            return View(supply);
        }

        // POST: Office/Supplies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SupplyID,,SupplyDesignator,SupplyModelNumber,SupplyItemNumber,SupplyVariety,SupplyColor,SupplyDescription,SupplySize,SupplyDimensions,SupplyOrderQuantity,SupplyCount,SupplyPack,SupplyQuantity,SupplyPriceString,SupplyCategory,SupplyCategorySub,SupplyTag,SupplyNote,SupplyURLAccess")] Supply supply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(supply).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(supply);
        }

        // GET: Office/Supplies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Supply supply = db.Supplies.Find(id);
            if (supply == null)
            {
                return HttpNotFound();
            }
            return View(supply);
        }

        // POST: Office/Supplies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Supply supply = db.Supplies.Find(id);
            db.Supplies.Remove(supply);
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
