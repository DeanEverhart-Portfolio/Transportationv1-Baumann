namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeIntsPpts2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coorespondence", "CoorespondenceTimeHr", c => c.Int(nullable: false));
            DropColumn("dbo.Coorespondence", "CoorespondenceTimeHour");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coorespondence", "CoorespondenceTimeHour", c => c.Int(nullable: false));
            DropColumn("dbo.Coorespondence", "CoorespondenceTimeHr");
        }
    }
}
