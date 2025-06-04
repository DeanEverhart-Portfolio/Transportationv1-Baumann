namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarDatePublishPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDatePublish", c => c.Boolean());
            DropColumn("dbo.Calendar", "CalendarPublish");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Calendar", "CalendarPublish", c => c.Boolean());
            DropColumn("dbo.Calendar", "CalendarDatePublish");
        }
    }
}
