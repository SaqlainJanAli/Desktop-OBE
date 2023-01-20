namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInCourseSection : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CourseSections", "SchoolId", "dbo.Schools");
            DropIndex("dbo.CourseSections", new[] { "SchoolId" });
            AddColumn("dbo.CourseSections", "DepartmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.CourseSections", "DepartmentId");
            AddForeignKey("dbo.CourseSections", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: false);
            DropColumn("dbo.CourseSections", "SchoolId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseSections", "SchoolId", c => c.Int(nullable: false));
            DropForeignKey("dbo.CourseSections", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.CourseSections", new[] { "DepartmentId" });
            DropColumn("dbo.CourseSections", "DepartmentId");
            CreateIndex("dbo.CourseSections", "SchoolId");
            AddForeignKey("dbo.CourseSections", "SchoolId", "dbo.Schools", "Id", cascadeDelete: true);
        }
    }
}
