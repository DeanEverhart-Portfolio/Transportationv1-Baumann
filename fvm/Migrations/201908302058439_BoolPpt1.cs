namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoolPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarSelect", c => c.Boolean());
            AddColumn("dbo.Calendar", "CalendarInactive", c => c.Boolean());
            AddColumn("dbo.Equipment", "EquipmentSelect", c => c.Boolean());
            AddColumn("dbo.Equipment", "EquipmentInactive", c => c.Boolean());
            AddColumn("dbo.Route", "RouteSelect", c => c.Boolean());
            AddColumn("dbo.Route", "RouteInactive", c => c.Boolean());
            DropColumn("dbo.Calendar", "ContactSelect");
            DropColumn("dbo.Calendar", "ContactInactive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Calendar", "ContactInactive", c => c.Boolean());
            AddColumn("dbo.Calendar", "ContactSelect", c => c.Boolean());
            DropColumn("dbo.Route", "RouteInactive");
            DropColumn("dbo.Route", "RouteSelect");
            DropColumn("dbo.Equipment", "EquipmentInactive");
            DropColumn("dbo.Equipment", "EquipmentSelect");
            DropColumn("dbo.Calendar", "CalendarInactive");
            DropColumn("dbo.Calendar", "CalendarSelect");
        }
    }
}
