namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentAccessPpt2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentAccessWrite", c => c.String());
            DropColumn("dbo.Document", "DocumentAccessEdit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Document", "DocumentAccessEdit", c => c.String());
            DropColumn("dbo.Document", "DocumentAccessWrite");
        }
    }
}
