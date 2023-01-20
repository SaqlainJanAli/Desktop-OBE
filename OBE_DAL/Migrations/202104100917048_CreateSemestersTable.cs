namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreateSemestersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcademicYear = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Notes = c.String(),
                        Completed = c.Boolean(nullable: false),
                        ShowResultInGPA = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Semesters");
        }
    }
}
