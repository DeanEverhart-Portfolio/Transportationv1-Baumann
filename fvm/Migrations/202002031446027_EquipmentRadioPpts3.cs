namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentRadioPpts3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentRadio", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentRadio");
        }
    }
}
