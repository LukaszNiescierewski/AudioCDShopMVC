namespace AudioCDShopMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewArrivals : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Albums", "IsNewArrival", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Albums", "IsNewArrival");
        }
    }
}
