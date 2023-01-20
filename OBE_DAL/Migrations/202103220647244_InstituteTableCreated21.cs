namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InstituteTableCreated21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "dbo.Countries",
              c => new
              {
                  Id = c.Int(nullable: false, identity: false),
                  Name = c.String(nullable: false, maxLength: 100),
                  Code = c.String(nullable: false),
                  Language = c.String(nullable: false)
              })
              .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
        }
    }
}
