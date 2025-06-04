namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunTimeArrivePpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Run", "RunTimeArriveHr", c => c.Int(nullable: false));
            AddColumn("dbo.Run", "RunTimeArriveMin", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Run", "RunTimeArriveMin");
            DropColumn("dbo.Run", "RunTimeArriveHr");
        }
    }
}
