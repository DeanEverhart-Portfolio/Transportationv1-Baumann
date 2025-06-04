namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Education3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CDL", "CDLSelect", c => c.Boolean());
            AddColumn("dbo.CDL", "CDLInactive", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CDL", "CDLInactive");
            DropColumn("dbo.CDL", "CDLSelect");
        }
    }
}
