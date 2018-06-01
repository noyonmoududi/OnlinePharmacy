namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartordervalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CartOrders", "OrderShipName", c => c.String(nullable: false));
            AlterColumn("dbo.CartOrders", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.CartOrders", "District", c => c.String(nullable: false));
            AlterColumn("dbo.CartOrders", "PhoneNo", c => c.String(nullable: false));
            AlterColumn("dbo.CartOrders", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CartOrders", "Email", c => c.String());
            AlterColumn("dbo.CartOrders", "PhoneNo", c => c.String());
            AlterColumn("dbo.CartOrders", "District", c => c.String());
            AlterColumn("dbo.CartOrders", "Address", c => c.String());
            AlterColumn("dbo.CartOrders", "OrderShipName", c => c.String());
        }
    }
}
