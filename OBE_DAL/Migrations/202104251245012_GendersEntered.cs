namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class GendersEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[Genders] ([Name]) VALUES ('Male')
INSERT INTO [dbo].[Genders] ([Name]) VALUES ('Female')
INSERT INTO [dbo].[Genders] ([Name]) VALUES ('Others')



");
        }
        
        public override void Down()
        {
        }
    }
}
