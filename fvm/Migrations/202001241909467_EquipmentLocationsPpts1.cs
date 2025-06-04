namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentLocationsPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentLocation", c => c.String());
            AddColumn("dbo.Equipment", "EquipmentLocationBook", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentLocationBook");
            DropColumn("dbo.Equipment", "EquipmentLocation");
        }
    }
}
