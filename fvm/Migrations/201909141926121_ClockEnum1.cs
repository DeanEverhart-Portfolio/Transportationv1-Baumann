namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockEnum1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clock", "Run", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clock", "Run");
        }
    }
}
