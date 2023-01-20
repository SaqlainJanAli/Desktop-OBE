using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.DepartmentUI
{
    public partial class Department : Form
    {
        private string _fullImagePath;
        ResultModel _resultModel = new ResultModel();
        Institute _instituteForm = new Institute();
        OBE_BEL.MyInstitute_Section.SchoolsBEL.School _school = new OBE_BEL.MyInstitute_Section.SchoolsBEL.School();
        OBE_BEL.MyInstitute_Section.DepartmentBEL.Department _departmentBEL = new OBE_BEL.MyInstitute_Section.DepartmentBEL.Department();
        School_BLL _schoolBLL = new School_BLL();
        DepartmentBLL _departmentBLL = new DepartmentBLL();
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();
        public Department()
        {
            InitializeComponent();

        }

        public Department(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onDepartmentLoad(object sender, EventArgs e)
        {
            FillDropDowns();
            HideFewControls();
            //GetDepartments();
            DepartmentPrivacies();
        }

        private void HideFewControls()
        {
            //Error Lbls
            AssessmentMethod_errorLbl.Visible = false;
            DeptName_errorLbl.Visible = false;
            GpaMethod_errorLbl.Visible = false;
            School_errorLbl.Visible = false;


            //Filter Controls
            flagForFilter = false;
            FilterName_TB.Enabled = false;
            FilterSchool_CB.Enabled = false;
        }

        private void FillDropDowns()
        {
            School_CB.DataSource = _schoolBLL.GetSchoolsBLL();
            GetGPAMethods();
            GetAssessmentMethods();
        }

        private void DepartmentPrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (!_rolePrivacy.DepartmentCreate)
            {
                Departments_TabControl.TabPages.RemoveAt(0);
            }
            

            if (_rolePrivacy.DepartmentRead)
            {
                departmentDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                departmentDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.DepartmentUpdate)
            {
                departmentDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                departmentDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.DepartmentDelete)
            {
                departmentDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                departmentDataGrid.Columns["Delete_DGV"].Visible = false;
            }
        }

        public void GetDepartments()
        {
            departmentDataGrid.AutoGenerateColumns = false;
            var departments = _departmentBLL.GetDepartmentsBLL();
            departmentDataGrid.DataSource = departments;


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in departmentDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(departments[i].Logo_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(departments[i].Logo_Path);
                }
            }

            FilterSchool_CB.DisplayMember = "Name";
            FilterSchool_CB.ValueMember = "Id";
            FilterSchool_CB.DataSource = _schoolBLL.GetSchoolsBLL();
        }

        public void GetAssessmentMethods()
        {
            AssessmentMethd_CB.DataSource = _departmentBLL.GetAssessmentMethodsBLL();
        }

        public void GetGPAMethods()
        {
            GpaMethod_CB.DataSource = _departmentBLL.GetGPAMethodsBLL();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UploadImage_Btn_Click(object sender, EventArgs e)
        {
            UploadImage();
        }
        public void UploadImage()
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Image Files (*.jpg ; *.jpeg; *.png; *.gif;)|*.jpg; *.jpeg; *png; *gif;";
            DialogResult dr = _openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap newBitmap = new Bitmap(_openFileDialog.FileName);
                DeptLogo_PicBox.Image = newBitmap;
            }

            var currentDirectory = Directory.GetCurrentDirectory();
            var imageFolderPath = Path.Combine(currentDirectory, "Institutes", "Campuses", "Schools", "Departments", "Logos");
            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }

            string extension = Path.GetExtension(_openFileDialog.FileName);
            var UniqueImageName = Guid.NewGuid();
            var newImageName = UniqueImageName + extension;
            _fullImagePath = Path.Combine(imageFolderPath, newImageName);
            File.Copy(_openFileDialog.FileName, _fullImagePath);

        }

        private void DepartmentName_TB_TextChanged(object sender, EventArgs e)
        {
            if (DepartmentName_TB.Text == string.Empty)
            {
                DeptName_errorFlag.Visible = true;

            }
            else
            {
                DeptName_errorFlag.Visible = false;
            }
        }

        private void School_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (School_CB.Text == string.Empty)
            {
                School_errorFlag.Visible = true;
            }
            else
            {
                School_errorFlag.Visible = false;
            }
        }

        private void GpaMethod_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GpaMethod_CB.Text == string.Empty)
            {
                GpaMethod_errorFlag.Visible = true;
            }
            else
            {
                GpaMethod_errorFlag.Visible = false;
            }
        }

        private void AssessmentMethd_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AssessmentMethd_CB.Text == string.Empty)
            {
                AssessmentMethod_errorFlag.Visible = true;

            }
            else
            {
                AssessmentMethod_errorFlag.Visible = false;
            }
        }

        private void CreateDept_Btn_Click(object sender, EventArgs e)
        {
            if (DeptName_errorFlag.Visible == true || GpaMethod_errorFlag.Visible == true || AssessmentMethod_errorFlag.Visible ==true || School_errorFlag.Visible == true)
            {
                if(DeptName_errorFlag.Visible == true)
                {
                    DeptName_errorLbl.Visible = true;
                }
                else if (GpaMethod_errorFlag.Visible == true)
                {
                    GpaMethod_errorLbl.Visible = true;
                }
                else if (AssessmentMethod_errorFlag.Visible == true)
                {
                    AssessmentMethod_errorLbl.Visible = true;
                }
                else
                {
                    School_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are mendatory", Form_Alert.enmType.Error);

            }
            else
            {
                CreateDepartment();
            }

            
        }

        private void CreateDepartment()
        {
            _departmentBEL.Name = DepartmentName_TB.Text;
            _departmentBEL.ShortName = ShortName_TB.Text;
            _departmentBEL.isActive = isActive_CB.Checked;
            _departmentBEL.AllowFaculty = AllowFaculty_CB.Checked;
            _departmentBEL.SchoolId = Convert.ToInt32(School_CB.SelectedValue);
            _departmentBEL.GPAMethodId = Convert.ToInt32(GpaMethod_CB.SelectedValue);
            _departmentBEL.Attendance = Convert.ToInt32(AttendancePercent_NUD.Value);
            _departmentBEL.AssessmentMethodId = Convert.ToInt32(AssessmentMethd_CB.SelectedValue);
            _departmentBEL.ActivitiesInDays = Convert.ToInt32(CourseActvtiesDays_NUD.Value);
            _departmentBEL.Logo_Path = _fullImagePath;
            _departmentBEL.Vision = DeptVision_RTB.Text;
            _departmentBEL.Mission = DeptMission_RTB.Text;


            _resultModel = _departmentBLL.CreateDepartmentBLL(_departmentBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                Departments_TabControl.SelectTab(1);
                GetDepartments();


            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }

        }

        private void ManageDept_Btn_Click(object sender, EventArgs e)
        {
            Departments_TabControl.SelectTab(1);
        }

        private void OnDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (departmentDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int ID = Convert.ToInt32(departmentDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                ViewADept(ID);
            }


            if (departmentDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int ID = Convert.ToInt32(departmentDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                UpdateDepartment _updateDept = new UpdateDepartment(ID);
                _updateDept.Show();
                GetDepartments();
            }

            if (departmentDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Department?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(departmentDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                    DeleteDept(ID);
                    GetDepartments();
                }
            }

        }

        private void DeleteDept(int iD)
        {
            _resultModel = _departmentBLL.DeleteDepartmentBLL(iD);
            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void ViewADept(int iD)
        {
            ViewDepartment _viewDept = new ViewDepartment(iD);
            _viewDept.Show();
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

            var departments = _departmentBLL.FilterByNameBLL(FilterName_TB.Text);
            departmentDataGrid.DataSource = departments;

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in departmentDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(departments[i].Logo_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(departments[i].Logo_Path);
                }
            }

            //Clear the text box
            FilterName_TB.Clear();
        }

        private void FilterSchool_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVBySchool();
        }

        private void FilterDGVBySchool()
        {
            var departments = _departmentBLL.FilterBySchoolBLL(Convert.ToInt32(FilterSchool_CB.SelectedValue));
            departmentDataGrid.DataSource = departments;


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in departmentDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(departments[i].Logo_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(departments[i].Logo_Path);
                }
            }

        }

        //Refresh
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetDepartments();
        }

        private void Departments_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetDepartments();
        }


        //Apply Filter button

        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterName_TB.Enabled = true;
                FilterSchool_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterName_TB.Enabled = false;
                FilterSchool_CB.Enabled = false;


                applyFilter_Btn.BackColor = Color.White;
                GetDepartments();
            }
        }
    }
}

