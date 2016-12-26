namespace LPL_Systems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                        organizationID = c.Int(nullable: false, identity: true),
                        organizationName = c.String(nullable: false),
                        addressID = c.Int(nullable: false),
                        organizationURL = c.String(),
                        employeeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.organizationID)
                .ForeignKey("dbo.Addresses", t => t.addressID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.employeeID, cascadeDelete: true)
                .Index(t => t.addressID)
                .Index(t => t.employeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        employeeId = c.Int(nullable: false, identity: true),
                        password = c.String(nullable: false),
                        position = c.String(nullable: false),
                        firstName = c.String(nullable: false, maxLength: 30),
                        lastName = c.String(nullable: false, maxLength: 30),
                        emailAddress = c.String(),
                        phoneNumber = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.employeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "employeeID", "dbo.Employees");
            DropForeignKey("dbo.Clients", "addressID", "dbo.Addresses");
            DropIndex("dbo.Clients", new[] { "employeeID" });
            DropIndex("dbo.Clients", new[] { "addressID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
            DropTable("dbo.Addresses");
        }
    }
}
