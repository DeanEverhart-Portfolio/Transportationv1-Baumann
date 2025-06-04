namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactEmergency7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactEmergency", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactEmergency");
        }
    }
}
