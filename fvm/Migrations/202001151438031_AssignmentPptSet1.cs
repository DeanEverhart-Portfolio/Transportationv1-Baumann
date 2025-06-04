namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignmentPptSet1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignment",
                c => new
                    {
                        AssignmentID = c.Int(nullable: false, identity: true),
                        RouteID = c.Int(),
                        RunID = c.Int(),
                        ContactID = c.Int(),
                        EquipmentID = c.Int(),
                    })
                .PrimaryKey(t => t.AssignmentID)
                .ForeignKey("dbo.Contact", t => t.ContactID)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID)
                .ForeignKey("dbo.Route", t => t.RouteID)
                .ForeignKey("dbo.Run", t => t.RunID)
                .Index(t => t.RouteID)
                .Index(t => t.RunID)
                .Index(t => t.ContactID)
                .Index(t => t.EquipmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assignment", "RunID", "dbo.Run");
            DropForeignKey("dbo.Assignment", "RouteID", "dbo.Route");
            DropForeignKey("dbo.Assignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.Assignment", "ContactID", "dbo.Contact");
            DropIndex("dbo.Assignment", new[] { "EquipmentID" });
            DropIndex("dbo.Assignment", new[] { "ContactID" });
            DropIndex("dbo.Assignment", new[] { "RunID" });
            DropIndex("dbo.Assignment", new[] { "RouteID" });
            DropTable("dbo.Assignment");
        }
    }
}
