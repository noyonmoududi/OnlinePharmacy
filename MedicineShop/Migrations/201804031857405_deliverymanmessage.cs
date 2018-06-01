namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deliverymanmessage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeliveryManMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        PhoneNo = c.String(),
                        Location = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        CourierMessageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CourierMessages", t => t.CourierMessageId, cascadeDelete: true)
                .Index(t => t.CourierMessageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeliveryManMessages", "CourierMessageId", "dbo.CourierMessages");
            DropIndex("dbo.DeliveryManMessages", new[] { "CourierMessageId" });
            DropTable("dbo.DeliveryManMessages");
        }
    }
}
