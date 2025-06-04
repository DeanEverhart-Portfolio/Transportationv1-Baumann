namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteDistrictPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RouteDistrict", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "RouteDistrict");
        }
    }
}
