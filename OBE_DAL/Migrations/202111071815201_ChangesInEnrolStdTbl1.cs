namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInEnrolStdTbl1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EnrollStudents");
            AddPrimaryKey("dbo.EnrollStudents", new[] { "CourseSectionId", "StudentUserId" });
            DropColumn("dbo.EnrollStudents", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EnrollStudents", "Id", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.EnrollStudents");
            AddPrimaryKey("dbo.EnrollStudents", new[] { "Id", "CourseSectionId", "StudentUserId" });
        }
    }
}
