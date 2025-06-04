namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockRunDesignatorPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "ClockRunDesignator", c => c.Int());
            DropColumn("dbo.Clock", "ClockRun");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clock", "ClockRun", c => c.Int());
            DropColumn("dbo.Clock", "ClockRunDesignator");
        }
    }
}
