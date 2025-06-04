namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRunPptSet1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RunAssignment", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.RunAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run");
            DropForeignKey("dbo.RunAssignment", "Run_RunID1", "dbo.Run");
            DropForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run");
            DropIndex("dbo.RouteAssignment", new[] { "RunID" });
            DropIndex("dbo.RunAssignment", new[] { "ContactID" });
            DropIndex("dbo.RunAssignment", new[] { "EquipmentID" });
            DropIndex("dbo.RunAssignment", new[] { "Run_RunID" });
            DropIndex("dbo.RunAssignment", new[] { "Run_RunID1" });
            DropColumn("dbo.RouteAssignment", "RunID");
            DropTable("dbo.Run");
            DropTable("dbo.RunAssignment");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RunAssignment",
                c => new
                    {
                        RunAssignmentID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        EquipmentID = c.Int(nullable: false),
                        Run_RunID = c.Int(),
                        Run_RunID1 = c.Int(),
                    })
                .PrimaryKey(t => t.RunAssignmentID);
            
            CreateTable(
                "dbo.Run",
                c => new
                    {
                        RunID = c.Int(nullable: false, identity: true),
                        RunDesignator = c.String(),
                        RunTimeArriveHr = c.Int(),
                        RunTimeArriveMin = c.Int(),
                        RunTimeArriveAMPM = c.String(),
                        RunTimeArriveDayOfWeek = c.String(),
                        RunHardware = c.String(),
                        RunSupervision = c.String(),
                        RunMonitors = c.String(),
                        RunSelect = c.Boolean(),
                        RunInactive = c.Boolean(),
                    })
                .PrimaryKey(t => t.RunID);
            
            AddColumn("dbo.RouteAssignment", "RunID", c => c.Int());
            CreateIndex("dbo.RunAssignment", "Run_RunID1");
            CreateIndex("dbo.RunAssignment", "Run_RunID");
            CreateIndex("dbo.RunAssignment", "EquipmentID");
            CreateIndex("dbo.RunAssignment", "ContactID");
            CreateIndex("dbo.RouteAssignment", "RunID");
            AddForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run", "RunID");
            AddForeignKey("dbo.RunAssignment", "Run_RunID1", "dbo.Run", "RunID");
            AddForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run", "RunID");
            AddForeignKey("dbo.RunAssignment", "EquipmentID", "dbo.Equipment", "EquipmentID", cascadeDelete: true);
            AddForeignKey("dbo.RunAssignment", "ContactID", "dbo.Contact", "ContactID", cascadeDelete: true);
        }
    }
}
