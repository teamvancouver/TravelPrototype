using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace TravelPrototype.Models
{
    public class ItineraryModel
    {
        public int ID { get; set; }
        public string Purpose { get { return "Test"; } }

        public override string ToString()
        {
            string json = (new JavaScriptSerializer()).Serialize(this);
            return json;
        }
    }

    public class ItineraryDBContext : DbContext
    {
        public DbSet<ItineraryModel> Itineraries { get; set; }
    }
}