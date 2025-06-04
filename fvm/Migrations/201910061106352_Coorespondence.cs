namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coorespondence : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coorespondence",
                c => new
                    {
                        CoorespondenceID = c.Int(nullable: false, identity: true),
                        CoorespondenceCategory = c.String(),
                        CoorespondenceCategorySub = c.String(),
                        CoorespondenceText = c.String(),
                        CoorespondenceTextFull = c.String(),
                        CoorespondenceDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CoorespondenceTime = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.CoorespondenceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Coorespondence");
        }
    }
}
