namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuidelinePptSet1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Guideline");
        }
        
        public override void Down()
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
    }
}
