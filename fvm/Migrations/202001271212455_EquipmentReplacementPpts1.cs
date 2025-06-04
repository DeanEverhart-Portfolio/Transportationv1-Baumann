namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentReplacementPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentDown", c => c.String());
            AddColumn("dbo.Equipment", "EquipmentReplacement", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentReplacement");
            DropColumn("dbo.Equipment", "EquipmentDown");
        }
    }
}
