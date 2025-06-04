namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentPptSets1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentAssignment",
                c => new
                    {
                        DocumentAssignmentID = c.Int(nullable: false, identity: true),
                        DocumentID = c.Int(nullable: false),
                        DocumentMenuID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DocumentAssignmentID)
                .ForeignKey("dbo.Document", t => t.DocumentID, cascadeDelete: true)
                .ForeignKey("dbo.DocumentMenu", t => t.DocumentMenuID, cascadeDelete: true)
                .Index(t => t.DocumentID)
                .Index(t => t.DocumentMenuID);
            
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        DocumentID = c.Int(nullable: false, identity: true),
                        DocumentDesignator = c.String(),
                        DocumentAccess = c.String(),
                        DocumentCategory = c.String(),
                        DocumentCategorySub = c.String(),
                        DocumentTag = c.String(),
                    })
                .PrimaryKey(t => t.DocumentID);
            
            CreateTable(
                "dbo.DocumentMenu",
                c => new
                    {
                        DocumentMenuID = c.Int(nullable: false, identity: true),
                        DocumentMenuDesignator = c.String(),
                        DocumentCategory = c.String(),
                        DocumentCategorySub = c.String(),
                        DocumentTag = c.String(),
                    })
                .PrimaryKey(t => t.DocumentMenuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentAssignment", "DocumentMenuID", "dbo.DocumentMenu");
            DropForeignKey("dbo.DocumentAssignment", "DocumentID", "dbo.Document");
            DropIndex("dbo.DocumentAssignment", new[] { "DocumentMenuID" });
            DropIndex("dbo.DocumentAssignment", new[] { "DocumentID" });
            DropTable("dbo.DocumentMenu");
            DropTable("dbo.Document");
            DropTable("dbo.DocumentAssignment");
        }
    }
}
