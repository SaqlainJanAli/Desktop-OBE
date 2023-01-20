using System;
using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.ActivityWeight;
using OBE_DAL.MyInstitute_DAL.CourseSection.Activity_Weight;

namespace OBE_BLL.MyInstitute_BLL.CourseSection.Activity_Weight
{
    public class ActivityWeightBLL
    {
        private ActivityWeightDAL _activityWeightDal = new ActivityWeightDAL();

        //Create
        public ResultModel CreateActivityWeightBLL(ActivityWeight activityWeightBel)
        {
            return _activityWeightDal.CreateActivityWeightDAL(activityWeightBel);
        }


        //Update
        public ResultModel UpdateActivityWeightBLL(ActivityWeight activityWeightBel)
        {
            return _activityWeightDal.UpdateActivityWeightDAL(activityWeightBel);
        }

        //Delete

        public ResultModel DeleteActivityWeightBLL(int actTypeId, int courseSecId)
        {
            return _activityWeightDal.DeleteActivityWeightDAL(actTypeId, courseSecId);
        }




        //Read
        public object GetWeightsBySecIdBLL(int courseSecId)
        {
            return _activityWeightDal.GetWeightsBySecIdDAL(courseSecId);
        }
     
        public ActivityWeight GetWeightByActTypeIdBLL(int actyTypeId, int courseSecId)
        {
            return _activityWeightDal.GetWeightByActTypeIdDAL(actyTypeId,courseSecId);
        }
        public List<ActivityWeight> GetWeightsByCourseSecIdBLL(int courseSecId)
        {
            return _activityWeightDal.GetWeightsByCourseSecIdDAL(courseSecId);
        }

    }
}
