namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentDesignatorCategoryPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentDesignatorCategory", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentDesignatorCategory");
        }
    }
}
