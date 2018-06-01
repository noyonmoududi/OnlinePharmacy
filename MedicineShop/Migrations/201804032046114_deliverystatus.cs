namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deliverystatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DeliveryManMessages", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DeliveryManMessages", "Status");
        }
    }
}
