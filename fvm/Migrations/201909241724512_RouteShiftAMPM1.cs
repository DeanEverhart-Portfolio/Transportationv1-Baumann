namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteShiftAMPM1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RouteTimeShiftAM", c => c.Boolean());
            AddColumn("dbo.Route", "RouteTimeShiftPM", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "RouteTimeShiftPM");
            DropColumn("dbo.Route", "RouteTimeShiftAM");
        }
    }
}
