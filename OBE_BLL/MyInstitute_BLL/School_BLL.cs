using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.SchoolsBEL;
using OBE_BEL.ViewModels;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class School_BLL
    {
        School_DAL _schoolDAL = new School_DAL();

        //Create
        public ResultModel CreateSchoolBLL(School _school)
        {
            return _schoolDAL.CreateSchoolDAL(_school);
        }

        //Delete
        public ResultModel DeleteSchoolBLL(int iD)
        {
            return _schoolDAL.DeleteSchoolDAL(iD);
        }

        //Update
        public ResultModel UpdateSchoolBLL(School _school)
        {
            return _schoolDAL.UpdateSchoolDAL(_school);
        }

        //Read
        public List<VM_SchoolCampusCity> GetSchoolsBLL()
        {
            return _schoolDAL.GetSchoolsDAL();
        }
        public School GetSchoolByIdBLL(int iD)
        {
            return _schoolDAL.getSchoolByIdDAL(iD);
        }
        public List<VM_SchoolCampusCity> FilterbyCampusBLL(int v)
        {
            return _schoolDAL.FilterByCampusDAL(v);
        }
        public List<VM_SchoolCampusCity> FilterByNameBLL(string text)
        {
            return _schoolDAL.FilterByNameDAL(text);
        }
        public int CountSchools()
        {
            return _schoolDAL.CountSchoolsDAL();
        }
    }
}
