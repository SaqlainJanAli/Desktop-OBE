namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class NoOfSessionsTableCreatedAndForeignKeyAddedInPrograms : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NoOfSessions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SessionCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Programs", "NoOfSessionsId", c => c.Int(nullable: false));
            CreateIndex("dbo.Programs", "NoOfSessionsId");
            AddForeignKey("dbo.Programs", "NoOfSessionsId", "dbo.NoOfSessions", "Id", cascadeDelete: true);
            DropColumn("dbo.Programs", "NoOfSessions");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Programs", "NoOfSessions", c => c.Int(nullable: false));
            DropForeignKey("dbo.Programs", "NoOfSessionsId", "dbo.NoOfSessions");
            DropIndex("dbo.Programs", new[] { "NoOfSessionsId" });
            DropColumn("dbo.Programs", "NoOfSessionsId");
            DropTable("dbo.NoOfSessions");
        }
    }
}
