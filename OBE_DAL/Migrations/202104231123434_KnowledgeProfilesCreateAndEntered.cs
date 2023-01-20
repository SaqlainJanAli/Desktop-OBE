namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class KnowledgeProfilesCreateeAndEntered : DbMigration
    {
        public override void Up()
        {


            CreateTable(
                           "dbo.KnowledgeProfiles",
                           c => new
                           {
                               Id = c.Int(nullable: false, identity: true),
                               Name = c.String(nullable: false),
                           })
                           .PrimaryKey(t => t.Id);


            Sql(@"
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK01')
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK02')
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK03')
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK04')
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK05')
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK06')
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK07')
INSERT INTO [dbo].[KnowledgeProfiles] ([Name]) VALUES ('WK08')
"

);
        }
        
        public override void Down()
        {
            DropTable("dbo.KnowledgeProfiles");

        }
    }
}
