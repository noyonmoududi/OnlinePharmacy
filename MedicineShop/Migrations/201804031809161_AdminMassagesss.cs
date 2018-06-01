namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminMassagesss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminMassages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Massage = c.String(),
                        Location = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        CartOrderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CartOrders", t => t.CartOrderId, cascadeDelete: true)
                .Index(t => t.CartOrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminMassages", "CartOrderId", "dbo.CartOrders");
            DropIndex("dbo.AdminMassages", new[] { "CartOrderId" });
            DropTable("dbo.AdminMassages");
        }
    }
}
