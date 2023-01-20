namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInCourseAndProgamCourse1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Courses", new[] { "PreReqCourseId" });
            AlterColumn("dbo.Courses", "PreReqCourseId", c => c.Int());
            CreateIndex("dbo.Courses", "PreReqCourseId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "PreReqCourseId" });
            AlterColumn("dbo.Courses", "PreReqCourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "PreReqCourseId");
        }
    }
}
