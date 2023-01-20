namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RoleTablesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
           
       
        }
        
        public override void Down()
        {
            DropTable("dbo.Roles");
        }
    }
}
