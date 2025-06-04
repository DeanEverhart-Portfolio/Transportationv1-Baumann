namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteRunContact3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Run", "ContactID", "dbo.Contact");
            DropIndex("dbo.Run", new[] { "ContactID" });
            AddColumn("dbo.Contact", "Route_RouteID", c => c.Int());
            AddColumn("dbo.Contact", "Run_RunID", c => c.Int());
            AddColumn("dbo.Equipment", "Route_RouteID", c => c.Int());
            AddColumn("dbo.Equipment", "Run_RunID", c => c.Int());
            AddColumn("dbo.Route", "ContactID", c => c.Int(nullable: false));
            AddColumn("dbo.Route", "EquipmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Run", "EquipmentID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contact", "Route_RouteID");
            CreateIndex("dbo.Contact", "Run_RunID");
            CreateIndex("dbo.Equipment", "Route_RouteID");
            CreateIndex("dbo.Equipment", "Run_RunID");
            AddForeignKey("dbo.Contact", "Route_RouteID", "dbo.Route", "RouteID");
            AddForeignKey("dbo.Equipment", "Route_RouteID", "dbo.Route", "RouteID");
            AddForeignKey("dbo.Contact", "Run_RunID", "dbo.Run", "RunID");
            AddForeignKey("dbo.Equipment", "Run_RunID", "dbo.Run", "RunID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Equipment", "Run_RunID", "dbo.Run");
            DropForeignKey("dbo.Contact", "Run_RunID", "dbo.Run");
            DropForeignKey("dbo.Equipment", "Route_RouteID", "dbo.Route");
            DropForeignKey("dbo.Contact", "Route_RouteID", "dbo.Route");
            DropIndex("dbo.Equipment", new[] { "Run_RunID" });
            DropIndex("dbo.Equipment", new[] { "Route_RouteID" });
            DropIndex("dbo.Contact", new[] { "Run_RunID" });
            DropIndex("dbo.Contact", new[] { "Route_RouteID" });
            DropColumn("dbo.Run", "EquipmentID");
            DropColumn("dbo.Route", "EquipmentID");
            DropColumn("dbo.Route", "ContactID");
            DropColumn("dbo.Equipment", "Run_RunID");
            DropColumn("dbo.Equipment", "Route_RouteID");
            DropColumn("dbo.Contact", "Run_RunID");
            DropColumn("dbo.Contact", "Route_RouteID");
            CreateIndex("dbo.Run", "ContactID");
            AddForeignKey("dbo.Run", "ContactID", "dbo.Contact", "ContactID", cascadeDelete: true);
        }
    }
}
