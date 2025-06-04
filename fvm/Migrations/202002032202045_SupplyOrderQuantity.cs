namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplyOrderQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supply", "SupplyOrderQuantity", c => c.Int());
            DropColumn("dbo.Supply", "SupplyQuantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supply", "SupplyQuantity", c => c.Int());
            DropColumn("dbo.Supply", "SupplyOrderQuantity");
        }
    }
}
