using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Script.Serialization;
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
        public IHttpActionResult GetItineraries()
        {
            //return Request.CreateResponse(HttpStatusCode.OK);
            //var responseStringBuilder = new StringBuilder();
            List<ItineraryModel> itineraryModelList = db.Itineraries.ToList<ItineraryModel>();
            itineraryModelList[0].segments = db.Segments.ToList<SegmentModel>();

            for (int i = 0; i < itineraryModelList.Count; i++)
            {
                itineraryModelList[i].segments = db.Segments.ToList<SegmentModel>();
            }


            string jsonResponse = (new JavaScriptSerializer()).Serialize(itineraryModelList);
            return Ok(jsonResponse);
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
            return db.Itineraries.Count(e => e.id == id) > 0;
        }
    }
}