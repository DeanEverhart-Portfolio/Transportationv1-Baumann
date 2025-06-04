namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarDisplayPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDisplay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDisplay");
        }
    }
}
