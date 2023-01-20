namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class TypesEntered : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[CLOTypes] ([Name]) VALUES ('Standard')
                
                "); 
        }
        
        public override void Down()
        {
        }
    }
}
