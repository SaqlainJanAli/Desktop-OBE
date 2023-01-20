namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class BaseTypeTableEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[BaseTypes] ([Name]) VALUES ('Core')

INSERT INTO [dbo].[BaseTypes] ([Name]) VALUES ('Elective')


");
        }
        
        public override void Down()
        {
        }
    }
}
