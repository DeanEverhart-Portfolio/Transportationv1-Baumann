namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunTimeArrivePpts2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Run", "RunTimeArriveHr", c => c.Int());
            AlterColumn("dbo.Run", "RunTimeArriveMin", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Run", "RunTimeArriveMin", c => c.Int(nullable: false));
            AlterColumn("dbo.Run", "RunTimeArriveHr", c => c.Int(nullable: false));
        }
    }
}
