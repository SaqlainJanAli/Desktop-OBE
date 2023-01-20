namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PEOPrograms_Created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PEOPrograms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProgramId = c.Int(nullable: false),
                        ShortName = c.String(nullable: false),
                        PEOId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PEOs", t => t.PEOId, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId)
                .Index(t => t.PEOId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PEOPrograms", "ProgramId", "dbo.Programs");
            DropForeignKey("dbo.PEOPrograms", "PEOId", "dbo.PEOs");
            DropIndex("dbo.PEOPrograms", new[] { "PEOId" });
            DropIndex("dbo.PEOPrograms", new[] { "ProgramId" });
            DropTable("dbo.PEOPrograms");
        }
    }
}
