namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInCourseAndProgamCourse : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "ProgramCourseId", "dbo.ProgramCourses");
            DropForeignKey("dbo.ProgramCourses", "Course_Id", "dbo.Courses");
            DropIndex("dbo.Courses", new[] { "ProgramCourseId" });
            DropIndex("dbo.ProgramCourses", new[] { "Course_Id" });
            RenameColumn(table: "dbo.ProgramCourses", name: "Course_Id", newName: "CourseId");
            AlterColumn("dbo.ProgramCourses", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProgramCourses", "CourseId");
            AddForeignKey("dbo.ProgramCourses", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "ProgramCourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "ProgramCourseId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProgramCourses", "CourseId", "dbo.Courses");
            DropIndex("dbo.ProgramCourses", new[] { "CourseId" });
            AlterColumn("dbo.ProgramCourses", "CourseId", c => c.Int());
            RenameColumn(table: "dbo.ProgramCourses", name: "CourseId", newName: "Course_Id");
            CreateIndex("dbo.ProgramCourses", "Course_Id");
            CreateIndex("dbo.Courses", "ProgramCourseId");
            AddForeignKey("dbo.ProgramCourses", "Course_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.Courses", "ProgramCourseId", "dbo.ProgramCourses", "Id", cascadeDelete: true);
        }
    }
}
