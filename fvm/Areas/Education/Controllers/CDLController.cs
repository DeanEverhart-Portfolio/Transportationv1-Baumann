using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fvm.Areas.Education.Models;
using fvm.DAL;

namespace fvm.Areas.Education.Controllers
{
    public class CDLController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Education/CDL/
        public ActionResult Index()
        {
            return View(db.CDLs.ToList());
        }

        // GET: /Education/CDL/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CDL cdl = db.CDLs.Find(id);
            if (cdl == null)
            {
                return HttpNotFound();
            }
            return View(cdl);
        }

        // GET: /Education/CDL/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Education/CDL/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="CDLID,CDLCategory,CDLCategorySub,CDLTag,CDLText1,CDLText2,CDLChapter,CDLPage,CDLSelect,CDLInactive")] CDL cdl)
        {
            if (ModelState.IsValid)
            {
                db.CDLs.Add(cdl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cdl);
        }

        // GET: /Education/CDL/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CDL cdl = db.CDLs.Find(id);
            if (cdl == null)
            {
                return HttpNotFound();
            }
            return View(cdl);
        }

        // POST: /Education/CDL/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="CDLID,CDLCategory,CDLCategorySub,CDLTag,CDLText1,CDLText2,CDLChapter,CDLPage,CDLSelect,CDLInactive")] CDL cdl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cdl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cdl);
        }

        // GET: /Education/CDL/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CDL cdl = db.CDLs.Find(id);
            if (cdl == null)
            {
                return HttpNotFound();
            }
            return View(cdl);
        }

        // POST: /Education/CDL/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CDL cdl = db.CDLs.Find(id);
            db.CDLs.Remove(cdl);
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
