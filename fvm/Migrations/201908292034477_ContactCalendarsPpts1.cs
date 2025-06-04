namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactCalendarsPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactCalendarOneSheet", c => c.String());
            AddColumn("dbo.Contact", "ContactCalendarWebsite", c => c.String());
            AddColumn("dbo.Contact", "ContactCalendarPublished", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactCalendarPublished");
            DropColumn("dbo.Contact", "ContactCalendarWebsite");
            DropColumn("dbo.Contact", "ContactCalendarOneSheet");
        }
    }
}
