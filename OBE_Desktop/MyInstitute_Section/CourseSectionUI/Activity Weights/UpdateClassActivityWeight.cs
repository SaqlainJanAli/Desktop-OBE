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
    public partial class UpdateClassActivityWeight : Form
    {
        //Fields
        private int courseSecId;
        private int actTypeId;
        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();
        private ActivityWeight _activityWeightBEL = new ActivityWeight();
        private Activity_BLL _activityBll = new Activity_BLL();
        private ActivityWeightBLL _activityWeightBll = new ActivityWeightBLL();
        private List<ActivityWeight> ActivityWeights = new List<ActivityWeight>();
        private decimal _totalActivityWieght;
        private decimal _prevWeight;


        //Constructor
        public UpdateClassActivityWeight()
        {
            InitializeComponent();
        }
        public UpdateClassActivityWeight(int _actTypeId, int courseSecId)
        {
            this.actTypeId = _actTypeId;
            this.courseSecId = courseSecId;
            InitializeComponent();
            Id_TB.Text = actTypeId.ToString();
        }
        
        //On Load

        private void UpdateClassActivityWeight_Load(object sender, EventArgs e)
        {
            HideErrorLabels();
            GetTotalActivityWeight(courseSecId);
            GetActivityTypes();
            GetPrevData();
        }

        //Functions
        private void HideErrorLabels()
        {
            Activity_errorLbl.Visible = false;
            weight_errorLbl.Visible = false;
        }

        //Get activity Weights for this courseSection
        private void GetTotalActivityWeight(int _courseSecId)
        {
            ActivityWeights = _activityWeightBll.GetWeightsByCourseSecIdBLL(_courseSecId);
            foreach (var activityWeight in ActivityWeights)
            {
                _totalActivityWieght += activityWeight.Weight;
            }
        }
        //Get all activity types for the drop down
        private void GetActivityTypes()
        {
            Activity_CB.DisplayMember = "Name";
            Activity_CB.ValueMember = "Id";
            Activity_CB.DataSource = _activityBll.GetActTypesByCourseSecIdBLL(courseSecId);
        }

        //Putting Previous Data that is needed to be updated
        private void GetPrevData()
        {
            var currentActivityWeight = _activityWeightBll.GetWeightByActTypeIdBLL(actTypeId,courseSecId);
            Activity_CB.SelectedValue = currentActivityWeight.ActivityId;
            _prevWeight = currentActivityWeight.Weight;
            Weight_NUD.Value = _prevWeight;
        }
      
        //SelectedChangedEvents
        private void Activity_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity_errorFlag.Visible = Activity_CB.Text == null;
        }
        private void Weight_NUD_ValueChanged(object sender, EventArgs e)
        {
            weight_errorFlag.Visible = Weight_NUD.Value == Convert.ToDecimal(0.00);
            
            //Calculate new Total
            _totalActivityWieght = _totalActivityWieght + Weight_NUD.Value - _prevWeight;

            //Assign new weight
            _prevWeight = Weight_NUD.Value;
        }

        //Update Button Click
        private void updateActivity_Btn_Click(object sender, EventArgs e)
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
                //GetActivityWeights();
                if (_totalActivityWieght < Convert.ToDecimal(101.00))
                {
                    UpdateActivityWeight();
                }
                else
                {
                    _instituteForm.NotifyAlert("You can only add activity weight equal to 100", Form_Alert.enmType.Warning);
                }
            }
        }

      
        private void UpdateActivityWeight()
        {
            _activityWeightBEL.CourseSectionId = courseSecId;
            _activityWeightBEL.ActivityId = Convert.ToInt32(Activity_CB.SelectedValue);
            _activityWeightBEL.Weight = Weight_NUD.Value;
            _resultModel = _activityWeightBll.UpdateActivityWeightBLL(_activityWeightBEL);
            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
               // new GPAWeight().GetActivityWeights();
                Close();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

    }
}
