namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunRel4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Run", "ContactID", c => c.Int());
            AddColumn("dbo.Run", "RunSelect", c => c.Boolean());
            AlterColumn("dbo.Run", "RunInactive", c => c.Boolean());
            CreateIndex("dbo.Run", "ContactID");
            AddForeignKey("dbo.Run", "ContactID", "dbo.Contact", "ContactID");
            DropColumn("dbo.Run", "RouteSelect");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Run", "RouteSelect", c => c.Boolean());
            DropForeignKey("dbo.Run", "ContactID", "dbo.Contact");
            DropIndex("dbo.Run", new[] { "ContactID" });
            AlterColumn("dbo.Run", "RunInactive", c => c.Int());
            DropColumn("dbo.Run", "RunSelect");
            DropColumn("dbo.Run", "ContactID");
        }
    }
}
