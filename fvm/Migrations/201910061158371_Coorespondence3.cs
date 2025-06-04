namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coorespondence3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coorespondence", "CoorespondenceAMPM", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coorespondence", "CoorespondenceAMPM");
        }
    }
}
