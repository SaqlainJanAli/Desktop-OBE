namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdOnetoOneWithActivityandResult : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ClassActivityResults", "ClassActivityResultId", "dbo.ClassActivities");
            RenameColumn(table: "dbo.ClassActivityResults", name: "ClassActivityResultId", newName: "ClassActivityResultId");
            RenameIndex(table: "dbo.ClassActivityResults", name: "IX_ClassActivityResultId", newName: "IX_ClassActivityResultId");
            DropPrimaryKey("dbo.ClassActivityResults");
            AddPrimaryKey("dbo.ClassActivityResults", "ClassActivityResultId");
            AddForeignKey("dbo.ClassActivityResults", "ClassActivityResultId", "dbo.ClassActivities", "Id");
            DropColumn("dbo.ClassActivityResults", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ClassActivityResults", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ClassActivityResults", "ClassActivityResultId", "dbo.ClassActivities");
            DropPrimaryKey("dbo.ClassActivityResults");
            AddPrimaryKey("dbo.ClassActivityResults", "Id");
            RenameIndex(table: "dbo.ClassActivityResults", name: "IX_ClassActivityResultId", newName: "IX_ClassActivityResultId");
            RenameColumn(table: "dbo.ClassActivityResults", name: "ClassActivityResultId", newName: "ClassActivityResultId");
            AddForeignKey("dbo.ClassActivityResults", "ClassActivityResultId", "dbo.ClassActivities", "Id", cascadeDelete: true);
        }
    }
}
