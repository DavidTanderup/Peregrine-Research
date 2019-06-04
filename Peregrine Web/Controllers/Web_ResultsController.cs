using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Peregrine_Web.Models;

namespace Peregrine_Web.Controllers
{
    public class Web_ResultsController : Controller
    {
        private PeregrineResearchEntities db = new PeregrineResearchEntities();

        // GET: Web_Results
        public ActionResult Index()
        {
            return View(db.Web_Results.ToList());
        }

        // GET: Web_Results/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Web_Result web_Result = db.Web_Results.Find(id);
            if (web_Result == null)
            {
                return HttpNotFound();
            }
            return View(web_Result);
        }

        // GET: Web_Results/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Web_Results/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date,CIK,Symbol,Last_Close,C50_Day_Avg")] Web_Result web_Result)
        {
            if (ModelState.IsValid)
            {
                db.Web_Results.Add(web_Result);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(web_Result);
        }

        // GET: Web_Results/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Web_Result web_Result = db.Web_Results.Find(id);
            if (web_Result == null)
            {
                return HttpNotFound();
            }
            return View(web_Result);
        }

        // POST: Web_Results/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date,CIK,Symbol,Last_Close,C50_Day_Avg")] Web_Result web_Result)
        {
            if (ModelState.IsValid)
            {
                db.Entry(web_Result).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(web_Result);
        }

        // GET: Web_Results/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Web_Result web_Result = db.Web_Results.Find(id);
            if (web_Result == null)
            {
                return HttpNotFound();
            }
            return View(web_Result);
        }

        // POST: Web_Results/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Web_Result web_Result = db.Web_Results.Find(id);
            db.Web_Results.Remove(web_Result);
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
