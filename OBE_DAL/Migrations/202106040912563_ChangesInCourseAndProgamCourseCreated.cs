namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInCourseAndProgamCourseCreated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "ProgramBatchId", "dbo.ProgramBatches");
            DropForeignKey("dbo.Courses", "SemesterTypeId", "dbo.SemesterTypes");
            DropIndex("dbo.Courses", new[] { "ProgramBatchId" });
            DropIndex("dbo.Courses", new[] { "SemesterTypeId" });
            CreateTable(
                "dbo.ProgramCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProgramBatchId = c.Int(nullable: false),
                        SemesterTypeId = c.Int(nullable: false),
                        TaughInSemester = c.Int(nullable: false),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProgramBatches", t => t.ProgramBatchId, cascadeDelete: true)
                .ForeignKey("dbo.SemesterTypes", t => t.SemesterTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.ProgramBatchId)
                .Index(t => t.SemesterTypeId)
                .Index(t => t.Course_Id);
            
            AddColumn("dbo.Courses", "ProgramCourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "ProgramCourseId");
            AddForeignKey("dbo.Courses", "ProgramCourseId", "dbo.ProgramCourses", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "ProgramBatchId");
            DropColumn("dbo.Courses", "SemesterTypeId");
            DropColumn("dbo.Courses", "TaughtInSemester");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "TaughtInSemester", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "SemesterTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "ProgramBatchId", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProgramCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Courses", "ProgramCourseId", "dbo.ProgramCourses");
            DropForeignKey("dbo.ProgramCourses", "SemesterTypeId", "dbo.SemesterTypes");
            DropForeignKey("dbo.ProgramCourses", "ProgramBatchId", "dbo.ProgramBatches");
            DropIndex("dbo.ProgramCourses", new[] { "Course_Id" });
            DropIndex("dbo.ProgramCourses", new[] { "SemesterTypeId" });
            DropIndex("dbo.ProgramCourses", new[] { "ProgramBatchId" });
            DropIndex("dbo.Courses", new[] { "ProgramCourseId" });
            DropColumn("dbo.Courses", "ProgramCourseId");
            DropTable("dbo.ProgramCourses");
            CreateIndex("dbo.Courses", "SemesterTypeId");
            CreateIndex("dbo.Courses", "ProgramBatchId");
            AddForeignKey("dbo.Courses", "SemesterTypeId", "dbo.SemesterTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "ProgramBatchId", "dbo.ProgramBatches", "Id", cascadeDelete: true);
        }
    }
}
