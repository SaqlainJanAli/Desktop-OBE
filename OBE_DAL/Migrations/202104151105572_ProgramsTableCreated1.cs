namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ProgramsTableCreated1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Programs", "MarksPercentage", c => c.Single(nullable: false));
            AlterColumn("dbo.Programs", "StudentPercentage", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Programs", "StudentPercentage", c => c.Int(nullable: false));
            AlterColumn("dbo.Programs", "MarksPercentage", c => c.Int(nullable: false));
        }
    }
}
