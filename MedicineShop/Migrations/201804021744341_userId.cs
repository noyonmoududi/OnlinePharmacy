namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartOrders", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartOrders", "UserId");
        }
    }
}
