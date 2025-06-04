namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteAssignmentTypePpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RouteAssignment", "RouteAssignmentReplacementType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RouteAssignment", "RouteAssignmentReplacementType");
        }
    }
}
