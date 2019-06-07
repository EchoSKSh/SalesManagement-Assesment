namespace SalesManagement.BOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStringLenght : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SalesRepresentatives", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.WorkRoutes", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkRoutes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.SalesRepresentatives", "Name", c => c.String(nullable: false));
        }
    }
}
