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

            context.Itineraries.AddOrUpdate(i => i.ID,
                new ItineraryModel { ID = 30, member_id = 7, itinerary_id = 42, begin_datetime = DateTime.Now, end_datetime = DateTime.Now, personal = 0, business = 1, distance = 66, created = DateTime.Now, updated = DateTime.Now }
            );
        }
    }
}
