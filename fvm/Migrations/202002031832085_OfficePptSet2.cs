namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OfficePptSet2 : DbMigration
    {
        public override void Up()
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
        
        public override void Down()
        {
            DropTable("dbo.Office");
        }
    }
}
