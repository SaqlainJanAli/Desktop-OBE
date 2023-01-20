namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CLOsAndTypesCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CLOs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false),
                        isActive = c.Boolean(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CLOTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CLOTypes");
            DropTable("dbo.CLOs");
        }
    }
}
