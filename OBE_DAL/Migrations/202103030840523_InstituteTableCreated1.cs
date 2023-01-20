namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InstituteTableCreated1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Institutes", "Logo_Path", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Institutes", "Logo_Path");
        }
    }
}
