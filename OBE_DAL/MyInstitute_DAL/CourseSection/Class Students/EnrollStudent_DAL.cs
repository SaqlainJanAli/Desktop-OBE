using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;

namespace OBE_DAL.MyInstitute_DAL.CourseSection.Class_Students
{
    public class EnrollStudent_DAL
    {
        public ResultModel SaveStudentDAL(EnrollStudent enrollStudentBel)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.EnrollStudents.Add(enrollStudentBel);
                    _dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Student enrolled successfully!",
                        Status = true
                    };

                }
                catch (Exception e)
                {
                    return new ResultModel()
                    {
                        Data = null,
                        Message = e.Message,
                        Status = false
                    };
                }
            }
        }

        public ResultModel SaveStudentsDAL(List<EnrollStudent> enrollStudentListBel)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.EnrollStudents.AddRange(enrollStudentListBel);
                    _dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Student enrolled successfully!",
                        Status = true
                    };

                }
                catch (Exception e)
                {
                    return new ResultModel()
                    {
                        Data = null,
                        Message = e.Message,
                        Status = false
                    };
                }
            }
        }

        public object GetEnrolledStudentsWithoutResultDAL(int courseSecid, int classActId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var enrollStudents = _dbContext.EnrollStudents.Where(es => es.CourseSectionId == courseSecid).ToList();
                var activityResults = _dbContext.ClassActivityResults
                    .Where(ar => ar.CourseSecId == courseSecid && ar.ClassActivityId == classActId).ToList();

                List<int> ListOfIdsToRemove = new List<int>();
                foreach (var enrollStudent in enrollStudents)
                {
                    if (activityResults.Count > 0)
                    {
                        foreach (var activityResult in activityResults)
                        {
                            if (enrollStudent.StudentUserId == activityResult.StudentUserId)
                            {
                                ListOfIdsToRemove.Add(enrollStudent.StudentUserId);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }

                // var ListOfES = new List<EnrollStudent>();
                foreach (var item in ListOfIdsToRemove)
                {

                    var enrollStd = enrollStudents.FirstOrDefault(c => c.StudentUserId == item);
                    enrollStudents.Remove(enrollStd);
                }

                return enrollStudents.Join(_dbContext.StudentUsers,
                    es => es.StudentUserId,
                    su => su.Id,
                    (es, su) => new
                    {
                        Id = es.StudentUserId,
                        Name = su.Name,
                        RegistrationNo = su.RegistrationNo,
                        RollNo = su.RollNo
                    }
                ).Distinct().ToList();
            }
        }

        public object GetEnrolledStudentsByDepartIdDAL(int departId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var query =
                   (from su in _dbContext.StudentUsers
                    join es in _dbContext.EnrollStudents on su.Id equals es.StudentUserId
                    join cs in _dbContext.CourseSections on es.CourseSectionId equals cs.Id
                    join d in _dbContext.Departments on cs.DepartmentId equals d.Id
                    where d.Id == departId
                    select  new 
                    {
                        Id = su.Id,
                        Name = su.Name,
                        RegistrationNo = su.RegistrationNo,
                        RollNo = su.RollNo
                    }).GroupBy(s => s.Id).Select(s=>s.FirstOrDefault()).ToList();
                return query;
            }
        }
    }
}
