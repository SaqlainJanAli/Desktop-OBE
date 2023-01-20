using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.ProgramUI
{
    public partial class UpdateProgram : Form
    {
        private int id;
        Program_BLL _programBLL = new Program_BLL();
        Institute _instituteForm = new Institute();
        ResultModel _resultModel = new ResultModel();
        DepartmentBLL _departmentBLL = new DepartmentBLL();
        OBE_BEL.MyInstitute_Section.ProgramBEL.Program _programBEL = new OBE_BEL.MyInstitute_Section.ProgramBEL.Program();
        public UpdateProgram()
        {
            InitializeComponent();
        }

        public UpdateProgram(int id)
        {
            this.id = id;
            InitializeComponent();

        }

        private void UpdateProgram_Btn_Click(object sender, EventArgs e)
        {

            if (AssesmentMethod_errorFlag.Visible == true || LearningType_errorFlag.Visible == true || Marks_errorFlag.Visible == true || Name_errorFlag.Visible == true || SemesterType_errorFlag.Visible == true || ShortName_errorFlag.Visible == true || StudentPercentage_errorflag.Visible == true)
            {
                if (AssesmentMethod_errorFlag.Visible == true)
                {
                    AssesmentMethod_errorLbl.Visible = true;
                }
                else if (LearningType_errorFlag.Visible == true)
                {
                    LearningType_errorLbl.Visible = true;
                }
                else if (Marks_errorFlag.Visible == true)
                {
                    Marks_errorLbl.Visible = true;
                }
                else if (Name_errorFlag.Visible == true)
                {
                    Name_errorLbl.Visible = true;
                }
                else if (SemesterType_errorFlag.Visible == true)
                {
                    SemesterType_errorLbl.Visible = true;
                }
                else if (StudentPercentage_errorflag.Visible == true)
                {
                    StudentPercentage_errorLbl.Visible = true;
                }
                else
                {
                    ShortName_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are required", Form_Alert.enmType.Error);
            }
            else
            {
                UpdateAProgram();
            }
        }

        private void UpdateAProgram()
        {
            _programBEL.Id = Convert.ToInt32(ProgramID_TB.Text);
            _programBEL.Name = Name_TB.Text;
            _programBEL.ShortName = ShortName_TB.Text;
            _programBEL.DepartmentId = Convert.ToInt32(Department_CB.SelectedValue);
            _programBEL.NoOfSessionsId = Convert.ToInt32(Session_CB.SelectedValue);
            _programBEL.ProgramLevelId = Convert.ToInt32(ProgramLevel_CB.SelectedValue);
            _programBEL.SemesterTypeId = Convert.ToInt32(SemesterType_CB.SelectedValue);
            _programBEL.MethodId = Convert.ToInt32(AssessmentMethod_CB.SelectedValue);
            _programBEL.LearningTypeId = Convert.ToInt32(LearningType_CB.SelectedValue);
            _programBEL.MarksPercentage = Convert.ToInt32(MarksPercentage_NUD.Value);
            _programBEL.StudentPercentage = Convert.ToInt32(StudentPercentage_NUD.Value);
            _programBEL.Vision = Vision_RTB.Text;
            _programBEL.Mission = Mission_RTB.Text;
            _resultModel = _programBLL.UpdateProgramBLL(_programBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void UpdateProgram_Load(object sender, EventArgs e)
        {
            AssesmentMethod_errorLbl.Visible = false;
            LearningType_errorLbl.Visible = false;
            Marks_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;
            SemesterType_errorLbl.Visible = false;
            ShortName_errorLbl.Visible = false;
            StudentPercentage_errorLbl.Visible = false;

            GetDepartments();
            GetAssesmentMethods();
            GetSemesterTypes();
            GetProgramLevels();
            GetNoOfSessions();
            GetLearningTypes();

            ProgramID_TB.Text = id.ToString();
            GetProgramById(id);
        }
        public void GetLearningTypes()
        {
            LearningType_CB.DisplayMember = "Name";
            LearningType_CB.ValueMember = "Id";
            LearningType_CB.DataSource = _programBLL.GetLearningTypesBLL();
        }

        public void GetNoOfSessions()
        {
            Session_CB.DisplayMember = "SessionCount";
            Session_CB.ValueMember = "Id";
            Session_CB.DataSource = _programBLL.GetNoOfSessionsBLL();
        }

        public void GetProgramLevels()
        {
            ProgramLevel_CB.DisplayMember = "Name";
            ProgramLevel_CB.ValueMember = "Id";
            ProgramLevel_CB.DataSource = _programBLL.GetProgramLevelsBLL();
        }

        public void GetSemesterTypes()
        {
            SemesterType_CB.DisplayMember = "Name";
            SemesterType_CB.ValueMember = "Id";
            SemesterType_CB.DataSource = _programBLL.GetSemesterTypesBLL();
        }

        public void GetAssesmentMethods()
        {
            AssessmentMethod_CB.DisplayMember = "MethodName";
            AssessmentMethod_CB.ValueMember = "Id";
            AssessmentMethod_CB.DataSource = _departmentBLL.GetAssessmentMethodsBLL();
        }

        public void GetDepartments()
        {
            Department_CB.DisplayMember = "Name";
            Department_CB.ValueMember = "Id";
            Department_CB.DataSource = _departmentBLL.GetDepartmentsBLL();
        }

        private void GetProgramById(int id)
        {
            var Ent = _programBLL.GetProgramByIdBLL(id);
            ProgramID_TB.Text = Ent.Id.ToString();
            Name_TB.Text = Ent.Name;
            ShortName_TB.Text = Ent.ShortName;
            SemesterType_CB.SelectedValue = Ent.SemesterTypeId;
            Department_CB.SelectedValue = Ent.DepartmentId;
            ProgramLevel_CB.SelectedValue = Ent.ProgramLevelId;
            Session_CB.SelectedValue = Ent.NoOfSessionsId;
            AssessmentMethod_CB.SelectedValue = Ent.MethodId;
            LearningType_CB.SelectedValue = Ent.LearningTypeId;
            MarksPercentage_NUD.Text = Ent.MarksPercentage.ToString();
            StudentPercentage_NUD.Text = Ent.StudentPercentage.ToString();
            Vision_RTB.Text = Ent.Vision;
            Mission_RTB.Text = Ent.Mission;
        }

        private void Name_TB_TextChanged(object sender, EventArgs e)
        {
            if (Name_TB.Text == string.Empty)
            {

                Name_errorFlag.Visible = true;
            }
            else
            {
                Name_errorFlag.Visible = false;
            }
        }

        private void ShortName_TB_TextChanged(object sender, EventArgs e)
        {
            if (ShortName_TB.Text == string.Empty)
            {
                ShortName_errorFlag.Visible = true;
            }
            else
            {
                ShortName_errorFlag.Visible = false;
            }
        }

        private void SemesterType_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SemesterType_CB.Text == string.Empty)
            {
                SemesterType_errorFlag.Visible = true;
            }
            else
            {
                SemesterType_errorFlag.Visible = false;
            }
        }

        private void AssessmentMethod_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AssessmentMethod_CB.Text == string.Empty)
            {
                AssesmentMethod_errorFlag.Visible = true;
            }
            else
            {
                AssesmentMethod_errorFlag.Visible = false;
            }
        }

        private void LearningType_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LearningType_CB.Text == string.Empty)
            {
                LearningType_errorFlag.Visible = true;

            }
            else
            {
                LearningType_errorFlag.Visible = false;
            }
        }

        private void MarksPercentage_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (MarksPercentage_NUD.Text == string.Empty || MarksPercentage_NUD.Value > 100)
            {
                Marks_errorFlag.Visible = true;
            }
            else
            {
                Marks_errorFlag.Visible = false;
            }
        }

        private void StudentPercentage_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (StudentPercentage_NUD.Value > 100 || StudentPercentage_NUD.Text == string.Empty)
            {
                StudentPercentage_errorflag.Visible = true;
            }
            else
            {
                StudentPercentage_errorflag.Visible = false;
            }
        }
    }
}
