namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRentalForTransactionView : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.NewRentals", name: "Customer_id", newName: "CustomerId");
            RenameColumn(table: "dbo.NewRentals", name: "Movie_Id", newName: "MovieId");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.NewRentals", name: "MovieId", newName: "Movie_Id");
            RenameColumn(table: "dbo.NewRentals", name: "CustomerId", newName: "Customer_id");
        }
    }
}
