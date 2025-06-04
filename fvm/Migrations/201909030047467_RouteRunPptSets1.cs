namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteRunPptSets1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Run",
                c => new
                    {
                        RunID = c.Int(nullable: false, identity: true),
                        RunDesignator = c.String(),
                        RunHardware = c.String(),
                        RunSupervision = c.String(),
                        RunMonitors = c.String(),
                        RunSelect = c.Boolean(),
                        RunInactive = c.Boolean(),
                    })
                .PrimaryKey(t => t.RunID);
            
            AddColumn("dbo.RouteAssignment", "RunID", c => c.Int(nullable: false));
            CreateIndex("dbo.RouteAssignment", "RunID");
            AddForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run", "RunID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run");
            DropIndex("dbo.RouteAssignment", new[] { "RunID" });
            DropColumn("dbo.RouteAssignment", "RunID");
            DropTable("dbo.Run");
        }
    }
}
