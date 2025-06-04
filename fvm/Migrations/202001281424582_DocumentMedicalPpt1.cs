namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentMedicalPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentMedical", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentMedical");
        }
    }
}
