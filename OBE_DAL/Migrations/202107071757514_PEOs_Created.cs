namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PEOs_Created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PEOs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        MapInstituteMission = c.Boolean(nullable: false),
                        MapInstituteVision = c.Boolean(nullable: false),
                        Description = c.String(nullable: false),
                        Elements = c.String(),
                        Strategies = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Programs", "PEO_Id", c => c.Int());
            CreateIndex("dbo.Programs", "PEO_Id");
            AddForeignKey("dbo.Programs", "PEO_Id", "dbo.PEOs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Programs", "PEO_Id", "dbo.PEOs");
            DropIndex("dbo.Programs", new[] { "PEO_Id" });
            DropColumn("dbo.Programs", "PEO_Id");
            DropTable("dbo.PEOs");
        }
    }
}
