namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovieGenreName : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOVIEGENRES (Id , GenreName ) VALUES (1 , 'Kid')");
            Sql("INSERT INTO MOVIEGENRES (Id , GenreName ) VALUES (2 , 'Romance')");
            Sql("INSERT INTO MOVIEGENRES (Id , GenreName ) VALUES (3 , 'Action')");
            Sql("INSERT INTO MOVIEGENRES (Id , GenreName ) VALUES (4, 'Family')");
            Sql("INSERT INTO MOVIEGENRES (Id , GenreName ) VALUES (5, 'Comendy')");
            Sql("INSERT INTO MOVIEGENRES (Id , GenreName ) VALUES (6, 'Documentary')");
   
        }
        
        public override void Down()
        {
        }
    }
}
