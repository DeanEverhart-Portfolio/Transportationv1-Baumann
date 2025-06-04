namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalendarBoolPpt1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendar", "ContactSelect", c => c.Boolean());
            AddColumn("dbo.Calendar", "ContactInactive", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendar", "ContactInactive");
            DropColumn("dbo.Calendar", "ContactSelect");
        }
    }
}
