namespace SalesManagement.BOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalesRepresentatives", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SalesRepresentatives", "Comment");
        }
    }
}
