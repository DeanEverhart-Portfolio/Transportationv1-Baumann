namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockDayOfWeek1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "ClockDayOfWeek", c => c.String());
            DropColumn("dbo.Clock", "ClockTimeAMPM");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clock", "ClockTimeAMPM", c => c.String());
            DropColumn("dbo.Clock", "ClockDayOfWeek");
        }
    }
}
