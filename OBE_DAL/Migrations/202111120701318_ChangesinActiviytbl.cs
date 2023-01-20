namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesinActiviytbl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Activities", "CourseSectionId", "dbo.CourseSections");
            DropIndex("dbo.Activities", new[] { "CourseSectionId" });
            DropColumn("dbo.Activities", "CourseSectionId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Activities", "CourseSectionId", c => c.Int(nullable: false));
            CreateIndex("dbo.Activities", "CourseSectionId");
            AddForeignKey("dbo.Activities", "CourseSectionId", "dbo.CourseSections", "Id", cascadeDelete: true);
        }
    }
}
