namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentHistoryRel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EquipmentHistory",
                c => new
                    {
                        EquipmentHistoryID = c.Int(nullable: false, identity: true),
                        EquipmentID = c.Int(nullable: false),
                        ContactID = c.Int(nullable: false),
                        EquipmentHistoryDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        EquipmentHistorySelect = c.Boolean(),
                        EquipmentHistoryInactive = c.Boolean(),
                    })
                .PrimaryKey(t => t.EquipmentHistoryID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .ForeignKey("dbo.Equipment", t => t.EquipmentID, cascadeDelete: true)
                .Index(t => t.EquipmentID)
                .Index(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EquipmentHistory", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.EquipmentHistory", "ContactID", "dbo.Contact");
            DropIndex("dbo.EquipmentHistory", new[] { "ContactID" });
            DropIndex("dbo.EquipmentHistory", new[] { "EquipmentID" });
            DropTable("dbo.EquipmentHistory");
        }
    }
}
