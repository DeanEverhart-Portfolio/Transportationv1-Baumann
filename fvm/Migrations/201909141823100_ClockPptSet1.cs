namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockPptSet1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clock",
                c => new
                    {
                        ClockID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(),
                        EquipmentID = c.Int(),
                        RouteID = c.Int(),
                        ClockTime = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.ClockID)
                .ForeignKey("dbo.Contact", t => t.ContactID)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID)
                .ForeignKey("dbo.Route", t => t.RouteID)
                .Index(t => t.ContactID)
                .Index(t => t.EquipmentID)
                .Index(t => t.RouteID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clock", "RouteID", "dbo.Route");
            DropForeignKey("dbo.Clock", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.Clock", "ContactID", "dbo.Contact");
            DropIndex("dbo.Clock", new[] { "RouteID" });
            DropIndex("dbo.Clock", new[] { "EquipmentID" });
            DropIndex("dbo.Clock", new[] { "ContactID" });
            DropTable("dbo.Clock");
        }
    }
}
