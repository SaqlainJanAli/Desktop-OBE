using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;

namespace OBE_DAL.MyInstitute_DAL
{
    public class Course_DAL
    {

        //Get
        public List<KnowledgeArea> GetKnowledgeAreasDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.KnowledgeAreas.ToList();
            }
        }
        public List<KnowledgeProfile> GetKnowledgeProfilesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.KnowledgeProfiles.ToList();
            }
        }
        public List<Course> GetPrereqCoursesDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.Courses.ToList();
            }
        }
        public List<ProgramCourse> GetProgramCourseDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.ProgramCourses.Where(P => P.CourseId == id).ToList();

            }
        }
        public Course GetCourseByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Courses.SingleOrDefault(C => C.Id == id);

            }
        }
        public List<DeliveryFormat> GetDeliveryFormatsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.DeliveryFormats.ToList();
            }
        }
        public List<CourseLevel> GetCourseLevelsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.CourseLevels.ToList();
            }
        }
        public object GetCoursesDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.Courses.Join(_dbContext.ProgramCourses,
                        C => C.Id,
                        pc => pc.CourseId,
                        (C, pc) => new
                        {
                            SerialNumber = C.Id,
                            Code = C.Code,
                            Name = C.Name,
                            DepartmentId = C.DepartmentId,
                            Active = C.Active,
                            CreditHours = C.TheoryCreditHours + C.LabCreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            KnowledgeProfileId = C.KnowledgeProfileId,
                            ProgramBatchId = pc.ProgramBatchId
                        }


                    ).Join(

                        _dbContext.ProgramBatches,
                        C => C.ProgramBatchId,
                        pb => pb.Id,
                        (C, pb) => new
                        {
                            SerialNumber = C.SerialNumber,
                            Code = C.Code,
                            Name = C.Name,
                            CreditHours = C.CreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            Active = C.Active,
                            KnowledgeProfileId = C.KnowledgeProfileId,

                            DepartmentId = C.DepartmentId,



                            ProgramBatchId = pb.ProgramBatchName


                        }).Join(

                    _dbContext.Departments,
                    C => C.DepartmentId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,

                        DepartmentId = D.Name,


                        ProgramBatchId = C.ProgramBatchId

                    }).Join(_dbContext.CourseLevels,
                    C => C.CourseLevelId,
                    c => c.Id,
                    (C, c) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,


                        CourseLevelId = c.LevelName,
                        ProgramBatchId = C.ProgramBatchId
                    }


                    ).Join(_dbContext.DeliveryFormats,

                    C => C.DeliveryFormatId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,

                        DeliveryFormatId = D.Name,
                        ProgramBatchId = C.ProgramBatchId

                    }

                    ).Join(_dbContext.KnowledgeProfiles,
                    C => C.KnowledgeProfileId,
                    K => K.Id,
                    (C, K) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,

                        KnowledgeProfileId = K.Name,
                        ProgramBatchId = C.ProgramBatchId
                    }

                    )



                    .ToList();
            }
        }
        public object CountCourseDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Courses.Count();
            }
        }
        public object FilterDGVByDeptDAL(int selectedValue)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Courses.Where(c => c.DepartmentId == selectedValue).Join(_dbContext.ProgramCourses,
                        C => C.Id,
                        pc => pc.CourseId,
                        (C, pc) => new
                        {
                            SerialNumber = C.Id,
                            Code = C.Code,
                            Name = C.Name,
                            DepartmentId = C.DepartmentId,
                            Active = C.Active,
                            CreditHours = C.TheoryCreditHours + C.LabCreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            KnowledgeProfileId = C.KnowledgeProfileId,
                            ProgramBatchId = pc.ProgramBatchId
                        }


                    ).Join(

                        _dbContext.ProgramBatches,
                        C => C.ProgramBatchId,
                        pb => pb.Id,
                        (C, pb) => new
                        {
                            SerialNumber = C.SerialNumber,
                            Code = C.Code,
                            Name = C.Name,
                            CreditHours = C.CreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            Active = C.Active,
                            KnowledgeProfileId = C.KnowledgeProfileId,

                            DepartmentId = C.DepartmentId,



                            ProgramBatchId = pb.ProgramBatchName


                        }).Join(

                    _dbContext.Departments,
                    C => C.DepartmentId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,

                        DepartmentId = D.Name,


                        ProgramBatchId = C.ProgramBatchId

                    }).Join(_dbContext.CourseLevels,
                    C => C.CourseLevelId,
                    c => c.Id,
                    (C, c) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,


                        CourseLevelId = c.LevelName,
                        ProgramBatchId = C.ProgramBatchId
                    }


                    ).Join(_dbContext.DeliveryFormats,

                    C => C.DeliveryFormatId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,

                        DeliveryFormatId = D.Name,
                        ProgramBatchId = C.ProgramBatchId

                    }

                    ).Join(_dbContext.KnowledgeProfiles,
                    C => C.KnowledgeProfileId,
                    K => K.Id,
                    (C, K) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,

                        KnowledgeProfileId = K.Name,
                        ProgramBatchId = C.ProgramBatchId
                    }

                    )



                    .ToList();
            }
        }
        public object FilterDGVByCodeDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Courses.Where(c => c.Code.Contains(text.Trim())).Join(_dbContext.ProgramCourses,
                        C => C.Id,
                        pc => pc.CourseId,
                        (C, pc) => new
                        {
                            SerialNumber = C.Id,
                            Code = C.Code,
                            Name = C.Name,
                            DepartmentId = C.DepartmentId,
                            Active = C.Active,
                            CreditHours = C.TheoryCreditHours + C.LabCreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            KnowledgeProfileId = C.KnowledgeProfileId,
                            ProgramBatchId = pc.ProgramBatchId
                        }


                    ).Join(

                        _dbContext.ProgramBatches,
                        C => C.ProgramBatchId,
                        pb => pb.Id,
                        (C, pb) => new
                        {
                            SerialNumber = C.SerialNumber,
                            Code = C.Code,
                            Name = C.Name,
                            CreditHours = C.CreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            Active = C.Active,
                            KnowledgeProfileId = C.KnowledgeProfileId,

                            DepartmentId = C.DepartmentId,



                            ProgramBatchId = pb.ProgramBatchName


                        }).Join(

                    _dbContext.Departments,
                    C => C.DepartmentId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,

                        DepartmentId = D.Name,


                        ProgramBatchId = C.ProgramBatchId

                    }).Join(_dbContext.CourseLevels,
                    C => C.CourseLevelId,
                    c => c.Id,
                    (C, c) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,


                        CourseLevelId = c.LevelName,
                        ProgramBatchId = C.ProgramBatchId
                    }


                    ).Join(_dbContext.DeliveryFormats,

                    C => C.DeliveryFormatId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,

                        DeliveryFormatId = D.Name,
                        ProgramBatchId = C.ProgramBatchId

                    }

                    ).Join(_dbContext.KnowledgeProfiles,
                    C => C.KnowledgeProfileId,
                    K => K.Id,
                    (C, K) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,

                        KnowledgeProfileId = K.Name,
                        ProgramBatchId = C.ProgramBatchId
                    }

                    )



                    .ToList();
            }
        }
        public object FilterDGVByNameDAL(int selectedValue)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Courses.Where(c => c.Id == selectedValue).Join(_dbContext.ProgramCourses,
                        C => C.Id,
                        pc => pc.CourseId,
                        (C, pc) => new
                        {
                            SerialNumber = C.Id,
                            Code = C.Code,
                            Name = C.Name,
                            DepartmentId = C.DepartmentId,
                            Active = C.Active,
                            CreditHours = C.TheoryCreditHours + C.LabCreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            KnowledgeProfileId = C.KnowledgeProfileId,
                            ProgramBatchId = pc.ProgramBatchId
                        }


                    ).Join(

                        _dbContext.ProgramBatches,
                        C => C.ProgramBatchId,
                        pb => pb.Id,
                        (C, pb) => new
                        {
                            SerialNumber = C.SerialNumber,
                            Code = C.Code,
                            Name = C.Name,
                            CreditHours = C.CreditHours,
                            CourseLevelId = C.CourseLevelId,
                            DeliveryFormatId = C.DeliveryFormatId,
                            Active = C.Active,
                            KnowledgeProfileId = C.KnowledgeProfileId,

                            DepartmentId = C.DepartmentId,



                            ProgramBatchId = pb.ProgramBatchName


                        }).Join(

                    _dbContext.Departments,
                    C => C.DepartmentId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,

                        DepartmentId = D.Name,


                        ProgramBatchId = C.ProgramBatchId

                    }).Join(_dbContext.CourseLevels,
                    C => C.CourseLevelId,
                    c => c.Id,
                    (C, c) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        DeliveryFormatId = C.DeliveryFormatId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,


                        CourseLevelId = c.LevelName,
                        ProgramBatchId = C.ProgramBatchId
                    }


                    ).Join(_dbContext.DeliveryFormats,

                    C => C.DeliveryFormatId,
                    D => D.Id,
                    (C, D) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        KnowledgeProfileId = C.KnowledgeProfileId,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,

                        DeliveryFormatId = D.Name,
                        ProgramBatchId = C.ProgramBatchId

                    }

                    ).Join(_dbContext.KnowledgeProfiles,
                    C => C.KnowledgeProfileId,
                    K => K.Id,
                    (C, K) => new
                    {
                        SerialNumber = C.SerialNumber,
                        Code = C.Code,
                        Name = C.Name,
                        DepartmentId = C.DepartmentId,
                        Active = C.Active,
                        CreditHours = C.CreditHours,
                        CourseLevelId = C.CourseLevelId,
                        DeliveryFormatId = C.DeliveryFormatId,

                        KnowledgeProfileId = K.Name,
                        ProgramBatchId = C.ProgramBatchId
                    }

                    )



                    .ToList();
            }
        }
        public List<BaseType> GetBaseTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.BaseTypes.ToList();
            }
        }



        //Update
        public ResultModel UpdateCourseDAL(Course _courseBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {

                    var Ent = _dbContext.Courses.SingleOrDefault(C => C.Id == _courseBEL.Id);
                    if (Ent != null)
                    {
                        Ent.Id = _courseBEL.Id;
                        Ent.Name = _courseBEL.Name;
                        Ent.Code = _courseBEL.Code;
                        Ent.SupervisorBased = _courseBEL.SupervisorBased;
                        Ent.Active = _courseBEL.Active;
                        Ent.TheoryCreditHours = _courseBEL.TheoryCreditHours;
                        Ent.LabCreditHours = _courseBEL.LabCreditHours;
                        Ent.DeliveryFormatId = _courseBEL.DeliveryFormatId;
                        Ent.BaseTypeId = _courseBEL.BaseTypeId;
                        Ent.CourseLevelId = _courseBEL.CourseLevelId;
                        Ent.KnowledgeAreaId = _courseBEL.KnowledgeAreaId;
                        Ent.DepartmentId = _courseBEL.DepartmentId;
                        Ent.PreReqCourseId = _courseBEL.PreReqCourseId;
                        Ent.KnowledgeProfileId = _courseBEL.KnowledgeProfileId;

                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = Ent.Id,
                            Message = "Course has been updated successfully!",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Course not found in database",
                            Status = false
                        };
                    }
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
        public ResultModel UpdateProgramCourseDAL(List<ProgramCourse> _programCourseBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    foreach (var item in _programCourseBEL)
                    {
                        var Ent = _dbContext.ProgramCourses.SingleOrDefault(C => C.Id == item.Id);
                        if (Ent != null)
                        {
                            Ent.Id = item.Id;
                            Ent.ProgramBatchId = item.ProgramBatchId;
                            Ent.SemesterTypeId = item.SemesterTypeId;
                            Ent.TaughInSemester = item.TaughInSemester;
                            _dbContext.SaveChanges();
                        }
                        else
                        {
                            _dbContext.ProgramCourses.Add(item);
                            _dbContext.SaveChanges();
                        }
                    }

                    return new ResultModel
                    {
                        Data = null,
                        Message = "Course has been updated successfully!",
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
        public ResultModel DeleteCourseDAL(int id)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {

                    var Ent = _dbContext.Courses.SingleOrDefault(C => C.Id == id);
                    if (Ent != null)
                    {
                        _dbContext.Courses.Remove(Ent);
                        _dbContext.SaveChanges();

                        var ent = _dbContext.ProgramCourses.Where(p => p.CourseId == id);
                        if (ent != null)
                        {
                            _dbContext.ProgramCourses.RemoveRange(ent);
                            _dbContext.SaveChanges();
                            return new ResultModel
                            {
                                Data = null,
                                Message = "Course has been deleted successfully!",
                                Status = true
                            };
                        }
                        else
                        {
                            return new ResultModel
                            {
                                Data = null,
                                Message = "Course Found but Course Program Not Found",
                                Status = true
                            };
                        }
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Course not found in database",
                            Status = false
                        };
                    }
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


        //Create
        public ResultModel CreateProgramCourseDAL(List<ProgramCourse> _programCoursesBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    foreach (var item in _programCoursesBEL)
                    {
                        _dbContext.ProgramCourses.Add(item);
                        _dbContext.SaveChanges();

                    }

                    return new ResultModel
                    {
                        Data = null,
                        Message = "Course created successfully!",
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
        public ResultModel CreateCourseDAL(Course _courseBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    _dbContext.Courses.Add(_courseBEL);
                    _dbContext.SaveChanges();

                    int CourseId = _courseBEL.Id;
                    return new ResultModel
                    {
                        Data = CourseId,
                        Message = "Course created successfully!",
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


    }
}
