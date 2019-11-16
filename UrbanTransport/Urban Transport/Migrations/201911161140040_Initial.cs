namespace Urban_Transport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DriverRoutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DriverId = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.DriverId, cascadeDelete: true)
                .ForeignKey("dbo.RoutesWorks", t => t.RouteId, cascadeDelete: true)
                .Index(t => t.DriverId)
                .Index(t => t.RouteId);
            
            CreateTable(
                "dbo.RoutesWorks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.String(),
                        TypeId = c.Int(nullable: false),
                        Fare = c.Double(nullable: false),
                        RouteStart = c.DateTime(nullable: false),
                        RouteStop = c.DateTime(nullable: false),
                        RangeOfMotion = c.DateTime(nullable: false),
                        RouteDuration = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TransportTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RouteId = c.Int(nullable: false),
                        StopStationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoutesWorks", t => t.RouteId, cascadeDelete: true)
                .ForeignKey("dbo.StopStations", t => t.StopStationId, cascadeDelete: true)
                .Index(t => t.RouteId)
                .Index(t => t.StopStationId);
            
            CreateTable(
                "dbo.StopStations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TransportTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DriverRoutes", "RouteId", "dbo.RoutesWorks");
            DropForeignKey("dbo.RoutesWorks", "TypeId", "dbo.TransportTypes");
            DropForeignKey("dbo.Routes", "StopStationId", "dbo.StopStations");
            DropForeignKey("dbo.Routes", "RouteId", "dbo.RoutesWorks");
            DropForeignKey("dbo.DriverRoutes", "DriverId", "dbo.Drivers");
            DropIndex("dbo.Routes", new[] { "StopStationId" });
            DropIndex("dbo.Routes", new[] { "RouteId" });
            DropIndex("dbo.RoutesWorks", new[] { "TypeId" });
            DropIndex("dbo.DriverRoutes", new[] { "RouteId" });
            DropIndex("dbo.DriverRoutes", new[] { "DriverId" });
            DropTable("dbo.TransportTypes");
            DropTable("dbo.StopStations");
            DropTable("dbo.Routes");
            DropTable("dbo.RoutesWorks");
            DropTable("dbo.DriverRoutes");
            DropTable("dbo.Drivers");
        }
    }
}
