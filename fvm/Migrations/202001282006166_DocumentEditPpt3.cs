namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentEditPpt3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Document", "DocumentEdit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Document", "DocumentEdit", c => c.String());
        }
    }
}
