namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunRouteJoin3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.RouteAssignment", name: "Route_RouteID", newName: "RouteID");
            RenameIndex(table: "dbo.RouteAssignment", name: "IX_Route_RouteID", newName: "IX_RouteID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.RouteAssignment", name: "IX_RouteID", newName: "IX_Route_RouteID");
            RenameColumn(table: "dbo.RouteAssignment", name: "RouteID", newName: "Route_RouteID");
        }
    }
}
