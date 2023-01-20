using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Assessment;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity.ActivityResult
{
    public partial class UpdateActivityResult : Form
    {

        //Fields
        //private int _activityResultID;
        private int _activityTypeId;
        private int _classActid;
        private int _studentUserId;
        private int _courseSecid;
        private ClassActivityResult _activityResultBEL = new ClassActivityResult();
        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();

        //Constructors
        public UpdateActivityResult()
        {
            InitializeComponent();
        }
        public UpdateActivityResult(int studentUserId, int courseSecid,  int classActid, int activityTypeId)
        {
            this._courseSecid = courseSecid;
            this._studentUserId = studentUserId;
            //this._activityResultID = activityResultID;
            this._classActid = classActid;
            this._activityTypeId = activityTypeId;
            InitializeComponent();

        }



        //On Load
        private void UpdateActivityResult_Load(object sender, EventArgs e)
        {
            HideFewControls();
            GetPrevData();
        }
        private void HideFewControls()
        {
            ObtainedMarks_errorFlag.Visible = false;
            ObtainedMarks_errorLbl.Visible = false;
        }
        private void GetPrevData()
        {
            var currentActResult = new ClassActivityResult_BLL().GetResultByClassActIdBLL(_classActid,_studentUserId,_courseSecid,_activityTypeId);

            GetDataFromIDs(currentActResult);
        }

        private void GetDataFromIDs(ClassActivityResult currentActResult)
        {
            var StdUser = new StudentUser_BLL().getStudentuserByIdBLL(currentActResult.StudentUserId);
            StudentName_TB.Text = StdUser.Name;
            RegistrationNo_TB.Text = StdUser.RegistrationNo;

            var ClassActivity = new ClassActivity_BLL().getclassActByIdBLL(currentActResult.ClassActivityId);
            ClassActivityName_TB.Text = ClassActivity.Name;
            TotaActivitylMarks_NUD.Value = ClassActivity.TotalMarks;

            var ActivityType = new Activity_BLL().GetActivityByIdBLL(currentActResult.ActivityTypeId);
            ActivityTypeName_TB.Text = ActivityType.Name;

            ObtainedMarks_NUD.Value = currentActResult.ActivityObtainedMarks;
        }


        private void UpdateResult_Btn_Click(object sender, EventArgs e)
        {
            if (ObtainedMarks_errorFlag.Visible)
            {
                ObtainedMarks_errorLbl.Visible = true;
                _instituteForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);
            }
            else
            {
                UpdateTheActivityResult();
            }
        }
        private void UpdateTheActivityResult()
        {
            _activityResultBEL.ClassActivityId = _classActid;
            _activityResultBEL.ActivityTypeId = _activityTypeId;
            _activityResultBEL.CourseSecId = _courseSecid;
            _activityResultBEL.StudentUserId = _studentUserId;
            _activityResultBEL.ActivityTotalMarks = TotaActivitylMarks_NUD.Value;
            _activityResultBEL.ActivityObtainedMarks = ObtainedMarks_NUD.Value;

            _resultModel = new ClassActivityResult_BLL().UpdateActivityResultBLL(_activityResultBEL);

            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                Close();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        //Value Changed Event on obtained result

        private void ObtainedMarks_NUD_ValueChanged(object sender, EventArgs e)
        {
            ObtainedMarks_NUD.Maximum = TotaActivitylMarks_NUD.Value;
            ObtainedMarks_errorFlag.Visible = ObtainedMarks_NUD.Value == Convert.ToDecimal(0.00) || ObtainedMarks_NUD.Value > TotaActivitylMarks_NUD.Value;
        }

    }
}
