namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactTitle1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactTitle");
        }
    }
}
