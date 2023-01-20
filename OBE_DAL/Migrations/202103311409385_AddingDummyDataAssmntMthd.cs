namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddingDummyDataAssmntMthd : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AssessmentMethods] ([MethodName]) VALUES ('Washington Accord')
");
        }
        
        public override void Down()
        {
        }
    }
}
