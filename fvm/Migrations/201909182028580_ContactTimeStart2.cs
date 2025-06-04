namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactTimeStart2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactTimeStart", c => c.DateTime(precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Contact", "ClockTimeStart");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contact", "ClockTimeStart", c => c.DateTime(precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Contact", "ContactTimeStart");
        }
    }
}
