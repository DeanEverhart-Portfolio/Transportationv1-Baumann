namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactTimeStart1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ClockTimeStart", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ClockTimeStart");
        }
    }
}
