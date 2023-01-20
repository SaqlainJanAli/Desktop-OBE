namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changsinActResultTbl : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ClassActivityResults");
            AddPrimaryKey("dbo.ClassActivityResults", new[] { "ClassActivityId", "CourseSecId", "StudentUserId" });
            DropColumn("dbo.ClassActivityResults", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClassActivityResults", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.ClassActivityResults");
            AddPrimaryKey("dbo.ClassActivityResults", "Id");
        }
    }
}
