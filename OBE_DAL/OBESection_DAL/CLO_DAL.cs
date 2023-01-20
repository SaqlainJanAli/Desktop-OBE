using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.OBE_Section.CLO_BEL;

namespace OBE_DAL.OBESection_DAL
{
    public class CLO_DAL
    {

        //Read
        public object GetTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CLOTypes.ToList();
            }
        }
        public object GetCLOsDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CLOs.Join(_dbContext.CLOCourses,
                    c => c.Id,
                    cc => cc.CLOId,
                    (c, cc) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = cc.PLO_Id,
                        CourseId = cc.CourseId,
                        TypeId = cc.Type_Id

                    }

                ).Join(_dbContext.PLOs,
                    c => c.PLOId,
                    p => p.Id,
                    (c, p) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = p.Code + "-" + p.Name,
                        CourseId = c.CourseId,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = C.Name,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.CLOTypes,
                    c => c.TypeId,
                    ct => ct.Id,
                    (c, ct) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = c.CourseId,
                        TypeId = ct.Name

                    }

                ).ToList();



            }
        }
        public object filterbyCodeDal(string text)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CLOs.Where(c=>c.Code.ToLower().Contains(text.Trim().ToLower())).Join(_dbContext.CLOCourses,
                    c => c.Id,
                    cc => cc.CLOId,
                    (c, cc) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = cc.PLO_Id,
                        CourseId = cc.CourseId,
                        TypeId = cc.Type_Id

                    }

                ).Join(_dbContext.PLOs,
                    c => c.PLOId,
                    p => p.Id,
                    (c, p) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = p.Code + "-" + p.Name,
                        CourseId = c.CourseId,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = C.Name,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.CLOTypes,
                    c => c.TypeId,
                    ct => ct.Id,
                    (c, ct) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = c.CourseId,
                        TypeId = ct.Name

                    }

                ).ToList();



            }
        }
        public object filterbyActiveDal(bool @checked)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CLOs.Where(c => c.isActive == @checked).Join(_dbContext.CLOCourses,
                    c => c.Id,
                    cc => cc.CLOId,
                    (c, cc) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = cc.PLO_Id,
                        CourseId = cc.CourseId,
                        TypeId = cc.Type_Id

                    }

                ).Join(_dbContext.PLOs,
                    c => c.PLOId,
                    p => p.Id,
                    (c, p) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = p.Code + "-" + p.Name,
                        CourseId = c.CourseId,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = C.Name,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.CLOTypes,
                    c => c.TypeId,
                    ct => ct.Id,
                    (c, ct) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = c.CourseId,
                        TypeId = ct.Name

                    }

                ).ToList();



            }
        }
        public object filterbyCourseDal(int selectedValue)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CLOs.Where(c => c.Id == selectedValue).Join(_dbContext.CLOCourses,
                    c => c.Id,
                    cc => cc.CLOId,
                    (c, cc) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = cc.PLO_Id,
                        CourseId = cc.CourseId,
                        TypeId = cc.Type_Id

                    }

                ).Join(_dbContext.PLOs,
                    c => c.PLOId,
                    p => p.Id,
                    (c, p) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = p.Code + "-" + p.Name,
                        CourseId = c.CourseId,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = C.Name,
                        TypeId = c.TypeId

                    }

                ).Join(_dbContext.CLOTypes,
                    c => c.TypeId,
                    ct => ct.Id,
                    (c, ct) => new
                    {
                        Id = c.Id,
                        Code = c.Code,
                        Description = c.Description,
                        isActive = c.isActive,
                        PLOId = c.PLOId,
                        CourseId = c.CourseId,
                        TypeId = ct.Name

                    }

                ).ToList();
            }
        }

        public List<CLOCourse> getCCourseByCIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CLOCourses.Where(c => c.CLOId == iD).ToList();
            }

        }

        public CLO getCloByIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CLOs.SingleOrDefault(c => c.Id == iD);
            }
        }


        //Create
        public ResultModel CreateCLODAL(CLO _cloBEL)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.CLOs.Add(_cloBEL);
                    _dbContext.SaveChanges();
                    return new ResultModel()
                    {
                        Data = _cloBEL.Id,
                        Message = "CLO has been created successfully",
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
        public ResultModel CreateCLOCourseDAL(List<CLOCourse> _cloCourses)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    foreach (var item in _cloCourses)
                    {
                        _dbContext.CLOCourses.Add(item);
                        _dbContext.SaveChanges();

                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "CLO has been created successfully",
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
        public ResultModel UpdateCloCourseDAL(List<CLOCourse> _cloCourses)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    foreach (var item in _cloCourses)
                    {
                        var _Ent = _dbContext.CLOCourses.SingleOrDefault(c => c.CLOId == item.CLOId && c.PLO_Id == item.PLO_Id && c.CourseId == item.CourseId);
                        if (_Ent != null)
                        {
                            _Ent.CLOId = item.CLOId;
                            _Ent.PLO_Id = item.PLO_Id;
                            _Ent.Type_Id = item.Type_Id;

                            _dbContext.SaveChanges();
                        }
                        else
                        {
                            _dbContext.CLOCourses.Add(item);
                            _dbContext.SaveChanges();
                        }
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "CLO has been deleted successfully",
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
        public ResultModel UpdateCloDAL(CLO _cloBEL)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var _clo = _dbContext.CLOs.SingleOrDefault(c => c.Id == _cloBEL.Id);
                    if (_clo != null)
                    {
                        _clo.Code = _cloBEL.Code;
                        _clo.Description = _cloBEL.Description;
                        _clo.isActive = _cloBEL.isActive;

                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = _clo.Id,
                            Message = "CLO has been updated successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "CLO not found",
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



        //Delete

        public ResultModel DeleteCLODAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var Ent = _dbContext.CLOs.SingleOrDefault(c => c.Id == iD);
                    if (Ent != null)
                    {
                        _dbContext.CLOs.Remove(Ent);
                        _dbContext.SaveChanges();

                        var _cloCourses = _dbContext.CLOCourses.Where(c => c.CLOId == iD);
                        if (_cloCourses != null)
                        {
                            _dbContext.CLOCourses.RemoveRange(_cloCourses);
                            _dbContext.SaveChanges();

                            return new ResultModel()
                            {
                                Data = null,
                                Message = "CLO has been deleted successfully",
                                Status = true
                            };
                        }
                        else
                        {
                            return new ResultModel()
                            {
                                Data = null,
                                Message = "CLO Deleted but Course profile not found",
                                Status = true
                            };
                        }
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "CLO not found",
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

        public object GetCLOsByCourseIdDAL(int courseSectionId)
        {

            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                var CourseSec = _dbContext.CourseSections.FirstOrDefault(cs => cs.Id == courseSectionId);
                var CourseId = _dbContext.Courses.FirstOrDefault(c => c.Id == CourseSec.CourseId).Id;

                var query =( from clo in _dbContext.CLOs
                    join cc in _dbContext.CLOCourses on clo.Id equals cc.CLOId
                    join c in _dbContext.Courses on cc.CourseId equals c.Id
                    where c.Id == CourseId
                    select new
                    {
                        Id = clo.Id,
                        CodePlusDescription = clo.Code +"-"+ clo.Description
                    }).ToList();
                return query;
            }
        }
    }
}
