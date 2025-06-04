namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarPublishPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarPublish", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarPublish");
        }
    }
}
