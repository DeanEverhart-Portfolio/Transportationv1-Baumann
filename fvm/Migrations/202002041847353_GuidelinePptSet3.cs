namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuidelinePptSet3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sign", "SignDesignator", c => c.String());
            DropColumn("dbo.Sign", "SignDescriptor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sign", "SignDescriptor", c => c.String());
            DropColumn("dbo.Sign", "SignDesignator");
        }
    }
}
