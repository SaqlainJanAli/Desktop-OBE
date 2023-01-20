using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    public partial class ImportFromProgramBatch : Form
    {
        private int courseSecid;

        public ImportFromProgramBatch()
        {
            InitializeComponent();
        }

        public ImportFromProgramBatch(int courseSecid)
        {
            this.courseSecid = courseSecid;
            InitializeComponent();
        }

        private void ImportFromProgramBatch_Load(object sender, EventArgs e)
        {
            GetProgramBatches();
        }

        private void GetProgramBatches()
        {
            var programBatches = new ProgramBatch_BLL().GetProgramBatchesBLL();
            ProgramBatch_CB.DisplayMember = "ProgramBatchDepartment";
            ProgramBatch_CB.ValueMember = "SerialNumber";
            ProgramBatch_CB.DataSource = programBatches;
        }

        private void select_Btn_Click(object sender, EventArgs e)
        {
            int selectedBatchId = Convert.ToInt32(ProgramBatch_CB.SelectedValue);

            SelectStudents selectStudents = new SelectStudents(selectedBatchId, courseSecid);
            this.Hide();
            selectStudents.Show();
        }
    }
}
