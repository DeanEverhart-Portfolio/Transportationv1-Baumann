namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentPptSet1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DocumentAssignment", "DocumentID", "dbo.Document");
            DropIndex("dbo.DocumentAssignment", new[] { "DocumentID" });
            DropTable("dbo.Document");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Document",
                c => new
                    {
                        DocumentID = c.Int(nullable: false, identity: true),
                        DocumentDesignator = c.String(),
                        DocumentDesignatorCategory = c.String(),
                        DocumentDesignatorIdentifier = c.String(),
                        DocumentForm = c.Boolean(),
                        DocumentTemplate = c.Boolean(),
                        DocumentMedical = c.Boolean(),
                        DocumentEmergency = c.Boolean(),
                        DocumentAccessRead = c.String(),
                        DocumentAccessWrite = c.String(),
                        DocumentCategory = c.String(),
                        DocumentCategorySub = c.String(),
                        DocumentVersion = c.String(),
                        DocumentTag = c.String(),
                        DocumentCrossCategory = c.String(),
                        DocumentWrite = c.String(),
                    })
                .PrimaryKey(t => t.DocumentID);
            
            CreateIndex("dbo.DocumentAssignment", "DocumentID");
            AddForeignKey("dbo.DocumentAssignment", "DocumentID", "dbo.Document", "DocumentID", cascadeDelete: true);
        }
    }
}
