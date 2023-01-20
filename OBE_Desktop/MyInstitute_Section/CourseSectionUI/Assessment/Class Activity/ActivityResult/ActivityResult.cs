using System;
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
    public partial class ActivityResult : Form
    {
        //Fields
        private int _classActid;
        private int _courseSecid;
        private int activityTypeId;
        private ClassActivityResult _activityResultBEL = new ClassActivityResult();
        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();
        //Constructors
        public ActivityResult()
        {
            InitializeComponent();
        }
        public ActivityResult(int id, int courseSecid, int activityTypeId)
        {
            this._classActid = id;
            this._courseSecid = courseSecid;
            this.activityTypeId = activityTypeId;
            InitializeComponent();

        }


        //ON Load Event
        private void ActivityResult_Load(object sender, EventArgs e)
        {
            GetEnrolledStudentsWithActResult();
        }
        private void GetEnrolledStudentsWithActResult()
        {
            ActivityResultDataGrid.AutoGenerateColumns = false;
            ActivityResultDataGrid.DataSource = new ClassActivityResult_BLL().GetEnrolledStudentsWithResultBLL(_courseSecid, _classActid, activityTypeId);

            foreach (DataGridViewRow dataGridViewRow in ActivityResultDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        //Row Header Mouse Double Click event
        private void ActivityResultDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int StudentId = Convert.ToInt32(ActivityResultDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
     
        }

        //Cell Content Click
        private void ActivityResultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int StudentId = Convert.ToInt32(ActivityResultDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);

            if (ActivityResultDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewActivityResult viewActivityResult = new ViewActivityResult(StudentId, _courseSecid, _classActid, activityTypeId);
                viewActivityResult.Show();
            }
            if (ActivityResultDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {

                UpdateActivityResult updateActivityResult =
                    new UpdateActivityResult(StudentId, _courseSecid, _classActid, activityTypeId);
                updateActivityResult.Show();
            }
            if (ActivityResultDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {

                DialogResult _dgr = MessageBox.Show(@"Are You Sure to Delete This Activity Result?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {
                    DeleteActivityResult(_classActid,StudentId, _courseSecid);
                }
            }
        }

    

        //Delete
        private void DeleteActivityResult(int classActid, int studentId, int courseSecid)
        {
            _resultModel = new ClassActivityResult_BLL().DeleteActivityResultBLL( classActid,  studentId,  courseSecid);

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
        

        private void ActivityResultDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // int StudentId = Convert.ToInt32(ActivityResultDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
           // int ActivityResultID = GetTheActivityResultID(StudentId);
            //GetDataFromIDs(StudentId);
        }

        private void AssignResult_Btn_Click(object sender, EventArgs e)
        {
            CreateActivityResult createActivityResult = new CreateActivityResult(_courseSecid, _classActid);
            createActivityResult.Show();
        }

        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetEnrolledStudentsWithActResult();
        }
    }
}
