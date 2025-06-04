namespace fvm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calendar",
                c => new
                    {
                        CalendarID = c.Int(nullable: false, identity: true),
                        ContactID = c.Int(nullable: false),
                        CalendarDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        CalendarDateDayOfWeek = c.String(),
                        CalendarDateHoliday = c.String(),
                        CalendarDateSchoolEvent = c.String(),
                    })
                .PrimaryKey(t => t.CalendarID)
                .ForeignKey("dbo.Contact", t => t.ContactID, cascadeDelete: true)
                .Index(t => t.ContactID);
            
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        ContactDesignator = c.String(),
                        ContactNameFirst = c.String(),
                        ContactEmployeeID = c.String(),
                        ContactPhoneLabel1 = c.String(),
                        ContactPhoneAreaCode1 = c.String(),
                        ContactPhone1 = c.String(),
                        ContactPhoneLabel2 = c.String(),
                        ContactPhoneAreaCode2 = c.String(),
                        ContactPhone2 = c.String(),
                        ContactPhoneLabel3 = c.String(),
                        ContactPhoneAreaCode3 = c.String(),
                        ContactPhone3 = c.String(),
                        ContactWirelessCarrier = c.String(),
                        ContactAddressStreetNumber1 = c.String(),
                        ContactAddressStreet1 = c.String(),
                        ContactAddressStreetType1 = c.String(),
                        ContactAddressStreetNumber2 = c.String(),
                        ContactAddressStreet2 = c.String(),
                        ContactAddressStreetType2 = c.String(),
                        ContactAddressCityTown = c.String(),
                        ContactAddressZipCode = c.String(),
                        ContactAddressDirections = c.String(),
                        ContactAddressMap = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calendar", "ContactID", "dbo.Contact");
            DropIndex("dbo.Calendar", new[] { "ContactID" });
            DropTable("dbo.Contact");
            DropTable("dbo.Calendar");
        }
    }
}
