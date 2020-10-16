namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieGenreType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieGenres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "MovieGenreTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movies", "MovieGenreTypeId");
            AddForeignKey("dbo.Movies", "MovieGenreTypeId", "dbo.MovieGenres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "MovieGenreTypeId", "dbo.MovieGenres");
            DropIndex("dbo.Movies", new[] { "MovieGenreTypeId" });
            DropColumn("dbo.Movies", "MovieGenreTypeId");
            DropTable("dbo.MovieGenres");
        }
    }
}
