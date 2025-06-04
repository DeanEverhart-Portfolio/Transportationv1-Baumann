namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactWebsiteDistrictPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactWebsiteDistrict", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactWebsiteDistrict");
        }
    }
}
