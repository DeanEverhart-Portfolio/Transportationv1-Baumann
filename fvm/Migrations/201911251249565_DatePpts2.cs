namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatePpts2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDateStart", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Calendar", "CalendarDateEnd1", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Calendar", "CalendarDateEnd2", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDateEnd2");
            DropColumn("dbo.Calendar", "CalendarDateEnd1");
            DropColumn("dbo.Calendar", "CalendarDateStart");
        }
    }
}
