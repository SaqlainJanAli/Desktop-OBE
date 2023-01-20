namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RegionsCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Regions",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: false),
                        Name = c.String(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
   

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Regions", "CountryId", "dbo.Countries");
            DropIndex("dbo.Regions", new[] { "CountryId" });
            DropTable("dbo.Regions");
           
        }
    }
}
