use Desktop_OBE

select * from ClassActivityResults

select * from StudentCourseSectionResults
update StudentCourseSectionResults set Percentage = 80.00, TotalMarks = 80
select * from StudentSemesterResults

select * from StudentCourseSectionResults

select * from EnrollStudents

select sr.Name, sr.RegistrationNo , cs.Name, sr.Assignment1, sr.Assignment2, sr.Assignment3, sr.Assignment4, sr.Quiz1, sr.Quiz2, sr.Quiz3, sr.Quiz4,
sr.Midterm, sr.Terminal, sr.Percentage, sr.Grade, sr.TotalMarks
from StudentCourseSectionResults as sr
inner join StudentUsers as su on sr.StudentId = su.id 
inner join CourseSections as cs on sr.CourseSecId = cs.Id
where su.Id = 5

select * from StudentUsers



select 
su.Name, su.RegistrationNo, su.FatherName, su.DateOfBirth, su.RollNo, 
c.Code, c.TheoryCreditHours,c.LabCreditHours, 
s.AcademicYear,s.Name, 
cs.Name, 
sr.Percentage, sr.Grade, sr.TotalMarks

from StudentCourseSectionResults as sr
inner join StudentUsers as su on sr.StudentId = su.id 
inner join CourseSections as cs on sr.CourseSecId = cs.Id
inner join Courses as c on cs.CourseId = c.Id
inner join Semesters as s on s.Id = cs.SemesterId
where su.Id = 6

ALTER PROCEDURE dbo.sp_StudentSemesterResult
    @studentId int
AS


select 
i.Name as InstututeName, i.Logo_Path as logoPath,
d.Name as DepartmentName,
su.Name as StudentName, su.RegistrationNo as RegistrationNo ,su.FatherName, su.DateOfBirth, su.RollNo, 
c.Code, CreditHours = c.TheoryCreditHours + c.LabCreditHours,
s.AcademicYear,s.Name as SemesterName, 
cs.Name as CourseSectionName, 
sr.Percentage, sr.Grade, sr.TotalMarks as ObtainedMarks

from StudentCourseSectionResults as sr
inner join StudentUsers as su on sr.StudentId = su.id 
inner join CourseSections as cs on sr.CourseSecId = cs.Id
inner join Courses as c on cs.CourseId = c.Id
inner join Semesters as s on s.Id = cs.SemesterId
inner join Departments as d on cs.DepartmentId = d.Id
inner join Schools as sc on sc.Id = d.SchoolId
inner join Campus as cam on cam.Id = sc.CampusId
inner join Institutes as i on i.Id = cam.University_Id
where su.Id = @studentId

go

exec sp_StudentSemesterResult 5

select * 
from StudentUsers as su
inner join EnrollStudents as es on su.Id=es.StudentUserId
inner join CourseSections as cs on cs.Id = es.CourseSectionId
inner join Departments as d on cs.DepartmentId = d.Id
where d.Id = 5004


select * from

CLOs as clo
inner join CLOCourses as cc on cc.CLOId = clo.Id
inner join Courses as c on c.Id = cc.CourseId where c.Id = 4002


select * from clos
select * from clocourses
select * from courses
select * from coursesections

select * from classactivities
select * from activityweights