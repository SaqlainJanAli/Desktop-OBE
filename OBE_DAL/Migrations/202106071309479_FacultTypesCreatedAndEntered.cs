namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class FacultTypesCreatedAndEntered : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                  "dbo.FacultyTypes",
                  c => new
                  {
                      Id = c.Int(nullable: false, identity: true),
                      Name = c.String(),
                  })
                  .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.FTypes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            //Entering Dummy Data

            Sql(@"
            INSERT INTO FTypes(Name) VALUES('Permanent')
            INSERT INTO FTypes(Name) VALUES('Visiting')


            INSERT INTO FacultyTypes(Name) VALUES('Instructor')
            INSERT INTO FacultyTypes(Name) VALUES('Lab Instructor')
            INSERT INTO FacultyTypes(Name) VALUES('Lecturer')
            INSERT INTO FacultyTypes(Name) VALUES('Assistant Professor')
            INSERT INTO FacultyTypes(Name) VALUES('Associate Professor')
            INSERT INTO FacultyTypes(Name) VALUES('Clerk')
            INSERT INTO FacultyTypes(Name) VALUES('Accountant')

                    ");
          

        }

        public override void Down()
        {
            DropTable("dbo.FTypes");
            DropTable("dbo.FacultyTypes");
        }
    }
}
