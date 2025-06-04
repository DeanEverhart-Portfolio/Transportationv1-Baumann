namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coorespondence31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coorespondence", "CoorespondenceDescription", c => c.String());
            AddColumn("dbo.Coorespondence", "CoorespondenceTag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coorespondence", "CoorespondenceTag");
            DropColumn("dbo.Coorespondence", "CoorespondenceDescription");
        }
    }
}
