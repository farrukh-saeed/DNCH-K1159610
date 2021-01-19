using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DNCHK_K1159610.Models;

namespace DNCHK_K1159610.Controllers
{
    public class ResidentDailyReportsController : Controller
    {
        private ResidentDailyReportContext db = new ResidentDailyReportContext();

        // GET: ResidentDailyReports
        public ActionResult Index()
        {
            return View(db.ResidentDailyReports.ToList());
        }

        // GET: ResidentDailyReports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentDailyReport residentDailyReport = db.ResidentDailyReports.Find(id);
            if (residentDailyReport == null)
            {
                return HttpNotFound();
            }
            return View(residentDailyReport);
        }

        // GET: ResidentDailyReports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResidentDailyReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ResidentDailyReportID,Daily_Report_Name,Report_Details,Care_Staff_Name")] ResidentDailyReport residentDailyReport)
        {
            if (ModelState.IsValid)
            {
                db.ResidentDailyReports.Add(residentDailyReport);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(residentDailyReport);
        }

        // GET: ResidentDailyReports/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentDailyReport residentDailyReport = db.ResidentDailyReports.Find(id);
            if (residentDailyReport == null)
            {
                return HttpNotFound();
            }
            return View(residentDailyReport);
        }

        // POST: ResidentDailyReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ResidentDailyReportID,Daily_Report_Name,Report_Details,Care_Staff_Name")] ResidentDailyReport residentDailyReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(residentDailyReport).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(residentDailyReport);
        }

        // GET: ResidentDailyReports/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ResidentDailyReport residentDailyReport = db.ResidentDailyReports.Find(id);
            if (residentDailyReport == null)
            {
                return HttpNotFound();
            }
            return View(residentDailyReport);
        }

        // POST: ResidentDailyReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ResidentDailyReport residentDailyReport = db.ResidentDailyReports.Find(id);
            db.ResidentDailyReports.Remove(residentDailyReport);
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
