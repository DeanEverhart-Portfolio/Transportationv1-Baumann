namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClockEnumRemove1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clock", "ClockRunDesignator", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clock", "ClockRunDesignator", c => c.Int());
        }
    }
}
