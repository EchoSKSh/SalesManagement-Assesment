namespace SalesManagement.BOL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SalesRepresentatives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        TelephoneNumber = c.Int(nullable: false),
                        JoinedDate = c.DateTime(),
                        WorkRouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.WorkRoutes", t => t.WorkRouteId, cascadeDelete: true)
                .Index(t => t.WorkRouteId);
            
            CreateTable(
                "dbo.WorkRoutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesRepresentatives", "WorkRouteId", "dbo.WorkRoutes");
            DropIndex("dbo.SalesRepresentatives", new[] { "WorkRouteId" });
            DropTable("dbo.WorkRoutes");
            DropTable("dbo.SalesRepresentatives");
        }
    }
}
