namespace LPL_Systems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneDatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "phoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "phoneNumber", c => c.Double(nullable: false));
        }
    }
}
