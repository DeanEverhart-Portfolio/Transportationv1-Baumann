namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactTimeArrivePpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactTimeArrive", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contact", "ContactTimeArrive");
        }
    }
}
