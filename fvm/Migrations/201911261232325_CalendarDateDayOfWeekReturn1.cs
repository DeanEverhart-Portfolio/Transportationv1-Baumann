namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarDateDayOfWeekReturn1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDateDayOfWeekReturn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDateDayOfWeekReturn");
        }
    }
}
