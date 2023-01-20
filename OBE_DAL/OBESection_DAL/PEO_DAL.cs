using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.OBE_Section.PEO_BEL;

namespace OBE_DAL.OBESection_DAL
{
    public class PEO_DAL
    {
        //Create
        public ResultModel CreatePEODAL(PEO _PeoBEL)
        {
            using (ApplicationDbContext _dbContext =new ApplicationDbContext() )
            {
                try
                {
                    _dbContext.PEOs.Add(_PeoBEL);
                    _dbContext.SaveChanges();

                    return new ResultModel()
                    {
                        Data = _PeoBEL.Id,
                        Message = "PEO Created Successfully",
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
        public ResultModel CreatePeoProgramDAL(List<PEOProgram> _peoPrograms)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    foreach (var item in _peoPrograms)
                    {
                        _dbContext.PEOPrograms.Add(item);
                        _dbContext.SaveChanges();
                    }
                    return new ResultModel
                    {
                        Data = null,
                        Message = "PEO created successfully!",
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
        
        
        //Read
        public List<PEOProgram> getPeoProgByPeoIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PEOPrograms.Where(pp => pp.PEOId == id).ToList();
            }
        }
        public PEO getPeoByIdDAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PEOs.SingleOrDefault(p => p.Id == id);
            }
        }
        public object GetPEOsDAL()
        {

            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PEOs.Join(_dbContext.PEOPrograms,
                    p => p.Id,
                    pp => pp.PEOId,
                    (p, pp) => new
                    {
                        Id = p.Id,
                        Code = p.Code,
                        Description = p.Description,
                        ProgramId = pp.ProgramId,
                        ShortName = pp.ShortName
                    }




                ).Join(_dbContext.Programs,
                    p => p.ProgramId,
                    Pr => Pr.Id,
                    (p, Pr) => new
                    {
                        Id = p.Id,
                        Code = p.Code,
                        Description = p.Description,
                        ProgramId = Pr.Name,
                        ShortName = p.ShortName
                    }

                ).ToList();
            }
        }
        

        //Update
        public ResultModel UpdatePeoProgDAL(List<PEOProgram> _peoPrograms)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    foreach (var item in _peoPrograms)
                    {
                        var _pp = _dbContext.PEOPrograms.SingleOrDefault(p => p.Id == item.Id);
                        if (_pp!=null)
                        {
                            _pp.Id = item.Id;
                            _pp.PEOId = item.PEOId;
                            _pp.ProgramId = item.ProgramId;
                            _pp.ShortName = item.ShortName;
                            _dbContext.SaveChanges();
                        }
                        else
                        {
                            _dbContext.PEOPrograms.Add(item);
                            _dbContext.SaveChanges();
                        }

                        
                    }
                    return new ResultModel
                    {
                        Data = null,
                        Message = "PEO Updated successfully!",
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
        public ResultModel UpdatePEODAL(PEO _PeoBEL)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var _peo = _dbContext.PEOs.SingleOrDefault(p => p.Id == _PeoBEL.Id);
                    if (_peo!=null)
                    {
                        _peo.Id = _peo.Id;
                        _peo.Code = _PeoBEL.Code;
                        _peo.Description = _PeoBEL.Description;
                        _peo.Strategies = _PeoBEL.Strategies;
                        _peo.Elements = _PeoBEL.Elements;
                        _peo.isActive = _PeoBEL.isActive;
                        _peo.MapInstituteMission = _PeoBEL.MapInstituteMission;
                        _peo.MapInstituteVision = _PeoBEL.MapInstituteVision;

                        _dbContext.SaveChanges();

                        return new ResultModel()
                        {
                            Data = _PeoBEL.Id,
                            Message = "PEO Updated Successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = _PeoBEL.Id,
                            Message = "PEO Not Found",
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
        public ResultModel DeletePEODAL(int id)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var Ent = _dbContext.PEOs.SingleOrDefault(p => p.Id == id);
                    if (Ent!=null)
                    {
                        _dbContext.PEOs.Remove(Ent);
                        _dbContext.SaveChanges();

                        var ent = _dbContext.PEOPrograms.Where(p => p.PEOId == id);
                        if (ent!=null)
                        {
                            _dbContext.PEOPrograms.RemoveRange(ent);
                            _dbContext.SaveChanges();

                            return new ResultModel
                            {
                                Data = null,
                                Message = "PEO Deleted successfully!",
                                Status = true
                            };
                        }
                        else
                        {
                            return new ResultModel
                            {
                                Data = null,
                                Message = "PEO found but PEO Program Not Found",
                                Status = true
                            };

                        }
                      

                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "PEO Not Found",
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
       
    }
}
