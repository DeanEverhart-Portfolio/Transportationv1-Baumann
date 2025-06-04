namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplyQuantityPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supply", "SupplyQuantity", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supply", "SupplyQuantity");
        }
    }
}
