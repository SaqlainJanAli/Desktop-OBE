using OBE_BLL.AssessmentSection_BLL;
using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.AssessmentMethod.Activity
{
    public partial class Activity : Form
    {
        //Fields
        private Activity_BLL _ActivityBll = new Activity_BLL();
        private Institute _instituteform = new Institute();
        ResultModel _resultModel = new ResultModel();

        private OBE_BEL.Assessment_Section.ActivityBEL.Activity _activityBEL =
            new OBE_BEL.Assessment_Section.ActivityBEL.Activity();
        private int _courseSecId;

        //Constructor

        public Activity()
        {
            InitializeComponent();
        }

        public Activity(int id)
        {
            this._courseSecId = id;
            InitializeComponent();

        }

        //ON Load
        private void Activity_Load(object sender, EventArgs e)
        {
            HideFewControls();
            //GetActivities();
        }

        private void HideFewControls()
        {
            Name_errorLbl.Visible = false;
            ShortName_errorLbl.Visible = false;
        }

        //Load Data Grid
        private void GetActivities()
        {
            ActivityDataGrid.AutoGenerateColumns = false;
            ActivityDataGrid.DataSource = _ActivityBll.GetActTypesByCourseSecIdBLL(_courseSecId);

            //ActivityDataGrid.Columns.Add("SrNo_DGV", "Sr. No.");
            foreach (DataGridViewRow dataGridViewRow in ActivityDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index+1;
            }
        }


        //Button Clicks
        private void ManageActivitites_Btn_Click(object sender, EventArgs e)
        {
            Activity_TabControl.SelectTab(1);
        }

        //Create button click
        private void CreateActivity_Btn_Click(object sender, EventArgs e)
        {
            if (Name_errorFlag.Visible || ShortName_errorFlag.Visible)
            {
                if (Name_errorFlag.Visible)
                {
                    Name_errorLbl.Visible = true;
                }
                else
                {
                    ShortName_errorLbl.Visible = true;
                }
                _instituteform.NotifyAlert("Fields marked with * are mandatory",Form_Alert.enmType.Error);
            }
            else
            {
                CreateActivity();
            }
        }

        //Create Activity Function
        private void CreateActivity()
        {
            _activityBEL.Name = Name_TB.Text;
            _activityBEL.ShortName = ShortName_TB.Text;
            _activityBEL.CourseSectionId = _courseSecId;
            _resultModel = _ActivityBll.CreateActivityBLL(_activityBEL);
            if (_resultModel.Status)
            {
                _instituteform.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetActivities();
                Activity_TabControl.SelectTab(1);
            }
            else
            {
                _instituteform.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }

        }


        //TextChanged Event
        private void ShortName_TB_TextChanged(object sender, EventArgs e)
        {
            ShortName_errorFlag.Visible = (ShortName_TB.Text == string.Empty) ? true : false;
        }
        private void Name_TB_TextChanged(object sender, EventArgs e)
        {
            Name_errorFlag.Visible = (Name_TB.Text == string.Empty) ? true : false;
        }


        //DataGrid Cell Content Click Event
        private void ActivityDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id = Convert.ToInt32(ActivityDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);

            if (ActivityDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewActivity _viewActivity = new ViewActivity(Id);
                _viewActivity.Show();
            }
            if (ActivityDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                UpdateActivity _updateActivity = new UpdateActivity(Id);
                _updateActivity.Show();
              
            }
            if (ActivityDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult _dgr = MessageBox.Show("Are You Sure to Delete This Activity?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {
                    DeleteActivity(Id);
                }
            }
        }


        //Delete Method
        private void DeleteActivity(int id)
        {
            _resultModel = _ActivityBll.DeleteActivityBLL(id);
            if (_resultModel.Status == true)
            {
                _instituteform.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetActivities();
            }
            else
            {
                _instituteform.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void Activity_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetActivities();
        }
    }
}
