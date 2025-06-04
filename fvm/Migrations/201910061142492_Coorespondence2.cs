namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coorespondence2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coorespondence", "CoorespondenceFrom", c => c.String());
            AddColumn("dbo.Coorespondence", "CoorespondenceImage", c => c.String());
            AddColumn("dbo.Coorespondence", "CoorespondenceSelect", c => c.Boolean());
            AddColumn("dbo.Coorespondence", "CoorespondenceInactive", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coorespondence", "CoorespondenceInactive");
            DropColumn("dbo.Coorespondence", "CoorespondenceSelect");
            DropColumn("dbo.Coorespondence", "CoorespondenceImage");
            DropColumn("dbo.Coorespondence", "CoorespondenceFrom");
        }
    }
}
