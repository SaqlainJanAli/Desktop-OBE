namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ClassAndSubActCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseSecId = c.Int(nullable: false),
                        ActivityId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        ActivityDate = c.DateTime(nullable: false),
                        TotalMarks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GpaWeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ComplexEP = c.Boolean(nullable: false),
                        IncludeGpaCal = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .ForeignKey("dbo.CourseSections", t => t.CourseSecId, cascadeDelete: true)
                .Index(t => t.CourseSecId)
                .Index(t => t.ActivityId);
            
            CreateTable(
                "dbo.SubActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        MaxMarks = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OBEWeight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CloId = c.Int(nullable: false),
                        ActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassActivities", t => t.ActivityId, cascadeDelete: true)
                .ForeignKey("dbo.CLOs", t => t.CloId, cascadeDelete: true)
                .Index(t => t.CloId)
                .Index(t => t.ActivityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SubActivities", "CloId", "dbo.CLOs");
            DropForeignKey("dbo.SubActivities", "ActivityId", "dbo.ClassActivities");
            DropForeignKey("dbo.ClassActivities", "CourseSecId", "dbo.CourseSections");
            DropForeignKey("dbo.ClassActivities", "ActivityId", "dbo.Activities");
            DropIndex("dbo.SubActivities", new[] { "ActivityId" });
            DropIndex("dbo.SubActivities", new[] { "CloId" });
            DropIndex("dbo.ClassActivities", new[] { "ActivityId" });
            DropIndex("dbo.ClassActivities", new[] { "CourseSecId" });
            DropTable("dbo.SubActivities");
            DropTable("dbo.ClassActivities");
        }
    }
}
