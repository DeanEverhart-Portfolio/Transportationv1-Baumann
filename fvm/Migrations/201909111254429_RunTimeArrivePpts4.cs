namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunTimeArrivePpts4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Run", "RunTimeArriveDayOfWeek", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Run", "RunTimeArriveDayOfWeek");
        }
    }
}
