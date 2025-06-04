namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RouteContactRP1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Route", "ContactID", c => c.Int());
            CreateIndex("dbo.Route", "ContactID");
            AddForeignKey("dbo.Route", "ContactID", "dbo.Contact", "ContactID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Route", "ContactID", "dbo.Contact");
            DropIndex("dbo.Route", new[] { "ContactID" });
            DropColumn("dbo.Route", "ContactID");
        }
    }
}
