namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockInactivePpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "ClockInactive", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clock", "ClockInactive");
        }
    }
}
