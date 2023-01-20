using System;
using System.Windows.Forms;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Activity_Weight;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Activity_Weights
{
    public partial class ViewClassActivityWeight : Form
    {
        private int courseSecId;
        private int actTypeId;
        private Activity_BLL _activityBll = new Activity_BLL();
        private ActivityWeightBLL _activityWeightBll = new ActivityWeightBLL();

        public ViewClassActivityWeight()
        {
            InitializeComponent();
        }

        public ViewClassActivityWeight(int id, int courseSecId)
        {
            this.actTypeId = id;
            this.courseSecId = courseSecId;
            InitializeComponent();

            ActTypeId_TB.Text = actTypeId.ToString();
            CourseSecId_TB.Text = courseSecId.ToString();

        }

        private void ViewClassActivityWeight_Load(object sender, EventArgs e)
        {
            GetPrevData();
        }
        private void GetPrevData()
        {
            var currentActivityWeight = _activityWeightBll.GetWeightByActTypeIdBLL(actTypeId,courseSecId);
            Weight_TB.Text= currentActivityWeight.Weight.ToString();

            var activityType = _activityBll.GetActivityByIdBLL(currentActivityWeight.ActivityId);
            Activity_TB.Text = activityType.Name;


        }
    }
}
