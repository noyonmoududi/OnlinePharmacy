namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ordercarts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderShipName = c.String(),
                        Address = c.String(),
                        District = c.String(),
                        PhoneNo = c.String(),
                        Email = c.String(),
                        TotalAmount = c.Single(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CartOrders");
        }
    }
}
