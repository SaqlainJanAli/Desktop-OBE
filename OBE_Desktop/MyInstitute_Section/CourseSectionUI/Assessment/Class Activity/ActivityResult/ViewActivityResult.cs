using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Assessment;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity.ActivityResult
{
    public partial class ViewActivityResult : Form
    {
      //  private int activityResultID;
        private int activityTypeId;
        private int _classActid;
        private int _studentUserId;
        private int _courseSecId;
        public ViewActivityResult()
        {
            InitializeComponent();
        }

        public ViewActivityResult(int studentUserId, int courseSecId, int _classActid, int activityTypeId)
        {
            this._studentUserId = studentUserId;
            this._courseSecId = courseSecId;
            //this.activityResultID = activityResultID;
            this._classActid = _classActid;
            this.activityTypeId = activityTypeId;
            InitializeComponent();

        }

        private void ViewActivityResult_Load(object sender, EventArgs e)
        {
            GetPrevData();
        }
        private void GetPrevData()
        {
            var currentActResult = new ClassActivityResult_BLL().GetResultByClassActIdBLL(_classActid, _studentUserId, _courseSecId, activityTypeId);

            GetDataFromIDs(currentActResult);
        }

        private void GetDataFromIDs(ClassActivityResult currentActResult)
        {
            var StdUser = new StudentUser_BLL().getStudentuserByIdBLL(currentActResult.StudentUserId);
            StudentName_TB.Text = StdUser.Name;
            RegistrationNo_TB.Text = StdUser.RegistrationNo;

            var ClassActivity = new ClassActivity_BLL().getclassActByIdBLL(currentActResult.ClassActivityId);
            ClassActivityName_TB.Text = ClassActivity.Name;
            ActivityTotalMarks_TB.Text = ClassActivity.TotalMarks.ToString();

            var ActivityType = new Activity_BLL().GetActivityByIdBLL(currentActResult.ActivityTypeId);
            ActivityTypeName_TB.Text = ActivityType.Name;

            ActivityObtainedMarks_TB.Text = currentActResult.ActivityObtainedMarks.ToString();
        }

    }
}
