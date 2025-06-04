namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactEmergency2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contact", "ContactEmergency", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contact", "ContactEmergency", c => c.Boolean(nullable: false));
        }
    }
}
