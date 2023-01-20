namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreateSchoolsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Address = c.String(),
                        Notes = c.String(),
                        CampusId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        SchoolIcon_Path = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Campus", t => t.CampusId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: false)
                .Index(t => t.CampusId)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Schools", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Schools", "CampusId", "dbo.Campus");
            DropIndex("dbo.Schools", new[] { "CityId" });
            DropIndex("dbo.Schools", new[] { "CampusId" });
            DropTable("dbo.Schools");
        }
    }
}
