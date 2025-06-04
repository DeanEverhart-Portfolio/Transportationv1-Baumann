namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactCalendarPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactCalendar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactCalendar");
        }
    }
}
