namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesinStdRstTbl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StudentCourseSectionResults", "RegistrationNo", c => c.String());
            AddColumn("dbo.StudentCourseSectionResults", "Name", c => c.String());
            AddColumn("dbo.StudentCourseSectionResults", "TotalMarks", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StudentCourseSectionResults", "Percentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.StudentCourseSectionResults", "Grade", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.StudentCourseSectionResults", "Grade");
            DropColumn("dbo.StudentCourseSectionResults", "Percentage");
            DropColumn("dbo.StudentCourseSectionResults", "TotalMarks");
            DropColumn("dbo.StudentCourseSectionResults", "Name");
            DropColumn("dbo.StudentCourseSectionResults", "RegistrationNo");
        }
    }
}
