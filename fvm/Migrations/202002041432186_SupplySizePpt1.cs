namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplySizePpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supply", "SupplySize", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supply", "SupplySize");
        }
    }
}
