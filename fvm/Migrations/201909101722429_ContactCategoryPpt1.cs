namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactCategoryPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactCategory", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactCategory");
        }
    }
}
