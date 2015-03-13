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
        public int member_id { get; set; }
        public int itinerary_id { get; set; }
        public string status { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string destination { get; set; }
        public string state { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public DateTime begin_datetime { get; set; }
        public string begin_time_zone { get; set; }
        public string begin_time_zone_id { get; set; }
        public DateTime end_datetime { get; set; }
        public string end_time_zone { get; set; }
        public string end_time_zone_id { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string privacy { get; set; }
        public int personal { get; set; }
        public int business { get; set; }
        public string verified { get; set; }
        public float distance { get; set; }
        public string duration { get; set; }
        public string headline { get; set; }
        public Uri url { get; set; }
        public string harvested { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }

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
        public string country { get; set; }
        public string zip { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public DateTime checkin_date { get; set; }
        //public enum time_zone checkin_time_zone { get; set; }
        public string checkin_time_zone { get; set; }
        public DateTime checkout_date { get; set; }
        //public enum time_zone checkout_time_zone { get; set; }
        public string checkout_time_zone { get; set; }
        public string time_zone_id { get; set; }
        public float price { get; set; }
        //public enum Currency currency { get; set; }
        public string currency { get; set; }
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

        // Air
        public string airline { get; set; }
        public string iata_code { get; set; }
        public string normalized_airline { get; set; }
        public string flight_num { get; set; }
        public string seat_assignment { get; set; }
        public string origin { get; set; }
        public string origin_city_name { get; set; }
        public string origin_admin_code { get; set; }
        public string origin_country { get; set; }
        public string origin_lat { get; set; }
        public string origin_lon { get; set; }
        public DateTime departure_datetime { get; set; }
        public string departure_time_zone { get; set; }
        public string departure_time_zone_id { get; set; }
        public DateTime arrival_datetime { get; set; }
        public string arrival_time_zone { get; set; }
        public string arrival_time_zone_id { get; set; }
        public string pax_number { get; set; }
        public string ticket_number { get; set; }
        public string class_of_service { get; set; }
        public string meal { get; set; }
        public string stops { get; set; }
        public string duration { get; set; }
        public string equipment_code { get; set; }
        public string equipment_type { get; set; }
        public string departure_terminal { get; set; }
        public string departure_gate { get; set; }
        public string arrival_terminal { get; set; }
        public string arrival_gate { get; set; }
        public string air_notes { get; set; }

        // Car
        public string car_company { get; set; }
        public string normalized_car_company { get; set; }
        public string pickup_address1 { get; set; }
        public string pickup_address2 { get; set; }
        public string pickup_city_name { get; set; }
        public string pickup_city_code { get; set; }
        public string pickup_admin_code { get; set; }
        public string pickup_country { get; set; }
        public string pickup_zip { get; set; }
        public string pickup_lat { get; set; }
        public string pickup_lon { get; set; }
        public DateTime pickup_datetime { get; set; }
        public string pickup_time_zone { get; set; }
        public string pickup_time_zone_id { get; set; }
        public string dropoff_address1 { get; set; }
        public string dropoff_address2 { get; set; }
        public string dropoff_city_name { get; set; }
        public string dropoff_city_code { get; set; }
        public string dropoff_admin_code { get; set; }
        public string dropoff_country { get; set; }
        public string dropoff_zip { get; set; }
        public string dropoff_lat { get; set; }
        public string dropoff_lon { get; set; }
        public DateTime dropoff_datetime { get; set; }
        public string dropoff_time_zone { get; set; }
        public string dropoff_time_zone_id { get; set; }
        public string reservation_id { get; set; }
        public string car_type { get; set; }
        public string car_description { get; set; }
        public string hours_of_operation { get; set; }
        public string car_notes { get; set; }


        // Activity
        public string activity_type { get; set; }
        public string activity_name { get; set; }
        public string end_address1 { get; set; }
        public string end_address2 { get; set; }
        public string end_city_name { get; set; }
        public string end_admin_code { get; set; }
        public string end_country { get; set; }
        public string end_zip { get; set; }
        public string end_lat { get; set; }
        public string end_lon { get; set; }
        public DateTime start_datetime { get; set; }
        public string start_time_zone { get; set; }
        public string start_time_zone_id { get; set; }
        public DateTime end_datetime { get; set; }
        public string end_time_zone { get; set; }
        public string end_time_zone_id { get; set; }
        public string activity_notes { get; set; }


    }
}