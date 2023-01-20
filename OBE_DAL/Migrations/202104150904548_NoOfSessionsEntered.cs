namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class NoOfSessionsEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (1)
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (2)
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (3)
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (4)
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (5)
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (6)
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (7)
INSERT INTO [dbo].[NoOfSessions] ([SessionCount]) VALUES (8)
");
        }
        
        public override void Down()
        {
        }
    }
}
