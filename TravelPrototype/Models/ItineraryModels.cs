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

        public List<SegmentModel> segments { get; set; }

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

    //Segments 
    public class SegmentModel
    {
        public int id { get; set; }
        public int member_id { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string hotel_name { get; set; }
        public string normalized_hotel_chain { get; set; }
        public string phone { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city_name { get; set; }
        public string admin_code { get; set; }
        //public enum country country { get; set; }
        public string zip { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public DateTime checkin_date { get; set; }
        //public enum time_zone checkin_time_zone { get; set; }
        public DateTime checkout_date { get; set; }
        //public enum time_zone checkout_time_zone { get; set; }
        public string time_zone_id { get; set; }
        public float price { get; set; }
        //public enum Currency currency { get; set; }
        public int number_of_rooms { get; set; }
        public string confirmation_no { get; set; }
        public string support_phone { get; set; }
        public Uri support_url { get; set; }
        public string booking_agent { get; set; }
        public string room_type { get; set; }
        public string room_description { get; set; }
        public string rate_description { get; set; }
        public string cancellation_policy { get; set; }
        public Uri icon_url  { get; set; }
        public Uri image_url { get; set; }
        public string source { get; set; }
        public string harvested { get; set; }
        public string hotel_notes { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public string metadata { get; set; }

    }
}