/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [Id]
      ,[Name]
  FROM [Desktop_OBE].[dbo].[Roles]

  insert into IssuingAuthorities (AuthorityName) Values ('HEC') 
  insert into PLOCalculationMethods (Name) Values ('GPA')
  insert into Types (Name) Values ('Engineering')
  insert into Countries (Name) Values ('Pakistan')
  insert into Cities (Name) Values ('Karachi')

 select * from Institutes

 insert into Institutes 
 (
 Name, IssuingAuthorityId,InstituteTypeId,MethodId,CountryId,
 CityId,FullGPA,AllowAttendance,PublicSector,YearEstablished,
 Address,WebsiteURL,Notes,Vision,Mission)
 Values
 (
 'UAJK',01,02,02,04,
 03,4,10,1,1980,
 'Muzaffarabad AJK Chehla Campus', 'www.ajku.edu.pk','Notesnotes notes notes notes','Vision','Mission'
 )
