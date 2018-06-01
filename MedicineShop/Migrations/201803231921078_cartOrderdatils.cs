namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartOrderdatils : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CartOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CartOrders", t => t.CartOrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.CartOrderId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartOrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.CartOrderDetails", "CartOrderId", "dbo.CartOrders");
            DropIndex("dbo.CartOrderDetails", new[] { "ProductId" });
            DropIndex("dbo.CartOrderDetails", new[] { "CartOrderId" });
            DropTable("dbo.CartOrderDetails");
        }
    }
}
