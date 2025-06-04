namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentVersionPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentVersion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentVersion");
        }
    }
}
