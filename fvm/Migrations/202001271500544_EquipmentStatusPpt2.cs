namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentStatusPpt2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentDOT", c => c.String());
            AddColumn("dbo.Equipment", "EquipmentDOTDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentDOTDate");
            DropColumn("dbo.Equipment", "EquipmentDOT");
        }
    }
}
