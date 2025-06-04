namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Menu1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        MenuDesignator = c.String(),
                    })
                .PrimaryKey(t => t.MenuID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Menu");
        }
    }
}
