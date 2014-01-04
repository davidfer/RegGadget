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
    public class BoatController : Controller
    {
        private BoatDBContext db = new BoatDBContext();

        // GET: /Boat/
        public ActionResult Index()
        {
            return View(db.Boats.ToList());
        }

        // GET: /Boat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boat boat = db.Boats.Find(id);
            if (boat == null)
            {
                return HttpNotFound();
            }
            return View(boat);
        }

        // GET: /Boat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Boat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,OwnerId,SailNo,AltSailNo,BowNo,HullNo,Manufacturer,Model,HullColor,Year,ImageData,PHRFRating,IRCRating,NFSRating,OtherRating,Length,Draft,Displacement,OneDesign")] Boat boat)
        {
            if (ModelState.IsValid)
            {
                db.Boats.Add(boat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(boat);
        }

        // GET: /Boat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boat boat = db.Boats.Find(id);
            if (boat == null)
            {
                return HttpNotFound();
            }
            return View(boat);
        }

        // POST: /Boat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,OwnerId,SailNo,AltSailNo,BowNo,HullNo,Manufacturer,Model,HullColor,Year,ImageData,PHRFRating,IRCRating,NFSRating,OtherRating,Length,Draft,Displacement,OneDesign")] Boat boat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(boat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(boat);
        }

        // GET: /Boat/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Boat boat = db.Boats.Find(id);
            if (boat == null)
            {
                return HttpNotFound();
            }
            return View(boat);
        }

        // POST: /Boat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Boat boat = db.Boats.Find(id);
            db.Boats.Remove(boat);
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
