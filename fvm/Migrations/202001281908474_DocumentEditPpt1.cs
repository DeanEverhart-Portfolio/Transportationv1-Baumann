namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentEditPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentCrossReference", c => c.String());
            AddColumn("dbo.Document", "DocumentEdit", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentEdit");
            DropColumn("dbo.Document", "DocumentCrossReference");
        }
    }
}
