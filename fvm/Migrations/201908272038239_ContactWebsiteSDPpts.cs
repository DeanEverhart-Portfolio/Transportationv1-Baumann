namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactWebsiteSDPpts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactSchoolDistrict", c => c.String());
            AddColumn("dbo.Contact", "ContactWebsite", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactWebsite");
            DropColumn("dbo.Contact", "ContactSchoolDistrict");
        }
    }
}
