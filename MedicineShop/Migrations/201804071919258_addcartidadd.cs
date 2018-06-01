namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcartidadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourierMessages", "CartOrderId", c => c.Int());
            CreateIndex("dbo.CourierMessages", "CartOrderId");
            AddForeignKey("dbo.CourierMessages", "CartOrderId", "dbo.CartOrders", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourierMessages", "CartOrderId", "dbo.CartOrders");
            DropIndex("dbo.CourierMessages", new[] { "CartOrderId" });
            DropColumn("dbo.CourierMessages", "CartOrderId");
        }
    }
}
