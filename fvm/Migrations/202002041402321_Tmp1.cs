namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tmp1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Supply", "SupplyItem");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Supply", "SupplyItem", c => c.String());
        }
    }
}
