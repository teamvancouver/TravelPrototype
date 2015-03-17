using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TravelPrototype.Models;

namespace TravelPrototype.api
{
    [RoutePrefix("itineraries")]
    public class TraxoController : ApiController
    {
        private ItineraryDBContext db = new ItineraryDBContext();

        // GET: api/Traxo
        [HttpGet]
        [Route("")]
        public IQueryable<ItineraryModel> GetItineraries()
        {
            //return Request.CreateResponse(HttpStatusCode.OK);
            List<ItineraryModel> itineraryModelList = db.Itineraries.ToList<ItineraryModel>();
            return db.Itineraries;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItineraryModelExists(int id)
        {
            return db.Itineraries.Count(e => e.ID == id) > 0;
        }
    }
}