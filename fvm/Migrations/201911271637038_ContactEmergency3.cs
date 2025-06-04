namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactEmergency3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contact", "ContactEmergency");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contact", "ContactEmergency", c => c.Boolean());
        }
    }
}
