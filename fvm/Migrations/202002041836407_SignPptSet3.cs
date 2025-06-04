namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SignPptSet3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sign",
                c => new
                    {
                        SignID = c.Int(nullable: false, identity: true),
                        SignDescriptor = c.String(),
                        SignText = c.String(),
                        SignCategory = c.String(),
                        SignCategorySub = c.String(),
                        SignURLAccess = c.String(),
                    })
                .PrimaryKey(t => t.SignID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sign");
        }
    }
}
