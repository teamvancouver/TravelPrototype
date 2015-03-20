namespace TravelPrototype.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SegmentsFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SegmentModels", "ItineraryModel_ID", "dbo.ItineraryModels");
            DropIndex("dbo.SegmentModels", new[] { "ItineraryModel_ID" });
            AddColumn("dbo.SegmentModels", "ItineraryModel_ID1", c => c.Int());
            CreateIndex("dbo.SegmentModels", "ItineraryModel_ID1");
            AddForeignKey("dbo.SegmentModels", "ItineraryModel_ID1", "dbo.ItineraryModels", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SegmentModels", "ItineraryModel_ID1", "dbo.ItineraryModels");
            DropIndex("dbo.SegmentModels", new[] { "ItineraryModel_ID1" });
            DropColumn("dbo.SegmentModels", "ItineraryModel_ID1");
            CreateIndex("dbo.SegmentModels", "ItineraryModel_ID");
            AddForeignKey("dbo.SegmentModels", "ItineraryModel_ID", "dbo.ItineraryModels", "ID");
        }
    }
}
