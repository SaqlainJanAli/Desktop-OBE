namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class changesInEnrollTbl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EnrollStudents", "StatusId", "dbo.Status");
            DropIndex("dbo.EnrollStudents", new[] { "StatusId" });
            AlterColumn("dbo.EnrollStudents", "StatusId", c => c.Int());
            AlterColumn("dbo.EnrollStudents", "UseInOBE", c => c.Boolean());
            CreateIndex("dbo.EnrollStudents", "StatusId");
            AddForeignKey("dbo.EnrollStudents", "StatusId", "dbo.Status", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EnrollStudents", "StatusId", "dbo.Status");
            DropIndex("dbo.EnrollStudents", new[] { "StatusId" });
            AlterColumn("dbo.EnrollStudents", "UseInOBE", c => c.Boolean(nullable: false));
            AlterColumn("dbo.EnrollStudents", "StatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.EnrollStudents", "StatusId");
            AddForeignKey("dbo.EnrollStudents", "StatusId", "dbo.Status", "Id", cascadeDelete: true);
        }
    }
}
