using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;
using OBE_BEL.ViewModels;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class InstituteBLL
    {
        readonly InstituteDAL _instituteDAL = new InstituteDAL();

        //Read
        public List<Country> GetCountriesBLL()
        {
            return _instituteDAL.GetCountriesDAL();

        }
        public List<IssuingAuthority> GetAuthoritiesBLL()
        {
            return _instituteDAL.GetAuthoritiesDAL();
        }
        public object GetInstituteTypesBLL()
        {
            return _instituteDAL.GetInstituteTypesDAL();
        }
        public List<City> GetCitiesBLL()
        {
            return _instituteDAL.GetCitiesDAL();
        }
        public object GetPLOMethodsBLL()
        {
            return _instituteDAL.GetPLOMethodsDAL();
        }
        public List<VM_InstituteCountryCity> GetInstitutesBLL()
        {
            return _instituteDAL.GetInstitutesDAL();
        }
        public Institute GetInstituteByIdBLL(int id)
        {
            return _instituteDAL.GetInstitutesByIdDAL(id);
        }
        public List<VM_InstituteCountryCity> FilterByNameBLL(string text)
        {
            return _instituteDAL.FilterByNameDAL(text);
        }
        public List<VM_InstituteCountryCity> FilterByAuthority(int v)
        {
            return _instituteDAL.FilterByAuthorityDAL(v);
        }
        public int CountInstitutes()
        {
            return _instituteDAL.CountInstituesDAL();
        }
        public List<Province> FilterRegionByCountryIdBLL(int countryId)
        {
            return _instituteDAL.FilterRegionByCountryIdDAL(countryId);
        }
        public List<City> FilterCityByRegionIdBLL(int regionId)
        {
            return _instituteDAL.FilterCityByRegionIdDAL(regionId);
        }
        public List<Institute> getAllInstitutesBLL()
        {
            return _instituteDAL.getAllInstitutesDAL();
        }

        public List<City> GetCityByRegionId(int instituteRegionId)
        {
            return _instituteDAL.GetCityByRegionId(instituteRegionId);
        }
        public Country GetCountryByIdBLL(int stdUserCountryId)
        {
            return _instituteDAL.GetCountryByIdDAL(stdUserCountryId);
        }

        public Province GetRegionByIdBLL(int stdUserRegionId)
        {
            return _instituteDAL.GetRegionByIdDAL(stdUserRegionId);
        }

        public City GetCityByIdAndRegionId(int provinceId, int stdUserCityId)
        {
            return _instituteDAL.GetCityByIdAndRegionIdDAL(provinceId, stdUserCityId);
        }


        //Create
        public ResultModel CreateInstituteBLL(Institute _instituteBEL)
        {
            return _instituteDAL.CreateInstituteDAL(_instituteBEL);
        }

        //Update
        public ResultModel UpdateInstituteBLL(Institute _instituteBEL)
        {
            return _instituteDAL.UpdateInstituteDAL(_instituteBEL);
        }


        //Delete
        public ResultModel DeleteInstituteBLL(int ID)
        {
            return _instituteDAL.DeleteInstituteDAL(ID);
        }

    }
}
