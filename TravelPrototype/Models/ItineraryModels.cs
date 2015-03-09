using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelPrototype.Models
{
    public class ItineraryModel
    {
        public int ID { get; set; }
    }

    public class ItineraryDBContext : DbContext
    {
        public DbSet<ItineraryModel> Itineraries { get; set; }
    }
}