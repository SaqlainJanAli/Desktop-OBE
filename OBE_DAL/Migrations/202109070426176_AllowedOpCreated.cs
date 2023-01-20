namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AllowedOpCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllowedOperations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AllowedOperations");
        }
    }
}
