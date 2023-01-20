namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActivityResultsCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassActivityResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseSecId = c.Int(nullable: false),
                        StudentUserId = c.Int(nullable: false),
                        ActivityTypeId = c.Int(nullable: false),
                        ClassActivityId = c.Int(nullable: false),
                        ActivityTotalMarks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActivityObtainedMarks = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityTypeId, cascadeDelete: true)
                .ForeignKey("dbo.ClassActivities", t => t.ClassActivityId, cascadeDelete: false)
                .ForeignKey("dbo.CourseSections", t => t.CourseSecId, cascadeDelete: true)
                .ForeignKey("dbo.StudentUsers", t => t.StudentUserId, cascadeDelete: true)
                .Index(t => t.CourseSecId)
                .Index(t => t.StudentUserId)
                .Index(t => t.ActivityTypeId)
                .Index(t => t.ClassActivityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassActivityResults", "StudentUserId", "dbo.StudentUsers");
            DropForeignKey("dbo.ClassActivityResults", "CourseSecId", "dbo.CourseSections");
            DropForeignKey("dbo.ClassActivityResults", "ClassActivityId", "dbo.ClassActivities");
            DropForeignKey("dbo.ClassActivityResults", "ActivityTypeId", "dbo.Activities");
            DropIndex("dbo.ClassActivityResults", new[] { "ClassActivityId" });
            DropIndex("dbo.ClassActivityResults", new[] { "ActivityTypeId" });
            DropIndex("dbo.ClassActivityResults", new[] { "StudentUserId" });
            DropIndex("dbo.ClassActivityResults", new[] { "CourseSecId" });
            DropTable("dbo.ClassActivityResults");
        }
    }
}
