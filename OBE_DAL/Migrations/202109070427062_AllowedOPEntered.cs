namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AllowedOPEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO dbo.AllowedOperations(Name) VALUES ('Accept Uploads')
INSERT INTO dbo.AllowedOperations(Name) VALUES ('Online Quiz')
INSERT INTO dbo.AllowedOperations(Name) VALUES ('Accept Presentation')
");
        }
        
        public override void Down()
        {
            
        }
    }
}
