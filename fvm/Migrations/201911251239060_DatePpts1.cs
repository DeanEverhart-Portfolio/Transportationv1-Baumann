namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatePpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDateLast2", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Calendar", "CalendarDateReturn", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDateReturn");
            DropColumn("dbo.Calendar", "CalendarDateLast2");
        }
    }
}
