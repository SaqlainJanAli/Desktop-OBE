namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PLOsAndProfCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PLOProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BatchId = c.Int(nullable: false),
                        KnowledgeProfileId = c.Int(nullable: false),
                        PEOId = c.Int(nullable: false),
                        PLOId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnowledgeProfiles", t => t.KnowledgeProfileId, cascadeDelete: true)
                .ForeignKey("dbo.PEOs", t => t.PEOId, cascadeDelete: true)
                .ForeignKey("dbo.PLOs", t => t.PLOId, cascadeDelete: true)
                .ForeignKey("dbo.ProgramBatches", t => t.BatchId, cascadeDelete: true)
                .Index(t => t.BatchId)
                .Index(t => t.KnowledgeProfileId)
                .Index(t => t.PEOId)
                .Index(t => t.PLOId);
            
            CreateTable(
                "dbo.PLOs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        WACode = c.String(),
                        isActive = c.Boolean(nullable: false),
                        Description = c.String(),
                        Strategies = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PLOProfiles", "BatchId", "dbo.ProgramBatches");
            DropForeignKey("dbo.PLOProfiles", "PLOId", "dbo.PLOs");
            DropForeignKey("dbo.PLOProfiles", "PEOId", "dbo.PEOs");
            DropForeignKey("dbo.PLOProfiles", "KnowledgeProfileId", "dbo.KnowledgeProfiles");
            DropIndex("dbo.PLOProfiles", new[] { "PLOId" });
            DropIndex("dbo.PLOProfiles", new[] { "PEOId" });
            DropIndex("dbo.PLOProfiles", new[] { "KnowledgeProfileId" });
            DropIndex("dbo.PLOProfiles", new[] { "BatchId" });
            DropTable("dbo.PLOs");
            DropTable("dbo.PLOProfiles");
        }
    }
}
