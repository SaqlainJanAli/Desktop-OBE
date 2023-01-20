using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.ProgramBatchBEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.ProgramBatchUI
{
    public partial class UpdateProgramBatch : Form
    {
        private int iD;
        private Program_BLL _programBLL = new Program_BLL();
        private DepartmentBLL _departBLL = new DepartmentBLL();
        private Institute _instituteForm = new Institute();
        private ProgramBatch_BLL _programBatchBLL = new ProgramBatch_BLL();
        private ProgramBatch _programBatchBEL = new ProgramBatch();
        private ResultModel _resultModel = new ResultModel();
        public UpdateProgramBatch()
        {
            InitializeComponent();
        }

        public UpdateProgramBatch(int iD)
        {
            this.iD = iD;
            InitializeComponent();

        }

        private void UpdateProgramBatch_Load(object sender, EventArgs e)
        {
            AcademicYear_errorLbl.Visible = false;
            ProgramBatch_errorLbl.Visible = false;
            Program_errorLbl.Visible = false;
            GetPrograms();
            GetNoOfSessions();
            GetGPAMethods();


            FillData();
        }

        private void FillData()
        {
            var UpdEnt = _programBatchBLL.GetProgramBatchByIdBLL(iD);

            ID_TB.Text = UpdEnt.Id.ToString();
            AcademicYear_TB.Text = UpdEnt.AcademicYear.ToString();
            Program_CB.SelectedValue = UpdEnt.ProgramId;
            ProgramBatch_TB.Text = UpdEnt.ProgramBatchName;
            NoOfSessions_CB.SelectedValue = UpdEnt.NoOfSessionId;
            GpaPolicy_CB.SelectedValue = UpdEnt.MethodId;
            PLOPassingThreshold_NUD.Value = UpdEnt.PLOPassingThreshold;
            MarksPercentage_NUD.Value = UpdEnt.MarksPercentage;
            StudentPercentage_NUD.Value = UpdEnt.StudentPercentage;
            Finished_CB.Checked = UpdEnt.Finished;
            UseInOBE_CB.Checked = UpdEnt.UseInOBE;
            TheoryCreditHours_NUD.Value = UpdEnt.TheoryCreditHours;
            LabCreditHours_NUD.Value = UpdEnt.LabCreditHours;
        }

        private void GetPrograms()
        {
            Program_CB.DisplayMember = "Name";
            Program_CB.ValueMember = "SerialNumber";
            Program_CB.DataSource = _programBLL.GetProgramsBLL();
        }
        private void GetNoOfSessions()
        {
            NoOfSessions_CB.DisplayMember = "SessionCount";
            NoOfSessions_CB.ValueMember = "Id";
            NoOfSessions_CB.DataSource = _programBLL.GetNoOfSessionsBLL();
        }

        private void GetGPAMethods()
        {
            GpaPolicy_CB.DisplayMember = "MethodName";
            GpaPolicy_CB.ValueMember = "Id";
            GpaPolicy_CB.DataSource = _departBLL.GetGPAMethodsBLL();
        }
        private void AcademicYear_TB_TextChanged(object sender, EventArgs e)
        {
            if (AcademicYear_TB.Text == string.Empty)
            {
                AcademicYear_errorFlag.Visible = true;
            }
            else
            {
                AcademicYear_errorFlag.Visible = false;
            }
        }

        private void Program_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program_CB.Text == string.Empty)
            {
                Program_errorFlag.Visible = true;

            }
            else
            {
                Program_errorFlag.Visible = false;
            }
        }

        private void ProgramBatch_TB_TextChanged(object sender, EventArgs e)
        {
            if (ProgramBatch_TB.Text == string.Empty)
            {
                ProgramBatch_errorFlag.Visible = true;
            }
            else
            {
                ProgramBatch_errorFlag.Visible = false;
            }
        }

        private void MarksPercentage_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (MarksPercentage_NUD.Text == string.Empty)
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
            if (StudentPercentage_NUD.Text == string.Empty)
            {
                Students_errorFlag.Visible = true;
            }
            else
            {
                Students_errorFlag.Visible = false;
            }
        }

        private void UpdateProgramBatch_Btn_Click(object sender, EventArgs e)
        {
            if (AcademicYear_errorFlag.Visible == true || Program_errorFlag.Visible == true || ProgramBatch_errorFlag.Visible == true || Marks_errorFlag.Visible == true || Students_errorFlag.Visible == true)
            {
                if (AcademicYear_errorFlag.Visible == true)
                {
                    AcademicYear_errorLbl.Visible = true;
                }
                else if (Program_errorFlag.Visible == true)
                {
                    Program_errorLbl.Visible = true;

                }
                else if (ProgramBatch_errorFlag.Visible == true)
                {
                    ProgramBatch_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);

            }
            else
            {
                UpdateAProgramBatch();
            }
        }

        private void UpdateAProgramBatch()
        {
            _programBatchBEL.Id = Convert.ToInt32(ID_TB.Text);
            _programBatchBEL.AcademicYear = Convert.ToInt32(AcademicYear_TB.Text);
            _programBatchBEL.ProgramId = Convert.ToInt32(Program_CB.SelectedValue);
            _programBatchBEL.ProgramBatchName = ProgramBatch_TB.Text;
            _programBatchBEL.NoOfSessionId = Convert.ToInt32(NoOfSessions_CB.SelectedValue);
            _programBatchBEL.MethodId = Convert.ToInt32(GpaPolicy_CB.SelectedValue);
            _programBatchBEL.PLOPassingThreshold = Convert.ToInt32(PLOPassingThreshold_NUD.Value);
            _programBatchBEL.MarksPercentage = Convert.ToInt32(MarksPercentage_NUD.Value);
            _programBatchBEL.StudentPercentage = Convert.ToInt32(StudentPercentage_NUD.Value);
            _programBatchBEL.Finished = Finished_CB.Checked;
            _programBatchBEL.TheoryCreditHours = Convert.ToInt32(TheoryCreditHours_NUD.Value);
            _programBatchBEL.LabCreditHours = Convert.ToInt32(LabCreditHours_NUD.Value);
            _programBatchBEL.UseInOBE = UseInOBE_CB.Checked;

            _resultModel = _programBatchBLL.UpdateProgramBatchBLL(_programBatchBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                this.Hide();


            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);


            }
        }

        private void Close_Icon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
