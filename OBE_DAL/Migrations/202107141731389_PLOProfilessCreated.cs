namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PLOProfilessCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PLOProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PLOId = c.Int(nullable: false),
                        BatchId = c.Int(nullable: false),
                        KnowledgeProfileId = c.Int(nullable: false),
                        PEOId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.KnowledgeProfiles", t => t.KnowledgeProfileId, cascadeDelete: true)
                .ForeignKey("dbo.PEOs", t => t.PEOId, cascadeDelete: true)
                .ForeignKey("dbo.PLOes", t => t.PLOId, cascadeDelete: true)
                .ForeignKey("dbo.ProgramBatches", t => t.BatchId, cascadeDelete: true)
                .Index(t => t.PLOId)
                .Index(t => t.BatchId)
                .Index(t => t.KnowledgeProfileId)
                .Index(t => t.PEOId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PLOProfiles", "BatchId", "dbo.ProgramBatches");
            DropForeignKey("dbo.PLOProfiles", "PLOId", "dbo.PLOes");
            DropForeignKey("dbo.PLOProfiles", "PEOId", "dbo.PEOs");
            DropForeignKey("dbo.PLOProfiles", "KnowledgeProfileId", "dbo.KnowledgeProfiles");
            DropIndex("dbo.PLOProfiles", new[] { "PEOId" });
            DropIndex("dbo.PLOProfiles", new[] { "KnowledgeProfileId" });
            DropIndex("dbo.PLOProfiles", new[] { "BatchId" });
            DropIndex("dbo.PLOProfiles", new[] { "PLOId" });
            DropTable("dbo.PLOProfiles");
        }
    }
}
