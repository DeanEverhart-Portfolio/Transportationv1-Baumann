namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EquipmentReplacementPpts2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Equipment", "EquipmentNote", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Equipment", "EquipmentNote");
        }
    }
}
