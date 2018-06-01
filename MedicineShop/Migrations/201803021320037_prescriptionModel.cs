namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prescriptionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrescriptionModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PhoneNo = c.String(),
                        PrescriptionImage = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PrescriptionModels");
        }
    }
}
