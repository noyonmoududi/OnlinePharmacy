namespace MedicineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adminstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AdminMassages", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AdminMassages", "Status");
        }
    }
}
