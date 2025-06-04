namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarDateFirstLastPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDateFirst", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Calendar", "CalendarDateLast", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDateLast");
            DropColumn("dbo.Calendar", "CalendarDateFirst");
        }
    }
}
