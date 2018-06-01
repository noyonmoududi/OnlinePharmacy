namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cartOrderdatils1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartOrderDetails", "SubTotal", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartOrderDetails", "SubTotal");
        }
    }
}
