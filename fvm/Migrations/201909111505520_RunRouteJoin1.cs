namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunRouteJoin1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run");
            AddColumn("dbo.RouteAssignment", "RunID", c => c.Int(nullable: false));
            AddColumn("dbo.RunAssignment", "Run_RunID1", c => c.Int());
            CreateIndex("dbo.RouteAssignment", "RunID");
            CreateIndex("dbo.RunAssignment", "Run_RunID1");
            AddForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run", "RunID");
            AddForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run", "RunID", cascadeDelete: true);
            AddForeignKey("dbo.RunAssignment", "Run_RunID1", "dbo.Run", "RunID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RunAssignment", "Run_RunID1", "dbo.Run");
            DropForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run");
            DropForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run");
            DropIndex("dbo.RunAssignment", new[] { "Run_RunID1" });
            DropIndex("dbo.RouteAssignment", new[] { "RunID" });
            DropColumn("dbo.RunAssignment", "Run_RunID1");
            DropColumn("dbo.RouteAssignment", "RunID");
            AddForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run", "RunID");
        }
    }
}
