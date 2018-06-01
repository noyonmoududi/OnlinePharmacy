namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdminMassages", "Massage", c => c.String(nullable: false));
            AlterColumn("dbo.AdminMassages", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Group", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "CompannyName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.CourierMessages", "Message", c => c.String(nullable: false));
            AlterColumn("dbo.CourierMessages", "PhoneNo", c => c.String(nullable: true));
            AlterColumn("dbo.CourierMessages", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.DeliveryManMessages", "Message", c => c.String(nullable: false));
            AlterColumn("dbo.DeliveryManMessages", "PhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.DeliveryManMessages", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.PrescriptionModels", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.PrescriptionModels", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.PrescriptionModels", "PhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.PrescriptionModels", "PrescriptionImage", c => c.Binary(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PrescriptionModels", "PrescriptionImage", c => c.Binary());
            AlterColumn("dbo.PrescriptionModels", "PhoneNo", c => c.String());
            AlterColumn("dbo.PrescriptionModels", "Address", c => c.String());
            AlterColumn("dbo.PrescriptionModels", "Name", c => c.String());
            AlterColumn("dbo.DeliveryManMessages", "Location", c => c.String());
            AlterColumn("dbo.DeliveryManMessages", "PhoneNo", c => c.String());
            AlterColumn("dbo.DeliveryManMessages", "Message", c => c.String());
            AlterColumn("dbo.CourierMessages", "Location", c => c.String());
            AlterColumn("dbo.CourierMessages", "PhoneNo", c => c.String());
            AlterColumn("dbo.CourierMessages", "Message", c => c.String());
            AlterColumn("dbo.Products", "Location", c => c.String());
            AlterColumn("dbo.Products", "CompannyName", c => c.String());
            AlterColumn("dbo.Products", "Group", c => c.String());
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
            AlterColumn("dbo.AdminMassages", "Location", c => c.String());
            AlterColumn("dbo.AdminMassages", "Massage", c => c.String());
        }
    }
}
