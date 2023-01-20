namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class emptyMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StudentUsers", "HsscMarksPercent", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.StudentUsers", "BscMarksPercent", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StudentUsers", "BscMarksPercent", c => c.Int(nullable: false));
            AlterColumn("dbo.StudentUsers", "HsscMarksPercent", c => c.Int(nullable: false));
        }
    }
}
