namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarDisplayPpt3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDisplay", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDisplay");
        }
    }
}
