using System;
using System.Drawing;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.SemesterUI
{
    public partial class Semester : Form
    {
        private OBE_BEL.MyInstitute_Section.SemesterBEL.Semester _semesterBEL = new OBE_BEL.MyInstitute_Section.SemesterBEL.Semester();
        private Semester_BLL _semesterBLL = new Semester_BLL();
        private ResultModel _resultModel = new ResultModel();
        private Institute _instituteForm = new Institute();
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();
        public Semester()
        {
            InitializeComponent();

        }

        public Semester(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onSemesterLoad(object sender, EventArgs e)
        {
            HideErrorLbls();
            //GetSemesters();
            SemesterPrivacies();
        }

        private void HideErrorLbls()
        {
            AcademicYear_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;

            //Filter Controls
            flagForFilter = false;
            FilterName_TB.Enabled = false;
            FilterCompleted_CB.Enabled = false;
            FilterShowResult_CB.Enabled = false;
            FilterYear_CB.Enabled = false;

        }

        private void SemesterPrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (_rolePrivacy.SemesterCreate)
            {
                tabPage1.Visible = true;
            }
            else
            {
                tabPage1.Visible = false;
            }

            if (_rolePrivacy.SemesterRead)
            {
                semsterDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                semsterDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.SemesterUpdate)
            {
                semsterDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                semsterDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.SemesterDelete)
            {
                semsterDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                semsterDataGrid.Columns["Delete_DGV"].Visible = false;
            }
        }


        private void ManageSemesters_Btn_Click(object sender, EventArgs e)
        {
            GetSemesters();
            Semester_TabControl.SelectTab(1);
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

        private void SemName_TB_TextChanged(object sender, EventArgs e)
        {
            if (SemName_TB.Text == string.Empty)
            {
                Name_errorFlag.Visible = true;
            }
            else
            {
                Name_errorFlag.Visible = false;
            }
        }

        private void CreateSemester_Btn_Click(object sender, EventArgs e)
        {
            if (AcademicYear_errorFlag.Visible == true || Name_errorFlag.Visible == true)
            {
                if (AcademicYear_errorFlag.Visible == true)
                {
                    AcademicYear_errorLbl.Visible = true;

                }
                else
                {
                    Name_errorLbl.Visible = true;
                }
            }
            else
            {
                CreateSemester();
                GetSemesters();
            }
        }

        public void GetSemesters()
        {
            FilterYear_CB.DisplayMember = "AcademicYear";
            FilterYear_CB.ValueMember = "Id";
            FilterYear_CB.DataSource = _semesterBLL.GetSemestersBLL();

            semsterDataGrid.AutoGenerateColumns = false;
            semsterDataGrid.DataSource = _semesterBLL.GetSemestersBLL();

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in semsterDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        private void CreateSemester()
        {
            _semesterBEL.AcademicYear = AcademicYear_TB.Text;
            _semesterBEL.Name = SemName_TB.Text;
            _semesterBEL.StartDate = StartDate_DTP.Value;
            _semesterBEL.EndDate = EndDate_DTP.Value;
            _semesterBEL.Notes = Notes_RTB.Text;
            _semesterBEL.Completed = Completed_CB.Checked;
            _semesterBEL.ShowResultInGPA = ShowResult_CB.Checked;

            _resultModel = _semesterBLL.CreateSemesterBLL(_semesterBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                Semester_TabControl.SelectTab(1);
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }


        }

        private void OnDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (semsterDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int Id = Convert.ToInt32(semsterDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                ShowSemesterGPA(Id);
            }
            if (semsterDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int Id = Convert.ToInt32(semsterDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                ViewASemester(Id);
            }
            if (semsterDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int Id = Convert.ToInt32(semsterDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                UpdateASemester(Id);
            }
            if (semsterDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Semester?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(semsterDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                    DeleteASemester(Id);
                }
            }
        }

        private void ShowSemesterGPA(int SemesterId)
        {
            //SemesterGPAHome semesterGpaHome = new SemesterGPAHome(SemesterId);
            //semesterGpaHome.Show();
        }

        private void DeleteASemester(int id)
        {
            _resultModel = _semesterBLL.DeleteSemesterBLL(id);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetSemesters();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void UpdateASemester(int id)
        {
            UpdateSemester _UpdateSem = new UpdateSemester(id);
            _UpdateSem.Show();
        }

        private void ViewASemester(int id)
        {
            ViewSemester _viewSem = new ViewSemester(id);
            _viewSem.Show();
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
            semsterDataGrid.DataSource = _semesterBLL.FilterByNameBLL(FilterName_TB.Text);


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in semsterDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterName_TB.Clear();
        }

        private void FilterYear_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByYear();
        }

        private void FilterDGVByYear()
        {
            semsterDataGrid.AutoGenerateColumns = false;
            semsterDataGrid.DataSource = _semesterBLL.FilterByYearBLL(FilterYear_CB.Text);


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in semsterDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void FilterCompleted_CB_CheckedChanged(object sender, EventArgs e)
        {
            FilterDGVByCompleted();
        }

        private void FilterDGVByCompleted()
        {
            semsterDataGrid.AutoGenerateColumns = false;
            semsterDataGrid.DataSource = _semesterBLL.FilterByCompletedBLL(FilterCompleted_CB.Checked);


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in semsterDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void FilterShowResult_CB_CheckedChanged(object sender, EventArgs e)
        {
            FilterDGVByShowResult();
        }

        private void FilterDGVByShowResult()
        {
            semsterDataGrid.AutoGenerateColumns = false;
            semsterDataGrid.DataSource = _semesterBLL.FilterByShowResultBLL(FilterShowResult_CB.Checked);
            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in semsterDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        //Refresh DGV
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetSemesters();
        }

        //Tab Changed
        private void Semester_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSemesters();
        }

        //Apply Filter button

        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterName_TB.Enabled = true;
                FilterCompleted_CB.Enabled = true;
                FilterShowResult_CB.Enabled = true;
                FilterYear_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterName_TB.Enabled = false;
                FilterCompleted_CB.Enabled = false;
                FilterShowResult_CB.Enabled = false;
                FilterYear_CB.Enabled = false;

                applyFilter_Btn.BackColor = Color.White;
                GetSemesters();
            }
        }
    }
}

