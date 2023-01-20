namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ReligionsAdded : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO dbo.Religions(Name) VALUES ('Muslim')
INSERT INTO dbo.Religions(Name) VALUES ('Christian')
INSERT INTO dbo.Religions(Name) VALUES ('Jew')
INSERT INTO dbo.Religions(Name) VALUES ('Hindu')
INSERT INTO dbo.Religions(Name) VALUES ('Others')


");
        }

        public override void Down()
        {
        }
    }
}
