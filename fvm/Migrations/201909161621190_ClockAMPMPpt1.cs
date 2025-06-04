namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockAMPMPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "ClockTimeAMPM", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clock", "ClockTimeAMPM");
        }
    }
}
