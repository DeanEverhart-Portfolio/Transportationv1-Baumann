using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fvm.Areas.Home.Models;
using fvm.DAL;

namespace fvm.Areas.Home.Controllers
{
    public class CoorespondenceController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Home/Coorespondence/
        //public ActionResult Index(string sortOrder, string searchString)
        ////{
        ////    return View(db.Coorespondences.ToList());
        ////}

        // GET: /Coorespondence/
        public ActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.coorespondencedatetime = String.IsNullOrEmpty(sortOrder) ? "coorespondencedatetime_desc" : "";
            ViewBag.coorespondencecategories = sortOrder == "coorespondencecategory" ? "coorespondencecategory_desc" : "coorespondencecategory";

            var coorespondences = from s in db.Coorespondences
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                coorespondences = coorespondences.Where(s => s.CoorespondenceCategory.Contains(searchString)
                                                          || s.CoorespondenceCategorySub.Contains(searchString)
                                                          || s.CoorespondenceTextFull.Contains(searchString)
                                                          || s.CoorespondenceDate.ToString().Contains(searchString));
            }
            switch (sortOrder)
            {
                default:
                    coorespondences = coorespondences.OrderBy(s => s.CoorespondenceDate).ThenBy(s => s.CoorespondenceAMPM).ThenBy(s => s.CoorespondenceTimeHr).ThenBy(s => s.CoorespondenceTimeMin);
                    break;
                case "coorespondencedatetime_desc":
                    coorespondences = coorespondences.OrderByDescending(s => s.CoorespondenceDate).ThenByDescending(s => s.CoorespondenceAMPM).ThenByDescending(s => s.CoorespondenceTimeHr).ThenByDescending(s => s.CoorespondenceTimeMin);
                    break;

                case "coorespondencecategory":
                    coorespondences = coorespondences.OrderBy(s => s.CoorespondenceCategory).ThenBy(s => s.CoorespondenceCategorySub);
                    break;
                case "coorespondencecategory_desc":
                    coorespondences = coorespondences.OrderByDescending(s => s.CoorespondenceCategory).ThenBy(s => s.CoorespondenceCategorySub);
                    break;
            }
            return View(coorespondences);
        }

        // GET: /Home/Coorespondence/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coorespondence coorespondence = db.Coorespondences.Find(id);
            if (coorespondence == null)
            {
                return HttpNotFound();
            }
            return View(coorespondence);
        }

        // GET: /Home/Coorespondence/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Home/Coorespondence/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CoorespondenceID,CoorespondenceFrom,CoorespondenceImage,CoorespondenceCategory,CoorespondenceCategorySub,CoorespondenceText,CoorespondenceTextFull,CoorespondenceDescription,DescriptionTag,CoorespondenceDate,CoorespondenceTime,CoorespondenceTimeHr,CoorespondenceTimeMin,CoorespondenceAMPM,CoorespondenceDayOfWeek")] Coorespondence coorespondence)
        {
            if (ModelState.IsValid)
            {
                db.Coorespondences.Add(coorespondence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coorespondence);
        }

        // GET: /Home/Coorespondence/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coorespondence coorespondence = db.Coorespondences.Find(id);
            if (coorespondence == null)
            {
                return HttpNotFound();
            }
            return View(coorespondence);
        }

        // POST: /Home/Coorespondence/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CoorespondenceID,CoorespondenceFrom,CoorespondenceImage,CoorespondenceCategory,CoorespondenceCategorySub,CoorespondenceText,CoorespondenceTextFull,CoorespondenceDescription,DescriptionTag,CoorespondenceDate,CoorespondenceTime,CoorespondenceTimeHr,CoorespondenceTimeMin,CoorespondenceAMPM,CoorespondenceDayOfWeek")] Coorespondence coorespondence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(coorespondence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(coorespondence);
        }

        // GET: /Home/Coorespondence/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Coorespondence coorespondence = db.Coorespondences.Find(id);
            if (coorespondence == null)
            {
                return HttpNotFound();
            }
            return View(coorespondence);
        }

        // POST: /Home/Coorespondence/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Coorespondence coorespondence = db.Coorespondences.Find(id);
            db.Coorespondences.Remove(coorespondence);
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
