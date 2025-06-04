namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteTimeReport1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RouteTimeReportAM", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Route", "RouteTimeReportPM", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "RouteTimeReportPM");
            DropColumn("dbo.Route", "RouteTimeReportAM");
        }
    }
}
