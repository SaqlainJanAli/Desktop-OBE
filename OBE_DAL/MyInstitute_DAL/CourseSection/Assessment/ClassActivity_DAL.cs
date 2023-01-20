using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;

namespace OBE_DAL.MyInstitute_DAL.CourseSection.Assessment
{
    public class ClassActivity_DAL
    {
        //Create
        public ResultModel CreateClassActivityDAL(ClassActivity _classActivityBEL)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.ClassActivities.Add(_classActivityBEL);
                    _dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = _classActivityBEL.Id,
                        Message = "Class Activity created successfully!",
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
        public ResultModel CreateSubActivityDAL(List<SubActivity> _subActivities)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {

                    _dbContext.SubActivities.AddRange(_subActivities);
                    _dbContext.SaveChanges();

                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Class Activity Created Successfully",
                        Status = true
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
        public ResultModel UpdateClassActivityDAL(ClassActivity _classActivityBEL)
        {

            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {

                    var _classActivity =
                        _dbContext.ClassActivities.SingleOrDefault(ca => ca.Id == _classActivityBEL.Id);
                    if (_classActivity != null)
                    {
                        _classActivity.ActivityId = _classActivityBEL.ActivityId;
                        _classActivity.Name = _classActivityBEL.Name;
                        _classActivity.ActivityDate = _classActivityBEL.ActivityDate;
                        _classActivity.ComplexEP = _classActivityBEL.ComplexEP;
                        _classActivity.IncludeGpaCal = _classActivityBEL.IncludeGpaCal;
                        _classActivity.CourseSecId = _classActivityBEL.CourseSecId;
                        _classActivity.GpaWeight = _classActivityBEL.GpaWeight;
                        _classActivity.TotalMarks = _classActivityBEL.TotalMarks;
                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Class Activity Updated Successfully!",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Class Activity not found!",
                            Status = false
                        };
                    }

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
        public ResultModel UpdateSubActivityDAL(List<SubActivity> _subActivities)
        {

            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    foreach (var item in _subActivities)
                    {
                        var _subActivity = _dbContext.SubActivities.SingleOrDefault(S => S.Id == item.Id);
                        if (_subActivity != null)
                        {
                            _subActivity.ActivityId = item.ActivityId;
                            _subActivity.CloId = item.CloId;
                            _subActivity.MaxMarks = item.MaxMarks;
                            _subActivity.Name = item.Name;
                            _subActivity.OBEWeight = item.OBEWeight;

                            _dbContext.SaveChanges();
                        }
                        else
                        {
                            _dbContext.SubActivities.Add(item);
                            _dbContext.SaveChanges();
                        }
                    }
                    return new ResultModel
                    {
                        Data = null,
                        Message = "Class activity updated successfully!",
                        Status = true
                    };
                }
            }
            catch (Exception e)
            {
                return new ResultModel
                {
                    Data = null,
                    Message = e.Message,
                    Status = false
                };
            }
        }


        //Delete
        public ResultModel DeleteClassActivityDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {

                    var Ent = _dbContext.ClassActivities.SingleOrDefault(ca => ca.Id == id);
                    if (Ent != null)
                    {
                        _dbContext.ClassActivities.Remove(Ent);
                        _dbContext.SaveChanges();
                        var ent = _dbContext.SubActivities.Where(s => s.ActivityId == id);
                        if (ent != null)
                        {
                            _dbContext.SubActivities.RemoveRange(ent);
                            _dbContext.SaveChanges();
                            return new ResultModel
                            {
                                Data = null,
                                Message = "Class Activity Deleted Successfully!",
                                Status = true
                            };
                        }
                        else
                        {
                            return new ResultModel
                            {
                                Data = null,
                                Message = "Sub Activity Not Found in Database",
                                Status = true
                            };
                        }

                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Class Activity not found!",
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
        }


        //Read
        public object getClassActivitiesDAL(int courseSectionId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ClassActivities.Where(ca => ca.CourseSecId == courseSectionId)
                    .Join(_dbContext.Activities, ca => ca.ActivityId, a => a.Id,
                        (ca, a) => new
                        {
                            Id = ca.Id,
                            Name = ca.Name,
                            ActivityId = a.Name,
                            TotalMarks = ca.TotalMarks,
                            GPAWeight = ca.GpaWeight,
                            CourseSectionId = ca.CourseSecId
                        }
                    ).ToList();
            }
        }
        public List<SubActivity> getSubActByActIdDAL(int classActId)
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                return _dbContext.SubActivities.Where(s => s.ActivityId == classActId).ToList();
            }
        }

        public ClassActivity getClassActByIdDAL(int classActId)
        {

            using (var _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ClassActivities.SingleOrDefault(c => c.Id == classActId);
            }
        }
        public decimal GetUsedActWeightByActTypeIdDAL(int selectedActTypeId, int courseSectionId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var listofActivities = _dbContext.ClassActivities
                    .Where(ca => ca.ActivityId == selectedActTypeId && ca.CourseSecId == courseSectionId).ToList();
                decimal WeightUsed= Convert.ToDecimal(0.00);
                //Getting total Gpa Weights for above activity type in this course section
                foreach (var activityItem in listofActivities)
                {
                    WeightUsed += activityItem.GpaWeight;
                }
                return WeightUsed;
            }
        }
    }
}
