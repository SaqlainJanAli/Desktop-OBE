using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.ActivityWeight;

namespace OBE_DAL.MyInstitute_DAL.CourseSection.Activity_Weight
{
    public class ActivityWeightDAL
    {

        //Create
        public ResultModel CreateActivityWeightDAL(ActivityWeight activityWeightBel)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.ActivityWeights.Add(activityWeightBel);
                    _dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Class Activity Weight created successfully!",
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

    
        //Update
        public ResultModel UpdateActivityWeightDAL(ActivityWeight activityWeightBel)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var activityWeight = _dbContext.ActivityWeights.FirstOrDefault(aw => aw.CourseSectionId == activityWeightBel.CourseSectionId && aw.ActivityId == activityWeightBel.ActivityId);
                    if (activityWeight != null)
                    {
                        activityWeight.CourseSectionId = activityWeightBel.CourseSectionId;
                        activityWeight.ActivityId = activityWeightBel.ActivityId;
                        activityWeight.Weight = activityWeightBel.Weight;
                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Activity Weight Updated successfully!",
                            Status = true
                        };
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Activity not found in database",
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

        //Delete
        public ResultModel DeleteActivityWeightDAL(int actTypeId, int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var activityWeight = _dbContext.ActivityWeights.FirstOrDefault(aw => aw.ActivityId == actTypeId && aw.CourseSectionId == courseSecId);
                    if (activityWeight !=null)
                    {
                        _dbContext.ActivityWeights.Remove(activityWeight);
                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Activity Weight deleted successfully!",
                            Status = true
                        };
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Activity not found in database",
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


        //public List<ActivityWeight> GetWeightsDAL()
        //{
        //    using (ApplicationDbContext _dbContext = new ApplicationDbContext())
        //    {
        //        return _dbContext.ActivityWeights.ToList();
        //    }
        //}
        public object GetWeightsBySecIdDAL(int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ActivityWeights.Where(a => a.CourseSectionId == courseSecId).Join(
                    _dbContext.Activities,
                    aw => aw.ActivityId,
                    a => a.Id,
                    (aw, a) => new
                    {
                        ActivityId = a.Id,
                        ActivityName = a.Name,
                        Weight = aw.Weight
                    }

                ).ToList();
            }
        }
        public List<ActivityWeight> GetWeightsByCourseSecIdDAL(int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ActivityWeights.Where(aw => aw.CourseSectionId== courseSecId).ToList();
            }
        }

        public ActivityWeight GetWeightByActTypeIdDAL(int actTypeId, int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ActivityWeights.FirstOrDefault(aw => aw.ActivityId == actTypeId && aw.CourseSectionId == courseSecId);
            }
        }
    }
}
