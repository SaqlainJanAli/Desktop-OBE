using System.IO;

namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RegionsEntered : DbMigration
    {
        public override void Up()
        {
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\","03 - Insert Regions.sql"));
        }
        
        public override void Down()
        {
        }
    }
}
