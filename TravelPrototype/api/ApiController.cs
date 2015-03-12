﻿using System;
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
        public HttpResponseMessage PostItin(ItineraryModel Itin)
        {
            Trace.WriteLine("PostItin reached");
            Trace.WriteLine(Itin.ToString());
            return Request.CreateResponse(HttpStatusCode.OK, "Dein Post ist voll total supi");
        }
    }
}
