namespace LPL_Systems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class saltAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "salt", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "salt");
        }
    }
}
