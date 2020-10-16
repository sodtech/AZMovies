namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateOfBritheTOCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBrith", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBrith", c => c.DateTime(nullable: false));
        }
    }
}
