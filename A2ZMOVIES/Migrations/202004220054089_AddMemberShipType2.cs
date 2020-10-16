namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShipType2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipTypeID", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypeID" });
            AddColumn("dbo.MemberShipTypes", "DurationInMonths", c => c.String());
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipTypeId");
            AddForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.MemberShipTypes", "DurationIMonths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "DurationIMonths", c => c.String());
            DropForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.MemberShipTypes", "DurationInMonths");
            CreateIndex("dbo.Customers", "MemberShipTypeID");
            AddForeignKey("dbo.Customers", "MemberShipTypeID", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
        }
    }
}
