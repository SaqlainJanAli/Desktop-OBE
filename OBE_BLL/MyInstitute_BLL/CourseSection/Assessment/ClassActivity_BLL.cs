using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_DAL.MyInstitute_DAL.CourseSection.Assessment;

namespace OBE_BLL.MyInstitute_BLL.CourseSection.Assessment
{
    public class ClassActivity_BLL
    {
        private ClassActivity_DAL _classActivityDal = new ClassActivity_DAL();

        //Create
        public ResultModel CreateClassActivityBLL(ClassActivity _classActivityBEL)
        {
            return _classActivityDal.CreateClassActivityDAL(_classActivityBEL);
        }

        public ResultModel CreateSubActivityBLL(List<SubActivity> _subActivities)
        {
            return _classActivityDal.CreateSubActivityDAL(_subActivities);
        }

        //Read
        public object getClassActivitiesBLL(int courseSectionId)
        {
            return _classActivityDal.getClassActivitiesDAL(courseSectionId);
        }


        //Delete
        public ResultModel DeleteClassActivityBLL(int id)
        {
            return _classActivityDal.DeleteClassActivityDAL(id);
        }


        //Update
        public ResultModel UpdateClassActivityBLL(ClassActivity _classActivityBEL)
        {
            return _classActivityDal.UpdateClassActivityDAL(_classActivityBEL);
        }

        public ResultModel UpdateSubActivityBLL(List<SubActivity> _subActivities)
        {
            return _classActivityDal.UpdateSubActivityDAL(_subActivities);
        }

        public ClassActivity getclassActByIdBLL(int classActId)
        {
            return _classActivityDal.getClassActByIdDAL(classActId);
        }

        public List<SubActivity> GetSubActByActIdBLL(int classActId)
        {
            return _classActivityDal.getSubActByActIdDAL(classActId);
        }

        public decimal GetUsedActWeightByActTypeIdBLL(int selectedActTypeId, int courseSectionId)
        {
            return _classActivityDal.GetUsedActWeightByActTypeIdDAL(selectedActTypeId, courseSectionId);
        }
    }
}
