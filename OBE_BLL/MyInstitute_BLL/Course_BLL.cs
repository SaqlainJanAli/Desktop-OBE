using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;
using OBE_DAL.MyInstitute_DAL;

namespace OBE_BLL.MyInstitute_BLL
{
    public class Course_BLL
    {
        Course_DAL _courseDAL = new Course_DAL();

        public List<Course> GetCoursesForPrereqBLL()
        {
            return _courseDAL.GetPrereqCoursesDAL();
        }

        public object GetCoursesBLL()
        {
            return _courseDAL.GetCoursesDAL();
        }

        public List<CourseLevel> GetCourseLevelsBLL()
        {
            return _courseDAL.GetCourseLevelsDAL();        
        }
        public List<DeliveryFormat> GetDeliveryFormatsBLL()
        {
            return _courseDAL.GetDeliveryFormatsDAL();
        }

        public List<KnowledgeArea> GetKnowledgeAreasBLL()
        {
            return _courseDAL.GetKnowledgeAreasDAL();
        }

        public List<KnowledgeProfile> GetKnowledgeProfilesBLL()
        {
            return _courseDAL.GetKnowledgeProfilesDAL();
        }

        public List<BaseType> GetBaseTypesBLL()
        {
            return _courseDAL.GetBaseTypesDAL();
        }

        public ResultModel CreateCourseBLL(Course _courseBEL)
        {
            return _courseDAL.CreateCourseDAL(_courseBEL);
        }

        public ResultModel CreateProgramCoursesBLL(List<ProgramCourse> _programCoursesBEL)
        {
            return _courseDAL.CreateProgramCourseDAL(_programCoursesBEL);
        }

        public ResultModel DeleteCourseBLL(int id)
        {
            return _courseDAL.DeleteCourseDAL(id);
        }

        public ResultModel UpdateCourseBLL(Course _courseBEL)
        {
            return _courseDAL.UpdateCourseDAL(_courseBEL);
        }

        public ResultModel UpdateProgramCoursesBLL(List<ProgramCourse> _programCourseBEL)
        {
            return _courseDAL.UpdateProgramCourseDAL(_programCourseBEL);
        }

        public Course GetCourseByIdBLL(int id)
        {
            return _courseDAL.GetCourseByIdDAL(id);
        }

        public List<ProgramCourse> getProgramCourseBLL(int id)
        {
            return _courseDAL.GetProgramCourseDAL(id);
        }

        public object FilterDGVByNameBLL(int selectedValue)
        {
            return _courseDAL.FilterDGVByNameDAL(selectedValue);
        }

        public object FilterDGVByCodeBLL(string text)
        {
            return _courseDAL.FilterDGVByCodeDAL(text);
        }

        public object FilterDGVByDeptBLL(int selectedValue)
        {
            return _courseDAL.FilterDGVByDeptDAL(selectedValue);
        }

        public object CountCourseBLL()
        {
            return _courseDAL.CountCourseDAL();
        }
    }
}
