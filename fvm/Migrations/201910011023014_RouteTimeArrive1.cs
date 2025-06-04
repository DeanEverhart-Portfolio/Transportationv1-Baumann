namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteTimeArrive1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RouteTimeArriveAM", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Route", "RouteTimeArrivePM", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "RouteTimeArrivePM");
            DropColumn("dbo.Route", "RouteTimeArriveAM");
        }
    }
}
