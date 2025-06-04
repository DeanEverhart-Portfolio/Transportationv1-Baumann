namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentRadioPpts2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Equipment", "EquipmentRadio");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Equipment", "EquipmentRadio", c => c.String());
        }
    }
}
