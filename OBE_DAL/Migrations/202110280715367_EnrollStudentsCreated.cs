namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class EnrollStudentsCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnrollStudents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseSectionId = c.Int(nullable: false),
                        StudentUserId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                        UseInOBE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CourseSections", t => t.CourseSectionId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.StudentUsers", t => t.StudentUserId, cascadeDelete: false)
                .Index(t => t.CourseSectionId)
                .Index(t => t.StudentUserId)
                .Index(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EnrollStudents", "StudentUserId", "dbo.StudentUsers");
            DropForeignKey("dbo.EnrollStudents", "StatusId", "dbo.Status");
            DropForeignKey("dbo.EnrollStudents", "CourseSectionId", "dbo.CourseSections");
            DropIndex("dbo.EnrollStudents", new[] { "StatusId" });
            DropIndex("dbo.EnrollStudents", new[] { "StudentUserId" });
            DropIndex("dbo.EnrollStudents", new[] { "CourseSectionId" });
            DropTable("dbo.EnrollStudents");
        }
    }
}
