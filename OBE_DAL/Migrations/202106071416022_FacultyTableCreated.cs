namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class FacultyTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FacultyUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MiddleName = c.String(),
                        FTypeId = c.Int(nullable: false),
                        Designation = c.String(),
                        GenderId = c.Int(nullable: false),
                        FacultyTypeId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Ph_D = c.Boolean(nullable: false),
                        CNIC = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                        LeavingDate = c.DateTime(nullable: false),
                        MobileNo = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.FacultyTypes", t => t.FacultyTypeId, cascadeDelete: true)
                .ForeignKey("dbo.FTypes", t => t.FTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.FTypeId)
                .Index(t => t.GenderId)
                .Index(t => t.FacultyTypeId)
                .Index(t => t.DepartmentId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FacultyUsers", "UserId", "dbo.Users");
            DropForeignKey("dbo.FacultyUsers", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.FacultyUsers", "FTypeId", "dbo.FTypes");
            DropForeignKey("dbo.FacultyUsers", "FacultyTypeId", "dbo.FacultyTypes");
            DropForeignKey("dbo.FacultyUsers", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.FacultyUsers", new[] { "UserId" });
            DropIndex("dbo.FacultyUsers", new[] { "DepartmentId" });
            DropIndex("dbo.FacultyUsers", new[] { "FacultyTypeId" });
            DropIndex("dbo.FacultyUsers", new[] { "GenderId" });
            DropIndex("dbo.FacultyUsers", new[] { "FTypeId" });
            DropTable("dbo.FacultyUsers");
        }
    }
}
