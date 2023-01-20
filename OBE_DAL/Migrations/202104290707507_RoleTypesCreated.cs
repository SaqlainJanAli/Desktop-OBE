namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RoleTypesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoleTypes");
        }
    }
}
