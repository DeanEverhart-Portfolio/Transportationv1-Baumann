namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplyDimensionsPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supply", "SupplyDimensions", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supply", "SupplyDimensions");
        }
    }
}
