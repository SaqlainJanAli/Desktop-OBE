using System;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.ProgramBatchBEL;

namespace OBE_DAL.MyInstitute_DAL
{
    public class ProgramBatch_DAL
    {
        public object GetProgramBatchesDAL()
        {

            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.ProgramBatches.Join(
                    _dbContext.NoOfSessions,
                    P => P.NoOfSessionId,
                    N => N.Id,
                    (P, N) => new
                    {
                        SerialNumber = P.Id,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatchName,
                        ProgramId = P.ProgramId,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        NoOfSessionId = N.SessionCount
                    }).Join(_dbContext.Programs,
                    P => P.ProgramId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.SerialNumber,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatch,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        NoOfSessionId = P.NoOfSessionId,
                        DepartmentId = p.DepartmentId,
                        ProgramPlusBatch = p.Name + " - " + P.ProgramBatch,
                        ProgramId = p.Name,

                    }).Join(_dbContext.Departments,
                    P => P.DepartmentId,
                    d => d.Id,
                    (P, d) => new
                    {
                        SerialNumber = P.SerialNumber,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatch,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        NoOfSessionId = P.NoOfSessionId,
                        DepartmentId = d.Name,
                        ProgramPlusBatch = P.ProgramPlusBatch,
                        ProgramBatchDepartment = P.ProgramPlusBatch + "(" + d.Name + ")",
                        ProgramId = P.ProgramId,

                    }

                ).ToList();
            }
        }

        public object FilterByNameDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {

                return _dbContext.ProgramBatches.Where(p => p.ProgramBatchName.ToLower().Contains(text.Trim().ToLower())).Join(
                    _dbContext.NoOfSessions,
                    P => P.NoOfSessionId,
                    N => N.Id,
                    (P, N) => new
                    {
                        SerialNumber = P.Id,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatchName,
                        ProgramId = P.ProgramId,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        NoOfSessionId = N.SessionCount
                    }).Join(_dbContext.Programs,
                    P => P.ProgramId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.SerialNumber,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatch,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        NoOfSessionId = P.NoOfSessionId,

                        ProgramId = p.Name,

                    }).ToList();
            }
        }

        public object FilterByBatchDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.ProgramBatches.Where(p => p.Id == v).Join(
                    _dbContext.NoOfSessions,
                    P => P.NoOfSessionId,
                    N => N.Id,

                    (P, N) => new
                    {
                        SerialNumber = P.Id,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatchName,
                        ProgramId = P.ProgramId,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        NoOfSessionId = N.SessionCount
                    }).Join(_dbContext.Programs,
                    P => P.ProgramId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.SerialNumber,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatch,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        NoOfSessionId = P.NoOfSessionId,

                        ProgramId = p.Name,

                    }).ToList();
            }
        }

        public object FilterByProgramDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.ProgramBatches.Where(p => p.ProgramId == v).Join(
                    _dbContext.NoOfSessions,
                    P => P.NoOfSessionId,
                    N => N.Id,

                    (P, N) => new
                    {
                        SerialNumber = P.Id,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatchName,
                        ProgramId = P.ProgramId,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,

                        NoOfSessionId = N.SessionCount
                    }).Join(_dbContext.Programs,
                    P => P.ProgramId,
                    p => p.Id,
                    (P, p) => new
                    {
                        SerialNumber = P.SerialNumber,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatch,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        NoOfSessionId = P.NoOfSessionId,
                        DepartmentId = p.DepartmentId,
                        ProgramPlusBatch = p.Name + " - " + P.ProgramBatch,
                        ProgramId = p.Name,

                    }).Join(_dbContext.Departments,
                    P => P.DepartmentId,
                    d => d.Id,
                    (P, d) => new
                    {
                        SerialNumber = P.SerialNumber,
                        AcademicYear = P.AcademicYear,
                        ProgramBatch = P.ProgramBatch,
                        Finished = P.Finished,
                        UseInOBE = P.UseInOBE,
                        MarksPercentage = P.MarksPercentage,
                        StudentPercentage = P.StudentPercentage,
                        NoOfSessionId = P.NoOfSessionId,
                        DepartmentId = d.Name,
                        ProgramPlusBatch = P.ProgramPlusBatch,
                        ProgramBatchDepartment = P.ProgramPlusBatch + "(" + d.Name + ")",
                        ProgramId = P.ProgramId,

                    }

                    ).ToList();
            }
        }

        public ResultModel UpdateProgramBatchDAL(ProgramBatch _programBatchBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    var UpdEnt = _dbContext.ProgramBatches.SingleOrDefault(P => P.Id == _programBatchBEL.Id);
                    if (UpdEnt != null)
                    {

                        UpdEnt.Id = _programBatchBEL.Id;
                        UpdEnt.AcademicYear = _programBatchBEL.AcademicYear;
                        UpdEnt.ProgramId = _programBatchBEL.ProgramId;
                        UpdEnt.ProgramBatchName = _programBatchBEL.ProgramBatchName;
                        UpdEnt.NoOfSessionId = _programBatchBEL.NoOfSessionId;
                        UpdEnt.MethodId = _programBatchBEL.MethodId;
                        UpdEnt.PLOPassingThreshold = _programBatchBEL.PLOPassingThreshold;
                        UpdEnt.MarksPercentage = _programBatchBEL.MarksPercentage;
                        UpdEnt.StudentPercentage = _programBatchBEL.StudentPercentage;
                        UpdEnt.Finished = _programBatchBEL.Finished;
                        UpdEnt.UseInOBE = _programBatchBEL.UseInOBE;
                        UpdEnt.TheoryCreditHours = _programBatchBEL.TheoryCreditHours;
                        UpdEnt.LabCreditHours = _programBatchBEL.LabCreditHours;


                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program batch has been updated successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program batch not found",
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

        public ProgramBatch GetProgramBatcheByIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.ProgramBatches.SingleOrDefault(P => P.Id == iD);

            }
        }

        public ResultModel DeleteProgramBatchDAL(int iD)
        {

            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    var DelEnt = _dbContext.ProgramBatches.SingleOrDefault(P => P.Id == iD);
                    if (DelEnt != null)
                    {

                        _dbContext.ProgramBatches.Remove(DelEnt);
                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program batch has been deleted successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Program batch not found",
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

        public ResultModel CreateProgramBatchDAL(ProgramBatch _programBatchBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {

                    _dbContext.ProgramBatches.Add(_programBatchBEL);
                    _dbContext.SaveChanges();
                    return new ResultModel
                    {
                        Data = null,
                        Message = "Program batch has been created successfully",
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
