namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentRadioPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentRadio", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentRadio");
        }
    }
}
