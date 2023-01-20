using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section;
using OBE_BEL.MyInstitute_Section.ProgramBEL;
using OBE_BEL.MyInstitute_Section.SemesterBEL;

namespace OBE_DAL
{
    public class Program_DAL
    {
        public object GetProgramsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Programs.Join(_dbContext.ProgramLevels,
                    P => P.ProgramLevelId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.Id,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        DepartmentId = P.DepartmentId,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.MethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        ProgramLevelId = p.Name
                    }

                    ).Join(_dbContext.Departments,
                    P => P.DepartmentId,
                    D => D.Id,
                    (P, D) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.AssesmentMethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,

                        DepartmentId = D.Name
                    }

                    ).Join(_dbContext.AssessmentMethods,
                    P => P.AssesmentMethodId,
                    A => A.Id,
                    (P, A) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,

                        AssesmentMethodId = A.MethodName

                    }).Join(_dbContext.NoOfSessions,
                    P => P.NoOfSessionsId,
                    N => N.Id,
                    (P, N) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,
                        AssesmentMethodId = P.AssesmentMethodId,

                        NoOfSessionsId = N.SessionCount

                    }).ToList();

            }
        }

        public object FilterByDepartDAL(int v)
        {

            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext ())
            {

                return _dbContext.Programs.Where(p => p.DepartmentId == v).Join(_dbContext.ProgramLevels,
                    P => P.ProgramLevelId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.Id,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        DepartmentId = P.DepartmentId,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.MethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        ProgramLevelId = p.Name
                    }

                    ).Join(_dbContext.Departments,
                    P => P.DepartmentId,
                    D => D.Id,
                    (P, D) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.AssesmentMethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,

                        DepartmentId = D.Name
                    }

                    ).Join(_dbContext.AssessmentMethods,
                    P => P.AssesmentMethodId,
                    A => A.Id,
                    (P, A) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,

                        AssesmentMethodId = A.MethodName

                    }).Join(_dbContext.NoOfSessions,
                    P => P.NoOfSessionsId,
                    N => N.Id,
                    (P, N) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,
                        AssesmentMethodId = P.AssesmentMethodId,

                        NoOfSessionsId = N.SessionCount

                    }).ToList();
            }
        }

        public object FilterByLevelDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.Programs.Where(p => p.ProgramLevelId == v).Join(_dbContext.ProgramLevels,
                    P => P.ProgramLevelId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.Id,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        DepartmentId = P.DepartmentId,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.MethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        ProgramLevelId = p.Name
                    }

                    ).Join(_dbContext.Departments,
                    P => P.DepartmentId,
                    D => D.Id,
                    (P, D) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.AssesmentMethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,

                        DepartmentId = D.Name
                    }

                    ).Join(_dbContext.AssessmentMethods,
                    P => P.AssesmentMethodId,
                    A => A.Id,
                    (P, A) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,

                        AssesmentMethodId = A.MethodName

                    }).Join(_dbContext.NoOfSessions,
                    P => P.NoOfSessionsId,
                    N => N.Id,
                    (P, N) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,
                        AssesmentMethodId = P.AssesmentMethodId,

                        NoOfSessionsId = N.SessionCount

                    }).ToList();
            }
        }

        public object FilterByNameDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.Programs.Where(p => p.Name.ToLower().Contains(text.Trim().ToLower())).Join(_dbContext.ProgramLevels,
                    P => P.ProgramLevelId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.Id,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        DepartmentId = P.DepartmentId,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.MethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        ProgramLevelId = p.Name
                    }

                    ).Join(_dbContext.Departments,
                    P => P.DepartmentId,
                    D => D.Id,
                    (P, D) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        AssesmentMethodId = P.AssesmentMethodId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,

                        DepartmentId = D.Name
                    }

                    ).Join(_dbContext.AssessmentMethods,
                    P => P.AssesmentMethodId,
                    A => A.Id,
                    (P, A) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        NoOfSessionsId = P.NoOfSessionsId,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,

                        AssesmentMethodId = A.MethodName

                    }).Join(_dbContext.NoOfSessions,
                    P => P.NoOfSessionsId,
                    N => N.Id,
                    (P, N) => new
                    {
                        SerialNumber = P.SerialNumber,
                        Name = P.Name,
                        ShortName = P.ShortName,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        ProgramLevelId = P.ProgramLevelId,
                        DepartmentId = P.DepartmentId,
                        AssesmentMethodId = P.AssesmentMethodId,

                        NoOfSessionsId = N.SessionCount

                    }).ToList();
            }
        }

        public ResultModel UpdateProgramDAL(Program _programBEL)
        {

            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {

                    var UpdEnt = _dbContext.Programs.SingleOrDefault(P => P.Id == _programBEL.Id);
                    if (UpdEnt != null)
                    {

                        UpdEnt.Id = _programBEL.Id;
                        UpdEnt.Name = _programBEL.Name;
                        UpdEnt.ShortName = _programBEL.ShortName;
                        UpdEnt.SemesterTypeId = _programBEL.SemesterTypeId;
                        UpdEnt.DepartmentId = _programBEL.DepartmentId;
                        UpdEnt.ProgramLevelId = _programBEL.ProgramLevelId;
                        UpdEnt.NoOfSessionsId = _programBEL.NoOfSessionsId;
                        UpdEnt.MethodId = _programBEL.MethodId;
                        UpdEnt.LearningTypeId = _programBEL.LearningTypeId;
                        UpdEnt.MarksPercentage = _programBEL.MarksPercentage;
                        UpdEnt.StudentPercentage = _programBEL.StudentPercentage;
                        UpdEnt.Vision = _programBEL.Vision;
                        UpdEnt.Mission = _programBEL.Mission;



                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program has been updated successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program not found",
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

        public Program GetProgramByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext ())
            {
                return _dbContext.Programs.SingleOrDefault(P => P.Id == id);

            }
        }

        public ResultModel DeleteProgramDAL(int id)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext ())
                {

                    var DelEnt = _dbContext.Programs.SingleOrDefault(P => P.Id == id);
                    if (DelEnt != null)
                    {
                        _dbContext.Programs.Remove(DelEnt);
                        _dbContext.SaveChanges();

                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program has been deleted successfully",
                            Status = true
                        };

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program not found",
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

        public ResultModel CreateProgramDAL(Program _programBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext ())
                {
                    _dbContext.Programs.Add(_programBEL);
                    _dbContext.SaveChanges();
                    return new ResultModel
                    {
                        Data = null,
                        Message = "Program has been created successfully",
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

        public List<LearningType> getLearningTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.LearningTypes.ToList();
            }
        }

        public List<NoOfSession> GetNoOfSessionsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.NoOfSessions.ToList();
            }
        }

        public List<SemesterType> GetSemesterTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.SemesterTypes.ToList();
            }
        }

        public List<ProgramLevel> GetProgramLevelsDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.ProgramLevels.ToList();

            }
        }
    }
}
