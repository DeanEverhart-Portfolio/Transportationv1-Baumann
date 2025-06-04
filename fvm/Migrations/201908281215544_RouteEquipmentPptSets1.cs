namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteEquipmentPptSets1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        EquipmentID = c.Int(nullable: false, identity: true),
                        EquipmentDesignator = c.String(),
                        EquipmentType = c.String(),
                        EquipmentPassengersAdult = c.Int(),
                        EquipmentPassengersChild = c.Int(),
                        EquipmentVideo = c.Int(),
                        EquipmentBuiltIns = c.Int(),
                        EquipmentWheelChair = c.Int(),
                    })
                .PrimaryKey(t => t.EquipmentID);
            
            CreateTable(
                "dbo.EquipmentAssignment",
                c => new
                    {
                        EquipmentAssignmentID = c.Int(nullable: false, identity: true),
                        EquipmentID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EquipmentAssignmentID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID, cascadeDelete: true)
                .Index(t => t.EquipmentID)
                .Index(t => t.ContactID);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        RouteID = c.Int(nullable: false, identity: true),
                        RouteDesignator = c.String(),
                        RouteHardware = c.String(),
                        RouteSupervision = c.String(),
                        RouteMonitors = c.String(),
                    })
                .PrimaryKey(t => t.RouteID);
            
            CreateTable(
                "dbo.RouteAssignment",
                c => new
                    {
                        RouteAssignmentID = c.Int(nullable: false, identity: true),
                        RouteID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        EquipmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RouteAssignmentID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID, cascadeDelete: true)
                .ForeignKey("dbo.Route", t => t.RouteID, cascadeDelete: true)
                .Index(t => t.RouteID)
                .Index(t => t.ContactID)
                .Index(t => t.EquipmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteAssignment", "RouteID", "dbo.Route");
            DropForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.EquipmentAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.EquipmentAssignment", "ContactID", "dbo.Contact");
            DropIndex("dbo.RouteAssignment", new[] { "EquipmentID" });
            DropIndex("dbo.RouteAssignment", new[] { "ContactID" });
            DropIndex("dbo.RouteAssignment", new[] { "RouteID" });
            DropIndex("dbo.EquipmentAssignment", new[] { "ContactID" });
            DropIndex("dbo.EquipmentAssignment", new[] { "EquipmentID" });
            DropTable("dbo.RouteAssignment");
            DropTable("dbo.Route");
            DropTable("dbo.EquipmentAssignment");
            DropTable("dbo.Equipment");
        }
    }
}
