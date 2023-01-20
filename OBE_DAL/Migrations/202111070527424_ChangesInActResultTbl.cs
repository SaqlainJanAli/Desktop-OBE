namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInActResultTbl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClassActivityResults", "ClassActivityResultId", "dbo.ClassActivities");
            RenameColumn(table: "dbo.ClassActivityResults", name: "ClassActivityResultId", newName: "ClassActivityId");
            RenameIndex(table: "dbo.ClassActivityResults", name: "IX_ClassActivityResultId", newName: "IX_ClassActivityId");
            DropPrimaryKey("dbo.ClassActivityResults");
            AddColumn("dbo.ClassActivityResults", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ClassActivityResults", "Id");
            AddForeignKey("dbo.ClassActivityResults", "ClassActivityId", "dbo.ClassActivities", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassActivityResults", "ClassActivityId", "dbo.ClassActivities");
            DropPrimaryKey("dbo.ClassActivityResults");
            DropColumn("dbo.ClassActivityResults", "Id");
            AddPrimaryKey("dbo.ClassActivityResults", "ClassActivityResultId");
            RenameIndex(table: "dbo.ClassActivityResults", name: "IX_ClassActivityId", newName: "IX_ClassActivityResultId");
            RenameColumn(table: "dbo.ClassActivityResults", name: "ClassActivityId", newName: "ClassActivityResultId");
            AddForeignKey("dbo.ClassActivityResults", "ClassActivityResultId", "dbo.ClassActivities", "Id");
        }
    }
}
