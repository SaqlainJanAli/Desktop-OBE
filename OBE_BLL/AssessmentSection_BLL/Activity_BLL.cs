using OBE_DAL.Assessment_DAL;
using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.Assessment_Section.ActivityBEL;

namespace OBE_BLL.AssessmentSection_BLL
{
    public class Activity_BLL
    {
        //Fields
        //Variable for Data Layer
        public Activity_DAL _ActivityDAL = new Activity_DAL();
        
   

        //Create
        public ResultModel CreateActivityBLL(Activity _activityBEL)
        {
            return _ActivityDAL.CreateActivityDAL(_activityBEL);
        }


        //Delete
        public ResultModel DeleteActivityBLL(int id)
        {
            return _ActivityDAL.DeleteActivityDAL(id);
        }


        //Update
        public ResultModel UpdateActivityBLL(Activity activityBel)
        {
            return _ActivityDAL.UpdateActivityDAL(activityBel);
        }


        //Read Data
        public List<Activity> GetActivitiesBLL()
        {
            return _ActivityDAL.GetActivitiesDAL();
        }
        public Activity GetActivityByIdBLL(int id)
        {
            return _ActivityDAL.GetActivityByIdDAL(id);
        }
        public List<Activity> GetActTypesByCourseSecIdBLL(int courseSecId)
        {
            return _ActivityDAL.GetActTypesByCourseSecIdDAL(courseSecId);
        }
    }
}
