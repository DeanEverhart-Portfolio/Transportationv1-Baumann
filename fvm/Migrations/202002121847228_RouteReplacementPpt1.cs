namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteReplacementPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "RouteReplacement", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Route", "RouteReplacement");
        }
    }
}
