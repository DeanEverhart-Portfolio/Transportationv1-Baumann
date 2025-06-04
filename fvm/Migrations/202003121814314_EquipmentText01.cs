namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentText01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentText", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentText");
        }
    }
}
