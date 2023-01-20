using System;
using System.Linq;
using System.Security.Cryptography;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;

namespace OBE_DAL.MyInstitute_DAL.CourseSection.Assessment
{
    public class ClassActivityResult_DAL
    {

        //Create
        public ResultModel SaveActivityResultDAL(ClassActivityResult activityResultBel)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.ClassActivityResults.Add(activityResultBel);
                    _dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Class Activity Result has been saved",
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


        //Delete
        public ResultModel DeleteActivityResultDAL(int classActid, int studentId, int courseSecid)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var actRes = _dbContext.ClassActivityResults.FirstOrDefault(ar => ar.ClassActivityId == classActid && ar.StudentUserId == studentId && ar.CourseSecId == courseSecid);
                    if (actRes != null)
                    {
                        _dbContext.ClassActivityResults.Remove(actRes);
                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Class Activity Result has been deleted",
                            Status = true
                        };
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Class Activity Result not found",
                        Status = false
                    };

                }
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


        //Update
        public ResultModel UpdateActivityResultDAL(ClassActivityResult activityResultBel)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var actRes = _dbContext.ClassActivityResults.FirstOrDefault(ar => ar.ClassActivityId == activityResultBel.ClassActivityId && ar.StudentUserId == activityResultBel.StudentUserId && ar.CourseSecId == activityResultBel.CourseSecId);
                    if (actRes != null)
                    {
                        actRes.CourseSecId = activityResultBel.CourseSecId;
                        actRes.StudentUserId = activityResultBel.StudentUserId;
                        actRes.ActivityTypeId = activityResultBel.ActivityTypeId;
                        actRes.ClassActivityId = activityResultBel.ClassActivityId;
                        actRes.ActivityTotalMarks = activityResultBel.ActivityTotalMarks;
                        actRes.ActivityObtainedMarks = activityResultBel.ActivityObtainedMarks;
                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Class Activity Result has been updated",
                            Status = true
                        };
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Class Activity Result not found",
                        Status = false
                    };

                }
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



        //Read
        public ClassActivityResult GetResultByClassActIdDAL(int classActid, int studentId, int courseSecid, int activityTypeId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ClassActivityResults.FirstOrDefault(car =>
                    car.ClassActivityId == classActid && car.StudentUserId == studentId &&
                    car.CourseSecId == courseSecid && car.ActivityTypeId == activityTypeId);
            }
        }

        public ClassActivityResult GetResultIDByClassActIdDAL(int classActid, int studentId, int courseSecid)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ClassActivityResults.FirstOrDefault(ar => ar.ClassActivityId == classActid && ar.StudentUserId == studentId && ar.CourseSecId == courseSecid);
            }
        }

        //public ClassActivityResult GetResultIDByClassActIdDAL(int classActid, int studentId, int courseSecid)
        //{
        //    using (ApplicationDbContext _dbContext = new ApplicationDbContext())
        //    {
        //        return _dbContext.ClassActivityResults.FirstOrDefault(ar => ar.ClassActivityId == classActid && ar.StudentUserId == studentId && ar.CourseSecId == courseSecid);
        //    }
        //}

        public object GetEnrolledStudentsWithResultDAL(int courseSecid, int classActid, int activityTypeId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var ResultsInThisClassActivity = _dbContext.ClassActivityResults.Where(ar => ar.ClassActivityId == classActid && ar.ActivityTypeId == activityTypeId && ar.CourseSecId == courseSecid).ToList();

                return ResultsInThisClassActivity.Join(_dbContext.StudentUsers,
                    car => car.StudentUserId,
                    es => es.Id,
                    (car, es) => new
                    {
                        Id = es.Id,
                        Name = es.Name,
                        RegistrationNo = es.RegistrationNo,
                        RollNo = es.RollNo,
                        ClassActivId = classActid,
                        ActivityTypeId = activityTypeId,
                        TotalMarks = car.ActivityTotalMarks.ToString(),
                        ObtainedMarks = car.ActivityObtainedMarks.ToString(),
                        
                    }
                ).Join(_dbContext.ClassActivities,
                    car => car.ClassActivId,
                    ca => ca.Id,
                    (car, ca) => new
                    {
                        Id = car.Id,
                        Name = car.Name,
                        RegistrationNo = car.RegistrationNo,
                        RollNo = car.RollNo,
                        ClassActivId = classActid,
                        ActivityTypeId = activityTypeId,
                        TotalMarks = car.TotalMarks,
                        ObtainedMarks = car.ObtainedMarks,
                        GpaWeight = ca.GpaWeight
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
                        ClassActivId = classActid,
                        ActivityTypeId = at.Name,
                        TotalMarks = car.TotalMarks,
                        ObtainedMarks = car.ObtainedMarks,
                        GpaWeight = car.GpaWeight
                    }).ToList();
            }
        }

    }
}

