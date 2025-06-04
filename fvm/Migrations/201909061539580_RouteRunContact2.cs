namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteRunContact2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Route", "ContactID", "dbo.Contact");
            DropIndex("dbo.Route", new[] { "ContactID" });
            CreateTable(
                "dbo.RouteAssignment",
                c => new
                    {
                        RouteAssignmentID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        EquipmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RouteAssignmentID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID, cascadeDelete: true)
                .Index(t => t.ContactID)
                .Index(t => t.EquipmentID);
            
            CreateTable(
                "dbo.RunAssignment",
                c => new
                    {
                        RunAssignmentID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        EquipmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RunAssignmentID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID, cascadeDelete: true)
                .Index(t => t.ContactID)
                .Index(t => t.EquipmentID);
            
            DropColumn("dbo.Route", "ContactID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Route", "ContactID", c => c.Int(nullable: false));
            DropForeignKey("dbo.RunAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.RunAssignment", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact");
            DropIndex("dbo.RunAssignment", new[] { "EquipmentID" });
            DropIndex("dbo.RunAssignment", new[] { "ContactID" });
            DropIndex("dbo.RouteAssignment", new[] { "EquipmentID" });
            DropIndex("dbo.RouteAssignment", new[] { "ContactID" });
            DropTable("dbo.RunAssignment");
            DropTable("dbo.RouteAssignment");
            CreateIndex("dbo.Route", "ContactID");
            AddForeignKey("dbo.Route", "ContactID", "dbo.Contact", "ContactID", cascadeDelete: true);
        }
    }
}
