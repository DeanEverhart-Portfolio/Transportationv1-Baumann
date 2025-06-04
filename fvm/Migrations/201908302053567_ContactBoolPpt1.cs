namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactBoolPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactSelect", c => c.Boolean());
            AddColumn("dbo.Contact", "ContactInactive", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactInactive");
            DropColumn("dbo.Contact", "ContactSelect");
        }
    }
}
