namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunRouteJoin2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact");
            DropForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run");
            DropIndex("dbo.RouteAssignment", new[] { "ContactID" });
            DropIndex("dbo.RouteAssignment", new[] { "EquipmentID" });
            DropIndex("dbo.RouteAssignment", new[] { "RunID" });
            AlterColumn("dbo.RouteAssignment", "ContactID", c => c.Int());
            AlterColumn("dbo.RouteAssignment", "EquipmentID", c => c.Int());
            AlterColumn("dbo.RouteAssignment", "RunID", c => c.Int());
            CreateIndex("dbo.RouteAssignment", "ContactID");
            CreateIndex("dbo.RouteAssignment", "EquipmentID");
            CreateIndex("dbo.RouteAssignment", "RunID");
            AddForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact", "ContactID");
            AddForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment", "EquipmentID");
            AddForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run", "RunID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run");
            DropForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment");
            DropForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact");
            DropIndex("dbo.RouteAssignment", new[] { "RunID" });
            DropIndex("dbo.RouteAssignment", new[] { "EquipmentID" });
            DropIndex("dbo.RouteAssignment", new[] { "ContactID" });
            AlterColumn("dbo.RouteAssignment", "RunID", c => c.Int(nullable: false));
            AlterColumn("dbo.RouteAssignment", "EquipmentID", c => c.Int(nullable: false));
            AlterColumn("dbo.RouteAssignment", "ContactID", c => c.Int(nullable: false));
            CreateIndex("dbo.RouteAssignment", "RunID");
            CreateIndex("dbo.RouteAssignment", "EquipmentID");
            CreateIndex("dbo.RouteAssignment", "ContactID");
            AddForeignKey("dbo.RouteAssignment", "RunID", "dbo.Run", "RunID", cascadeDelete: true);
            AddForeignKey("dbo.RouteAssignment", "EquipmentID", "dbo.Equipment", "EquipmentID", cascadeDelete: true);
            AddForeignKey("dbo.RouteAssignment", "ContactID", "dbo.Contact", "ContactID", cascadeDelete: true);
        }
    }
}
