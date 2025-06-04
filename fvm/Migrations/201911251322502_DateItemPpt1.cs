namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateItemPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDateItem", c => c.String());
            AddColumn("dbo.Calendar", "CalendarDateCategory", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDateCategory");
            DropColumn("dbo.Calendar", "CalendarDateItem");
        }
    }
}
