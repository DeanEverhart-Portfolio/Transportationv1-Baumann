namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactEmergency5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactEmergency", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactEmergency");
        }
    }
}
