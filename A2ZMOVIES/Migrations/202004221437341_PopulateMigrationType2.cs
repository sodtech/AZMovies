namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMigrationType2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE  MemberShipTypeS  SET SignUpFee = 0, DiscountRate = 0, DurationInMonthS = 0, Name ='Pay As You Go' WHERE Id = 1");
            Sql("UPDATE  MemberShipTypeS  SET SignUpFee = 30, DiscountRate = 10, DurationInMonthS = 1, Name ='Monthly'  WHERE Id = 2");
            Sql("UPDATE  MemberShipTypeS  SET SignUpFee = 90, DiscountRate = 15, DurationInMonthS = 3, Name ='Quaterly' WHERE Id = 3 ");
            Sql("UPDATE  MemberShipTypeS SET  SignUpFee = 300, DiscountRate = 20, DurationInMonthS = 12, Name ='Yearly' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
