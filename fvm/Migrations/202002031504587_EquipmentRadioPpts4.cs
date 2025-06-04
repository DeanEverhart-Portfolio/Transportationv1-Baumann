namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentRadioPpts4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentRadioNote", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentRadioNote");
        }
    }
}
