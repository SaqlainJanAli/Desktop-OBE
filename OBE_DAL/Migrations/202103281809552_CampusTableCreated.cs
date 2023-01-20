namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CampusTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Campus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        University_Id = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Address = c.String(),
                        Notes = c.String(),
                        HeaderImage_Path = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: false)
                .ForeignKey("dbo.Institutes", t => t.University_Id, cascadeDelete: false)
                .Index(t => t.University_Id)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Campus", "University_Id", "dbo.Institutes");
            DropForeignKey("dbo.Campus", "CityId", "dbo.Cities");
            DropIndex("dbo.Campus", new[] { "CityId" });
            DropIndex("dbo.Campus", new[] { "University_Id" });
            DropTable("dbo.Campus");
        }
    }
}
