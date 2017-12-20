namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class location : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Location");
        }
    }
}
