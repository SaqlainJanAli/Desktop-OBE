namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ActivityWeightsCreated : DbMigration
    {
        public override void Up()
        {
           
            CreateTable(
                "dbo.ActivityWeights",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityId = c.Int(nullable: false),
                        CourseSectionId = c.Int(nullable: false),
                        Weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: true)
                .ForeignKey("dbo.CourseSections", t => t.CourseSectionId, cascadeDelete: true)
                .Index(t => t.ActivityId)
                .Index(t => t.CourseSectionId);
        }
        
        public override void Down()
        {
           
            DropForeignKey("dbo.ActivityWeights", "CourseSectionId", "dbo.CourseSections");
            DropForeignKey("dbo.ActivityWeights", "ActivityId", "dbo.Activities");
            DropIndex("dbo.ActivityWeights", new[] { "CourseSectionId" });
            DropIndex("dbo.ActivityWeights", new[] { "ActivityId" });
            DropTable("dbo.ActivityWeights");
        }
    }
}
