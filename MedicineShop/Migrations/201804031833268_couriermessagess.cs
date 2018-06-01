namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class couriermessagess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourierMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        PhoneNo = c.String(),
                        Location = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        AdminMassageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdminMassages", t => t.AdminMassageId, cascadeDelete: true)
                .Index(t => t.AdminMassageId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourierMessages", "AdminMassageId", "dbo.AdminMassages");
            DropIndex("dbo.CourierMessages", new[] { "AdminMassageId" });
            DropTable("dbo.CourierMessages");
        }
    }
}
