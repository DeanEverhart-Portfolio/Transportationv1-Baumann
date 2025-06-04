namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarAdditionalInformationPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "CalendarDateAdditionalInformation", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "CalendarDateAdditionalInformation");
        }
    }
}
