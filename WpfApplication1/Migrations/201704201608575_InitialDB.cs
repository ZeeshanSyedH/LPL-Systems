namespace LPLSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        addressID = c.Int(nullable: false, identity: true),
                        civicNumber = c.Int(nullable: false),
                        street = c.String(nullable: false, maxLength: 40),
                        city = c.String(nullable: false, maxLength: 40),
                        zipCode = c.String(nullable: false, maxLength: 6),
                    })
                .PrimaryKey(t => t.addressID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        organizationID = c.Guid(nullable: false),
                        organizationID1 = c.Int(nullable: false),
                        organizationName = c.String(nullable: false),
                        addressID = c.Int(nullable: false),
                        organizationURL = c.String(),
                        employeeID = c.Int(nullable: false),
                        Employee_id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.organizationID)
                .ForeignKey("dbo.Addresses", t => t.addressID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .Index(t => t.addressID)
                .Index(t => t.Employee_id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employeeId = c.Guid(nullable: false),
                        password = c.String(nullable: false),
                        salt = c.String(nullable: false),
                        position = c.String(nullable: false),
                        firstName = c.String(nullable: false, maxLength: 30),
                        lastName = c.String(nullable: false, maxLength: 30),
                        emailAddress = c.String(),
                        phoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.employeeId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        invoiceID = c.Int(nullable: false, identity: true),
                        organizationID = c.Int(nullable: false),
                        pickupLocation = c.String(nullable: false),
                        dropoffLocation = c.String(nullable: false),
                        employeeID = c.Int(nullable: false),
                        Employee_id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.invoiceID)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .Index(t => t.Employee_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.Clients", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.Clients", "addressID", "dbo.Addresses");
            DropIndex("dbo.Invoices", new[] { "Employee_id" });
            DropIndex("dbo.Clients", new[] { "Employee_id" });
            DropIndex("dbo.Clients", new[] { "addressID" });
            DropTable("dbo.Invoices");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Addresses");
        }
    }
}
