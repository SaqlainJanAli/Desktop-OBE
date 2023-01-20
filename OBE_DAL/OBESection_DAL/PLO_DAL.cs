using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.OBE_Section.PLO_BEL;

namespace OBE_DAL.OBESection_DAL
{
    public class PLO_DAL
    {
        //Create
        public ResultModel CreatePloDAL(PLO _ploBEL)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    _dbContext.PLOs.Add(_ploBEL);
                    _dbContext.SaveChanges();

                    return new ResultModel()
                    {
                        Data = _ploBEL.Id,
                        Message = "PLO has been created successfully",
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
        public ResultModel CreatePloProfilesDAL(List<PLOProfile> _ploProfiles)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    foreach (var ploProfile in _ploProfiles)
                    {
                        _dbContext.PLOProfiles.Add(ploProfile);
                        _dbContext.SaveChanges();
                    }
                    return new ResultModel()
                    {
                        Data = null,
                        Message = "PLO has been created successfully",
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
        public object GetPLOsDAL()
        {

            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PLOs.Join(_dbContext.PLOProfiles,
                         p => p.Id,
                         pp => pp.PLOId,
                         (p, pp) => new
                         {
                             Id = p.Id,
                             Name = p.Name,
                             Code = p.Code,
                             CodePlusName = p.Code + "-"+p.Name,
                             Description = p.Description,
                             WACode = p.WACode,
                             Active = p.isActive,
                             BatchId = pp.BatchId,
                             PEOId = pp.PEOId,
                             KnowledgeProfileId = pp.KnowledgeProfileId,
                         }

                     ).Join(_dbContext.PEOs,
                         p => p.PEOId,
                         pp => pp.Id,
                         (p, pp) => new
                         {
                             Id = p.Id,
                             Name = p.Name,
                             Code = p.Code,
                             CodePlusName = p.Code + "-" + p.Name,
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
                             CodePlusName = p.Code + "-" + p.Name,
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
                             CodePlusName = p.Code + " - " + p.Name,
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
        public List<PLOProfile> getPloProfByPloIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PLOProfiles.Where(p => p.PLOId == iD).ToList();
            }
        }
        public PLO getPloByIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PLOs.SingleOrDefault(p => p.Id == iD);
            }
        }

        //Filter
        public object filterbyNameDal(string text)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PLOs.Where(p => p.Name.ToLower().Contains(text.Trim().ToLower())).Join(_dbContext.PLOProfiles,
                    p => p.Id,
                    pp => pp.PLOId,
                    (p, pp) => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Code = p.Code,
                        CodePlusName = p.Code + "-" + p.Name,
                        Description = p.Description,
                        WACode = p.WACode,
                        Active = p.isActive,
                        BatchId = pp.BatchId,
                        PEOId = pp.PEOId,
                        KnowledgeProfileId = pp.KnowledgeProfileId,
                    }

                ).Join(_dbContext.PEOs,
                    p => p.PEOId,
                    pp => pp.Id,
                    (p, pp) => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Code = p.Code,
                        CodePlusName = p.Code + "-" + p.Name,
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
                        CodePlusName = p.Code + "-" + p.Name,
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
                        CodePlusName = p.Code + " - " + p.Name,
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
        public object filterbyActiveDal(bool @checked)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PLOs.Where(p => p.isActive == @checked).Join(_dbContext.PLOProfiles,
                    p => p.Id,
                    pp => pp.PLOId,
                    (p, pp) => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Code = p.Code,
                        CodePlusName = p.Code + "-" + p.Name,
                        Description = p.Description,
                        WACode = p.WACode,
                        Active = p.isActive,
                        BatchId = pp.BatchId,
                        PEOId = pp.PEOId,
                        KnowledgeProfileId = pp.KnowledgeProfileId,
                    }

                ).Join(_dbContext.PEOs,
                    p => p.PEOId,
                    pp => pp.Id,
                    (p, pp) => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Code = p.Code,
                        CodePlusName = p.Code + "-" + p.Name,
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
                        CodePlusName = p.Code + "-" + p.Name,
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
                        CodePlusName = p.Code + " - " + p.Name,
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
        public object filterbyCodeDal(string text)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PLOs.Where(p => p.Code.ToLower() == text.ToLower()).Join(_dbContext.PLOProfiles,
                    p => p.Id,
                    pp => pp.PLOId,
                    (p, pp) => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Code = p.Code,
                        CodePlusName = p.Code + "-" + p.Name,
                        Description = p.Description,
                        WACode = p.WACode,
                        Active = p.isActive,
                        BatchId = pp.BatchId,
                        PEOId = pp.PEOId,
                        KnowledgeProfileId = pp.KnowledgeProfileId,
                    }

                ).Join(_dbContext.PEOs,
                    p => p.PEOId,
                    pp => pp.Id,
                    (p, pp) => new
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Code = p.Code,
                        CodePlusName = p.Code + "-" + p.Name,
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
                        CodePlusName = p.Code + "-" + p.Name,
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
                        CodePlusName = p.Code + " - " + p.Name,
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


        //Update
        public ResultModel UpdatePloDAL(PLO _ploBEL)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var _plo = _dbContext.PLOs.SingleOrDefault(p => p.Id == _ploBEL.Id);
                    if (_plo != null)
                    {
                        _plo.Id = _ploBEL.Id;
                        _plo.Code = _ploBEL.Code;
                        _plo.Description = _ploBEL.Description;
                        _plo.Name = _ploBEL.Name;
                        _plo.Strategies = _ploBEL.Strategies;
                        _plo.WACode = _ploBEL.WACode;
                        _plo.isActive = _ploBEL.isActive;
                        _dbContext.SaveChanges();
                        return new ResultModel()
                        {
                            Data = _plo.Id,
                            Message = "PLO Updated Successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "PLO not found in Database",
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
        public ResultModel UpdatePloProfDAL(List<PLOProfile> _ploProfiles)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    foreach (var item in _ploProfiles)
                    {
                        var _pp = _dbContext.PLOProfiles.SingleOrDefault(p => p.Id == item.Id);
                        if (_pp != null)
                        {
                            _pp.PEOId = item.PEOId;
                            _pp.BatchId = item.BatchId;
                            _pp.KnowledgeProfileId = item.KnowledgeProfileId;
                            _pp.PLOId = item.PLOId;
                            _dbContext.SaveChanges();
                        }
                        else
                        {
                            _dbContext.PLOProfiles.Add(item);
                            _dbContext.SaveChanges();
                        }
                    }


                    return new ResultModel
                    {
                        Data = null,
                        Message = "PLO Updated successfully!",
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
        public ResultModel DeletePLODAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                try
                {
                    var _ploBEL = _dbContext.PLOs.SingleOrDefault(p => p.Id == iD);
                    if (_ploBEL != null)
                    {
                        _dbContext.PLOs.Remove(_ploBEL);
                        _dbContext.SaveChanges();

                        var _ploProfiles = _dbContext.PLOProfiles.Where(p => p.PLOId == iD);
                        if (_ploProfiles != null)
                        {
                            _dbContext.PLOProfiles.RemoveRange(_ploProfiles);
                            _dbContext.SaveChanges();

                            return new ResultModel()
                            {
                                Data = null,
                                Message = "PLO has been deleted successfully",
                                Status = true
                            };
                        }
                        else
                        {
                            return new ResultModel()
                            {
                                Data = null,
                                Message = "PLO deleted but PLO profile Not found",
                                Status = true
                            };
                        }

                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "PLO not found in Database",
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
