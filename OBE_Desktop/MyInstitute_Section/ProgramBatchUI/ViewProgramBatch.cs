using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.ProgramBatchUI
{
    public partial class ViewProgramBatch : Form
    {
        private int iD;
        private Program_BLL _programBLL = new Program_BLL();
        private ProgramBatch_BLL _programBatchBLL = new ProgramBatch_BLL();
        
        public ViewProgramBatch()
        {
            InitializeComponent();
        }

        public ViewProgramBatch(int iD)
        {
            this.iD = iD;
            InitializeComponent();

        }

        private void ViewProgramBatch_Load(object sender, EventArgs e)
        {
            //GetPrograms();
            //GetNoOfSessions();
            //GetGPAMethods();


            FillData();
        }
        private void FillData()
        {
            var UpdEnt = _programBatchBLL.GetProgramBatchByIdBLL(iD);

            ID_TB.Text = UpdEnt.Id.ToString();
            AcademicYear_TB.Text = UpdEnt.AcademicYear.ToString();
            Program_TB.Text = UpdEnt.ProgramId.ToString();
            ProgramBatch_TB.Text = UpdEnt.ProgramBatchName.ToString();
            NoOfSession_TB.Text = UpdEnt.NoOfSessionId.ToString();
            GpaPolicy_TB.Text = UpdEnt.MethodId.ToString();
            PloPassing_TB.Text = UpdEnt.PLOPassingThreshold.ToString();
            Marks_TB.Text= UpdEnt.MarksPercentage.ToString();
            Students_TB.Text= UpdEnt.StudentPercentage.ToString();
            Finished_CB.Checked = UpdEnt.Finished;
            UseInOBE_CB.Checked = UpdEnt.UseInOBE;
            TheoryCreditHours_TB.Text= UpdEnt.TheoryCreditHours.ToString();
            LabCreditHours_TB.Text= UpdEnt.LabCreditHours.ToString();
        }
        
        //private void GetPrograms()
        //{
        //    var ProgramEnt = _programBLL.GetProgramsBLL();
        //}
        //private void GetNoOfSessions()
        //{
        //    var NoOfSessionEnt = _programBLL.GetNoOfSessionsBLL();
        //}

        //private void GetGPAMethods()
        //{
        //    var GpaMethodsEnt = _departBLL.GetGPAMethodsBLL();
           
        //}

    }
}