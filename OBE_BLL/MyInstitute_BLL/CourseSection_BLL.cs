using OBE_BEL;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class CourseSection_BLL
    {
        CourseSection_DAL _courseSectionDAL = new CourseSection_DAL();

        //Create
        public ResultModel CreateCourseSectionBLL(OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection _courseSectionBEL)
        {
            return _courseSectionDAL.CreateCourseSectionDAL(_courseSectionBEL);
        }


        //Read

        public object GetCourseSectionBLL()
        {
            return _courseSectionDAL.GetCourseSectionDAL();
        }
        public OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection GetCourseSectionByIdBLL(int id)
        {
            return _courseSectionDAL.GetCourseSectionByIdDAL(id);
        }

        public object FilterByNameBLL(string name)
        {
            return _courseSectionDAL.FilterByNameDAL(name);
        }

        public object FilterByCourseIdBLL(int selectedid)
        {
            return _courseSectionDAL.FilterByCourseIdDAL(selectedid);
        }

        public object FilterByDeptIdBLL(int selectedId)
        {
            return _courseSectionDAL.FilterByDeptIdDAL(selectedId);
        }

        public object FilterBySemBLL(int v)
        {
            return _courseSectionDAL.FilterBySemDAL(v);
        }

        public object GetCLOsOfCurrentCourseSectionBLL(int courseSecId)
        {
            return _courseSectionDAL.GetCLOsOfCurrentCourseSecDAL(courseSecId);
        }






        //Update

        public ResultModel UpdateCourseSectionBLL(OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection _courseSectionBEL)
        {
            return _courseSectionDAL.UpdateCourseSectionDAL(_courseSectionBEL);
        }


        //Delete
        public ResultModel DeleteCourseSectionBLL(int id)
        {
            return _courseSectionDAL.DeleteCourseSectionDAL(id);
        }

        public object GetPLOsInCurrentCourseSecBLL(int courseSecId)
        {
            return _courseSectionDAL.GetPLOsInCurrentCourseSecDAL(courseSecId);
        }
    }
}
