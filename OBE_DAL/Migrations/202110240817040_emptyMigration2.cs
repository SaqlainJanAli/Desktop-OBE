namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class emptyMigration2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentUsers", "CityId", "dbo.Cities");
            DropIndex("dbo.StudentUsers", new[] { "CityId" });
            AlterColumn("dbo.StudentUsers", "isLocal", c => c.Boolean(nullable: false));
            AlterColumn("dbo.StudentUsers", "CityId", c => c.Int(nullable: false));
            CreateIndex("dbo.StudentUsers", "CityId");
            AddForeignKey("dbo.StudentUsers", "CityId", "dbo.Cities", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentUsers", "CityId", "dbo.Cities");
            DropIndex("dbo.StudentUsers", new[] { "CityId" });
            AlterColumn("dbo.StudentUsers", "CityId", c => c.Int());
            AlterColumn("dbo.StudentUsers", "isLocal", c => c.Boolean());
            CreateIndex("dbo.StudentUsers", "CityId");
            AddForeignKey("dbo.StudentUsers", "CityId", "dbo.Cities", "Id");
        }
    }
}
