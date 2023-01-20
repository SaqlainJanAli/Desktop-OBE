namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseSecStdResultCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentCourseSectionResults",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        CourseSecId = c.Int(nullable: false),
                        Assignment1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Assignment2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Assignment3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Assignment4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quiz1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quiz2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quiz3 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quiz4 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Midterm = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Terminal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseSecId })
                .ForeignKey("dbo.CourseSections", t => t.CourseSecId, cascadeDelete: true)
                .ForeignKey("dbo.StudentUsers", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseSecId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourseSectionResults", "StudentId", "dbo.StudentUsers");
            DropForeignKey("dbo.StudentCourseSectionResults", "CourseSecId", "dbo.CourseSections");
            DropIndex("dbo.StudentCourseSectionResults", new[] { "CourseSecId" });
            DropIndex("dbo.StudentCourseSectionResults", new[] { "StudentId" });
            DropTable("dbo.StudentCourseSectionResults");
        }
    }
}
