using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.OBE_Section.CLO_BEL;
using OBE_DAL.OBESection_DAL;

namespace OBE_BLL.OBESection_BLL
{
    public class CLO_BLL
    {
        private CLO_DAL _cloDal = new CLO_DAL();


        //Read
        public object GetCLOsBLL()
        {
            return _cloDal.GetCLOsDAL();
        }

        public object GetTypesBLL()
        {
            return _cloDal.GetTypesDAL();
        }

        //Create
        public ResultModel CreateCLOBLL(CLO _cloBEL)
        {
            return _cloDal.CreateCLODAL(_cloBEL);
        }

        public ResultModel CreateCLOCourseBLL(List<CLOCourse> _cloCourses)
        {
            return _cloDal.CreateCLOCourseDAL(_cloCourses);
        }

        public ResultModel DeleteCLOBLL(int iD)
        {
            return _cloDal.DeleteCLODAL(iD);
        }

        public ResultModel UpdateCLOCourseBLL(List<CLOCourse> _cloCourses)
        {
            return _cloDal.UpdateCloCourseDAL(_cloCourses);
        }

        public ResultModel UpdateCLOBLL(CLO _cloBEL)
        {
            return _cloDal.UpdateCloDAL(_cloBEL);
        }

        public CLO getCLOByIdBLL(int iD)
        {
            return _cloDal.getCloByIdDAL(iD);
        }

        public List<CLOCourse> getCCourseByCloIdBLL(int iD)
        {
            return _cloDal.getCCourseByCIdDAL(iD);
        }

        public object filterbyCourseBll(int selectedValue)
        {
            return _cloDal.filterbyCourseDal(selectedValue);
        }

        public object filterbyActiveBll(bool @checked)
        {
            return _cloDal.filterbyActiveDal(@checked);
        }

        public object filterbyCodeBll(string text)
        {
            return _cloDal.filterbyCodeDal(text);
        }

        public object GetCLOsByCourseIdBLL(int courseSectionId)
        {
            return _cloDal.GetCLOsByCourseIdDAL(courseSectionId);
        }
    }
}
