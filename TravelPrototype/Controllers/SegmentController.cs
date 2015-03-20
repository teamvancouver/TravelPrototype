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
    public class SegmentController : Controller
    {
        private ItineraryDBContext db = new ItineraryDBContext();

        // GET: Segment
        public ActionResult Index()
        {
            return View(db.Segments.ToList());
        }

        // GET: Segment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SegmentModel segmentModel = db.Segments.Find(id);
            if (segmentModel == null)
            {
                return HttpNotFound();
            }
            return View(segmentModel);
        }

        // GET: Segment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Segment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,member_id,type,status,hotel_name,normalized_hotel_chain,phone,first_name,last_name,address1,address2,city_name,admin_code,country,zip,lat,lon,checkin_date,checkin_time_zone,checkout_date,checkout_time_zone,time_zone_id,price,currency,number_of_rooms,confirmation_no,support_phone,booking_agent,room_type,room_description,rate_description,cancellation_policy,source,harvested,hotel_notes,created,updated,metadata,airline,iata_code,normalized_airline,flight_num,seat_assignment,origin,origin_city_name,origin_admin_code,origin_country,origin_lat,origin_lon,departure_datetime,departure_time_zone,departure_time_zone_id,arrival_datetime,arrival_time_zone,arrival_time_zone_id,pax_number,ticket_number,class_of_service,meal,stops,duration,equipment_code,equipment_type,departure_terminal,departure_gate,arrival_terminal,arrival_gate,air_notes,car_company,normalized_car_company,pickup_address1,pickup_address2,pickup_city_name,pickup_city_code,pickup_admin_code,pickup_country,pickup_zip,pickup_lat,pickup_lon,pickup_datetime,pickup_time_zone,pickup_time_zone_id,dropoff_address1,dropoff_address2,dropoff_city_name,dropoff_city_code,dropoff_admin_code,dropoff_country,dropoff_zip,dropoff_lat,dropoff_lon,dropoff_datetime,dropoff_time_zone,dropoff_time_zone_id,reservation_id,car_type,car_description,hours_of_operation,car_notes,activity_type,activity_name,end_address1,end_address2,end_city_name,end_admin_code,end_country,end_zip,end_lat,end_lon,start_datetime,start_time_zone,start_time_zone_id,end_datetime,end_time_zone,end_time_zone_id,activity_notes")] SegmentModel segmentModel)
        {
            if (ModelState.IsValid)
            {
                db.Segments.Add(segmentModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(segmentModel);
        }

        // GET: Segment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SegmentModel segmentModel = db.Segments.Find(id);
            if (segmentModel == null)
            {
                return HttpNotFound();
            }
            return View(segmentModel);
        }

        // POST: Segment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,member_id,type,status,hotel_name,normalized_hotel_chain,phone,first_name,last_name,address1,address2,city_name,admin_code,country,zip,lat,lon,checkin_date,checkin_time_zone,checkout_date,checkout_time_zone,time_zone_id,price,currency,number_of_rooms,confirmation_no,support_phone,booking_agent,room_type,room_description,rate_description,cancellation_policy,source,harvested,hotel_notes,created,updated,metadata,airline,iata_code,normalized_airline,flight_num,seat_assignment,origin,origin_city_name,origin_admin_code,origin_country,origin_lat,origin_lon,departure_datetime,departure_time_zone,departure_time_zone_id,arrival_datetime,arrival_time_zone,arrival_time_zone_id,pax_number,ticket_number,class_of_service,meal,stops,duration,equipment_code,equipment_type,departure_terminal,departure_gate,arrival_terminal,arrival_gate,air_notes,car_company,normalized_car_company,pickup_address1,pickup_address2,pickup_city_name,pickup_city_code,pickup_admin_code,pickup_country,pickup_zip,pickup_lat,pickup_lon,pickup_datetime,pickup_time_zone,pickup_time_zone_id,dropoff_address1,dropoff_address2,dropoff_city_name,dropoff_city_code,dropoff_admin_code,dropoff_country,dropoff_zip,dropoff_lat,dropoff_lon,dropoff_datetime,dropoff_time_zone,dropoff_time_zone_id,reservation_id,car_type,car_description,hours_of_operation,car_notes,activity_type,activity_name,end_address1,end_address2,end_city_name,end_admin_code,end_country,end_zip,end_lat,end_lon,start_datetime,start_time_zone,start_time_zone_id,end_datetime,end_time_zone,end_time_zone_id,activity_notes")] SegmentModel segmentModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(segmentModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(segmentModel);
        }

        // GET: Segment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SegmentModel segmentModel = db.Segments.Find(id);
            if (segmentModel == null)
            {
                return HttpNotFound();
            }
            return View(segmentModel);
        }

        // POST: Segment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SegmentModel segmentModel = db.Segments.Find(id);
            db.Segments.Remove(segmentModel);
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
