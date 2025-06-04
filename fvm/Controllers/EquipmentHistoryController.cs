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
    public class EquipmentHistoryController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /EquipmentHistory/
        public ActionResult Index()
        {
            var equipmenthistories = db.EquipmentHistories.Include(e => e.Contact).Include(e => e.Equipment);
            return View(equipmenthistories.ToList());
        }

        // GET: /EquipmentHistory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentHistory equipmenthistory = db.EquipmentHistories.Find(id);
            if (equipmenthistory == null)
            {
                return HttpNotFound();
            }
            return View(equipmenthistory);
        }

        // GET: /EquipmentHistory/Create
        public ActionResult Create()
        {
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator");
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator");
            return View();
        }

        // POST: /EquipmentHistory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="EquipmentHistoryID,EquipmentID,ContactID,EquipmentHistoryDate,EquipmentHistoryCategory,EquipmentHistoryCategorySub,EquipmentHistoryNote,EquipmentHistorySelect,EquipmentHistoryInactive")] EquipmentHistory equipmenthistory)
        {
            if (ModelState.IsValid)
            {
                db.EquipmentHistories.Add(equipmenthistory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", equipmenthistory.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", equipmenthistory.EquipmentID);
            return View(equipmenthistory);
        }

        // GET: /EquipmentHistory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentHistory equipmenthistory = db.EquipmentHistories.Find(id);
            if (equipmenthistory == null)
            {
                return HttpNotFound();
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", equipmenthistory.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", equipmenthistory.EquipmentID);
            return View(equipmenthistory);
        }

        // POST: /EquipmentHistory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="EquipmentHistoryID,EquipmentID,ContactID,EquipmentHistoryDate,EquipmentHistoryCategory,EquipmentHistoryCategorySub,EquipmentHistoryNote,EquipmentHistorySelect,EquipmentHistoryInactive")] EquipmentHistory equipmenthistory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipmenthistory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ContactID = new SelectList(db.Contacts, "ContactID", "ContactDesignator", equipmenthistory.ContactID);
            ViewBag.EquipmentID = new SelectList(db.Equipments, "EquipmentID", "EquipmentDesignator", equipmenthistory.EquipmentID);
            return View(equipmenthistory);
        }

        // GET: /EquipmentHistory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EquipmentHistory equipmenthistory = db.EquipmentHistories.Find(id);
            if (equipmenthistory == null)
            {
                return HttpNotFound();
            }
            return View(equipmenthistory);
        }

        // POST: /EquipmentHistory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EquipmentHistory equipmenthistory = db.EquipmentHistories.Find(id);
            db.EquipmentHistories.Remove(equipmenthistory);
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
