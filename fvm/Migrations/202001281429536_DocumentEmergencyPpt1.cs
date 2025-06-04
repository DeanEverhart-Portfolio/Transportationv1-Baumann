namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DocumentEmergencyPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Document", "DocumentEmergency", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Document", "DocumentEmergency");
        }
    }
}
