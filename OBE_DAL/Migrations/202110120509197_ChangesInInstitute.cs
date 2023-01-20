namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInInstitute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Institutes", "RegionId", c => c.Int(nullable: true));
            CreateIndex("dbo.Institutes", "RegionId");
            AddForeignKey("dbo.Institutes", "RegionId", "dbo.Regions", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Institutes", "RegionId", "dbo.Regions");
            DropIndex("dbo.Institutes", new[] { "RegionId" });
            DropColumn("dbo.Institutes", "RegionId");
        }
    }
}
