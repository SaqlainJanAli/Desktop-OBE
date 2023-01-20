namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class UsersTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Email = c.String(nullable: false),
                    FirstName = c.String(nullable: false),
                    LastName = c.String(nullable: false),
                    RoleId = c.Int(nullable: false),
                    SchoolId = c.Int(nullable: false),
                    isActive = c.Boolean(nullable: false),
                    Password = c.String(nullable: false),
                    ConfirmPassword = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .Index(t => t.SchoolId);
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
