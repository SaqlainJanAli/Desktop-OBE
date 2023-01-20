namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class DummyDataForGPAMethodsTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[GPA_Method] ([MethodName]) VALUES ('Absolute')
");
        }
        
        public override void Down()
        {
        }
    }
}
