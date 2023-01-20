using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.Admin_Section.UserUI
{
    public partial class Users : Form
    {
        private School_BLL _schoolBLL = new School_BLL();
        private DepartmentBLL _departBLL = new DepartmentBLL();
        private User_BLL _userBLL = new User_BLL();
        private ResultModel _resultModel = new ResultModel();
        private User _userBEL = new User();
        private FacultyUser _facultyUserBEL = new FacultyUser();
        private Role_BLL _roleBLL = new Role_BLL();
        private Institute _instForm = new Institute();
        private User loggedInUser;


        public Users()
        {
            InitializeComponent();

        }

        public Users(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }


        private void onUsersFormLoad(object sender, EventArgs e)
        {
            FillDropDowns();
            CreateFacultyRecord_CB.Checked = false;
            Faculty_BCL.Visible = false;
            Faculty_BC.Visible = false;
            HideErrorLbls();
            UserPrivacies();

        }

        private void UserPrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (_rolePrivacy.UserCreate)
            {
                tabPage1.Visible = true;
            }
            else
            {
                tabPage1.Visible = false;
            }

            if (_rolePrivacy.UserRead)
            {
                usersDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                usersDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.UserUpdate)
            {
                usersDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                usersDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.UserDelete)
            {
                usersDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                usersDataGrid.Columns["Delete_DGV"].Visible = false;
            }
        }
        private void HideErrorLbls()
        {
            Confirm_errorLbl.Visible = false;
            Department_errorLbl.Visible = false;
            Email_errorLbl.Visible = false;
            FacultyType_errorLbl.Visible = false;
            FirstName_errorLbl.Visible = false;
            LastName_errorLbl.Visible = false;
            Password_errorLbl.Visible = false;
            Role_errorLbl.Visible = false;
            School_errorLbl.Visible = false;
            Type_errorLbl.Visible = false;

            //Filter Controls
            flagForFilter = false;
            FilterActive_CB.Enabled = false;
            FilterEmail_TB.Enabled = false;
            FilterRole_CB.Enabled = false;
        }

        private void FillDropDowns()
        {
            getRoles();
            getFacultyTypes();
            getFTypes();
            getDepartments();
            getGenders();
            getSchools();
            //GetUsers();
        }

        private void getSchools()
        {
            School_CB.DisplayMember = "Name";
            School_CB.ValueMember = "Id";
            School_CB.DataSource = _schoolBLL.GetSchoolsBLL();
        }

        private void getGenders()
        {
            Gender_CB.DisplayMember = "Name";
            Gender_CB.ValueMember = "Id";
            Gender_CB.DataSource = _userBLL.GetGendersBLL();
        }

        private void getDepartments()
        {
            Department_CB.DisplayMember = "Name";
            Department_CB.ValueMember = "Id";
            Department_CB.DataSource = _departBLL.GetDepartmentsBLL();
        }

        private void getFTypes()
        {
            Type_CB.DisplayMember = "Name";
            Type_CB.ValueMember = "Id";
            Type_CB.DataSource = _userBLL.GetFTypesBLL();
        }

        private void getFacultyTypes()
        {
            FacultyType_CB.DisplayMember = "Name";
            FacultyType_CB.ValueMember = "Id";
            FacultyType_CB.DataSource = _userBLL.GetFacultyTypesBLL();
        }

        private void getRoles()
        {
            Role_CB.DisplayMember = "Name";
            Role_CB.ValueMember = "Id";
            Role_CB.DataSource = _roleBLL.GetRolesBLL();
        }




        private void ManageUsers_Btn_Click(object sender, EventArgs e)
        {
            Users_TabControl.SelectTab(1);
        }

        private void CreateUser_Btn_Click(object sender, EventArgs e)
        {

            if (CreateFacultyRecord_CB.Checked)
            {
                if (Department_errorFlag.Visible || FacultyType_errorFlag.Visible || Type_errorFlag.Visible  || ConfirmPwd_errorFlag.Visible  || Email_errorFlag.Visible || FirstName_errorFlag.Visible || LastName_errorFlag.Visible  || Password_errorFlag.Visible || Role_errorFlag.Visible || School_errorFlag.Visible )
                {
                    if (Department_errorFlag.Visible )
                    {
                        Department_errorLbl.Visible = true;

                    }
                    else if (FacultyType_errorFlag.Visible )
                    {
                        FacultyType_errorLbl.Visible = true;
                    }
                    else if (Type_errorFlag.Visible )
                    {
                        Type_errorLbl.Visible = true;
                    }

                    CheckVisibleFlags();
                    _instForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);
                }
                else
                {
                    CreateUser();
                }

            }
            else
            {
                if (ConfirmPwd_errorFlag.Visible || Email_errorFlag.Visible || FirstName_errorFlag.Visible || LastName_errorFlag.Visible == true || Password_errorFlag.Visible == true || Role_errorFlag.Visible == true || School_errorFlag.Visible == true)
                {
                    CheckVisibleFlags();
                    _instForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);
                }
                else
                {
                    CreateUser();
                }
            }




        }

        private void GetUsers()
        {
            usersDataGrid.AutoGenerateColumns = false;
            usersDataGrid.DataSource = _userBLL.GetUsersBLL();

            foreach (DataGridViewRow dataGridViewRow in usersDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterRole_CB.DisplayMember = "Name";
            FilterRole_CB.ValueMember = "Id";
            FilterRole_CB.DataSource = _roleBLL.GetRolesBLL();


        }

        private void CreateUser()
        {
            _userBEL.FirstName = FirstName_TB.Text;
            _userBEL.LastName = LastName_TB.Text;
            _userBEL.isActive = Active_CB.Checked;
            _userBEL.Email = Email_TB.Text;
            _userBEL.RoleId = Convert.ToInt32(Role_CB.SelectedValue);
            _userBEL.SchoolId = Convert.ToInt32(School_CB.SelectedValue);
            _userBEL.Password = Password_TB.Text;
            _userBEL.ConfirmPassword = ConfirmPwd_TB.Text;

            _resultModel = _userBLL.CreateUserBLL(_userBEL);

            if (_resultModel.Status)
            {
                if (CreateFacultyRecord_CB.Checked)
                {
                    int UserId = Convert.ToInt32(_resultModel.Data);
                    _facultyUserBEL.MiddleName = MiddleName_TB.Text;
                    _facultyUserBEL.FTypeId = Convert.ToInt32(Type_CB.SelectedValue);
                    _facultyUserBEL.Designation = Designation_TB.Text;
                    _facultyUserBEL.GenderId = Convert.ToInt32(Gender_CB.SelectedValue);
                    _facultyUserBEL.FacultyTypeId = Convert.ToInt32(FacultyType_CB.SelectedValue);
                    _facultyUserBEL.Active = ActiveFaculty_CB.Checked;
                    _facultyUserBEL.Ph_D = PhD_CB.Checked;
                    _facultyUserBEL.CNIC = CNIC_TB.Text;
                    _facultyUserBEL.JoiningDate = Joining_DTP.Value;
                    _facultyUserBEL.LeavingDate = Leaving_DTP.Value;
                    _facultyUserBEL.MobileNo = MobileNo_TB.Text;
                    _facultyUserBEL.DepartmentId = Convert.ToInt32(Department_CB.SelectedValue);
                    _facultyUserBEL.UserId = UserId;
                    _resultModel = _userBLL.CreateFacultyBLL(_facultyUserBEL);

                }


                if (_resultModel.Status)
                {
                    _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    GetUsers();
                    Users_TabControl.SelectTab(1);
                }
                else
                {
                    _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);

                }

            }
            else
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);

            }


        }
        private void OnDGVCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (usersDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int Id = Convert.ToInt32(usersDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                ViewUser _ViewUser = new ViewUser(Id);
                _ViewUser.Show();
            }
            if (usersDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int Id = Convert.ToInt32(usersDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                UpdateUser _updateUser = new UpdateUser(Id);
                _updateUser.Show();
            }

            if (usersDataGrid.Columns[e.ColumnIndex].Name == "SendPassword_DGV")
            {
                int Id = Convert.ToInt32(usersDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                UpdateUser _updateUser = new UpdateUser(Id);
                _updateUser.Show();
            }

            if (usersDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult _dgr = MessageBox.Show("Are You Sure to Delete This User?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(usersDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                    DeleteUser(Id);

                }
            }
        }

        private void DeleteUser(int id)
        {
            _resultModel = _userBLL.DeleteUserBLL(id);

            if (_resultModel.Status == true)
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetUsers();
            }
            else
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);

            }

        }

        private void CheckVisibleFlags()
        {
            if (ConfirmPwd_errorFlag.Visible == true)
            {
                Confirm_errorLbl.Visible = true;

            }
            else if (Email_errorFlag.Visible == true)
            {
                Email_errorLbl.Visible = true;

            }
            else if (FirstName_errorFlag.Visible == true)
            {
                FirstName_errorLbl.Visible = true;

            }
            else if (LastName_errorFlag.Visible == true)
            {

                LastName_errorLbl.Visible = true;
            }
            else if (Password_errorFlag.Visible == true)
            {
                Password_errorLbl.Visible = true;
            }
            else if (Role_errorFlag.Visible == true)
            {
                Role_errorLbl.Visible = true;

            }
            else
            {
                School_errorLbl.Visible = true;
            }
        }

        private void Department_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Department_CB == null)
            {
                Department_errorFlag.Visible = true;

            }
            else
            {
                Department_errorFlag.Visible = false;
            }
        }

        private void Email_TB_TextChanged(object sender, EventArgs e)
        {
            string EmailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(EmailRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(Email_TB.Text) && !string.IsNullOrWhiteSpace(Email_TB.Text))
            {
                Email_errorFlag.Visible = false;

                var Ent = _userBLL.GetEmailsBLL();
                foreach (var item in Ent)
                {
                    if (Email_TB.Text.ToLower() == item.Email.ToLower())
                    {
                        Email_errorLbl.Text = "This email is already used";
                        Email_errorLbl.Visible = true;
                        Email_errorFlag.Visible = true;
                    }
                    else
                    {
                        Email_errorLbl.Visible = false;
                        Email_errorLbl.Text = "Please enter a valid email.";
                        Email_errorFlag.Visible = false;
                    }
                }

            }
            else
            {
                Email_errorFlag.Visible = true;
            }
        }

        private void FirstName_TB_TextChanged(object sender, EventArgs e)
        {
            if (FirstName_TB.Text == string.Empty)
            {
                FirstName_errorFlag.Visible = true;
            }
            else
            {
                FirstName_errorFlag.Visible = false;
            }
        }

        private void LastName_TB_TextChanged(object sender, EventArgs e)
        {
            if (LastName_TB.Text == string.Empty)
            {
                LastName_errorFlag.Visible = true;

            }
            else
            {
                LastName_errorFlag.Visible = false;

            }
        }

        private void Role_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Role_CB == null)
            {
                Role_errorFlag.Visible = true;

            }
            else
            {
                Role_errorFlag.Visible = false;
            }
        }

        private void School_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (School_CB == null)
            {
                School_errorFlag.Visible = true;

            }
            else
            {
                School_errorFlag.Visible = false;
            }
        }

        private void Password_TB_TextChanged(object sender, EventArgs e)
        {
            if (Password_TB.Text == string.Empty)
            {
                Password_errorFlag.Visible = true;
            }
            else
            {
                Password_errorFlag.Visible = false;
            }
        }

        private void ConfirmPwd_TB_TextChanged(object sender, EventArgs e)
        {
            if (ConfirmPwd_TB.Text == string.Empty || Password_TB.Text != ConfirmPwd_TB.Text)
            {
                ConfirmPwd_errorFlag.Visible = true;

            }
            else
            {
                ConfirmPwd_errorFlag.Visible = false;
            }
        }

        private void Type_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type_CB == null)
            {
                Type_errorFlag.Visible = true;

            }
            else
            {
                Type_errorFlag.Visible = false;
            }
        }

        private void FacultyType_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FacultyType_CB == null)
            {
                FacultyType_errorFlag.Visible = true;
            }
            else
            {
                FacultyType_errorFlag.Visible = false;
            }
        }

        private void CreateFacultyRecord_CB_OnChange(object sender, EventArgs e)
        {
            if (CreateFacultyRecord_CB.Checked )
            {
                Faculty_BCL.Visible = true;
                Faculty_BC.Visible = true;
            }
            else
            {
                Faculty_BCL.Visible = false;
                Faculty_BC.Visible = false;
            }
        }

        private void FilterRole_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByRole();

        }

        private void FilterDGVByRole()
        {
            usersDataGrid.DataSource = _userBLL.FilterByRoleBLL(Convert.ToInt32(FilterRole_CB.SelectedValue));


            foreach (DataGridViewRow dataGridViewRow in usersDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        private void onEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterDGVByEmail();

            }
        }

        private void FilterDGVByEmail()
        {
            usersDataGrid.DataSource = _userBLL.FilterByEmailBLL(FilterEmail_TB.Text);

            foreach (DataGridViewRow dataGridViewRow in usersDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterEmail_TB.Clear();
        }

        private void FilterActive_CB_CheckedChanged(object sender, EventArgs e)
        {
            FilterByisActive();
        }

        private void FilterByisActive()
        {
            usersDataGrid.DataSource = _userBLL.FilterByisActiveBLL(FilterActive_CB.Checked);

            foreach (DataGridViewRow dataGridViewRow in usersDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        private void Users_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUsers();
        }


        //Apply Filter button
        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterActive_CB.Enabled = true;
                FilterEmail_TB.Enabled = true;
                FilterRole_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterActive_CB.Enabled = false;
                FilterEmail_TB.Enabled = false;
                FilterRole_CB.Enabled = false;

                applyFilter_Btn.BackColor = Color.White;
                GetUsers();
            }
        }

        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {

        }

        private void RefreshDataGrid_Btn_Click_1(object sender, EventArgs e)
        {
            GetUsers();
        }
    }
}
