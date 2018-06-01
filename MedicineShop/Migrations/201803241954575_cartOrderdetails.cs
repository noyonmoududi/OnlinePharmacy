namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartOrderdetails : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CartOrderDetails", "Price", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CartOrderDetails", "Price", c => c.Int(nullable: false));
        }
    }
}
