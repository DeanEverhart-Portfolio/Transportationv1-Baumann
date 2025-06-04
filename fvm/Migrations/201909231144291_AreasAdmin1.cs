namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AreasAdmin1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin1",
                c => new
                    {
                        Admin1ID = c.Int(nullable: false, identity: true),
                        Admin1String = c.String(),
                    })
                .PrimaryKey(t => t.Admin1ID);
            
            CreateTable(
                "dbo.Admin2",
                c => new
                    {
                        Admin2ID = c.Int(nullable: false, identity: true),
                        Admin2String = c.String(),
                    })
                .PrimaryKey(t => t.Admin2ID);
            
            CreateTable(
                "dbo.Admin3",
                c => new
                    {
                        Admin3ID = c.Int(nullable: false, identity: true),
                        Admin1ID = c.Int(nullable: false),
                        Admin2ID = c.Int(nullable: false),
                        Admin3String = c.String(),
                    })
                .PrimaryKey(t => t.Admin3ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admin3");
            DropTable("dbo.Admin2");
            DropTable("dbo.Admin1");
        }
    }
}
