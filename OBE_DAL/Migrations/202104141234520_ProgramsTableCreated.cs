namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ProgramsTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                        SemesterTypeId = c.Int(nullable: false),
                        ProgramLevelId = c.Int(nullable: false),
                        NoOfSessions = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        MethodId = c.Int(nullable: false),
                        LearningTypeId = c.Int(nullable: false),
                        MarksPercentage = c.Int(nullable: false),
                        StudentPercentage = c.Int(nullable: false),
                        Vision = c.String(),
                        Mission = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssessmentMethods", t => t.MethodId, cascadeDelete: false)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.LearningTypes", t => t.LearningTypeId, cascadeDelete: false)
                .ForeignKey("dbo.ProgramLevels", t => t.ProgramLevelId, cascadeDelete: false)
                .ForeignKey("dbo.SemesterTypes", t => t.SemesterTypeId, cascadeDelete: false)
                .Index(t => t.SemesterTypeId)
                .Index(t => t.ProgramLevelId)
                .Index(t => t.DepartmentId)
                .Index(t => t.MethodId)
                .Index(t => t.LearningTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Programs", "SemesterTypeId", "dbo.SemesterTypes");
            DropForeignKey("dbo.Programs", "ProgramLevelId", "dbo.ProgramLevels");
            DropForeignKey("dbo.Programs", "LearningTypeId", "dbo.LearningTypes");
            DropForeignKey("dbo.Programs", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Programs", "MethodId", "dbo.AssessmentMethods");
            DropIndex("dbo.Programs", new[] { "LearningTypeId" });
            DropIndex("dbo.Programs", new[] { "MethodId" });
            DropIndex("dbo.Programs", new[] { "DepartmentId" });
            DropIndex("dbo.Programs", new[] { "ProgramLevelId" });
            DropIndex("dbo.Programs", new[] { "SemesterTypeId" });
            DropTable("dbo.Programs");
        }
    }
}
