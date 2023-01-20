using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Activity_Weight;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Activity_Weights
{
    public partial class GPAWeight : Form
    {
        //Fields
        private int CourseSecId;
        private ResultModel _resultModel = new ResultModel();
        private Institute _instituteForm = new Institute();
        private Activity_BLL _activityBll = new Activity_BLL();
        private ActivityWeightBLL _activityWeightBll = new ActivityWeightBLL();

        public GPAWeight()
        {
            InitializeComponent();
        }

        public GPAWeight(int id)
        {
            this.CourseSecId = id;
            InitializeComponent();

        }

        private void GPAWeight_Load(object sender, EventArgs e)
        {
            GetActivityWeights();
        }

        public void GetActivityWeights()
        {
            ActivityWeightDataGrid.AutoGenerateColumns = false;
            ActivityWeightDataGrid.DataSource = new ActivityWeightBLL().GetWeightsBySecIdBLL(CourseSecId);
            foreach (DataGridViewRow dataGridViewRow in ActivityWeightDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            //Getting Total Activity Weights for this course section
            var activityWeights = _activityWeightBll.GetWeightsByCourseSecIdBLL(CourseSecId);
            decimal totalweight = Convert.ToDecimal(0.00);
            foreach (var activityWeight in activityWeights)
            {
                totalweight += activityWeight.Weight;
            }

            TotalWeight_Lbl.Text = totalweight.ToString();
        }

        private void addActivityWeight_Btn_Click(object sender, EventArgs e)
        {
            AddClassActivityWeight addClassActivityWeight = new AddClassActivityWeight(CourseSecId);
            addClassActivityWeight.Show();
        }

        private void ActivityWeightDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ActTypeId = Convert.ToInt32(ActivityWeightDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);

            if (ActivityWeightDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewClassActivityWeight _viewClassActivityWeight = new ViewClassActivityWeight(ActTypeId, CourseSecId);
                _viewClassActivityWeight.Show();
            }
            if (ActivityWeightDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                UpdateClassActivityWeight _updActivityWeight = new UpdateClassActivityWeight(ActTypeId, CourseSecId);
                _updActivityWeight.Show();
            }
            if (ActivityWeightDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult _dgr = MessageBox.Show("Are You Sure to Delete This Activity Weight?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {
                    DeleteActivityWeight(ActTypeId,CourseSecId);
                }
            }
        }

        private void DeleteActivityWeight(int actTypeId, int courseSecId)
        {
            _resultModel = _activityWeightBll.DeleteActivityWeightBLL(actTypeId, courseSecId);
            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetActivityWeights();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetActivityWeights();
        }
    }
}
