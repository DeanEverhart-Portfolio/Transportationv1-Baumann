namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentHistoryRel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EquipmentHistory", "EquipmentHistoryCategory", c => c.String());
            AddColumn("dbo.EquipmentHistory", "EquipmentHistoryCategorySub", c => c.String());
            AddColumn("dbo.EquipmentHistory", "EquipmentHistoryNote", c => c.String());
            AddColumn("dbo.EquipmentHistory", "Route_RouteID", c => c.Int());
            CreateIndex("dbo.EquipmentHistory", "Route_RouteID");
            AddForeignKey("dbo.EquipmentHistory", "Route_RouteID", "dbo.Route", "RouteID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EquipmentHistory", "Route_RouteID", "dbo.Route");
            DropIndex("dbo.EquipmentHistory", new[] { "Route_RouteID" });
            DropColumn("dbo.EquipmentHistory", "Route_RouteID");
            DropColumn("dbo.EquipmentHistory", "EquipmentHistoryNote");
            DropColumn("dbo.EquipmentHistory", "EquipmentHistoryCategorySub");
            DropColumn("dbo.EquipmentHistory", "EquipmentHistoryCategory");
        }
    }
}
