namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentPptSet4 : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Document");
        }
    }
}
