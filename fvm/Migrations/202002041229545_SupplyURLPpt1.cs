namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplyURLPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supply", "SupplyURLAccess", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supply", "SupplyURLAccess");
        }
    }
}
