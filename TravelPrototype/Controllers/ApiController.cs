using System;
using System.Collections.Generic;
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
    }
}
