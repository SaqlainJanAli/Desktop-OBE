using System;
using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CampusesBEL;
using OBE_BEL.ViewModels;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class Campus_BLL
    {
        CampusDAL _campusDAL = new CampusDAL();

        //Create
        public ResultModel CreateCampusBLL(Campus _CampusBEL)
        {
            return _campusDAL.CreateCampusDAL(_CampusBEL);
        }

        //Delete
        public ResultModel DeleteCampusBLL(int iD)
        {
            return _campusDAL.DeleteCampusDAL(iD);
        }



        //Update
        public ResultModel UpdateCampusBLL(Campus _CampusBEL)
        {
            return _campusDAL.UpdateCampusDAL(_CampusBEL);
        }


        //Read
        public List<VM_CampusInstituteCity> GetCampusesBLL()
        {
            return _campusDAL.GetCampusesDAL();
        }


        //public object GetCampusesWithLogoPathBLL(out List<string> listofPaths)
        //{
        //    var x =_campusDAL.GetCampusesWithLogoPathDAL(out List<string> listofPath);
        //    listofPaths = listofPath;
        //}



        public Campus GetCampusById(int iD)
        {
            return _campusDAL.GetCampusByIdDAL(iD);
        }

        public List<VM_CampusInstituteCity> FilterByInstituteBLL(int v)
        {
            return _campusDAL.FilterByInstituteDAL(v);
        }

        public List<VM_CampusInstituteCity> FilterByNameBLL(string text)
        {
            return _campusDAL.FilterByNameDAL(text);
        }

        public int CountCampuses()
        {
            return _campusDAL.CountCampusesDAL();
        }

    }
}
