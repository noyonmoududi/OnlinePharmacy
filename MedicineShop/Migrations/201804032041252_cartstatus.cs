namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartOrders", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartOrders", "Status");
        }
    }
}
