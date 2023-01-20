namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ActivityCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
           }
        
        public override void Down()
        {
            DropTable("dbo.Activities");
        }
    }
}
