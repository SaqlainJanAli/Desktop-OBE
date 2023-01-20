using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_DAL.MyInstitute_DAL.CourseSection.Assessment;

namespace OBE_BLL.MyInstitute_BLL.CourseSection.Assessment
{
    public class MarksGPA_BLL
    {
        private MarksGPA_DAL _marksGpaDAL = new MarksGPA_DAL();

        public List<StudentCourseSectionResult> GetActiviyResultsBLL(int courseSecId)
        {
            return _marksGpaDAL.GetActiviyResultsDAL(courseSecId);
        }

        public ResultModel SaveCourseSecResultsBLL(List<StudentCourseSectionResult> courseSectionResults)
        {
            return _marksGpaDAL.SaveCourseSecResultsDAL(courseSectionResults);
        }
    }
}
