namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SemesterTypesEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[SemesterTypes] ([Name]) VALUES ('Fall')
INSERT INTO [dbo].[SemesterTypes] ([Name]) VALUES ('Spring')
INSERT INTO [dbo].[SemesterTypes] ([Name]) VALUES ('Summer')
INSERT INTO [dbo].[SemesterTypes] ([Name]) VALUES ('Winter')

");
        }
        
        public override void Down()
        {
        }
    }
}
