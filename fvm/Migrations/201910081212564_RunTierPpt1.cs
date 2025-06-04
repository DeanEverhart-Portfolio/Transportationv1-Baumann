namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunTierPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Run", "RunSequence", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Run", "RunSequence");
        }
    }
}
