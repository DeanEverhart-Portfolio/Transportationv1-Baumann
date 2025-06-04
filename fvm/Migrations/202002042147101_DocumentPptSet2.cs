namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentPptSet2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DocumentAssignment", "DocumentMenuID", "dbo.DocumentMenu");
            DropIndex("dbo.DocumentAssignment", new[] { "DocumentMenuID" });
            DropTable("dbo.DocumentAssignment");
            DropTable("dbo.DocumentMenu");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DocumentMenu",
                c => new
                    {
                        DocumentMenuID = c.Int(nullable: false, identity: true),
                        DocumentMenuDesignator = c.String(),
                        DocumentMenuCategory = c.String(),
                        DocumentMenuCategorySub = c.String(),
                        DocumentMenuTag = c.String(),
                    })
                .PrimaryKey(t => t.DocumentMenuID);
            
            CreateTable(
                "dbo.DocumentAssignment",
                c => new
                    {
                        DocumentAssignmentID = c.Int(nullable: false, identity: true),
                        DocumentID = c.Int(nullable: false),
                        DocumentMenuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DocumentAssignmentID);
            
            CreateIndex("dbo.DocumentAssignment", "DocumentMenuID");
            AddForeignKey("dbo.DocumentAssignment", "DocumentMenuID", "dbo.DocumentMenu", "DocumentMenuID", cascadeDelete: true);
        }
    }
}
