using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.SchoolsBEL;
using OBE_BEL.ViewModels;

namespace OBE_DAL.MyInstitute_DAL
{
    public class School_DAL
    {
        //Create
        public ResultModel CreateSchoolDAL(School _school)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    _dbContext.Schools.Add(_school);
                    _dbContext.SaveChanges();
                    return new ResultModel
                    {
                        Data = null,
                        Message = "School has been created successfully",
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
        public ResultModel UpdateSchoolDAL(School _school)
        {
            try
            {
                int iD = _school.Id;
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var _UpdateEnt = _dbContext.Schools.SingleOrDefault(S => S.Id == iD);
                    if (_UpdateEnt != null)
                    {
                        _UpdateEnt.Name = _school.Name;
                        _UpdateEnt.Address = _school.Address;
                        _UpdateEnt.CampusId = _school.CampusId;
                        _UpdateEnt.CityId = _school.CityId;
                        _UpdateEnt.Notes = _school.Notes;
                        _UpdateEnt.SchoolIcon_Path = _school.SchoolIcon_Path;

                        _dbContext.SaveChanges();

                        return new ResultModel()
                        {
                            Data = null,
                            Message = "School has been updated successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "School not found",
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

        //Delete
        public ResultModel DeleteSchoolDAL(int iD)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
                {
                    var DelEnt = _dbContext.Schools.Single(S => S.Id == iD);
                    if (DelEnt != null)
                    {
                        _dbContext.Schools.Remove(DelEnt);
                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "School has been deleted successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel
                        {
                            Data = null,
                            Message = "School  with Id " + iD + "not Found",
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
        public int CountSchoolsDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Schools.Count();
            }
        }
        public List<VM_SchoolCampusCity> FilterByCampusDAL(int v)
        {

            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Schools.Where(S => S.CampusId == v).Join(_dbContext.Campuses,
                    s => s.CampusId,
                    c => c.Id,
                    (s, c) => new
                    {
                        Id = s.Id,
                        SchoolIcon = s.SchoolIcon_Path,
                        Name = s.Name,
                        CampusId = c.Name,
                        CityId = s.CityId,
                        Address = s.Address,
                        Notes = s.Notes
                    }
                ).Join(_dbContext.Cities,
                    s => s.CityId,
                    c => c.Id,
                    (s, c) => new VM_SchoolCampusCity()
                    {
                        Id = s.Id,
                        Icon_Path = s.SchoolIcon,
                        Name = s.Name,
                        CampusId = s.CampusId,
                        CityId = c.Name,
                        Address = s.Address,
                        Notes = s.Notes
                    }
                ).ToList();
            }
        }
        public List<VM_SchoolCampusCity> FilterByNameDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext())
            {
                return _dbContext.Schools.Where(S => S.Name.ToLower().Contains(text.Trim().ToLower())).Join(_dbContext.Campuses,
                    s => s.CampusId,
                    c => c.Id,
                    (s, c) => new
                    {
                        Id = s.Id,
                        SchoolIcon = s.SchoolIcon_Path,
                        Name = s.Name,
                        CampusId = c.Name,
                        CityId = s.CityId,
                        Address = s.Address,
                        Notes = s.Notes
                    }
                ).Join(_dbContext.Cities,
                    s => s.CityId,
                    c => c.Id,
                    (s, c) => new VM_SchoolCampusCity()
                    {
                        Id = s.Id,
                        Icon_Path = s.SchoolIcon,
                        Name = s.Name,
                        CampusId = s.CampusId,
                        CityId = c.Name,
                        Address = s.Address,
                        Notes = s.Notes
                    }
                ).ToList();
            }
        }
        public List<VM_SchoolCampusCity> GetSchoolsDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Schools.Join(_dbContext.Campuses,
                    s => s.CampusId,
                    c => c.Id,
                    (s, c) => new
                    {
                        Id = s.Id,
                        SchoolIcon = s.SchoolIcon_Path,
                        Name = s.Name,
                        CampusId = c.Name,
                        CityId = s.CityId,
                        Address = s.Address,
                        Notes = s.Notes
                    }
                    ).Join(_dbContext.Cities,
                    s => s.CityId,
                    c => c.Id,
                    (s, c) => new VM_SchoolCampusCity()
                    {
                        Id = s.Id,
                        Icon_Path = s.SchoolIcon,
                        Name = s.Name,
                        CampusId = s.CampusId,
                        CityId = c.Name,
                        Address = s.Address,
                        Notes = s.Notes
                    }
                    ).ToList();
            }
        }
        public School getSchoolByIdDAL(int iD)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Schools.SingleOrDefault(S => S.Id == iD);
            }
        }

    }
}
