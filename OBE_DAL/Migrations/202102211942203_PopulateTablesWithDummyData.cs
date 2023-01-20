namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTablesWithDummyData : DbMigration
    {
        public override void Up()
        {
            Sql("insert into IssuingAuthorities (Id,AuthorityName) Values (1,'HEC')");
            Sql("insert into IssuingAuthorities (Id,AuthorityName) Values (2,'PEC')");

            Sql("insert into PLOCalculationMethods(Name) Values('GPA')");
            Sql("insert into PLOCalculationMethods(Name) Values('Percentage')");
            
            Sql("insert into Types(Name) Values('Engineering')");
            Sql("insert into Types(Name) Values('Engineering')");
            Sql("insert into Types(Name) Values('Engineering')");

            //Sql("insert into Countries(Name) Values('Pakistan')");
            //Sql("insert into Countries(Name) Values('India')");
            //Sql("insert into Countries(Name) Values('Afghanistan')");
            //Sql("insert into Countries(Name) Values('China')");

            Sql("insert into Cities(Name) Values('Karachi')");
            Sql("insert into Cities(Name) Values('Lahore')");
            Sql("insert into Cities(Name) Values('Islamabad')");
            Sql("insert into Cities(Name) Values('Skardu')");
            Sql("insert into Cities(Name) Values('Rawalpindi')");
        }

        public override void Down()
        {
        }
    }
}
