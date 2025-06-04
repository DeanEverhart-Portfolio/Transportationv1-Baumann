namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteDesignator2Ppt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RouteDesignator2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "RouteDesignator2");
        }
    }
}
