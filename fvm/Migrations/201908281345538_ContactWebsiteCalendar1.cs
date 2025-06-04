namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactWebsiteCalendar1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactWebsiteCalendar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactWebsiteCalendar");
        }
    }
}
