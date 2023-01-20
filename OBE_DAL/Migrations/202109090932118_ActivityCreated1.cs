namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ActivityCreated1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Activities", "AllowedOpId", "dbo.AllowedOperations");
            DropIndex("dbo.Activities", new[] { "AllowedOpId" });
            DropColumn("dbo.Activities", "isRubric");
            DropColumn("dbo.Activities", "AllowedOpId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Activities", "AllowedOpId", c => c.Int(nullable: false));
            AddColumn("dbo.Activities", "isRubric", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Activities", "AllowedOpId");
            AddForeignKey("dbo.Activities", "AllowedOpId", "dbo.AllowedOperations", "Id", cascadeDelete: true);
        }
    }
}
