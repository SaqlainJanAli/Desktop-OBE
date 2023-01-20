using System.IO;

namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CitiesEntered : DbMigration
    {
        public override void Up()
        {
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 01.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 02.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 03.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 04.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 05.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 06.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 07.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 08.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 09.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 10.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 11.sql"));
            SqlFile(Path.Combine(@"F:\Saqlain Mushtaq\FYP\Project\SqlScripts\SqlScript\Scripts\", "04 - Insert Cities 12.sql"));
        }

        public override void Down()
        {
        }
    }
}
