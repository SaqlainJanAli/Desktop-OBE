namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreateGPAMethodsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GPA_Method",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MethodName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GPA_Method");
        }
    }
}
