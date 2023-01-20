using System;
using System.Collections.Generic;
using System.Linq;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;
using OBE_BEL.ViewModels;

namespace OBE_DAL.MyInstitute_DAL
{
    public class InstituteDAL
    {

        //Read
        public List<Country> GetCountriesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Countries.ToList();
            }

        }

        public List<IssuingAuthority> GetAuthoritiesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.IssuingAuthorities.ToList();
            }
        }

        public object GetPLOMethodsDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.PloCalculationMethods.ToList();
            }
        }

        public List<VM_InstituteCountryCity> FilterByNameDAL(string text)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Institutes.Where(I => I.Name.ToLower().Contains(text.Trim().ToLower())).Join(
                    _dbContext.IssuingAuthorities,
                    i => i.IssuingAuthorityId,
                    ia => ia.Id,
                    (i, ia) => new
                    {
                        Id = i.Id,
                        Logo_Path = i.Logo_Path,
                        Name = i.Name,
                        IssuingAuthorityId = ia.AuthorityName,
                        InstituteTypeId = i.InstituteTypeId,
                        FullGPA = i.FullGPA,
                        WebsiteURL = i.WebsiteURL
                    }

                ).Join(_dbContext.Types,
                    i => i.InstituteTypeId,
                    t => t.Id,
                    (i, t) => new VM_InstituteCountryCity()
                    {
                        Id = i.Id,
                        Logo_Path = i.Logo_Path,
                        Name = i.Name,
                        IssuingAuthorityId = i.IssuingAuthorityId,
                        InstituteTypeId = t.Name,
                        FullGPA = i.FullGPA,
                        WebsiteURL = i.WebsiteURL
                    }

                ).ToList();

            }
        }

        public int CountInstituesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Institutes.Count();
            }
        }

        public List<VM_InstituteCountryCity> FilterByAuthorityDAL(int v)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {

                return _dbContext.Institutes.Where(I => I.IssuingAuthorityId == v).Join(_dbContext.IssuingAuthorities,
                    i => i.IssuingAuthorityId,
                    ia => ia.Id,
                    (i, ia) => new
                    {
                        Id = i.Id,
                        Logo_Path = i.Logo_Path,
                        Name = i.Name,
                        IssuingAuthorityId = ia.AuthorityName,
                        InstituteTypeId = i.InstituteTypeId,
                        FullGPA = i.FullGPA,
                        WebsiteURL = i.WebsiteURL
                    }

                ).Join(_dbContext.Types,
                    i => i.InstituteTypeId,
                    t => t.Id,
                    (i, t) => new VM_InstituteCountryCity()
                    {
                        Id = i.Id,
                        Logo_Path = i.Logo_Path,
                        Name = i.Name,
                        IssuingAuthorityId = i.IssuingAuthorityId,
                        InstituteTypeId = t.Name,
                        FullGPA = i.FullGPA,
                        WebsiteURL = i.WebsiteURL
                    }

                ).ToList();

            }
        }

        public Institute GetInstitutesByIdDAL(int id)
        {

            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {

                return _dbContext.Institutes.SingleOrDefault(I => I.Id == id);

            }

        }

        public List<VM_InstituteCountryCity> GetInstitutesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Institutes.Join(_dbContext.IssuingAuthorities,
                    i => i.IssuingAuthorityId,
                    ia => ia.Id,
                    (i, ia) => new
                    {
                        Id = i.Id,
                        Logo_Path = i.Logo_Path,

                        Name = i.Name,
                        IssuingAuthorityId = ia.AuthorityName,
                        InstituteTypeId = i.InstituteTypeId,
                        FullGPA = i.FullGPA,
                        WebsiteURL = i.WebsiteURL
                    }

                ).Join(_dbContext.Types,
                    i => i.InstituteTypeId,
                    t => t.Id,
                    (i, t) => new VM_InstituteCountryCity()
                    {
                        Id = i.Id,
                        Logo_Path = i.Logo_Path,
                        Name = i.Name,
                        IssuingAuthorityId = i.IssuingAuthorityId,
                        InstituteTypeId = t.Name,
                        FullGPA = i.FullGPA,
                        WebsiteURL = i.WebsiteURL
                    }

                ).ToList();


            }
        }

        public List<City> GetCitiesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Cities.ToList();
            }
        }

        public object GetInstituteTypesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Types.ToList();
            }
        }

        public List<Province> FilterRegionByCountryIdDAL(int countryId)
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Regions.Where(R => R.CountryId == countryId).ToList();
            }
        }

        public List<City> FilterCityByRegionIdDAL(int regionId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Cities.Where(c => c.RegionId == regionId).ToList();

            }
        }

        public List<City> GetCityByRegionId(int instituteRegionId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Cities.Where(c => c.RegionId == instituteRegionId).ToList();
            }
        }
        public Province GetRegionByIdDAL(int stdUserRegionId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Regions.FirstOrDefault(r => r.Id == stdUserRegionId);

            }
        }

        public City GetCityByIdAndRegionIdDAL(int provinceId, int stdUserCityId)
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Cities.FirstOrDefault(r => r.Id == stdUserCityId && r.RegionId == provinceId);
            }
        }

        public List<Institute> getAllInstitutesDAL()
        {
            using (ApplicationDbContext _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Institutes.ToList();
            }
        }

        public Country GetCountryByIdDAL(int stdUserCountryId)
        {
            using (var _dbContext = new ApplicationDbContext())
            {
                return _dbContext.Countries.FirstOrDefault(c => c.Id == stdUserCountryId);
            }
        }


        //Create
        public ResultModel CreateInstituteDAL(Institute _instituteBEL)
        {
            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    _dbContext.Institutes.Add(_instituteBEL);
                    _dbContext.SaveChanges();

                    return new ResultModel()
                    {
                        Data = null,
                        Status = true,
                        Message = "Institute has been created successfully"
                    };
                }
            }
            catch (Exception e)
            {
                return new ResultModel()
                {
                    Data = null,
                    Status = false,
                    Message = e.Message
                };
            }

        }


        //Update
        public ResultModel UpdateInstituteDAL(Institute _instituteBEL)
        {
            try
            {
                int id = _instituteBEL.Id;
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {
                    var _UpdateEnt = _dbContext.Institutes.SingleOrDefault(I => I.Id == id);
                    if (_UpdateEnt != null)
                    {
                        _UpdateEnt.Name = _instituteBEL.Name;
                        _UpdateEnt.IssuingAuthorityId = _instituteBEL.IssuingAuthorityId;
                        _UpdateEnt.InstituteTypeId = _instituteBEL.InstituteTypeId;
                        _UpdateEnt.MethodId = _instituteBEL.MethodId;
                        _UpdateEnt.CountryId = _instituteBEL.CountryId;
                        _UpdateEnt.CityId = _instituteBEL.CityId;
                        _UpdateEnt.FullGPA = _instituteBEL.FullGPA;
                        _UpdateEnt.AllowAttendance = _instituteBEL.AllowAttendance;
                        _UpdateEnt.PublicSector = _instituteBEL.PublicSector;
                        _UpdateEnt.YearEstablished = _instituteBEL.YearEstablished;
                        _UpdateEnt.Address = _instituteBEL.Address;
                        _UpdateEnt.WebsiteURL = _instituteBEL.WebsiteURL;
                        _UpdateEnt.Logo_Path = _instituteBEL.Logo_Path;
                        _UpdateEnt.Notes = _instituteBEL.Notes;
                        _UpdateEnt.Vision = _instituteBEL.Vision;
                        _UpdateEnt.Mission = _instituteBEL.Mission;

                        _dbContext.SaveChanges();

                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Institute updated successfully",
                            Status = true
                        };
                    }

                    return new ResultModel()
                    {
                        Data = null,
                        Message = "Institute not found",
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


        //Delete
        public ResultModel DeleteInstituteDAL(int ID)
        {

            try
            {
                using (ApplicationDbContext _dbContext = new ApplicationDbContext())
                {

                    var _DelEntity = _dbContext.Institutes.SingleOrDefault(I => I.Id == ID);
                    if (_DelEntity != null)
                    {
                        _dbContext.Institutes.Remove(_DelEntity);
                        _dbContext.SaveChanges();
                        return new ResultModel
                        {
                            Data = null,
                            Message = "Institute has been deleted successfully",
                            Status = true
                        };
                    }
                    else
                    {
                        return new ResultModel()
                        {
                            Data = null,
                            Message = "Institute does not exist",
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


    }
}
