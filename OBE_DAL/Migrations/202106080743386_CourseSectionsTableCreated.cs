namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CourseSectionsTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseSections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        FacultyId = c.Int(nullable: false),
                        Finished = c.Boolean(nullable: false),
                        UseInOBE = c.Boolean(nullable: false),
                        MarksPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StudentsPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Section = c.String(),
                        GenderId = c.Int(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.FacultyUsers", t => t.FacultyId, cascadeDelete: false)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: true)
                .Index(t => t.SchoolId)
                .Index(t => t.SemesterId)
                .Index(t => t.CourseId)
                .Index(t => t.FacultyId)
                .Index(t => t.GenderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseSections", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.CourseSections", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.CourseSections", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.CourseSections", "FacultyId", "dbo.FacultyUsers");
            DropForeignKey("dbo.CourseSections", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseSections", new[] { "GenderId" });
            DropIndex("dbo.CourseSections", new[] { "FacultyId" });
            DropIndex("dbo.CourseSections", new[] { "CourseId" });
            DropIndex("dbo.CourseSections", new[] { "SemesterId" });
            DropIndex("dbo.CourseSections", new[] { "SchoolId" });
            DropTable("dbo.CourseSections");
        }
    }
}
