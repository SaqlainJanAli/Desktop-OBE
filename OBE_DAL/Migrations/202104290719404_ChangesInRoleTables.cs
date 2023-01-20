namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInRoleTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Roles", "RoleTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Roles", "RoleTypeId");
            AddForeignKey("dbo.Roles", "RoleTypeId", "dbo.RoleTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "RoleTypeId", "dbo.RoleTypes");
            DropIndex("dbo.Roles", new[] { "RoleTypeId" });
            DropColumn("dbo.Roles", "RoleTypeId");
        }
    }
}
