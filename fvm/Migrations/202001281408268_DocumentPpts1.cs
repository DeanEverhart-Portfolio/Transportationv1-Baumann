namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentForm", c => c.Boolean());
            AddColumn("dbo.Document", "DocumentTemplate", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentTemplate");
            DropColumn("dbo.Document", "DocumentForm");
        }
    }
}
