using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL.Admin_Section.StudentUserBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;

namespace OBE_DAL.MyInstitute_DAL.CourseSection.Class_Students
{
    public class ClassStudent_DAL
    {
        public object GetStudentsBySecIdDAL(int courseSecid)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecid).Join(_dbContext.StudentUsers,
                    es => es.StudentUserId,
                    su => su.Id,
                    (es, su) => new
                    {
                        Id = es.StudentUserId,
                        RegistrationNo = su.RegistrationNo,
                        RollNo = su.RollNo,
                        Name = su.Name,
                        ProgramBatchId = su.ProgramBatchId,
                        //Grade = ,
                    }
                ).Join(_dbContext.ProgramBatches,
                    es => es.ProgramBatchId,
                    pb => pb.Id,
                    (es, pb) => new
                    {
                        Id = es.Id,
                        RegistrationNo = es.RegistrationNo,
                        RollNo = es.RollNo,
                        Name = es.Name,
                        ProgramBatchId = pb.ProgramBatchName,
                        //Grade = ,
                    }
                ).ToList();
            }
        }

        public List<EnrollStudent> GetAllStudentsBySecIdDAL(int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecId).ToList();
            }
        }

        public object GetEnrolledStudentsWithActResultDAL(int courseSecid, int classActid, int activityTypeId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {

                ////StudentUsers
                //List<StudentUser> _studentUsers = new List<StudentUser>();
                //foreach (var enrollStudent in EnrollStds)
                //{
                //    var StdUser = _dbContext.StudentUsers.FirstOrDefault(su => su.Id == enrollStudent.StudentUserId );
                //    _studentUsers.Add(StdUser);
                //}

                //ActivityResult
                //var AvtivityResults = _dbContext.ClassActivityResults.Where(car => car.ClassActivityId == classActid && car.CourseSecId == courseSecid)
                //    .ToList();
                //List<int> StudentIDsWithCAR = new List<int>();
                //foreach (var item in AvtivityResults)
                //{
                //    StudentIDsWithCAR.Add(item.StudentUserId);
                //}
                ////Enrolled Students
                //object List1WithoutAR;
                //List<EnrollStudent> obj1WithoutAR = _dbContext.EnrollStudents.Where(es => es.CourseSectionId == es.CourseSectionId).ToList();

                //foreach (var Std in obj1WithoutAR)
                //{
                //    foreach (var item in StudentIDsWithCAR)
                //    {
                //        if (Std.StudentUserId == item)
                //        {
                //            obj1WithoutAR.Remove(Std);
                //        }
                //    }
                //}

                //var obj2WithAR = _dbContext.EnrollStudents.;


                //var abc = from es in _dbContext.EnrollStudents
                //          where es.CourseSectionId == courseSecid
                //          join su in _dbContext.StudentUsers on es.StudentUserId equals su.Id into enstds
                //          from std in enstds.DefaultIfEmpty()  

                //join ca in _dbContext.ClassActivities on std. in _dbContext.ac

                //        let

                ////var qry = _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecid).GroupJoin(_dbConte);
                //var qry2 = _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecid).Join(
                //    _dbContext.ClassActivities,
                //    es => es.CourseSectionId,
                //    ca => ca.CourseSecId,
                //    (es, ca) => new
                //    {
                //        Id = es.StudentUserId,
                //        Name = "su.Name",
                //        RegistrationNo = "su.RegistrationNo",
                //        RollNo = "su.RollNo",
                //        ClassActivityId = classActid,
                //        ActivityTypeId = activityTypeId,
                //        TotalMarks = ca.TotalMarks,
                //        ObtainedMarks = 0.00,
                //        //GpaWeight
                //    }
                //).Join(
                //    _dbContext.StudentUsers,
                //    es => es.Id,
                //    su => su.Id,
                //    (es, su) => new
                //    {
                //        Id = es.Id,
                //        Name = su.Name,
                //        RegistrationNo = su.RegistrationNo,
                //        RollNo = su.RollNo,
                //        ClassActivityId = es.ClassActivityId,
                //        ActivityTypeId = es.ActivityTypeId,
                //        TotalMarks = es.TotalMarks,
                //        ObtainedMarks = es.ObtainedMarks,
                //        //GpaWeight

                //    }
                //).Join(_dbContext.Activities,
                //    es => es.ActivityTypeId,
                //    at => at.Id,
                //    (es, at) => new
                //    {
                //        Id = es.Id,
                //        Name = es.Name,
                //        RegistrationNo = es.RegistrationNo,
                //        RollNo = es.RollNo,
                //        ClassActivityId = es.ClassActivityId,
                //        ActivityTypeId = at.Name,
                //        TotalMarks = es.TotalMarks,
                //        ObtainedMarks = es.ObtainedMarks,
                //        //GpaWeight
                //    }
                //).SelectMany(
                //    es =>

                //        _dbContext.ClassActivityResults.Where(car => car.ClassActivityId == es.ClassActivityId)
                //            .DefaultIfEmpty(),
                //    (es, car) => new
                //    {
                //        Id = es.Id,
                //        Name = es.Name,
                //        RegistrationNo = es.RegistrationNo,
                //        RollNo = es.RollNo,
                //        ClassActivityId = classActid,
                //        ActivityTypeId = activityTypeId,
                //        TotalMarks = car.ActivityTotalMarks,
                //        ObtainedMarks =(car.ActivityObtainedMarks == null ||car.ActivityObtainedMarks.ToString()=="0.00")?es.ObtainedMarks.ToString(): car.ActivityObtainedMarks.ToString(),
                //        //GpaWeight
                //    }
                //).DefaultIfEmpty().ToList();

                //return qry2;



                //return _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecid).ToList();

                if (_dbContext.ClassActivityResults.Where(car => car.CourseSecId == courseSecid).Count() < 1)
                {
                    return _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecid).Join(_dbContext.ClassActivities,
                        es => es.CourseSectionId,
                        ca => ca.CourseSecId,
                        (es, ca) => new
                        {
                            Id = es.StudentUserId,
                            Name = "Nil",
                            RegistrationNo = "Nil",
                            RollNo = "Nil",
                             //ClassActivityId = classActid,
                             ActivityTypeId = activityTypeId,
                            TotalMarks = ca.TotalMarks,
                            ObtainedMarks = 0.00,
                             //GpaWeight
                         }).Join(
                    _dbContext.StudentUsers,
                    es => es.Id,
                    su => su.Id,
                    (es, su) => new
                    {
                        Id = es.Id,
                        Name = su.Name,
                        RegistrationNo = su.RegistrationNo,
                        RollNo = su.RollNo,
                        ActivityTypeId = es.ActivityTypeId,
                        TotalMarks = es.TotalMarks,
                        ObtainedMarks = es.ObtainedMarks,
                         //GpaWeight

                     }
                ).Join(_dbContext.Activities,
                    car => car.ActivityTypeId,
                    at => at.Id,
                    (car, at) => new
                    {
                        Id = car.Id,
                        Name = car.Name,
                        RegistrationNo = car.RegistrationNo,
                        RollNo = car.RollNo,
                        ActivityTypeId = at.Name,
                        TotalMarks = car.TotalMarks,
                        ObtainedMarks = car.ObtainedMarks,
                         //GpaWeight
                     }
                ).Distinct().ToList();
                }
                else
                {
                    return _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecid).Join(_dbContext.ClassActivities,
                   es => es.CourseSectionId,
                   ca => ca.CourseSecId,
                   (es, ca) => new
                   {
                       Id = es.StudentUserId,
                       Name = "su.Name",
                       RegistrationNo = "su.RegistrationNo",
                       RollNo = "su.RollNo",
                       ClassActivityId = classActid,
                       ActivityTypeId = activityTypeId,
                       TotalMarks = ca.TotalMarks,
                       ObtainedMarks = 0.00,
                        //GpaWeight
                    }
               ).Join(_dbContext.ClassActivityResults,
                   es => es.ClassActivityId,
                   car => car.ClassActivityId,
                   (es, car) => new
                   {
                       Id = es.Id,
                       Name = "su.Name",
                       RegistrationNo = "su.RegistrationNo",
                       RollNo = "su.RollNo",
                       ClassActivityId = classActid,
                       ActivityTypeId = activityTypeId,
                       TotalMarks = car.ActivityTotalMarks,
                       ObtainedMarks = car.ActivityObtainedMarks,
                        //GpaWeight
                    }
               ).Join(
                   _dbContext.StudentUsers,
                   es => es.Id,
                   su => su.Id,
                   (es, su) => new
                   {
                       Id = es.Id,
                       Name = su.Name,
                       RegistrationNo = su.RegistrationNo,
                       RollNo = su.RollNo,
                       ActivityTypeId = es.ActivityTypeId,
                       TotalMarks = es.TotalMarks,
                       ObtainedMarks = es.ObtainedMarks,
                        //GpaWeight

                    }
               ).Join(_dbContext.Activities,
                   car => car.ActivityTypeId,
                   at => at.Id,
                   (car, at) => new
                   {
                       Id = car.Id,
                       Name = car.Name,
                       RegistrationNo = car.RegistrationNo,
                       RollNo = car.RollNo,
                       ActivityTypeId = at.Name,
                       TotalMarks = car.TotalMarks,
                       ObtainedMarks = car.ObtainedMarks,
                        //GpaWeight
                    }
               ).DefaultIfEmpty().Distinct().ToList();
                }

            }
        }
    }
}
