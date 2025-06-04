namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactDesignator2Ppt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactDesignator2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactDesignator2");
        }
    }
}
