namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuidelinePptSet2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guideline",
                c => new
                    {
                        GuidelineID = c.Int(nullable: false, identity: true),
                        GuidelineDescriptor = c.String(),
                        GuidelineText = c.String(),
                        GuidelineCategory = c.String(),
                        GuidelineCategorySub = c.String(),
                    })
                .PrimaryKey(t => t.GuidelineID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Guideline");
        }
    }
}
