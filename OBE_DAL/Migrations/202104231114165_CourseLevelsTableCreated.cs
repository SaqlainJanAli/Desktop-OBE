namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CourseLevelsTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LevelName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CourseLevels");
        }
    }
}
