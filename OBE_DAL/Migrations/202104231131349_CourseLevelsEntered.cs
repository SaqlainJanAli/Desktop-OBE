namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CourseLevelsEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"


INSERT INTO [dbo].[CourseLevels] ([LevelName]) VALUES ('Undergraduate')
INSERT INTO [dbo].[CourseLevels] ([LevelName]) VALUES ('Graduation')
INSERT INTO [dbo].[CourseLevels] ([LevelName]) VALUES ('PhD')


");
        }
        
        public override void Down()
        {
        }
    }
}
