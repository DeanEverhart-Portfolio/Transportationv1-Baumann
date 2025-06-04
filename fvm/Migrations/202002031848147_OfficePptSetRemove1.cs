namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OfficePptSetRemove1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Office");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Office",
                c => new
                    {
                        OfficeID = c.Int(nullable: false, identity: true),
                        OfficeMenuItem = c.String(),
                    })
                .PrimaryKey(t => t.OfficeID);
            
        }
    }
}
