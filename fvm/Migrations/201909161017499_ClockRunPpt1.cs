namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockRunPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "ClockRun", c => c.Int());
            DropColumn("dbo.Clock", "Run");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clock", "Run", c => c.Int());
            DropColumn("dbo.Clock", "ClockRun");
        }
    }
}
