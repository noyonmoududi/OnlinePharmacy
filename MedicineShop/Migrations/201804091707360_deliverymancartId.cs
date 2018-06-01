namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deliverymancartId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeliveryManMessages", "CartOrderId", c => c.Int());
            CreateIndex("dbo.DeliveryManMessages", "CartOrderId");
            AddForeignKey("dbo.DeliveryManMessages", "CartOrderId", "dbo.CartOrders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeliveryManMessages", "CartOrderId", "dbo.CartOrders");
            DropIndex("dbo.DeliveryManMessages", new[] { "CartOrderId" });
            DropColumn("dbo.DeliveryManMessages", "CartOrderId");
        }
    }
}
