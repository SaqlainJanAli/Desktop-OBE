namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInProgramTbl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Programs", "PEO_Id", "dbo.PEOs");
            DropIndex("dbo.Programs", new[] { "PEO_Id" });
            DropColumn("dbo.Programs", "PEO_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Programs", "PEO_Id", c => c.Int());
            CreateIndex("dbo.Programs", "PEO_Id");
            AddForeignKey("dbo.Programs", "PEO_Id", "dbo.PEOs", "Id");
        }
    }
}
