namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesinEnrollStdTbl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EnrollStudents", "StatusId", "dbo.Status");
            DropIndex("dbo.EnrollStudents", new[] { "StatusId" });
            DropColumn("dbo.EnrollStudents", "StatusId");
            DropColumn("dbo.EnrollStudents", "UseInOBE");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EnrollStudents", "UseInOBE", c => c.Boolean());
            AddColumn("dbo.EnrollStudents", "StatusId", c => c.Int());
            CreateIndex("dbo.EnrollStudents", "StatusId");
            AddForeignKey("dbo.EnrollStudents", "StatusId", "dbo.Status", "Id");
        }
    }
}
