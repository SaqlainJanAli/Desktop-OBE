using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CampusesBEL;
using OBE_BEL.ViewModels;

namespace OBE_DAL.MyInstitute_DAL
{
    public class CampusDAL
    {
        //Create
        public ResultModel CreateCampusDAL(Campus _CampusBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    _dbContext.Campuses.Add(_CampusBEL);
                    _dbContext.SaveChanges();
                    return new ResultModel
                    {
                        Data = null,
                        Message = "Campus has been created successfully",
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

     

        //Update
        public ResultModel UpdateCampusDAL(Campus _CampusBEL)
        {
            try
            {
                int id = _CampusBEL.Id;
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var _UpdateEnt = _dbContext.Campuses.SingleOrDefault(I => I.Id == id);
                    if (_UpdateEnt != null)
                    {
                        _UpdateEnt.Name = _CampusBEL.Name;
                        _UpdateEnt.CityId = _CampusBEL.CityId;
                        _UpdateEnt.University_Id = _CampusBEL.University_Id;
                        _UpdateEnt.Address = _CampusBEL.Address;
                        _UpdateEnt.Notes = _CampusBEL.Notes;
                        _UpdateEnt.HeaderImage_Path = _CampusBEL.HeaderImage_Path;

                        _dbContext.SaveChanges();

                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Campus has been updated successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Campus not found",
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


        //Delete
        public ResultModel DeleteCampusDAL(int iD)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var Ent = _dbContext.Campuses.Single(C => C.Id == iD);

                    if (Ent != null)
                    {
                        _dbContext.Campuses.Remove(Ent);
                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Campus delete successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Campus does not exist",
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


        //Read

        public List<VM_CampusInstituteCity> FilterByInstituteDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Campuses.Where(C => C.University_Id == v).Join(_dbContext.Institutes,
                    c => c.University_Id,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        HeaderImage = c.HeaderImage_Path,
                        Name = c.Name,
                        University_Id = u.Name,
                        CityId = u.CityId,
                        Address = c.Address,
                        Notes = c.Notes
                    }

                    ).Join(_dbContext.Cities,
                    c => c.CityId,
                    C => C.Id,
                    (c, C) => new VM_CampusInstituteCity()
                    {
                        Id = c.Id,
                        HeaderImage_Path = c.HeaderImage,
                        Name = c.Name,
                        University_Id = c.University_Id,
                        CityId = C.Name,
                        Address = c.Address,
                        Notes = c.Notes
                    }
                    ).ToList();
            }

        }

        public int CountCampusesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Campuses.Count();
            }
        }

        public List<VM_CampusInstituteCity> FilterByNameDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Campuses.Where(C => C.Name.Contains(text.Trim())).Join(_dbContext.Institutes,
                    c => c.University_Id,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        HeaderImage = c.HeaderImage_Path,
                        Name = c.Name,
                        University_Id = u.Name,
                        CityId = u.CityId,
                        Address = c.Address,
                        Notes = c.Notes

                    }

                    ).Join(_dbContext.Cities,
                    c => c.CityId,
                    C => C.Id,
                    (c, C) => new VM_CampusInstituteCity()
                    {
                        Id = c.Id,
                        HeaderImage_Path = c.HeaderImage,
                        Name = c.Name,
                        University_Id = c.University_Id,
                        CityId = C.Name,
                        Address = c.Address,
                        Notes = c.Notes
                    }




                    ).ToList();
            }
        }

        public Campus GetCampusByIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Campuses.SingleOrDefault(C => C.Id == iD);
            }
        }
        public List<VM_CampusInstituteCity> GetCampusesDAL()
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Campuses.Join(_dbContext.Institutes,
                    c => c.University_Id,
                    u => u.Id,
                    (c, u) => new
                    {
                        Id = c.Id,
                        HeaderImage = c.HeaderImage_Path,
                        Name = c.Name,
                        University_Id = u.Name,
                        CityId = u.CityId,
                        Address = c.Address,
                        Notes = c.Notes
                    }

                    ).Join(_dbContext.Cities,
                    c => c.CityId,
                    C => C.Id,
                    (c, C) => new VM_CampusInstituteCity()
                    {
                        Id = c.Id,
                        HeaderImage_Path = c.HeaderImage,
                        Name = c.Name,
                        University_Id = c.University_Id,
                        CityId = C.Name,
                        Address = c.Address,
                        Notes = c.Notes
                    }
                ).ToList();
            }
        }
        
    }
}
