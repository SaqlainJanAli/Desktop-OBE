namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class PrivaciesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RolePrivacies",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        InstituteRead = c.Boolean(nullable: false),
                        InstituteCreate = c.Boolean(nullable: false),
                        InstituteUpdate = c.Boolean(nullable: false),
                        InstituteDelete = c.Boolean(nullable: false),
                        CampusRead = c.Boolean(nullable: false),
                        CampusCreate = c.Boolean(nullable: false),
                        CampusUpdate = c.Boolean(nullable: false),
                        CampusDelete = c.Boolean(nullable: false),
                        SchoolRead = c.Boolean(nullable: false),
                        SchoolCreate = c.Boolean(nullable: false),
                        SchoolUpdate = c.Boolean(nullable: false),
                        SchoolDelete = c.Boolean(nullable: false),
                        DepartmentRead = c.Boolean(nullable: false),
                        DepartmentCreate = c.Boolean(nullable: false),
                        DepartmentUpdate = c.Boolean(nullable: false),
                        DepartmentDelete = c.Boolean(nullable: false),
                        SemesterRead = c.Boolean(nullable: false),
                        SemesterCreate = c.Boolean(nullable: false),
                        SemesterUpdate = c.Boolean(nullable: false),
                        SemesterDelete = c.Boolean(nullable: false),
                        ProgramRead = c.Boolean(nullable: false),
                        ProgramCreate = c.Boolean(nullable: false),
                        ProgramUpdate = c.Boolean(nullable: false),
                        ProgramDelete = c.Boolean(nullable: false),
                        BatchRead = c.Boolean(nullable: false),
                        BatchCreate = c.Boolean(nullable: false),
                        BatchUpdate = c.Boolean(nullable: false),
                        BatchDelete = c.Boolean(nullable: false),
                        CourseRead = c.Boolean(nullable: false),
                        CourseCreate = c.Boolean(nullable: false),
                        CourseUpdate = c.Boolean(nullable: false),
                        CourseDelete = c.Boolean(nullable: false),
                        StudentRead = c.Boolean(nullable: false),
                        StudentCreate = c.Boolean(nullable: false),
                        StudentUpdate = c.Boolean(nullable: false),
                        StudentDelete = c.Boolean(nullable: false),
                        SectionRead = c.Boolean(nullable: false),
                        SectionCreate = c.Boolean(nullable: false),
                        SectionUpdate = c.Boolean(nullable: false),
                        SectionDelete = c.Boolean(nullable: false),
                        UserRead = c.Boolean(nullable: false),
                        UserCreate = c.Boolean(nullable: false),
                        UserUpdate = c.Boolean(nullable: false),
                        UserDelete = c.Boolean(nullable: false),
                        StudentUserRead = c.Boolean(nullable: false),
                        StudentUserCreate = c.Boolean(nullable: false),
                        StudentUserUpdate = c.Boolean(nullable: false),
                        StudentUserDelete = c.Boolean(nullable: false),
                        RoleRead = c.Boolean(nullable: false),
                        RoleCreate = c.Boolean(nullable: false),
                        RoleUpdate = c.Boolean(nullable: false),
                        RoleDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolePrivacies", "RoleId", "dbo.Roles");
            DropIndex("dbo.RolePrivacies", new[] { "RoleId" });
            DropTable("dbo.RolePrivacies");
        }
    }
}
