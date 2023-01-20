namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CitiesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Cities",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            AddColumn("dbo.Cities", "RegionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "RegionId");
            AddForeignKey("dbo.Cities", "RegionId", "dbo.Regions", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Institutes", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "RegionId", "dbo.Regions");
            DropIndex("dbo.Cities", new[] { "RegionId" });
            DropColumn("dbo.Cities", "RegionId");
            DropTable("dbo.Cities");
        }
    }
}
