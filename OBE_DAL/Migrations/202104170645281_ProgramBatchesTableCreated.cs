namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ProgramBatchesTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProgramBatches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AcademicYear = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        ProgramBatchName = c.String(nullable: false),
                        NoOfSessionId = c.Int(nullable: false),
                        MethodId = c.Int(nullable: false),
                        PLOPassingThreshold = c.Int(nullable: false),
                        MarksPercentage = c.Int(nullable: false),
                        StudentPercentage = c.Int(nullable: false),
                        Finished = c.Boolean(nullable: false),
                        TheoryCreditHours = c.Int(nullable: false),
                        LabCreditHours = c.Int(nullable: false),
                        UseInOBE = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GPA_Method", t => t.MethodId, cascadeDelete: true)
                .ForeignKey("dbo.NoOfSessions", t => t.NoOfSessionId, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId)
                .Index(t => t.NoOfSessionId)
                .Index(t => t.MethodId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProgramBatches", "ProgramId", "dbo.Programs");
            DropForeignKey("dbo.ProgramBatches", "NoOfSessionId", "dbo.NoOfSessions");
            DropForeignKey("dbo.ProgramBatches", "MethodId", "dbo.GPA_Method");
            DropIndex("dbo.ProgramBatches", new[] { "MethodId" });
            DropIndex("dbo.ProgramBatches", new[] { "NoOfSessionId" });
            DropIndex("dbo.ProgramBatches", new[] { "ProgramId" });
            DropTable("dbo.ProgramBatches");
        }
    }
}
