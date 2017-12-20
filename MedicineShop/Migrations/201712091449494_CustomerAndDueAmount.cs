namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAndDueAmount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false),
                        Village = c.String(nullable: false),
                        PhoneNo = c.String(nullable: false),
                        City = c.String(),
                        District = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DueAmounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DueAmounts", "CustomerId", "dbo.Customers");
            DropIndex("dbo.DueAmounts", new[] { "CustomerId" });
            DropTable("dbo.DueAmounts");
            DropTable("dbo.Customers");
        }
    }
}
