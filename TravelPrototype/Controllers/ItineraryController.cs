using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelPrototype.Models;

namespace TravelPrototype.Controllers
{
    public class ItineraryController : Controller
    {
        private ItineraryDBContext db = new ItineraryDBContext();

        // GET: Itinerary
        public ActionResult Index()
        {
            return View(db.Itineraries.ToList());
        }

        // GET: Itinerary/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryModel itineraryModel = db.Itineraries.Find(id);
            if (itineraryModel == null)
            {
                return HttpNotFound();
            }
            return View(itineraryModel);
        }

        // GET: Itinerary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Itinerary/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,member_id,itinerary_id,status,first_name,last_name,destination,state,postal_code,country,begin_datetime,begin_time_zone,begin_time_zone_id,end_datetime,end_time_zone,end_time_zone_id,lat,lon,privacy,personal,business,verified,distance,duration,headline,harvested,created,updated")] ItineraryModel itineraryModel)
        {
            if (ModelState.IsValid)
            {
                db.Itineraries.Add(itineraryModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(itineraryModel);
        }

        // GET: Itinerary/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryModel itineraryModel = db.Itineraries.Find(id);
            if (itineraryModel == null)
            {
                return HttpNotFound();
            }
            return View(itineraryModel);
        }

        // POST: Itinerary/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,member_id,itinerary_id,status,first_name,last_name,destination,state,postal_code,country,begin_datetime,begin_time_zone,begin_time_zone_id,end_datetime,end_time_zone,end_time_zone_id,lat,lon,privacy,personal,business,verified,distance,duration,headline,harvested,created,updated")] ItineraryModel itineraryModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itineraryModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(itineraryModel);
        }

        // GET: Itinerary/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryModel itineraryModel = db.Itineraries.Find(id);
            if (itineraryModel == null)
            {
                return HttpNotFound();
            }
            return View(itineraryModel);
        }

        // POST: Itinerary/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ItineraryModel itineraryModel = db.Itineraries.Find(id);
            db.Itineraries.Remove(itineraryModel);
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
