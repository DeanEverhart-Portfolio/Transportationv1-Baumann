namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockTimeAMPM1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "ClockTimeAMPM", c => c.String());
            DropColumn("dbo.Clock", "ClockAMPM");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clock", "ClockAMPM", c => c.String());
            DropColumn("dbo.Clock", "ClockTimeAMPM");
        }
    }
}
