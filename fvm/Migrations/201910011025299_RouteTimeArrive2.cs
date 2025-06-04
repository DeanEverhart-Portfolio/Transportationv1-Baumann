namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteTimeArrive2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Route", "RouteTimeReportAMPM");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Route", "RouteTimeReportAMPM", c => c.Boolean());
        }
    }
}
