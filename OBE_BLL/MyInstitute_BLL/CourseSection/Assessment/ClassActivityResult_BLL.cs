using System;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_DAL.MyInstitute_DAL.CourseSection.Assessment;

namespace OBE_BLL.MyInstitute_BLL.CourseSection.Assessment
{
    public class ClassActivityResult_BLL
    {
        private ClassActivityResult_DAL _activityResultDal = new ClassActivityResult_DAL();


        //Create
        public ResultModel SaveActivityResultBLL(ClassActivityResult activityResultBel)
        {
            return _activityResultDal.SaveActivityResultDAL(activityResultBel);
        }

        //Delete
        public ResultModel DeleteActivityResultBLL(int classActid, int studentId, int courseSecid)
        {

            return _activityResultDal.DeleteActivityResultDAL( classActid, studentId,  courseSecid);
        }

        //Update
        public ResultModel UpdateActivityResultBLL(ClassActivityResult activityResultBel)
        {
            return _activityResultDal.UpdateActivityResultDAL(activityResultBel);
        }

        //Read
        public ClassActivityResult GetResultByClassActIdBLL(int classActid, int studentId, int courseSecid, int activityTypeId)
        {
            return _activityResultDal.GetResultByClassActIdDAL(classActid,studentId, courseSecid, activityTypeId);
        }
        //public ClassActivityResult getResultByIdBLL(int activityResultId)
        //{
        //    return _activityResultDal.GetResultIDByClassActIdDAL(activityResultId);
        //}


        public object GetEnrolledStudentsWithResultBLL(int courseSecid, int classActid, int activityTypeId)
        {
            return _activityResultDal.GetEnrolledStudentsWithResultDAL(courseSecid, classActid, activityTypeId);
        }

    }
}
