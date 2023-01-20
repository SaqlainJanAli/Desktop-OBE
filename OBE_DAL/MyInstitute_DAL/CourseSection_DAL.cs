using System;
using System.Linq;
using OBE_BEL;

namespace OBE_DAL.MyInstitute_DAL
{
    public class CourseSection_DAL
    {

        //Create
        public ResultModel CreateCourseSectionDAL(OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection _courseSectionBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {

                    _dbContext.CourseSections.Add(_courseSectionBEL);
                    _dbContext.SaveChanges();

                    return new ResultModel
                    {
                        Data = null,
                        Message = "Course Section has been created successfully!",
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
                throw;
            }
        }


        //Delete
        public ResultModel DeleteCourseSectionDAL(int id)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var Ent = _dbContext.CourseSections.SingleOrDefault(c => c.Id == id);
                    if (Ent != null)
                    {
                        _dbContext.CourseSections.Remove(Ent);
                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "Course Section has been deleted successfully!",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Course Section not found!",
                            Status = true
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


        //Update
        public ResultModel UpdateCourseSectionDAL(OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection _courseSectionBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    var Ent = _dbContext.CourseSections.SingleOrDefault(c => c.Id == _courseSectionBEL.Id);
                    if (Ent != null)
                    {
                        Ent.Name = _courseSectionBEL.Name;
                        Ent.MarksPercentage = _courseSectionBEL.MarksPercentage;
                        Ent.StudentsPercentage = _courseSectionBEL.StudentsPercentage;
                        Ent.Notes = _courseSectionBEL.Notes;
                        Ent.DepartmentId = _courseSectionBEL.DepartmentId;
                        Ent.SemesterId = _courseSectionBEL.SemesterId;
                        Ent.Finished = _courseSectionBEL.Finished;
                        Ent.GenderId = _courseSectionBEL.GenderId;
                        Ent.FacultyId = _courseSectionBEL.FacultyId;
                        Ent.CourseId = _courseSectionBEL.CourseId;
                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "Course Section has been updated successfully!",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Course Section not found!",
                            Status = true
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


        //Read
        public OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection GetCourseSectionByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.CourseSections.SingleOrDefault(C => C.Id == id);
            }
        }

        public object FilterByCourseIdDAL(int selectedid)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.CourseSections.Where(C => C.CourseId == selectedid).Join(_dbContext.Semesters,
                    c => c.SemesterId,
                    s => s.Id,
                    (c, s) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,


                        SemesterId = s.Name,
                    }).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        CourseId = C.Name,

                    }).Join(_dbContext.FacultyUsers,
                    c => c.FacultyId,
                    f => f.Id,
                    (c, f) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = f.UserId,

                    }).Join(_dbContext.Users,
                    c => c.FacultyId,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = u.FirstName + " " + u.LastName,


                    }).Join(_dbContext.Departments,
                    c => c.DepartmentId,
                    d => d.Id,
                    (c, d) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = d.Name,

                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,
                        FacultyId = c.FacultyId



                    }).ToList();

            }
        }
        public object FilterBySemDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.CourseSections.Where(C => C.SemesterId == v).Join(_dbContext.Semesters,
                    c => c.SemesterId,
                    s => s.Id,
                    (c, s) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,


                        SemesterId = s.Name,
                    }).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        CourseId = C.Name,

                    }).Join(_dbContext.FacultyUsers,
                    c => c.FacultyId,
                    f => f.Id,
                    (c, f) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = f.UserId,

                    }).Join(_dbContext.Users,
                    c => c.FacultyId,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = u.FirstName + " " + u.LastName,


                    }).Join(_dbContext.Departments,
                    c => c.DepartmentId,
                    d => d.Id,
                    (c, d) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = d.Name,

                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,
                        FacultyId = c.FacultyId



                    }).ToList();
            }
        }
        public object FilterByDeptIdDAL(int selectedId)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.CourseSections.Where(C => C.DepartmentId == selectedId).Join(_dbContext.Semesters,
                    c => c.SemesterId,
                    s => s.Id,
                    (c, s) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,


                        SemesterId = s.Name,
                    }).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        CourseId = C.Name,

                    }).Join(_dbContext.FacultyUsers,
                    c => c.FacultyId,
                    f => f.Id,
                    (c, f) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = f.UserId,

                    }).Join(_dbContext.Users,
                    c => c.FacultyId,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = u.FirstName + " " + u.LastName,


                    }).Join(_dbContext.Departments,
                    c => c.DepartmentId,
                    d => d.Id,
                    (c, d) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = d.Name,

                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,
                        FacultyId = c.FacultyId



                    }).ToList();

            }
        }
        public object FilterByNameDAL(string name)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.CourseSections.Where(C => C.Name.Contains(name.Trim())).Join(_dbContext.Semesters,
                    c => c.SemesterId,
                    s => s.Id,
                    (c, s) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,


                        SemesterId = s.Name,
                    }).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        CourseId = C.Name,

                    }).Join(_dbContext.FacultyUsers,
                    c => c.FacultyId,
                    f => f.Id,
                    (c, f) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = f.UserId,

                    }).Join(_dbContext.Users,
                    c => c.FacultyId,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = u.FirstName + " " + u.LastName,


                    }).Join(_dbContext.Departments,
                    c => c.DepartmentId,
                    d => d.Id,
                    (c, d) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = d.Name,

                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,
                        FacultyId = c.FacultyId



                    }).ToList();

            }
        }
        public object GetCourseSectionDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.CourseSections.Join(_dbContext.Semesters,
                    c => c.SemesterId,
                    s => s.Id,
                    (c, s) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,


                        SemesterId = s.Name,
                    }).Join(_dbContext.Courses,
                    c => c.CourseId,
                    C => C.Id,
                    (c, C) => new
                    {
                        Id = c.Id,
                        Name = c.Name,
                        FacultyId = c.FacultyId,
                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        CourseId = C.Name,

                    }).Join(_dbContext.FacultyUsers,
                    c => c.FacultyId,
                    f => f.Id,
                    (c, f) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = f.UserId,

                    }).Join(_dbContext.Users,
                    c => c.FacultyId,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = c.DepartmentId,
                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,

                        FacultyId = u.FirstName + " " + u.LastName,


                    }).Join(_dbContext.Departments,
                    c => c.DepartmentId,
                    d => d.Id,
                    (c, d) => new
                    {

                        Id = c.Id,
                        CourseId = c.CourseId,
                        Name = c.Name,

                        DepartmentId = d.Name,

                        Finished = c.Finished,
                        UseInOBE = c.UseInOBE,
                        SemesterId = c.SemesterId,
                        FacultyId = c.FacultyId



                    }).ToList();



            }
        }
        public object GetCLOsOfCurrentCourseSecDAL(int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                //var clos = from c in _dbContext.CLOCourses join cs in _dbContext.CourseSections on c.CourseId equals cs.CourseId

                return _dbContext.CourseSections.Where(c=>c.Id == courseSecId).Join(_dbContext.CLOCourses,
                    cs=>cs.CourseId,
                    cc=>cc.CourseId,
                    (cs, cc) => new
                    {
                        Id = cc.CLOId,
                        Code = "Nil",
                        Description = "Nil",
                        isActive = false,
                        PLOId = cc.PLO_Id,
                        CourseId = cc.CourseId,
                        TypeId = cc.Type_Id
                    }
                ).Join(_dbContext.CLOs,
                        cs => cs.Id,
                        clo => clo.Id,
                        (cs, clo) => new
                        {
                            Id = clo.Id,
                            Code = clo.Code,
                            Description = clo.Description,
                            isActive = clo.isActive,
                            PLOId = cs.PLOId,
                            CourseId = cs.CourseId,
                            TypeId = cs.TypeId
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
        public object GetPLOsInCurrentCourseSecDAL(int courseSecId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                //var clos = from c in _dbContext.CLOCourses join cs in _dbContext.CourseSections on c.CourseId equals cs.CourseId
                return _dbContext.CourseSections.Where(c=>c.Id == courseSecId).Join(_dbContext.CLOCourses,
                        cs => cs.CourseId,
                        cc => cc.CourseId,
                        (cs, cc) => new
                        {
                            Id = cc.PLO_Id,
                            Name = "Nil",
                            Code = "Nil",
                            CodePlusName = "Nil",
                            Description = "Nil",
                            WACode = "Nil",
                            Active = false,
                            BatchId = "Nil",
                            PEOId = "Nil",
                            KnowledgeProfileId = "Nil",
                        }

                    ).Join(_dbContext.PLOs,
                        cs=>cs.Id,
                        p=>p.Id,
                        (cs, p) => new
                        {
                            Id = cs.Id,
                            Name = p.Name,
                            Code = p.Code,
                            CodePlusName = p.Name + " - "+p.Code,
                            Description = p.Description,
                            WACode = p.WACode,
                            Active = p.isActive,
                            BatchId = "Nil",
                            PEOId = "Nil",
                            KnowledgeProfileId = "Nil"
                        }
                        
                        ).Join(_dbContext.PLOProfiles,
                        cs=>cs.Id,
                        pp=>pp.PLOId,
                        (cs, pp) => new
                        {
                            Id = cs.Id,
                            Name = cs.Name,
                            Code = cs.Code,
                            CodePlusName = cs.CodePlusName,
                            Description = cs.Description,
                            WACode = cs.WACode,
                            Active = cs.Active,
                            BatchId = pp.BatchId,
                            PEOId = pp.PEOId,
                            KnowledgeProfileId = pp.KnowledgeProfileId
                        }

                        )
                    .Join(_dbContext.PEOs,
                        p => p.PEOId,
                        pp => pp.Id,
                        (p, pp) => new
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Code = p.Code,
                            CodePlusName = p.CodePlusName,
                            Description = p.Description,
                            WACode = p.WACode,
                            Active = p.Active,
                            BatchId = p.BatchId,
                            PEOId = pp.Code,
                            KnowledgeProfileId = p.KnowledgeProfileId,
                        }


                    ).Join(_dbContext.KnowledgeProfiles,
                        p => p.KnowledgeProfileId,
                        kp => kp.Id,
                        (p, kp) => new
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Code = p.Code,
                            CodePlusName = p.CodePlusName,
                            Description = p.Description,
                            WACode = p.WACode,
                            Active = p.Active,
                            BatchId = p.BatchId,
                            PEOId = p.PEOId,
                            KnowledgeProfileId = kp.Name,
                        }


                    ).Join(_dbContext.ProgramBatches,
                        p => p.BatchId,
                        pb => pb.Id,
                        (p, pb) => new
                        {
                            Id = p.Id,
                            Name = p.Name,
                            Code = p.Code,
                            CodePlusName = p.CodePlusName,
                            Description = p.Description,
                            WACode = p.WACode,
                            Active = p.Active,
                            BatchId = pb.ProgramBatchName,
                            PEOId = p.PEOId,
                            KnowledgeProfileId = p.KnowledgeProfileId,
                        }


                    ).ToList();
            }


        }
    }
}
