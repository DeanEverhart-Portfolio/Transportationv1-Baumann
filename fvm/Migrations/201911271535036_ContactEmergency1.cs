namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactEmergency1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactEmergency", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactEmergency");
        }
    }
}
