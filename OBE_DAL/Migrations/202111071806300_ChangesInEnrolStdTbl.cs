namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInEnrolStdTbl : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.EnrollStudents");
            AlterColumn("dbo.EnrollStudents", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.EnrollStudents", new[] { "Id", "CourseSectionId", "StudentUserId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EnrollStudents");
            AlterColumn("dbo.EnrollStudents", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.EnrollStudents", "Id");
        }
    }
}
