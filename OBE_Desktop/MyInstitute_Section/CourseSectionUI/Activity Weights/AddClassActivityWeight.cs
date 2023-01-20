using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.ActivityWeight;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Activity_Weight;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Activity_Weights
{
    public partial class AddClassActivityWeight : Form
    {
        //Fields
        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();
        private ActivityWeight _activityWeightBEL = new ActivityWeight();
        private Activity_BLL _activityBll = new Activity_BLL();
        private ActivityWeightBLL _activityWeightBll = new ActivityWeightBLL();
        private int courseSecId;
        private List<ActivityWeight> ActivityWeights = new List<ActivityWeight>();
        private decimal _currentWeightage = Convert.ToDecimal(0.00);

        //Constructor
        public AddClassActivityWeight()
        {
            InitializeComponent();
        }
        public AddClassActivityWeight(int courseSecId)
        {
            this.courseSecId = courseSecId;
            InitializeComponent();
        }

        //On Load Event
        private void AddClassActivityWeight_Load(object sender, EventArgs e)
        {
            HideErrorLabels();
            GetActivityTypes();
        }
        private void GetActivityTypes()
        {
            Activity_CB.DisplayMember = "Name";
            Activity_CB.ValueMember = "Id";
            Activity_CB.DataSource = _activityBll.GetActTypesByCourseSecIdBLL(courseSecId);
        }
        private void HideErrorLabels()
        {
            Activity_errorLbl.Visible = false;
            weight_errorLbl.Visible = false;
        }


        //Selected Changed
        private void Activity_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity_errorFlag.Visible = Activity_CB.Text == null;
        }
        private void Weight_NUD_ValueChanged(object sender, EventArgs e)
        {
            weight_errorFlag.Visible = Weight_NUD.Value == Convert.ToDecimal(0.00);
        }

        //Save Button Click
        private void saveActivityWeight_Btn_Click(object sender, EventArgs e)
        {
            if (Activity_errorFlag.Visible || weight_errorFlag.Visible)
            {
                if (Activity_errorFlag.Visible)
                {
                    Activity_errorLbl.Visible = true;
                }
                else
                {
                    weight_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are required", Form_Alert.enmType.Error);
            }
            else
            {
                GetActivityWeights();
                if ((_currentWeightage + Weight_NUD.Value) < Convert.ToDecimal(101.00))
                {
                    CreateActivityWeight();
                  
                }
                else
                {
                    _instituteForm.NotifyAlert("You can only add activity weight equal to \n100", Form_Alert.enmType.Warning);
                }
            }
        }

        private void GetActivityWeights()
        {
            ActivityWeights = _activityWeightBll.GetWeightsByCourseSecIdBLL(courseSecId);
            foreach (var activityWeight in ActivityWeights)
            {
                _currentWeightage += activityWeight.Weight;
            }
        }
        private void CreateActivityWeight()
        {
            _activityWeightBEL.CourseSectionId = courseSecId;
            _activityWeightBEL.ActivityId = Convert.ToInt32(Activity_CB.SelectedValue);
            _activityWeightBEL.Weight = Weight_NUD.Value;
            _resultModel = _activityWeightBll.CreateActivityWeightBLL(_activityWeightBEL);
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
    }
}
