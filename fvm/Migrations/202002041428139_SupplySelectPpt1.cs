namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplySelectPpt1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Supply", "SupplySelect");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supply", "SupplySelect", c => c.Boolean());
        }
    }
}
