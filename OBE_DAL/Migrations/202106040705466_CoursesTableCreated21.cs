namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CoursesTableCreated21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "ProgramBatchId", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "SemesterTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "TaughtInSemester", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "ProgramBatchId");
            CreateIndex("dbo.Courses", "SemesterTypeId");
            AddForeignKey("dbo.Courses", "ProgramBatchId", "dbo.ProgramBatches", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "SemesterTypeId", "dbo.SemesterTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SemesterTypeId", "dbo.SemesterTypes");
            DropForeignKey("dbo.Courses", "ProgramBatchId", "dbo.ProgramBatches");
            DropIndex("dbo.Courses", new[] { "SemesterTypeId" });
            DropIndex("dbo.Courses", new[] { "ProgramBatchId" });
            DropColumn("dbo.Courses", "TaughtInSemester");
            DropColumn("dbo.Courses", "SemesterTypeId");
            DropColumn("dbo.Courses", "ProgramBatchId");
        }
    }
}
