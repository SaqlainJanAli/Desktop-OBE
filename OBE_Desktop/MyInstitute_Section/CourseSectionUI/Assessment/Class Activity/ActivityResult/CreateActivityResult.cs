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
using OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity.ActivityResult
{
    public partial class CreateActivityResult : Form
    {
        private int _studentUserId;
        private int _courseSecid;
        private int _classActid;
        private int activityTypeID;
        private ClassActivityResult _activityResultBEL = new ClassActivityResult();
        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();
        public CreateActivityResult()
        {
            InitializeComponent();
        }


        public CreateActivityResult(int _courseSecid, int _classActid )
        {
            //this.activityTypeID = activityTypeID;
            this._classActid = _classActid;
           // this._studentUserId = studentUserId;
            this._courseSecid = _courseSecid;
            InitializeComponent();
        }

        private void CreateActivityResult_Load(object sender, EventArgs e)
        {
            HideFewControls();
            GetEnrolledStudents();
        }

        private void GetEnrolledStudents()
        {
            ActivityResultDataGrid.AutoGenerateColumns = false;
            ActivityResultDataGrid.DataSource = new EnrollStudent_BLL().GetEnrolledStudentsWithoutResultBLL(_courseSecid,_classActid);

            foreach (DataGridViewRow dataGridViewRow in ActivityResultDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        private void HideFewControls()
        {

            StudentName_errorFlag.Visible = false;
            StudentName_errorLbl.Visible = false;

            regNo_errorFlag.Visible = false;
            regNo_errorLbl.Visible = false;


            ObtainedMarks_errorFlag.Visible = false;
            ObtainedMarks_errorLbl.Visible = false;

        }



        //Save Button Click
        private void SaveResult_Btn_Click(object sender, EventArgs e)
        {
            if (StudentName_errorFlag.Visible == true || regNo_errorFlag.Visible == true || ObtainedMarks_errorFlag.Visible == true)
            {

                if (StudentName_errorFlag.Visible == true)
                {

                    StudentName_errorLbl.Visible = true;
                }
                else if (regNo_errorFlag.Visible == true)
                {

                    regNo_errorLbl.Visible = true;
                }
                else
                {
                    ObtainedMarks_errorLbl.Visible = true;

                }
                _instituteForm.NotifyAlert("Fields marked with * are required", Form_Alert.enmType.Error);
            }
            else
            {
                SaveActivityResult();
            }
        }
        private void SaveActivityResult()
        {
            
            _activityResultBEL.ClassActivityId = _classActid;
            _activityResultBEL.ActivityTypeId = activityTypeID;
            _activityResultBEL.CourseSecId = _courseSecid;
            _activityResultBEL.StudentUserId = _studentUserId ;
            _activityResultBEL.ActivityTotalMarks = TotaActivitylMarks_NUD.Value;
            _activityResultBEL.ActivityObtainedMarks = ObtainedMarks_NUD.Value;
           
            _resultModel = new ClassActivityResult_BLL().SaveActivityResultBLL(_activityResultBEL);

            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetEnrolledStudents();
                //Reset obtained marks
                ObtainedMarks_NUD.ResetText();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        //Value Changed
        private void ObtainedMarks_NUD_ValueChanged(object sender, EventArgs e)
        {
            ObtainedMarks_NUD.Maximum = TotaActivitylMarks_NUD.Value;
            ObtainedMarks_errorFlag.Visible = ObtainedMarks_NUD.Value == Convert.ToDecimal(0.00) || ObtainedMarks_NUD.Value > TotaActivitylMarks_NUD.Value;
        }
        private void StudentName_TB_TextChanged(object sender, EventArgs e)
        {
            StudentName_errorFlag.Visible = StudentName_TB.Text == string.Empty;
        }
        private void RegistrationNo_TB_TextChanged(object sender, EventArgs e)
        {
            regNo_errorFlag.Visible = RegistrationNo_TB.Text == string.Empty;
        }

        //Data Grid Cell Content Click
        private void ActivityResultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int StudentId = Convert.ToInt32(ActivityResultDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
            if (ActivityResultDataGrid.Columns[e.ColumnIndex].Name == "CreateResult_DGV")
            {
                //CreateActivityResult createActivityResult = new CreateActivityResult(StudentId, _courseSecid, _classActid, activityTypeID);
                //createActivityResult.Show();
                GetDataFromIDs(studentId:StudentId);
            }
            GetDataFromIDs(StudentId);
        }
        //Get Data From Ids
        private void GetDataFromIDs(int studentId)
        {
            var StdUser = new StudentUser_BLL().getStudentuserByIdBLL(studentId);
            StudentName_TB.Text = StdUser.Name;
            RegistrationNo_TB.Text = StdUser.RegistrationNo;
            StudentId_TB.Text = studentId.ToString();
            _studentUserId = studentId;

            var ClassActivity = new ClassActivity_BLL().getclassActByIdBLL(_classActid);
            ClassActivityName_TB.Text = ClassActivity.Name;
            TotaActivitylMarks_NUD.Value = ClassActivity.TotalMarks;
            activityTypeID = ClassActivity.ActivityId;

            var ActivityType = new Activity_BLL().GetActivityByIdBLL(ClassActivity.ActivityId);
            ActivityTypeName_TB.Text = ActivityType.Name;
        }


        //Pic box Button Clicks
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetEnrolledStudents();
        }

    }
}
