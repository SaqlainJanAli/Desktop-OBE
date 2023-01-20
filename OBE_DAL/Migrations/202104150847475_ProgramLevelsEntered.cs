namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ProgramLevelsEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('Pre-School')
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('Primary 5 Years')
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('Middle 8 Years')
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('High 10 Years')
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('Intermediate 12 Years')
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('Bachelor 16 Years')
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('Master 18 Years')
INSERT INTO [dbo].[ProgramLevels] ([Name]) VALUES ('Doctor of Philosophy 20 Years')
");
        }
        
        public override void Down()
        {
        }
    }
}
