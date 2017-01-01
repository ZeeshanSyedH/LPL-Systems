namespace LPL_Systems.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class invoiceAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                {
                    invoiceID = c.Int(nullable: false, identity: true),
                    organizationID = c.Int(nullable: false),
                    employeeID = c.Int(nullable: false),
                    dropoffLocation_addressID = c.Int(nullable: false),
                    pickupLocation_addressID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.invoiceID)
                .ForeignKey("dbo.Addresses", t => t.dropoffLocation_addressID, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.employeeID, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.pickupLocation_addressID, cascadeDelete: false)
                .Index(t => t.employeeID)
                .Index(t => t.dropoffLocation_addressID)
                .Index(t => t.pickupLocation_addressID);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "pickupLocation_addressID", "dbo.Addresses");
            DropForeignKey("dbo.Invoices", "employeeID", "dbo.Employees");
            DropForeignKey("dbo.Invoices", "dropoffLocation_addressID", "dbo.Addresses");
            DropIndex("dbo.Invoices", new[] { "pickupLocation_addressID" });
            DropIndex("dbo.Invoices", new[] { "dropoffLocation_addressID" });
            DropIndex("dbo.Invoices", new[] { "employeeID" });
            DropTable("dbo.Invoices");
        }
    }
}
