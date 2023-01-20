namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class StudentUsrsCrtd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentUsers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    RegistrationNo = c.String(nullable: false),
                    Name = c.String(nullable: false),
                    RollNo = c.String(),
                    ERPId = c.String(),
                    ProgramBatchId = c.Int(),
                    GenderId = c.Int(),
                    ReligionId = c.Int(),
                    DateOfBirth = c.DateTime(nullable: false),
                    StudyModeId = c.Int(nullable: true),
                    StatusId = c.Int(nullable: true),
                    isLocal = c.Boolean(),
                    FatherName = c.String(),
                    Email = c.String(nullable: false),
                    CNIC = c.String(nullable: false),
                    Passport = c.String(),
                    PhoneNo = c.String(),
                    MobileNo = c.String(),
                    PermanentAddress = c.String(),
                    CityId = c.Int(),
                    District = c.String(),
                    RegionId = c.Int(nullable: false),
                    CountryId = c.Int(nullable: false),
                    PostalAddress = c.String(nullable: false),
                    HsscTypeId = c.Int(nullable: true),
                    HsscMarksPercent = c.Decimal(nullable: true, precision: 18, scale: 2),
                    BscTypeId = c.Int(nullable: true),
                    BscMarksPercent = c.Decimal(nullable: true, precision: 18, scale: 2),
                    EntryTestMarks = c.Decimal(nullable: true, precision: 18, scale: 2),
                    QuotaId = c.Int(nullable: true),
                    ApplicationNo = c.String(),
                    AdmissionDate = c.DateTime(nullable: true),
                    AdmissionTypeId = c.Int(nullable: true),
                    AdmissionCategoryId = c.Int(nullable: true),
                    ExtraNotes = c.String(),
                    ImagePath = c.String(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AdmissionCategories", t => t.AdmissionCategoryId)
                .ForeignKey("dbo.AdmissionTypes", t => t.AdmissionTypeId)
                .ForeignKey("dbo.BScTypes", t => t.BscTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.HSSCTypes", t => t.HsscTypeId, cascadeDelete: true)
                .ForeignKey("dbo.ProgramBatches", t => t.ProgramBatchId)
                .ForeignKey("dbo.Quotas", t => t.QuotaId, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: false)
                .ForeignKey("dbo.Religions", t => t.ReligionId)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .ForeignKey("dbo.StudyModes", t => t.StudyModeId, cascadeDelete: true)
                .Index(t => t.ProgramBatchId)
                .Index(t => t.GenderId)
                .Index(t => t.ReligionId)
                .Index(t => t.StudyModeId)
                .Index(t => t.StatusId)
                .Index(t => t.CityId)
                .Index(t => t.RegionId)
                .Index(t => t.CountryId)
                .Index(t => t.HsscTypeId)
                .Index(t => t.BscTypeId)
                .Index(t => t.QuotaId)
                .Index(t => t.AdmissionTypeId)
                .Index(t => t.AdmissionCategoryId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.StudentUsers", "StudyModeId", "dbo.StudyModes");
            DropForeignKey("dbo.StudentUsers", "StatusId", "dbo.Status");
            DropForeignKey("dbo.StudentUsers", "ReligionId", "dbo.Religions");
            DropForeignKey("dbo.StudentUsers", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.StudentUsers", "QuotaId", "dbo.Quotas");
            DropForeignKey("dbo.StudentUsers", "ProgramBatchId", "dbo.ProgramBatches");
            DropForeignKey("dbo.StudentUsers", "HsscTypeId", "dbo.HSSCTypes");
            DropForeignKey("dbo.StudentUsers", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.StudentUsers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.StudentUsers", "CityId", "dbo.Cities");
            DropForeignKey("dbo.StudentUsers", "BscTypeId", "dbo.BScTypes");
            DropForeignKey("dbo.StudentUsers", "AdmissionTypeId", "dbo.AdmissionTypes");
            DropForeignKey("dbo.StudentUsers", "AdmissionCategoryId", "dbo.AdmissionCategories");
            DropIndex("dbo.StudentUsers", new[] { "AdmissionCategoryId" });
            DropIndex("dbo.StudentUsers", new[] { "AdmissionTypeId" });
            DropIndex("dbo.StudentUsers", new[] { "QuotaId" });
            DropIndex("dbo.StudentUsers", new[] { "BscTypeId" });
            DropIndex("dbo.StudentUsers", new[] { "HsscTypeId" });
            DropIndex("dbo.StudentUsers", new[] { "CountryId" });
            DropIndex("dbo.StudentUsers", new[] { "RegionId" });
            DropIndex("dbo.StudentUsers", new[] { "CityId" });
            DropIndex("dbo.StudentUsers", new[] { "StatusId" });
            DropIndex("dbo.StudentUsers", new[] { "StudyModeId" });
            DropIndex("dbo.StudentUsers", new[] { "ReligionId" });
            DropIndex("dbo.StudentUsers", new[] { "GenderId" });
            DropIndex("dbo.StudentUsers", new[] { "ProgramBatchId" });
            DropTable("dbo.StudentUsers");
        }
    }
}
