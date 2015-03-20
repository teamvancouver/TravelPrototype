namespace TravelPrototype.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TravelPrototype.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TravelPrototype.Models.ItineraryDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TravelPrototype.Models.ItineraryDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Itineraries.AddOrUpdate(i => i.itinerary_id,
                new ItineraryModel { ID = 30, member_id = 7, itinerary_id = 42, begin_datetime = DateTime.Now, end_datetime = DateTime.Now, personal = 0, business = 1, distance = 66, created = DateTime.Now, updated = DateTime.Now }

            );

            context.Segments.AddOrUpdate(i => i.id,
                new SegmentModel { id = 40, member_id = 9, checkin_date = DateTime.Now, checkout_date = DateTime.Now, price = 105, number_of_rooms = 5, created = DateTime.Now, updated = DateTime.Now, departure_datetime = DateTime.Now, arrival_datetime = DateTime.Now, pickup_datetime = DateTime.Now, dropoff_datetime = DateTime.Now, start_datetime = DateTime.Now, end_datetime = DateTime.Now });

        }
    }
}
