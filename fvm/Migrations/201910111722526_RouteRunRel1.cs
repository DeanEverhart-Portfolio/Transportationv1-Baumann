namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteRunRel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RunID", c => c.Int());
            AddColumn("dbo.RouteAssignment", "RunID", c => c.Int());
            CreateIndex("dbo.RouteAssignment", "RunID");
            AddForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run", "RunID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run");
            DropIndex("dbo.RouteAssignment", new[] { "RunID" });
            DropColumn("dbo.RouteAssignment", "RunID");
            DropColumn("dbo.Route", "RunID");
        }
    }
}
