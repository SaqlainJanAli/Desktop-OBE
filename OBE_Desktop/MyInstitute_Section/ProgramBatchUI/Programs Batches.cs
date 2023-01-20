using System;
using System.Drawing;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BEL.MyInstitute_Section.ProgramBatchBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.ProgramBatchUI
{
    public partial class 
        
        ProgramsBatches : Form
    {

        private Program_BLL _programBLL = new Program_BLL();
        private DepartmentBLL _departBLL = new DepartmentBLL();
        private Institute _instituteForm = new Institute();
        private ProgramBatch_BLL _programBatchBLL = new ProgramBatch_BLL();
        private ProgramBatch _programBatchBEL = new ProgramBatch();
        private ResultModel _resultModel = new ResultModel();
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();
        public ProgramsBatches()
        {
            InitializeComponent();

        }

        public ProgramsBatches(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onProgramBatchesLoad(object sender, EventArgs e)
        {
            FillDropDowns();
            HideFewControls();
            //GetProgramBatches();
            BatchPrivacies();
        }

        private void FillDropDowns()
        {
            GetPrograms();
            GetNoOfSessions();
            GetGPAMethods();
        }

        private void HideFewControls()
        {
            //ErrorLbls
                
            AcademicYear_errorLbl.Visible = false;
            ProgramBatch_errorLbl.Visible = false;
            Program_errorLbl.Visible = false;


            //Filter Controls
            flagForFilter = false;
            FilterName_TB.Enabled = false;
            FilterBatch_CB.Enabled = false;
            FilterProgram_CB.Enabled = false;
        }

        private void BatchPrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (!_rolePrivacy.BatchCreate)
            {
                ProgramBatch_TabControl.TabPages.Remove(ProgramBatch_TabControl.TabPages[0]);
            }

            if (_rolePrivacy.BatchRead)
            {
                programsbatchsDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                programsbatchsDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.BatchUpdate)
            {
                programsbatchsDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                programsbatchsDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.BatchDelete)
            {
                programsbatchsDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                programsbatchsDataGrid.Columns["Delete_DGV"].Visible = false;
            }
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

        private void ManageProgramBatches_Btn_Click(object sender, EventArgs e)
        {
            ProgramBatch_TabControl.SelectTab(1);
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateProgramBatch_Btn_Click(object sender, EventArgs e)
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
                _instituteForm.NotifyAlert("Fields marked with * are mendatory", Form_Alert.enmType.Error);

            }
            else
            {
                CreateProgramBatch();
                GetProgramBatches();
            }
        }

        private void GetProgramBatches()
        {

            programsbatchsDataGrid.AutoGenerateColumns = false;
            programsbatchsDataGrid.DataSource = _programBatchBLL.GetProgramBatchesBLL();

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programsbatchsDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }


            FilterProgram_CB.DisplayMember = "Name";
            FilterProgram_CB.ValueMember = "SerialNumber";
            FilterProgram_CB.DataSource = _programBLL.GetProgramsBLL();

            FilterBatch_CB.DisplayMember = "ProgramBatch";
            FilterBatch_CB.ValueMember = "SerialNumber";
            FilterBatch_CB.DataSource = _programBatchBLL.GetProgramBatchesBLL();
        }

        private void CreateProgramBatch()
        {
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

            _resultModel = _programBatchBLL.CreateProgramBatchBLL(_programBatchBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetProgramBatches();
                ProgramBatch_TabControl.SelectTab(1);


            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);


            }
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

        private void OnDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (programsbatchsDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int ID = Convert.ToInt32(programsbatchsDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());

                ViewProgramBatch _ViewForm = new ViewProgramBatch(ID);
                _ViewForm.Show();

            }
            if (programsbatchsDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {

                int ID = Convert.ToInt32(programsbatchsDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                UpdateProgramBatch _UpdateForm = new UpdateProgramBatch(ID);
                _UpdateForm.Show();
            }
            if (programsbatchsDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Program Batch?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(programsbatchsDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                    DeleteProgramBatch(ID);
                    GetProgramBatches();
                }
            }
        }

        private void DeleteProgramBatch(int iD)
        {
            _resultModel = _programBatchBLL.DeleteProgramBLL(iD);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);

            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);


            }

        }

        private void FilterBatch_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByBatch(); 
        }

        private void FilterDGVByBatch()
        {
            programsbatchsDataGrid.DataSource = _programBatchBLL.FilterByBatchBLL(Convert.ToInt32(FilterBatch_CB.SelectedValue));

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programsbatchsDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void FilterProgram_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByProgram();
        }

        private void FilterDGVByProgram()
        {
            programsbatchsDataGrid.DataSource = _programBatchBLL.FilterByProgramBLL(Convert.ToInt32(FilterProgram_CB.SelectedValue));

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programsbatchsDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void onEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterDGVByName();
            }
        }

        private void FilterDGVByName()
        {
            programsbatchsDataGrid.DataSource = _programBatchBLL.FilterByNameBLL(FilterName_TB.Text);

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programsbatchsDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterName_TB.Clear();
        }

        //Refresh Button Click
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetProgramBatches();
        }

        private void ProgramBatch_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProgramBatches();
        }



        //Apply Filter button

        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterName_TB.Enabled = true;
                FilterBatch_CB.Enabled = true;
                FilterProgram_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterName_TB.Enabled = false;
                FilterBatch_CB.Enabled = false;
                FilterProgram_CB.Enabled = false;

                applyFilter_Btn.BackColor = Color.White;
                GetProgramBatches();
            }
        }
    }
}

