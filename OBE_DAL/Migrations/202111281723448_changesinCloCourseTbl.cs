namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesinCloCourseTbl : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CLOCourses");
            AddPrimaryKey("dbo.CLOCourses", new[] { "CLOId", "CourseId", "PLO_Id" });
            DropColumn("dbo.CLOCourses", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CLOCourses", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.CLOCourses");
            AddPrimaryKey("dbo.CLOCourses", "Id");
        }
    }
}
