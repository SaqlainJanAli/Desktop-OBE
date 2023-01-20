namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stdSemesterRsltCrtdAndChangesInStdUsersTbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentSemesterResults",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        CourseSecId = c.Int(nullable: false),
                        SemesterId = c.Int(nullable: false),
                        CourseCode = c.String(),
                        CourseName = c.String(),
                        RegistrationNo = c.String(),
                        Name = c.String(),
                        TotalMarks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ObtainedMarks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Percentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Grade = c.String(),
                        CreditHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseSecId, t.SemesterId })
                .ForeignKey("dbo.CourseSections", t => t.CourseSecId, cascadeDelete: true)
                .ForeignKey("dbo.Semesters", t => t.SemesterId, cascadeDelete: true)
                .ForeignKey("dbo.StudentUsers", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseSecId)
                .Index(t => t.SemesterId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSemesterResults", "StudentId", "dbo.StudentUsers");
            DropForeignKey("dbo.StudentSemesterResults", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.StudentSemesterResults", "CourseSecId", "dbo.CourseSections");
            DropIndex("dbo.StudentSemesterResults", new[] { "SemesterId" });
            DropIndex("dbo.StudentSemesterResults", new[] { "CourseSecId" });
            DropIndex("dbo.StudentSemesterResults", new[] { "StudentId" });
            DropTable("dbo.StudentSemesterResults");
        }
    }
}
