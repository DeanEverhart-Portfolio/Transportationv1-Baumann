namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Education2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CDL",
                c => new
                    {
                        CDLID = c.Int(nullable: false, identity: true),
                        CDLCategory = c.String(),
                        CDLCategorySub = c.String(),
                        CDLTag = c.String(),
                        CDLText1 = c.String(),
                        CDLText2 = c.String(),
                        CDLChapter = c.Int(),
                        CDLPage = c.Int(),
                    })
                .PrimaryKey(t => t.CDLID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CDL");
        }
    }
}
