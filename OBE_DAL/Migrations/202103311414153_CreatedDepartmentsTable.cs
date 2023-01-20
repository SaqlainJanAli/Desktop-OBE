namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDepartmentsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(),
                        isActive = c.Boolean(nullable: false),
                        AllowFaculty = c.Boolean(nullable: false),
                        SchoolId = c.Int(nullable: false),
                        GPAMethodId = c.Int(nullable: false),
                        Attendance = c.Int(nullable: false),
                        AssessmentMethodId = c.Int(nullable: false),
                        ActivitiesInDays = c.Int(nullable: false),
                        Vision = c.String(),
                        Mission = c.String(),
                        Logo_Path = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GPA_Method", t => t.GPAMethodId, cascadeDelete: false)
                .ForeignKey("dbo.AssessmentMethods", t => t.AssessmentMethodId, cascadeDelete: false)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId)
                .Index(t => t.GPAMethodId)
                .Index(t => t.AssessmentMethodId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Departments", "AssessmentMethodId", "dbo.AssessmentMethods");
            DropForeignKey("dbo.Departments", "GPAMethodId", "dbo.GPA_Method");
            DropIndex("dbo.Departments", new[] { "AssessmentMethodId" });
            DropIndex("dbo.Departments", new[] { "GPAMethodId" });
            DropIndex("dbo.Departments", new[] { "SchoolId" });
            DropTable("dbo.Departments");
        }
    }
}
