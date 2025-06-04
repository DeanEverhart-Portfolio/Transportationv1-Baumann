namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunRel3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Run", "RunDistrict", c => c.String());
            AddColumn("dbo.Run", "RunHardware", c => c.String());
            AddColumn("dbo.Run", "RunSupervision", c => c.String());
            AddColumn("dbo.Run", "RunMonitors", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Run", "RunMonitors");
            DropColumn("dbo.Run", "RunSupervision");
            DropColumn("dbo.Run", "RunHardware");
            DropColumn("dbo.Run", "RunDistrict");
        }
    }
}
