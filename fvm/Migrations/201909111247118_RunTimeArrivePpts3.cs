namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunTimeArrivePpts3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Run", "RunTimeArriveAMPM", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Run", "RunTimeArriveAMPM");
        }
    }
}
