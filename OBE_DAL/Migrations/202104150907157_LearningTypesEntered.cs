namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class LearningTypesEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[LearningTypes] ([Name]) VALUES ('Visual')

INSERT INTO [dbo].[LearningTypes] ([Name]) VALUES ('Auditory')

INSERT INTO [dbo].[LearningTypes] ([Name]) VALUES ('Reading/Writing')

INSERT INTO [dbo].[LearningTypes] ([Name]) VALUES ('Kinesthetic')

");
        }
        
        public override void Down()
        {
        }
    }
}
