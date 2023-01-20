using System.Collections.Generic;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;
using OBE_DAL.MyInstitute_DAL.CourseSection.Class_Students;

namespace OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students
{
   public class ClassStudent_BLL
   {
       private ClassStudent_DAL _classStudentDal = new ClassStudent_DAL();

        //Read
       public object GetStudentsBySecIdBLL(int courseSecid)
       {
           return _classStudentDal.GetStudentsBySecIdDAL(courseSecid);
       }

       public List<EnrollStudent> GetAllStudentsBySecIdBLL(int courseSecId)
       {
           return _classStudentDal.GetAllStudentsBySecIdDAL(courseSecId);
       }

       public object GetEnrolledStudentsWithActResultBLL(int courseSecid, int classActid, int activityTypeId)
       {
           return _classStudentDal.GetEnrolledStudentsWithActResultDAL(courseSecid, classActid,activityTypeId);
       }
    }
}
