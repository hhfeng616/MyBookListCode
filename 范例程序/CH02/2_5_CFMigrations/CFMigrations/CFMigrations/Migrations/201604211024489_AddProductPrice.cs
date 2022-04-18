namespace CFMigrations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Price");
        }
    }
}
