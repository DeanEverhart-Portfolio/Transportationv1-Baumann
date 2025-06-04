namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentEditPpt2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentCrossCategory", c => c.String());
            DropColumn("dbo.Document", "DocumentCrossReference");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Document", "DocumentCrossReference", c => c.String());
            DropColumn("dbo.Document", "DocumentCrossCategory");
        }
    }
}
