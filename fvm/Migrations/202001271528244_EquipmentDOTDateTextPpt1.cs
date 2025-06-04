namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentDOTDateTextPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentDOTDateText", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentDOTDateText");
        }
    }
}
