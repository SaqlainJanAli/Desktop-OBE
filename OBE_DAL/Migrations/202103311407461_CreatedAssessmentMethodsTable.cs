namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreatedAssessmentMethodsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssessmentMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MethodName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AssessmentMethods");
        }
    }
}
