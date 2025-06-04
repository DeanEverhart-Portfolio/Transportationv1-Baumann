namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunRoutContact1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.RouteAssignment", "RouteID", "dbo.Route");
            DropForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run");
            DropIndex("dbo.RouteAssignment", new[] { "RouteID" });
            DropIndex("dbo.RouteAssignment", new[] { "ContactID" });
            DropIndex("dbo.RouteAssignment", new[] { "EquipmentID" });
            DropIndex("dbo.RouteAssignment", new[] { "RunID" });
            AddColumn("dbo.Route", "ContactID", c => c.Int(nullable: false));
            AddColumn("dbo.Run", "ContactID", c => c.Int(nullable: false));
            CreateIndex("dbo.Route", "ContactID");
            CreateIndex("dbo.Run", "ContactID");
            AddForeignKey("dbo.Route", "ContactID", "dbo.Contact", "ContactID", cascadeDelete: true);
            AddForeignKey("dbo.Run", "ContactID", "dbo.Contact", "ContactID", cascadeDelete: true);
            DropTable("dbo.RouteAssignment");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.RouteAssignment",
                c => new
                    {
                        RouteAssignmentID = c.Int(nullable: false, identity: true),
                        RouteID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        EquipmentID = c.Int(nullable: false),
                        RunID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RouteAssignmentID);
            
            DropForeignKey("dbo.Run", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.Route", "ContactID", "dbo.Contact");
            DropIndex("dbo.Run", new[] { "ContactID" });
            DropIndex("dbo.Route", new[] { "ContactID" });
            DropColumn("dbo.Run", "ContactID");
            DropColumn("dbo.Route", "ContactID");
            CreateIndex("dbo.RouteAssignment", "RunID");
            CreateIndex("dbo.RouteAssignment", "EquipmentID");
            CreateIndex("dbo.RouteAssignment", "ContactID");
            CreateIndex("dbo.RouteAssignment", "RouteID");
            AddForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run", "RunID", cascadeDelete: true);
            AddForeignKey("dbo.RouteAssignment", "RouteID", "dbo.Route", "RouteID", cascadeDelete: true);
            AddForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment", "EquipmentID", cascadeDelete: true);
            AddForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact", "ContactID", cascadeDelete: true);
        }
    }
}
