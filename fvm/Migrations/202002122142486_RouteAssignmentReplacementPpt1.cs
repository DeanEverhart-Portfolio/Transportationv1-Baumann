namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteAssignmentReplacementPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RouteAssignment", "RouteAssignmentReplacement", c => c.String());
            DropColumn("dbo.Route", "RouteReplacement");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Route", "RouteReplacement", c => c.String());
            DropColumn("dbo.RouteAssignment", "RouteAssignmentReplacement");
        }
    }
}
