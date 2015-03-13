using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Tracing;
using TravelPrototype.Models;

namespace TravelPrototype.Controllers
{
    public class ItineraryServiceAPIController : ApiController
    {
        private ItineraryDBContext db = new ItineraryDBContext();

        // GET: ItineraryServiceAPI
        public IQueryable<ItineraryModel> GetItineraries()
        {
            return db.Itineraries;
        }

        // POST: ItineraryServiceAPI
        public IHttpActionResult PostItin(ItineraryModel Itin)
        {
            //example Custom Trace
            Configuration.Services.GetTraceWriter().Info(Request, "TravelPrototype.Controllers.ItineraryServiceAPIController", "Test");
            var response = Ok(Itin);
            return response;
        }
    }
}
