using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
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
            //Trace.WriteLine("START PostItin");
            //Trace.WriteLine("Request Header:");
            //Trace.WriteLine(Request.Content.Headers.ToString());
            //Trace.WriteLine("Request JSON:");
            //Trace.WriteLine(Itin.ToString());
            var response = Ok(Itin);
            //Trace.WriteLine("Response JSON:");
            //Trace.WriteLine(response.Content.ToString());
            //Trace.WriteLine("END PostItin");
            return response;
        }
    }
}
