namespace Adminka.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttribute : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductEntities", newName: "Products");
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String());
            RenameTable(name: "dbo.Products", newName: "ProductEntities");
        }
    }
}
