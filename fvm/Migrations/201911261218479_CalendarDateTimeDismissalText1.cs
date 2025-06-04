namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarDateTimeDismissalText1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDateTimeDismissalText", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDateTimeDismissalText");
        }
    }
}
