namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class BaseTypeTableCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BaseTypes");
        }
    }
}
