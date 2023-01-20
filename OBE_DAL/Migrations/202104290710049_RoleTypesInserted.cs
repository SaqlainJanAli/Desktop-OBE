namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RoleTypesInserted : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[RoleTypes] ([Name]) VALUES ('University')
INSERT INTO [dbo].[RoleTypes] ([Name]) VALUES ('Application')

");
        }
        
        public override void Down()
        {
        }
    }
}
