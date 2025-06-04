namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentRadioPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentRadioReported", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentRadioReported");
        }
    }
}
