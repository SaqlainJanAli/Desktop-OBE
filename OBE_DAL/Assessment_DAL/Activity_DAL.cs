using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.Assessment_Section.ActivityBEL;

namespace OBE_DAL.Assessment_DAL
{
    public class Activity_DAL
    {

        //Create
        public ResultModel CreateActivityDAL(Activity _activityBEL)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.Activities.Add(_activityBEL);
                    _dbContext.SaveChanges();

                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Activity Created Successfully!",
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
        public ResultModel DeleteActivityDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var activity = _dbContext.Activities.SingleOrDefault(a => a.Id == id);
                    if (activity != null)
                    {
                        _dbContext.Activities.Remove(activity);
                        _dbContext.SaveChanges();

                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Activity Deleted Successfully!",
                            Status = true
                        };
                    }

                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Activity Not Found!",
                        Status = false
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


        //Update
        public ResultModel UpdateActivityDAL(Activity activityBel)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var activity = _dbContext.Activities.SingleOrDefault(a => a.Id == activityBel.Id);
                    if (activity != null)
                    {
                        activity.Name = activityBel.Name;
                        activity.ShortName = activityBel.ShortName;
                        // activity.CourseSectionId = activityBel.CourseSectionId;
                        _dbContext.SaveChanges();

                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Activity has been updated Successfully!",
                            Status = true
                        };
                    }

                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Activity Not Found!",
                        Status = false
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

        //Read
        public List<Activity> GetActivitiesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Activities.ToList();
            }
        }

        public Activity GetActivityByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Activities.FirstOrDefault(a => a.Id == id);
            }
        }


        public List<Activity> GetActTypesByCourseSecIdDAL(int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Activities.Where(a => a.CourseSectionId == courseSecId).ToList();
            }
        }
    }
}
