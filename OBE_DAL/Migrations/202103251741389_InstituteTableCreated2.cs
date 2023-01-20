namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InstituteTableCreated2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Institutes", "YearEstablished", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Institutes", "YearEstablished", c => c.Int(nullable: false));
        }
    }
}
