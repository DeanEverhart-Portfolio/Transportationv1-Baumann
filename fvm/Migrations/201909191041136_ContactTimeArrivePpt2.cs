namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactTimeArrivePpt2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "ContactTimeArriveAM", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Contact", "ContactTimeArrivePM", c => c.DateTime(precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Contact", "ContactTimeStart");
            DropColumn("dbo.Contact", "ContactTimeArrive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contact", "ContactTimeArrive", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Contact", "ContactTimeStart", c => c.DateTime(precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Contact", "ContactTimeArrivePM");
            DropColumn("dbo.Contact", "ContactTimeArriveAM");
        }
    }
}
