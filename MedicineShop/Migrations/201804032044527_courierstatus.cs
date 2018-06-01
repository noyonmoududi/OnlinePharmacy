namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class courierstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CourierMessages", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CourierMessages", "Status");
        }
    }
}
