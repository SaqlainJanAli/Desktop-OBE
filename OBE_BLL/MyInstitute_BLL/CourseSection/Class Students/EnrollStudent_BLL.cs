using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;
using OBE_DAL.MyInstitute_DAL.CourseSection.Class_Students;

namespace OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students
{
    public class EnrollStudent_BLL
    {
        private EnrollStudent_DAL _enrollStudentDal = new EnrollStudent_DAL();


        //Save
        public ResultModel SaveStudentBLL(EnrollStudent enrollStudentBel)
        {
            return _enrollStudentDal.SaveStudentDAL(enrollStudentBel);
        }

        public ResultModel SaveStudentsBLL(List<EnrollStudent> enrollStudentListBel)
        {
            return _enrollStudentDal.SaveStudentsDAL(enrollStudentListBel);
        }


        //Read
        public object GetEnrolledStudentsWithoutResultBLL(int courseSecid,int classActId)
        {
            return _enrollStudentDal.GetEnrolledStudentsWithoutResultDAL(courseSecid, classActId);
        }

        public object GetEnrolledStudentsByDepartIdBLL(int departId)
        {
            return _enrollStudentDal.GetEnrolledStudentsByDepartIdDAL(departId);
        }
    }
}
