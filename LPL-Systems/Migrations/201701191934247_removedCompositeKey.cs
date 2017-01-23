namespace LPL_Systems.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removedCompositeKey : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Clients", name: "organizationID", newName: "organizationID1");
            AlterColumn("dbo.Clients", "organizationID1", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "organizationID1", c => c.Int(nullable: false, identity: true));
            RenameColumn(table: "dbo.Clients", name: "organizationID1", newName: "organizationID");
        }
    }
}
