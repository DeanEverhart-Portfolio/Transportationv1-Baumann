namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentDesignatorIdentifierPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentDesignatorIdentifier", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentDesignatorIdentifier");
        }
    }
}
