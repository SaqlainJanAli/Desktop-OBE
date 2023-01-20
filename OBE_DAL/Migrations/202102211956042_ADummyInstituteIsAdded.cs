namespace OBE_DAL.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ADummyInstituteIsAdded : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Institutes (Name, IssuingAuthorityId, InstituteTypeId, MethodId, CountryId,CityId, FullGPA, AllowAttendance, PublicSector, YearEstablished,Address, WebsiteURL, Notes, Vision, Mission)Values('UAJK', 01, 02, 02, 04,03, 4, 10, 1, 1980,'Muzaffarabad AJK Chehla Campus', 'www.ajku.edu.pk', 'Notesnotes notes notes notes', 'Vision', 'Mission')");
            Sql("insert into Institutes (Name, IssuingAuthorityId, InstituteTypeId, MethodId, CountryId,CityId, FullGPA, AllowAttendance, PublicSector, YearEstablished,Address, WebsiteURL, Notes, Vision, Mission)Values('MUST', 01, 02, 02, 04,03, 4, 10, 1, 1999,'Mirpur AJK', 'www.must.edu.pk', 'Notesnotes notes notes notes', 'Vision', 'Mission')");
            Sql("insert into Institutes (Name, IssuingAuthorityId, InstituteTypeId, MethodId, CountryId,CityId, FullGPA, AllowAttendance, PublicSector, YearEstablished,Address, WebsiteURL, Notes, Vision, Mission)Values('Kotli University', 01, 02, 02, 04,03, 4, 10, 1, 1990,'Kotli Bagh AJK', 'www.kotliajk.edu.pk', 'Notesnotes notes notes notes', 'Vision', 'Mission')");
            Sql("insert into Institutes (Name, IssuingAuthorityId, InstituteTypeId, MethodId, CountryId,CityId, FullGPA, AllowAttendance, PublicSector, YearEstablished,Address, WebsiteURL, Notes, Vision, Mission)Values('Rawalakot University', 01, 02, 02, 04,03, 4, 10, 1, 1985,'Rawalakot AJK', 'www.rawalakotajk.edu.pk', 'Notesnotes notes notes notes', 'Vision', 'Mission')");



            //insert into Institutes
            //(
            //    Name, IssuingAuthorityId, InstituteTypeId, MethodId, CountryId,
            //    CityId, FullGPA, AllowAttendance, PublicSector, YearEstablished,
            //    Address, WebsiteURL, Notes, Vision, Mission)
            //Values
            //(
            //    'UAJK', 01, 02, 02, 04,
            //    03, 4, 10, 1, 1980,
            //    'Muzaffarabad AJK Chehla Campus', 'www.ajku.edu.pk', 'Notesnotes notes notes notes', 'Vision', 'Mission'
            //)

        }

        public override void Down()
        {
        }
    }
}
