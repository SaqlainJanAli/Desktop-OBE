namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CoursesTableCreated2 : DbMigration
    {
        public override void Up()
        {

            CreateTable(
                "dbo.Courses",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Code = c.String(nullable: false),
                    SupervisorBased = c.Boolean(nullable: false),
                    Active = c.Boolean(nullable: false),
                    TheoryCreditHours = c.Int(nullable: false),
                    LabCreditHours = c.Int(nullable: false),
                    KnowledgeAreaId = c.Int(nullable: false),
                    KnowledgeProfileId = c.Int(nullable: false),
                    CourseLevelId = c.Int(nullable: false),
                    DepartmentId = c.Int(nullable: false),
                    DeliveryFormatId = c.Int(nullable: false),
                    PreReqCourseId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CourseLevels", t => t.CourseLevelId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.PreReqCourseId)
                .ForeignKey("dbo.DeliveryFormats", t => t.DeliveryFormatId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.KnowledgeAreas", t => t.KnowledgeAreaId, cascadeDelete: true)
                .ForeignKey("dbo.KnowledgeProfiles", t => t.KnowledgeProfileId, cascadeDelete: true)
                .Index(t => t.KnowledgeAreaId)
                .Index(t => t.KnowledgeProfileId)
                .Index(t => t.CourseLevelId)
                .Index(t => t.DepartmentId)
                .Index(t => t.DeliveryFormatId)
                .Index(t => t.PreReqCourseId);
          
            AddColumn("dbo.Courses", "BaseTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "BaseTypeId");
            AddForeignKey("dbo.Courses", "BaseTypeId", "dbo.BaseTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "KnowledgeProfileId", "dbo.KnowledgeProfiles");
            DropForeignKey("dbo.Courses", "KnowledgeAreaId", "dbo.KnowledgeAreas");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Courses", "DeliveryFormatId", "dbo.DeliveryFormats");
            DropForeignKey("dbo.Courses", "PreReqCourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "CourseLevelId", "dbo.CourseLevels");
            DropIndex("dbo.Courses", new[] { "PreReqCourseId" });
            DropIndex("dbo.Courses", new[] { "DeliveryFormatId" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropIndex("dbo.Courses", new[] { "CourseLevelId" });
            DropIndex("dbo.Courses", new[] { "KnowledgeProfileId" });
            DropIndex("dbo.Courses", new[] { "KnowledgeAreaId" });
            DropTable("dbo.Courses");
          
            DropForeignKey("dbo.Courses", "BaseTypeId", "dbo.BaseTypes");
            DropIndex("dbo.Courses", new[] { "BaseTypeId" });
            DropColumn("dbo.Courses", "BaseTypeId");
        }
    }
}
