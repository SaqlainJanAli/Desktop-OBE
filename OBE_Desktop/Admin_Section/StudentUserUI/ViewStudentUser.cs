using System;
using System.Windows.Forms;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.Admin_Section.StudentUserUI
{
    public partial class ViewStudentUser : Form
    {
        private int id;
        private StudentUser_BLL _studentUserBll = new StudentUser_BLL();
        private InstituteBLL _instituteBll = new InstituteBLL();
        private ProgramBatch_BLL _programBatchBll = new ProgramBatch_BLL();
        public ViewStudentUser()
        {
            InitializeComponent();
        }

        public ViewStudentUser(int id)
        {
            this.id = id;
            InitializeComponent();

        }


        private void ViewStudentUser_Load(object sender, System.EventArgs e)
        {
            GetStudentUserById();
        }

        private void GetStudentUserById()
        {
            var stdUser = _studentUserBll.getStudentuserByIdBLL(id);
            ID_TB.Text = id.ToString();
            RegNo_TB.Text = stdUser.RegistrationNo;
            Name_TB.Text = stdUser.Name;
            RollNo_TB.Text = stdUser.RollNo;
            erpId_TB.Text = stdUser.ERPId;
            dob_DTP.Value = stdUser.DateOfBirth;
            fatherName_TB.Text = stdUser.FatherName;
            email_TB.Text = stdUser.Email;
            cnic_TB.Text = stdUser.CNIC;
            passport_TB.Text = stdUser.Passport;
            homePh_TB.Text = stdUser.PhoneNo;
            mobileNo_TB.Text = stdUser.MobileNo;
            permanentAdd_RTB.Text = stdUser.PermanentAddress;
            district_TB.Text = stdUser.District;
            postalAdd_RTB.Text = stdUser.PostalAddress;
            hsscMarksPerc_TB.Text = stdUser.HsscMarksPercent.ToString();
            bscMarksPerc_TB.Text = stdUser.BscMarksPercent.ToString();
            entryTestMarks_TB.Text = stdUser.EntryTestMarks.ToString();
            applicationNo_TB.Text = stdUser.ApplicationNo;
            admissionDate_d.Value = stdUser.AdmissionDate;
            extraInfo_RTB.Text = stdUser.ExtraNotes;
            var programBatch = _programBatchBll.GetProgramBatchByIdBLL(Convert.ToInt32(stdUser.ProgramBatchId)); //because ProgramBatchId is kept nullable in table column
            programBatch_TB.Text = programBatch.ProgramBatchName;
            gender_TB.Text = stdUser.GenderId == 1 ? "Male" : stdUser.GenderId == 2 ? "Female" : "Others";
            isLocal_TB.Text = stdUser.isLocal == true ? "Yes" : "False";
            religion_TB.Text = stdUser.ReligionId == 1 ? "Muslim" :
                                stdUser.ReligionId == 2 ? "Christian" :
                                stdUser.ReligionId == 3 ? "Jew" :
                stdUser.ReligionId == 4 ? "Hindu" :
                stdUser.ReligionId == 4 ? "Sikh" : "Others";

            var studyMode = _studentUserBll.getStudyModeByIdBLL(stdUser.StudyModeId);
            studyMode_TB.Text = studyMode.Name;

            var status = _studentUserBll.getStatusByIdBLL(stdUser.StatusId);
            status_TB.Text = status.Name;

            var country = _instituteBll.GetCountryByIdBLL(stdUser.CountryId);
            country_TB.Text = country.Name;

            var province = _instituteBll.GetRegionByIdBLL(stdUser.RegionId);
            region_TB.Text = province.Name;

            var city = _instituteBll.GetCityByIdAndRegionId(province.Id,Convert.ToInt32(stdUser.CityId));
            city_TB.Text = city.Name;

            var hsscType = _studentUserBll.getHsscTypeByIdBLL(stdUser.HsscTypeId);
            hsscType_TB.Text = hsscType.Name;

            var bscType = _studentUserBll.getBscTypeByIdBLL(stdUser.BscTypeId);
            bscType_TB.Text = bscType.Name;

            var quota = _studentUserBll.GetQuotaByIdBLL(stdUser.QuotaId);
            quota_TB.Text = quota.Name;

            var admissionType = _studentUserBll.getAdmissionTypeByIdBLL(stdUser.AdmissionTypeId);
            admissionType_TB.Text = admissionType.Name;

            var admissionCategory = _studentUserBll.getAdmnCategoryByIdBLL(stdUser.AdmissionCategoryId);
            admissionCategory_TB.Text = admissionCategory.Name;
        }

    }
}
