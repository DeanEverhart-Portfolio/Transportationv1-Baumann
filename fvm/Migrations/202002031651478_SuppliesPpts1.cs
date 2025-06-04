namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SuppliesPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supply", "SupplyDesignator", c => c.String());
            AddColumn("dbo.Supply", "SupplyCategory", c => c.String());
            AddColumn("dbo.Supply", "SupplyCategorySub", c => c.String());
            AddColumn("dbo.Supply", "SupplyTag", c => c.String());
            AddColumn("dbo.Supply", "SupplyNote", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supply", "SupplyNote");
            DropColumn("dbo.Supply", "SupplyTag");
            DropColumn("dbo.Supply", "SupplyCategorySub");
            DropColumn("dbo.Supply", "SupplyCategory");
            DropColumn("dbo.Supply", "SupplyDesignator");
        }
    }
}
