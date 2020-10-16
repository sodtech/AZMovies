namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMigrationType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypeS (SignUpFee , DiscountRate , DurationInMonthS) VALUES (0,0,0) ");
            Sql("INSERT INTO MemberShipTypeS (SignUpFee , DiscountRate , DurationInMonthS) VALUES (30,1,10) ");
            Sql("INSERT INTO MemberShipTypeS (SignUpFee , DiscountRate , DurationInMonthS) VALUES (90,3,15) ");
            Sql("INSERT INTO MemberShipTypeS (SignUpFee , DiscountRate , DurationInMonthS) VALUES (300,12,20) ");
        }
        
        public override void Down()
        {
        }
    }
}
