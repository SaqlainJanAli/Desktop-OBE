using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.AssessmentSection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.AssessmentMethod.Activity
{
    public partial class UpdateActivity : Form
    {
        //Fields
        private Activity_BLL _ActivityBll = new Activity_BLL();
        private Institute _instituteform = new Institute();
        ResultModel _resultModel = new ResultModel();

        private OBE_BEL.Assessment_Section.ActivityBEL.Activity _activityBEL =
            new OBE_BEL.Assessment_Section.ActivityBEL.Activity();

        private int id;
        //private int _courseSecId;

        //Constructor
        public UpdateActivity()
        {
            InitializeComponent();
        }

        //public UpdateActivity(int id, int _courseSecId)
        //{
        //    this.id = id;
        //    this._courseSecId = _courseSecId;
        //    InitializeComponent();

        //}

        public UpdateActivity(int id)
        {
            this.id = id;
            InitializeComponent();
        }



        //Load
        private void UpdateActivity_Load(object sender, EventArgs e)
        {
            GetPrevData();
            HideFewControls();

        }

        private void GetPrevData()
        {
            ID_TB.Text = id.ToString();
            var existingActivity = _ActivityBll.GetActivityByIdBLL(id);
            Name_TB.Text = existingActivity.Name;
            ShortName_TB.Text = existingActivity.ShortName;
        }

        private void HideFewControls()
        {
            Name_errorFlag.Visible = false;
            ShortName_errorFlag.Visible = false;

            Name_errorLbl.Visible = false;
            ShortName_errorLbl.Visible = false;
        }



        //Create button click
        private void UpdateActivity_Btn_Click(object sender, EventArgs e)
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
                _instituteform.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);
            }
            else
            {
                UpdateAnActivity();
            }
        }

        //Create Activity Function
        private void UpdateAnActivity()
        {
            _activityBEL.Id = id;
            _activityBEL.Name = Name_TB.Text;
            _activityBEL.ShortName = ShortName_TB.Text;
            //_activityBEL.CourseSectionId = _courseSecId;
            _resultModel = _ActivityBll.UpdateActivityBLL(_activityBEL);
            _instituteform.NotifyAlert(_resultModel.Message,_resultModel.Status ? Form_Alert.enmType.Success : Form_Alert.enmType.Error);
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


    }
}
