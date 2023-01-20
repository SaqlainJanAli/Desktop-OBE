using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.ProgramUI
{
    public partial class ViewProgram : Form
    {
        private int id;
        Program_BLL _programBLL = new Program_BLL();
        public ViewProgram()
        {
            InitializeComponent();
        }

        public ViewProgram(int id)
        {
            this.id = id;
            InitializeComponent();

        }

        private void ViewProgram_Load(object sender, EventArgs e)
        {
            ProgramID_TB.ReadOnly = true;
            Department_TB.ReadOnly = true;
            AssessmentMethod_TB.ReadOnly = true;
            LearningType_TB.ReadOnly = true;
            MarksPercentage_TB.ReadOnly = true;
            Name_TB.ReadOnly = true;
            NoOfSession_TB.ReadOnly = true;
            ProgramLevel_TB.ReadOnly = true;
            SemesterType_TB.ReadOnly = true;
            ShortName_TB.ReadOnly = true;
            StudentPercentage_TB.ReadOnly = true;



            GetProgramById(id);
        }

        private void GetProgramById(int id)
        {
            var Ent = _programBLL.GetProgramByIdBLL(id);
            ProgramID_TB.Text = Ent.Id.ToString();
            Name_TB.Text = Ent.Name;
            ShortName_TB.Text = Ent.ShortName;
            SemesterType_TB.Text = Ent.SemesterTypeId.ToString();
            Department_TB.Text = Ent.DepartmentId.ToString();
            ProgramLevel_TB.Text= Ent.ProgramLevelId.ToString();
            NoOfSession_TB.Text = Ent.NoOfSessionsId.ToString();
            AssessmentMethod_TB.Text = Ent.MethodId.ToString();
            LearningType_TB.Text = Ent.LearningTypeId.ToString();
            MarksPercentage_TB.Text = Ent.MarksPercentage.ToString();
            StudentPercentage_TB.Text = Ent.StudentPercentage.ToString();
            Vision_RTB.Text = Ent.Vision;
            Mission_RTB.Text = Ent.Mission;
        }
    }
}
