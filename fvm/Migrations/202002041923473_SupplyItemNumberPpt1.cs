namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SupplyItemNumberPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supply", "SupplyItemNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Supply", "SupplyItemNumber");
        }
    }
}
