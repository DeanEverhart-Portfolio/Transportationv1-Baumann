namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentVideo2Ppt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentVideo2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentVideo2");
        }
    }
}
