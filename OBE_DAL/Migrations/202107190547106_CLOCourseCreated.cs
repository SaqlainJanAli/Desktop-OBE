namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CLOCourseCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CLOCourses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        PLO_Id = c.Int(nullable: false),
                        Type_Id = c.Int(nullable: false),
                        CLOId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CLOs", t => t.CLOId, cascadeDelete: true)
                .ForeignKey("dbo.CLOTypes", t => t.Type_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.PLOs", t => t.PLO_Id, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.PLO_Id)
                .Index(t => t.Type_Id)
                .Index(t => t.CLOId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CLOCourses", "PLO_Id", "dbo.PLOs");
            DropForeignKey("dbo.CLOCourses", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.CLOCourses", "Type_Id", "dbo.CLOTypes");
            DropForeignKey("dbo.CLOCourses", "CLOId", "dbo.CLOs");
            DropIndex("dbo.CLOCourses", new[] { "CLOId" });
            DropIndex("dbo.CLOCourses", new[] { "Type_Id" });
            DropIndex("dbo.CLOCourses", new[] { "PLO_Id" });
            DropIndex("dbo.CLOCourses", new[] { "CourseId" });
            DropTable("dbo.CLOCourses");
        }
    }
}
