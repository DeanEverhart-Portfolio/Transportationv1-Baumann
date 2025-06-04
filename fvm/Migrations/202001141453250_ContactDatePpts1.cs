namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactDatePpts1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactDateHire", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Contact", "ContactDatePick", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Contact", "ContactDateSeniority", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactDateSeniority");
            DropColumn("dbo.Contact", "ContactDatePick");
            DropColumn("dbo.Contact", "ContactDateHire");
        }
    }
}
