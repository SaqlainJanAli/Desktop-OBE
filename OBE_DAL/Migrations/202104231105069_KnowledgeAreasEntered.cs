namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class KnowledgeAreasEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[KnowledgeAreas] ([Name]) VALUES ('K.Area 01')
INSERT INTO [dbo].[KnowledgeAreas] ([Name]) VALUES ('K.Area 02')
INSERT INTO [dbo].[KnowledgeAreas] ([Name]) VALUES ('K.Area 03')
INSERT INTO [dbo].[KnowledgeAreas] ([Name]) VALUES ('K.Area 04')

");
        }
        
        public override void Down()
        {
        }
    }
}
