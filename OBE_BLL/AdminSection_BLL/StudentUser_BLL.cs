using System.Collections.Generic;
using OBE_BEL;
using OBE_BEL.Admin_Section.StudentUserBEL;
using OBE_DAL.Admin_DAL;

namespace OBE_BLL.AdminSection_BLL
{
    public class StudentUser_BLL
    {
        //Field
        private StudentUser_DAL _studentUserDal = new StudentUser_DAL();

        //Read
        public List<StudentUser> GetStudentUsersBLL()
        {
            return _studentUserDal.GetStudentUsersDAL();
        }
        public List<StudyMode> getStudyModesBLL()
        {
            return _studentUserDal.GetStudyModesDAL();
        }
        public List<Religion> getReligionsBLL()
        {
            return _studentUserDal.GetReligionsDAL();
        }
        public List<Status> getStatusesBLL()
        {
            return _studentUserDal.GetStatusesDAL();
        }
        public StudyMode getStudyModeByIdBLL(int stdUserStudyModeId)
        {
            return _studentUserDal.getStudyModeByIdDAL(stdUserStudyModeId);
        }
        public Status getStatusByIdBLL(int stdUserStatusId)
        {
            return _studentUserDal.GetStatusByIdDAL(stdUserStatusId);
        }
        public HSSCType getHsscTypeByIdBLL(int stdUserHsscTypeId)
        {
            return _studentUserDal.GetHsscTypesByIdDAL(stdUserHsscTypeId);
        }
        public BScType getBscTypeByIdBLL(int stdUserBscTypeId)
        {
            return _studentUserDal.GetBscTypeByIdDAL(stdUserBscTypeId);
        }
        public List<HSSCType> getHsscTypesBLL()
        {
            return _studentUserDal.GetHsscTypesDAL();
        }
        public List<BScType> getBscTypesBLL()
        {
            return _studentUserDal.GetBscTypesDAL();
        }
        public List<AdmissionType> getAdmissionTypesBLL()
        {
            return _studentUserDal.GetAdmissionTypesDAL();
        }
        public List<AdmissionCategory> getAdmissionCategoBLL()
        {
            return _studentUserDal.GetAdmissionCategoDAL();
        }

        public StudentUser getStudentuserByIdBLL(int id)
        {
            return _studentUserDal.GetStudentUserByIdDAL(id);
        }

        public List<Quota> GetQuotasBLL()
        {
            return _studentUserDal.GetQuotasDAL();
        }

        public Quota GetQuotaByIdBLL(int stdUserQuotaId)
        {
            return _studentUserDal.GetQuotaByIdDAL(stdUserQuotaId);
        }

        public AdmissionType getAdmissionTypeByIdBLL(int? stdUserAdmissionTypeId)
        {
            return _studentUserDal.GetAdmissionTypeByIdDAL(stdUserAdmissionTypeId);
        }

        public AdmissionCategory getAdmnCategoryByIdBLL(int? stdUserAdmissionCategoryId)
        {
            return _studentUserDal.GetAdmnCategoryByIdDAL(stdUserAdmissionCategoryId);
        }

        public object GetStudentusersByBatchIdBLL(int selectedBatchId)
        {
            return _studentUserDal.GetStudentusersByBatchIdDAL(selectedBatchId);
        }

        //Create
        public ResultModel createStudentUserBLL(StudentUser studentUserBel)
        {
            return _studentUserDal.createStudentDAL(studentUserBel);
        }



        //Delete
        public ResultModel DeleteStudentUserBLL(int id)
        {
            return _studentUserDal.DeleteStudentUserDAL(id);
        }



        //Update
        public ResultModel updateStudentUserBLL(StudentUser _studentUserBEL)
        {
            return _studentUserDal.UpdateStudentUserDAL(_studentUserBEL);
        }

       
    }
}
