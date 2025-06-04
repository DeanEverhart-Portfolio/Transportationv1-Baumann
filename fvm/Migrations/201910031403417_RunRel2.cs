namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunRel2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RunAssignment",
                c => new
                    {
                        RunAssignmentID = c.Int(nullable: false, identity: true),
                        RouteID = c.Int(),
                        RunID = c.Int(),
                    })
                .PrimaryKey(t => t.RunAssignmentID)
                .ForeignKey("dbo.Route", t => t.RouteID)
                .ForeignKey("dbo.Run", t => t.RunID)
                .Index(t => t.RouteID)
                .Index(t => t.RunID);
            
            CreateTable(
                "dbo.Run",
                c => new
                    {
                        RunID = c.Int(nullable: false, identity: true),
                        RouteID = c.Int(),
                        RunDesignator = c.String(),
                        RunTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        RunAMPM = c.String(),
                        RunDayOfWeek = c.String(),
                        RouteSelect = c.Boolean(),
                        RunInactive = c.Int(),
                    })
                .PrimaryKey(t => t.RunID)
                .ForeignKey("dbo.Route", t => t.RouteID)
                .Index(t => t.RouteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RunAssignment", "RunID", "dbo.Run");
            DropForeignKey("dbo.Run", "RouteID", "dbo.Route");
            DropForeignKey("dbo.RunAssignment", "RouteID", "dbo.Route");
            DropIndex("dbo.Run", new[] { "RouteID" });
            DropIndex("dbo.RunAssignment", new[] { "RunID" });
            DropIndex("dbo.RunAssignment", new[] { "RouteID" });
            DropTable("dbo.Run");
            DropTable("dbo.RunAssignment");
        }
    }
}
