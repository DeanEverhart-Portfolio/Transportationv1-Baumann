namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeIntsPpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coorespondence", "CoorespondenceTimeHour", c => c.Int(nullable: false));
            AddColumn("dbo.Coorespondence", "CoorespondenceTimeMin", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coorespondence", "CoorespondenceTimeMin");
            DropColumn("dbo.Coorespondence", "CoorespondenceTimeHour");
        }
    }
}
