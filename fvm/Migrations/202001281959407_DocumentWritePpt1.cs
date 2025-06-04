namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentWritePpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentWrite", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentWrite");
        }
    }
}
