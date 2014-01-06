using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RegGadget.Models;

namespace RegGadget.Controllers
{
    public class EventController : Controller
    {
        private PublicEventContext db = new PublicEventContext();

        // GET: /Event/
        public ActionResult Index()
        {
            return View(db.PublicEvents.ToList());
        }

        // GET: /Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicEvent publicevent = db.PublicEvents.Find(id);
            if (publicevent == null)
            {
                return HttpNotFound();
            }
            return View(publicevent);
        }

        // GET: /Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,EventName,EventVenue,EventHost,EventUrl,RegUrl,NORUrl,SIUrl,StartDate,EndDate,LateRegDate,LateRegPenaltyType,LateRegPenaltyValue")] PublicEvent publicevent)
        {
            if (ModelState.IsValid)
            {
                db.PublicEvents.Add(publicevent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(publicevent);
        }

        // GET: /Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicEvent publicevent = db.PublicEvents.Find(id);
            if (publicevent == null)
            {
                return HttpNotFound();
            }
            return View(publicevent);
        }

        // POST: /Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,EventName,EventVenue,EventHost,EventUrl,RegUrl,NORUrl,SIUrl,StartDate,EndDate,LateRegDate,LateRegPenaltyType,LateRegPenaltyValue")] PublicEvent publicevent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publicevent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(publicevent);
        }

        // GET: /Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PublicEvent publicevent = db.PublicEvents.Find(id);
            if (publicevent == null)
            {
                return HttpNotFound();
            }
            return View(publicevent);
        }

        // POST: /Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PublicEvent publicevent = db.PublicEvents.Find(id);
            db.PublicEvents.Remove(publicevent);
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
