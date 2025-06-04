namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteReportTimeAMPM1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RouteTimeReportAMPM", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "RouteTimeReportAMPM");
        }
    }
}
