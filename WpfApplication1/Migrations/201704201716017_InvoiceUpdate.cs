namespace LPLSystems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InvoiceUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Invoices", "Employee_id", "dbo.Employees");
            DropIndex("dbo.Invoices", new[] { "Employee_id" });
            DropColumn("dbo.Invoices", "Employee_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "Employee_id", c => c.Guid(nullable: false));
            CreateIndex("dbo.Invoices", "Employee_id");
            AddForeignKey("dbo.Invoices", "Employee_id", "dbo.Employees", "employeeId", cascadeDelete: true);
        }
    }
}
