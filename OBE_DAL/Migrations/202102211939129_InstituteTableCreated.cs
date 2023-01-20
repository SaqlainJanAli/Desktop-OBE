namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InstituteTableCreated : DbMigration
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

            CreateTable(
                "dbo.Institutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        IssuingAuthorityId = c.Int(nullable: false),
                        InstituteTypeId = c.Int(nullable: false),
                        MethodId = c.Int(nullable: false),
                        CountryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        FullGPA = c.Int(nullable: false),
                        AllowAttendance = c.Int(nullable: false),
                        PublicSector = c.Boolean(nullable: false),
                        YearEstablished = c.Int(nullable: false),
                        Address = c.String(nullable: false),
                        WebsiteURL = c.String(nullable: false),
                        Notes = c.String(),
                        Vision = c.String(nullable: false),
                        Mission = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IssuingAuthorities", t => t.IssuingAuthorityId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.InstituteTypeId, cascadeDelete: true)
                .ForeignKey("dbo.PLOCalculationMethods", t => t.MethodId, cascadeDelete: true)
                .Index(t => t.IssuingAuthorityId)
                .Index(t => t.InstituteTypeId)
                .Index(t => t.MethodId)
                .Index(t => t.CountryId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.IssuingAuthorities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorityName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
              "dbo.Countries",
              c => new
              {
                  Id = c.Int(nullable: false, identity: false),
                  Name = c.String(nullable: false, maxLength: 100),
                  Code = c.String(nullable: false),
                  Language = c.String(nullable: false)
              })
              .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PLOCalculationMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Institutes", "MethodId", "dbo.PLOCalculationMethods");
            DropForeignKey("dbo.Institutes", "InstituteTypeId", "dbo.Types");
            DropForeignKey("dbo.Institutes", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Institutes", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Institutes", "IssuingAuthorityId", "dbo.IssuingAuthorities");
            DropIndex("dbo.Institutes", new[] { "CityId" });
            DropIndex("dbo.Institutes", new[] { "CountryId" });
            DropIndex("dbo.Institutes", new[] { "MethodId" });
            DropIndex("dbo.Institutes", new[] { "InstituteTypeId" });
            DropIndex("dbo.Institutes", new[] { "IssuingAuthorityId" });
            DropTable("dbo.PLOCalculationMethods");
            DropTable("dbo.Types");
            DropTable("dbo.Countries");
            DropTable("dbo.IssuingAuthorities");
            DropTable("dbo.Institutes");
            DropTable("dbo.Cities");
        }
    }
}
