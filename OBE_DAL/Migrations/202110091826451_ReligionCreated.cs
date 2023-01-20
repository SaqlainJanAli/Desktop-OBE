namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ReligionCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Religions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Religions");
        }
    }
}
