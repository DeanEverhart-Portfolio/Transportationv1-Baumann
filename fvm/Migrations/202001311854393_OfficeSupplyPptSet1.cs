namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OfficeSupplyPptSet1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supply",
                c => new
                    {
                        SupplyID = c.Int(nullable: false, identity: true),
                        SupplyItem = c.String(),
                        SupplyModelNumber = c.String(),
                        SupplySerialNumber = c.String(),
                        SupplyVariety = c.String(),
                        SupplyColor = c.String(),
                        SupplyDescription = c.String(),
                        SupplySelect = c.Boolean(),
                        SupplyCount = c.Int(),
                        SupplyPack = c.Int(),
                    })
                .PrimaryKey(t => t.SupplyID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Supply");
        }
    }
}
