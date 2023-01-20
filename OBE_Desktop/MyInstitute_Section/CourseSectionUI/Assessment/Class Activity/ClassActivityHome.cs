using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Assessment;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity
{
    public partial class ClassActivityHome : Form
    {

        //Fields
        private int _courseSecid;
        private ClassActivity_BLL _classActivityBll = new ClassActivity_BLL();
        private ResultModel _resultModel = new ResultModel();
        private ClassActivity_BLL _ClassActivityBll = new ClassActivity_BLL();
        private Institute _instForm = new Institute();


        //Constructor
        public ClassActivityHome()
        {
            InitializeComponent();
        }

        public ClassActivityHome(int id)
        {
            this._courseSecid = id;
            InitializeComponent();

        }

        //Load
        private void ClassActivityHome_Load(object sender, System.EventArgs e)
        {
            GetClassActivities();
        }
        private void GetClassActivities()
        {
            ClassActivityDataGrid.AutoGenerateColumns = false;
            ClassActivityDataGrid.DataSource = _classActivityBll.getClassActivitiesBLL(_courseSecid);

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in ClassActivityDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }
      
        
        //Data Grid View Content Click
        private void ClassActivityDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int _classActId = Convert.ToInt32(ClassActivityDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
           // int ActivityTypeId = Convert.ToInt32(ClassActivityDataGrid.Rows[e.RowIndex].Cells["ActivityTypeId_DGV"].Value);

            var classActivity = _ClassActivityBll.getclassActByIdBLL(_classActId);
            int ActivityTypeId = classActivity.ActivityId;


            if (ClassActivityDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewClassActivity _viewActivity = new ViewClassActivity(_classActId);
                _viewActivity.Show();
            }
            if (ClassActivityDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                UpdateClassActivity _updateActivity = new UpdateClassActivity(_classActId,_courseSecid);
                _updateActivity.Show();
            }
            if (ClassActivityDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult _dgr = MessageBox.Show("Are You Sure to Delete This Activity?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {
                    DeleteClassActivity(_classActId);
                }
            }
            if (ClassActivityDataGrid.Columns[e.ColumnIndex].Name == "Result_DGV")
            {
                ActivityResult.ActivityResult _activityResultFrom = new ActivityResult.ActivityResult(_classActId,_courseSecid,ActivityTypeId);
                _activityResultFrom.Show();
            }
        }

        private void DeleteClassActivity(int id)
        {
            _resultModel = _ClassActivityBll.DeleteClassActivityBLL(id);
            if (_resultModel.Status)
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetClassActivities();
            }
            else
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }


        //Add Button Click
        private void CreateActivity_Btn_Click(object sender, EventArgs e)
        {
            CreateClassActivity _classActivityForm = new CreateClassActivity(_courseSecid);
            _classActivityForm.Show();
        }


        //Refresh Button Click
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetClassActivities();
        }
    }
}
