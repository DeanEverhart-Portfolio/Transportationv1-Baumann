namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentMenuPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentMenu", "DocumentMenuCategory", c => c.String());
            AddColumn("dbo.DocumentMenu", "DocumentMenuCategorySub", c => c.String());
            AddColumn("dbo.DocumentMenu", "DocumentMenuTag", c => c.String());
            DropColumn("dbo.DocumentMenu", "DocumentCategory");
            DropColumn("dbo.DocumentMenu", "DocumentCategorySub");
            DropColumn("dbo.DocumentMenu", "DocumentTag");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DocumentMenu", "DocumentTag", c => c.String());
            AddColumn("dbo.DocumentMenu", "DocumentCategorySub", c => c.String());
            AddColumn("dbo.DocumentMenu", "DocumentCategory", c => c.String());
            DropColumn("dbo.DocumentMenu", "DocumentMenuTag");
            DropColumn("dbo.DocumentMenu", "DocumentMenuCategorySub");
            DropColumn("dbo.DocumentMenu", "DocumentMenuCategory");
        }
    }
}
