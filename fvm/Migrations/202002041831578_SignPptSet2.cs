namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SignPptSet2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Sign");
        }
        
        public override void Down()
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
    }
}
