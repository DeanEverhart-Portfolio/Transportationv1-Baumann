namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockAMPM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "ClockAMPM", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clock", "ClockAMPM");
        }
    }
}
