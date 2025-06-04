namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteRunContact4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contact", "Route_RouteID", "dbo.Route");
            DropForeignKey("dbo.Equipment", "Route_RouteID", "dbo.Route");
            DropForeignKey("dbo.Contact", "Run_RunID", "dbo.Run");
            DropForeignKey("dbo.Equipment", "Run_RunID", "dbo.Run");
            DropIndex("dbo.Contact", new[] { "Route_RouteID" });
            DropIndex("dbo.Contact", new[] { "Run_RunID" });
            DropIndex("dbo.Equipment", new[] { "Route_RouteID" });
            DropIndex("dbo.Equipment", new[] { "Run_RunID" });
            AddColumn("dbo.RouteAssignment", "Route_RouteID", c => c.Int());
            AddColumn("dbo.RunAssignment", "Run_RunID", c => c.Int());
            CreateIndex("dbo.RouteAssignment", "Route_RouteID");
            CreateIndex("dbo.RunAssignment", "Run_RunID");
            AddForeignKey("dbo.RouteAssignment", "Route_RouteID", "dbo.Route", "RouteID");
            AddForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run", "RunID");
            DropColumn("dbo.Contact", "Route_RouteID");
            DropColumn("dbo.Contact", "Run_RunID");
            DropColumn("dbo.Equipment", "Route_RouteID");
            DropColumn("dbo.Equipment", "Run_RunID");
            DropColumn("dbo.Route", "ContactID");
            DropColumn("dbo.Route", "EquipmentID");
            DropColumn("dbo.Run", "ContactID");
            DropColumn("dbo.Run", "EquipmentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Run", "EquipmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Run", "ContactID", c => c.Int(nullable: false));
            AddColumn("dbo.Route", "EquipmentID", c => c.Int(nullable: false));
            AddColumn("dbo.Route", "ContactID", c => c.Int(nullable: false));
            AddColumn("dbo.Equipment", "Run_RunID", c => c.Int());
            AddColumn("dbo.Equipment", "Route_RouteID", c => c.Int());
            AddColumn("dbo.Contact", "Run_RunID", c => c.Int());
            AddColumn("dbo.Contact", "Route_RouteID", c => c.Int());
            DropForeignKey("dbo.RunAssignment", "Run_RunID", "dbo.Run");
            DropForeignKey("dbo.RouteAssignment", "Route_RouteID", "dbo.Route");
            DropIndex("dbo.RunAssignment", new[] { "Run_RunID" });
            DropIndex("dbo.RouteAssignment", new[] { "Route_RouteID" });
            DropColumn("dbo.RunAssignment", "Run_RunID");
            DropColumn("dbo.RouteAssignment", "Route_RouteID");
            CreateIndex("dbo.Equipment", "Run_RunID");
            CreateIndex("dbo.Equipment", "Route_RouteID");
            CreateIndex("dbo.Contact", "Run_RunID");
            CreateIndex("dbo.Contact", "Route_RouteID");
            AddForeignKey("dbo.Equipment", "Run_RunID", "dbo.Run", "RunID");
            AddForeignKey("dbo.Contact", "Run_RunID", "dbo.Run", "RunID");
            AddForeignKey("dbo.Equipment", "Route_RouteID", "dbo.Route", "RouteID");
            AddForeignKey("dbo.Contact", "Route_RouteID", "dbo.Route", "RouteID");
        }
    }
}
