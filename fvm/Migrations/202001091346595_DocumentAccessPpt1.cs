namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentAccessPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentAccessRead", c => c.String());
            AddColumn("dbo.Document", "DocumentAccessEdit", c => c.String());
            DropColumn("dbo.Document", "DocumentAccess");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Document", "DocumentAccess", c => c.String());
            DropColumn("dbo.Document", "DocumentAccessEdit");
            DropColumn("dbo.Document", "DocumentAccessRead");
        }
    }
}
