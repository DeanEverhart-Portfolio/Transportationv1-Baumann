namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoorespondenceDayOfWeekPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coorespondence", "CoorespondenceDayOfWeek", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coorespondence", "CoorespondenceDayOfWeek");
        }
    }
}
