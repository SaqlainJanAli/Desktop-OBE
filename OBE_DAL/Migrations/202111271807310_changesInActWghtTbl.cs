namespace OBE_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesInActWghtTbl : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ActivityWeights");
            AddPrimaryKey("dbo.ActivityWeights", new[] { "CourseSectionId", "ActivityId" });
            DropColumn("dbo.ActivityWeights", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActivityWeights", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.ActivityWeights");
            AddPrimaryKey("dbo.ActivityWeights", "Id");
        }
    }
}
