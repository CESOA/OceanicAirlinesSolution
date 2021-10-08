namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Comment = c.String(),
                        DeliveryAddress_Id = c.Guid(),
                        PaymentInfo_Id = c.Guid(),
                        SelectedRoute_Id = c.Guid(),
                        UserInfo_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.DeliveryAddress_Id)
                .ForeignKey("dbo.Payments", t => t.PaymentInfo_Id)
                .ForeignKey("dbo.RouteOptions", t => t.SelectedRoute_Id)
                .ForeignKey("dbo.Users", t => t.UserInfo_Id)
                .Index(t => t.DeliveryAddress_Id)
                .Index(t => t.PaymentInfo_Id)
                .Index(t => t.SelectedRoute_Id)
                .Index(t => t.UserInfo_Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNo = c.String(),
                        Street = c.String(),
                        StreetNo = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CardholdersName = c.String(),
                        CardNo = c.String(),
                        ExpirationDate = c.String(),
                        Cvv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RouteOptions",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        ExpectedDeliveryTime = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Name = c.String(),
                        Phonenumber = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        LoggedStatus = c.Boolean(nullable: false),
                        Street = c.String(),
                        StreetNumber = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        CityFrom = c.String(),
                        CityTo = c.String(),
                        Weight = c.Double(nullable: false),
                        Duration = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        Cost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transports",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Company = c.String(),
                        BookingId = c.Guid(nullable: false),
                        TransportId = c.Guid(nullable: false),
                        CityFrom = c.String(),
                        CityTo = c.String(),
                        Weight = c.Double(nullable: false),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "UserInfo_Id", "dbo.Users");
            DropForeignKey("dbo.Orders", "SelectedRoute_Id", "dbo.RouteOptions");
            DropForeignKey("dbo.Orders", "PaymentInfo_Id", "dbo.Payments");
            DropForeignKey("dbo.Orders", "DeliveryAddress_Id", "dbo.Addresses");
            DropIndex("dbo.Orders", new[] { "UserInfo_Id" });
            DropIndex("dbo.Orders", new[] { "SelectedRoute_Id" });
            DropIndex("dbo.Orders", new[] { "PaymentInfo_Id" });
            DropIndex("dbo.Orders", new[] { "DeliveryAddress_Id" });
            DropTable("dbo.Transports");
            DropTable("dbo.Routes");
            DropTable("dbo.Users");
            DropTable("dbo.RouteOptions");
            DropTable("dbo.Payments");
            DropTable("dbo.Addresses");
            DropTable("dbo.Orders");
        }
    }
}
