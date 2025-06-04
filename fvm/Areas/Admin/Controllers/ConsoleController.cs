using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using fvm.Areas.Admin.Models;
using fvm.DAL;

namespace fvm.Areas.Admin.Controllers
{
    public class ConsoleController : Controller
    {
        private fvmcontext db = new fvmcontext();

        // GET: /Admin/Console/
        public ActionResult Index()
        {
            return View(db.Admin1s.ToList());
        }

        // GET: /Admin/Console/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin1 admin1 = db.Admin1s.Find(id);
            if (admin1 == null)
            {
                return HttpNotFound();
            }
            return View(admin1);
        }

        // GET: /Admin/Console/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Admin/Console/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Admin1ID,Admin1String")] Admin1 admin1)
        {
            if (ModelState.IsValid)
            {
                db.Admin1s.Add(admin1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admin1);
        }

        // GET: /Admin/Console/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin1 admin1 = db.Admin1s.Find(id);
            if (admin1 == null)
            {
                return HttpNotFound();
            }
            return View(admin1);
        }

        // POST: /Admin/Console/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Admin1ID,Admin1String")] Admin1 admin1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admin1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admin1);
        }

        // GET: /Admin/Console/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admin1 admin1 = db.Admin1s.Find(id);
            if (admin1 == null)
            {
                return HttpNotFound();
            }
            return View(admin1);
        }

        // POST: /Admin/Console/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admin1 admin1 = db.Admin1s.Find(id);
            db.Admin1s.Remove(admin1);
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
