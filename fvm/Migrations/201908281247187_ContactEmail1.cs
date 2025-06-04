namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactEmail1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactEmail");
        }
    }
}
