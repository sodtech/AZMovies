namespace A2ZMOVIES.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRolesTotheApp : DbMigration
    {
        public override void Up()
        {

            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'959d8777-24e7-4748-92b6-59959bf84570', N'Admin', N'AIWladpZCjelZLVPu12Yq3Pk4JPW4fNZblQIuC3W9SxVprd/GFssSAO/qRa/+j+jkw==', N'fb0b67d5-46c3-4872-88c5-199190ef7068', N'ApplicationUser')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'cbd38ed2-b249-468d-a57c-e9488e689538', N'guess', N'AGrNOOLrU+QyNSmj9jkaPUHaJh7ZpAk7wmkjbTdgLsUGzJXFdDyA7PnOw0Tr4/64xg==', N'fc42f9c1-3c43-4b18-9a5a-3a96dd0af301', N'ApplicationUser')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'23c50858-710a-4ddc-b2f9-d533f5857df9', N'canManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'959d8777-24e7-4748-92b6-59959bf84570', N'23c50858-710a-4ddc-b2f9-d533f5857df9')



"

                );
        }
        
        public override void Down()
        {
        }
    }
}
