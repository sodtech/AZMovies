namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddnewproperyinMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDAte", c => c.String());
            AddColumn("dbo.Movies", "DateAdded", c => c.String());
            AddColumn("dbo.Movies", "NumberInStock", c => c.String());
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Movies");
            AddPrimaryKey("dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Movies");
            AddPrimaryKey("dbo.Movies", "id");
            AlterColumn("dbo.Movies", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Movies", "NumberInStock");
            DropColumn("dbo.Movies", "DateAdded");
            DropColumn("dbo.Movies", "ReleaseDAte");
        }
    }
}
