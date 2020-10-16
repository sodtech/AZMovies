namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMoviePropertytoDateType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDAte", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDAte", c => c.String());
        }
    }
}
