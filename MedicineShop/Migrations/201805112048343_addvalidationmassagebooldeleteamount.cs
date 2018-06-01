namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addvalidationmassagebooldeleteamount : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CartOrders", "TotalAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CartOrders", "TotalAmount", c => c.Single(nullable: false));
        }
    }
}
