using System;
using System.Drawing;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.ProgramUI
{
    public partial class Programs : Form
    {
        private Program_BLL _programBLL = new Program_BLL();
        private DepartmentBLL _departmentBLL = new DepartmentBLL();
        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();
        private OBE_BEL.MyInstitute_Section.ProgramBEL.Program _programBEL = new OBE_BEL.MyInstitute_Section.ProgramBEL.Program();
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();
        public Programs()
        {
            InitializeComponent();

        }

        public Programs(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onProgramsLoad(object sender, EventArgs e)
        {
            HideErrorLbls();
            //GetPrograms();
            FillDropDowns();
            ProgramPrivacies();
        }

        private void HideErrorLbls()
        {
            AssesmentMethod_errorLbl.Visible = false;
            LearningType_errorLbl.Visible = false;
            Marks_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;
            SemesterType_errorLbl.Visible = false;
            ShortName_errorLbl.Visible = false;
            StudentPercentage_errorLbl.Visible = false;

            //Filter Controls
            flagForFilter = false;
            FilterName_TB.Enabled = false;
            FilterDepartment_CB.Enabled = false;
            FilterLevel_CB.Enabled = false;

        }

        private void FillDropDowns()
        {

            GetDepartments();
            GetAssesmentMethods();
            GetSemesterTypes();
            GetProgramLevels();
            GetNoOfSessions();
            GetLearningTypes();
        }

        private void ProgramPrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (!_rolePrivacy.ProgramCreate)
            {
                Programs_TabControl.TabPages.RemoveAt(0);
            }


            if (_rolePrivacy.ProgramRead)
            {
                programssDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                programssDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.ProgramUpdate)
            {
                programssDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                programssDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.ProgramDelete)
            {
                programssDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                programssDataGrid.Columns["Delete_DGV"].Visible = false;
            }
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

        public void GetPrograms()
        {
            programssDataGrid.AutoGenerateColumns = false;
            programssDataGrid.DataSource = _programBLL.GetProgramsBLL();


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programssDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }


            FilterLevel_CB.DisplayMember = "Name";
            FilterLevel_CB.ValueMember = "Id";
            FilterLevel_CB.DataSource = _programBLL.GetProgramLevelsBLL();

            FilterDepartment_CB.DisplayMember = "Name";
            FilterDepartment_CB.ValueMember = "Id";
            FilterDepartment_CB.DataSource = _departmentBLL.GetDepartmentsBLL();


        }

        private void ManagePrograms_Btn_Click(object sender, EventArgs e)
        {
            Programs_TabControl.SelectTab(1);
        }
        private void OnDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (programssDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int Id = Convert.ToInt32(programssDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                ViewAProgram(Id);
            }
            if (programssDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int Id = Convert.ToInt32(programssDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                UpdateAProgram(Id);
            }
            if (programssDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Program?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(programssDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                    DeleteAProgram(Id);
                }
            }
        }

        private void DeleteAProgram(int id)
        {
            _resultModel = _programBLL.DeleteProgramBLL(id);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetPrograms();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void UpdateAProgram(int id)
        {
            UpdateProgram _UpdateAProgram = new UpdateProgram(id);
            _UpdateAProgram.Show();
        }

        private void ViewAProgram(int id)
        {
            ViewProgram _viewProgram = new ViewProgram(id);
            _viewProgram.Show();
        }

        private void CreateProgram_Btn_Click(object sender, EventArgs e)
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
                CreateProgram();
                GetPrograms();
            }
        }

        private void CreateProgram()
        {
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
            _resultModel = _programBLL.CreateProgramBLL(_programBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                Programs_TabControl.SelectTab(1);
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
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

        private void OnEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterDGVByName();

            }
        }

        private void FilterDGVByName()
        {
            programssDataGrid.DataSource = _programBLL.FilterByNameBLL(FilterName_TB.Text);


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programssDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }



            FilterName_TB.Clear();

        }

        private void FilterLevel_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByLevel();
        }

        private void FilterByLevel()
        {
            programssDataGrid.DataSource = _programBLL.FilterByLevelBLL(Convert.ToInt32(FilterLevel_CB.SelectedValue));


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programssDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void FilterDepartment_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByDepartment();
        }

        private void FilterByDepartment()
        {
            programssDataGrid.DataSource = _programBLL.FilterByDepartBLL(Convert.ToInt32(FilterDepartment_CB.SelectedValue));


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in programssDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetPrograms();
        }

        private void Programs_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetPrograms();
        }


        //Apply Filter button

        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterName_TB.Enabled = true;
                FilterDepartment_CB.Enabled = true;
                FilterLevel_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterName_TB.Enabled = false;
                FilterDepartment_CB.Enabled = false;
                FilterLevel_CB.Enabled = false;

                applyFilter_Btn.BackColor = Color.White;
                GetPrograms();
            }
        }
    }
}

