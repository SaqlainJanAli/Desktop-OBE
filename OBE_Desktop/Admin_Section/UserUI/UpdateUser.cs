using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.Admin_Section.UserUI
{
    public partial class UpdateUser : Form
    {
        School_BLL _schoolBLL = new School_BLL();
        DepartmentBLL _departBLL = new DepartmentBLL();
        User_BLL _userBLL = new User_BLL();
        ResultModel _resultModel = new ResultModel();
        User _userBEL = new User();
        FacultyUser _facultyUserBEL = new FacultyUser();
        Role_BLL _roleBLL = new Role_BLL();
        Institute _instForm = new Institute();
        private int Id;

        public UpdateUser()
        {
            InitializeComponent();
        }
        public UpdateUser(int id)
        {
            this.Id = id;
            InitializeComponent();
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

        }

        private void FillDropDowns()
        {
            getRoles();
            getFacultyTypes();
            getFTypes();
            getDepartments();
            getGenders();
            getSchools();

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





        private void UpdateUser_Btn_Click(object sender, EventArgs e)
        {

            if (CreateFacultyRecord_CB.Checked == true)
            {
                if (Department_errorFlag.Visible == true || FacultyType_errorFlag.Visible == true || Type_errorFlag.Visible == true || ConfirmPwd_errorFlag.Visible == true || Email_errorFlag.Visible == true || FirstName_errorFlag.Visible == true || LastName_errorFlag.Visible == true || Password_errorFlag.Visible == true || Role_errorFlag.Visible == true || School_errorFlag.Visible == true)
                {
                    if (Department_errorFlag.Visible == true)
                    {
                        Department_errorLbl.Visible = true;

                    }
                    else if (FacultyType_errorFlag.Visible == true)
                    {
                        FacultyType_errorLbl.Visible = true;
                    }
                    else if (Type_errorFlag.Visible == true)
                    {
                        Type_errorLbl.Visible = true;
                    }

                    CheckVisibleFlags();
                    _instForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);
                }
                else
                {
                    UpdateAUser();
                }

            }
            else
            {
                if (ConfirmPwd_errorFlag.Visible == true || Email_errorFlag.Visible == true || FirstName_errorFlag.Visible == true || LastName_errorFlag.Visible == true || Password_errorFlag.Visible == true || Role_errorFlag.Visible == true || School_errorFlag.Visible == true)
                {
                    CheckVisibleFlags();
                    _instForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);
                }
                else
                {
                    UpdateAUser();
                }
            }




        }
      

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            FillDropDowns();
            if (CreateFacultyRecord_CB.Checked == true)
            {
                Faculty_BCL.Visible = true;
                Faculty_BC.Visible = true;
            }
            else
            {
                Faculty_BCL.Visible = false;
                Faculty_BC.Visible = false;
            }
            HideErrorLbls();
            FillPreviousData();
        }

        private void FillPreviousData()
        {
            UserID_TB.Text = Id.ToString();

            var UserEnt = _userBLL.getUserByIdBLL(Id);
            FirstName_TB.Text = UserEnt.FirstName;
            LastName_TB.Text = UserEnt.LastName;
            Active_CB.Checked = UserEnt.isActive;
            Email_TB.Text = UserEnt.Email;
            Role_CB.SelectedValue = UserEnt.RoleId;
            School_CB.SelectedValue = UserEnt.SchoolId;
            Password_TB.Text = UserEnt.Password;
            ConfirmPwd_TB.Text = UserEnt.ConfirmPassword;

            var _faculty = _userBLL.getFacultyByIdBLL(Id);
            if (_faculty==null)
            {
                CreateFacultyRecord_CB.Checked = false;
                Faculty_BC.Visible = false;
            }
            else
            {
                MiddleName_TB.Text = _faculty.MiddleName;
                FacultyType_CB.SelectedValue = _faculty.FacultyTypeId;
                Designation_TB.Text = _faculty.Designation;
                Gender_CB.SelectedValue = _faculty.GenderId;
                Type_CB.SelectedValue = _faculty.FTypeId;
                ActiveFaculty_CB.Checked = _faculty.Active;
                PhD_CB.Checked = _faculty.Ph_D;
                CNIC_TB.Text = _faculty.CNIC;
                Joining_DTP.Value = _faculty.JoiningDate;
                Leaving_DTP.Value = _faculty.LeavingDate;
                MobileNo_TB.Text = _faculty.MobileNo;
                Department_CB.SelectedValue = _faculty.DepartmentId;
                FacultyID_TB.Text = _faculty.Id.ToString();
            }
            
        }

        private void UpdateAUser()
        {
            _userBEL.Id = Convert.ToInt32(UserID_TB.Text);
            _userBEL.FirstName = FirstName_TB.Text;
            _userBEL.LastName = LastName_TB.Text;
            _userBEL.isActive = Active_CB.Checked;
            _userBEL.Email = Email_TB.Text;
            _userBEL.RoleId = Convert.ToInt32(Role_CB.SelectedValue);
            _userBEL.SchoolId = Convert.ToInt32(School_CB.SelectedValue);
            _userBEL.Password = Password_TB.Text;
            _userBEL.ConfirmPassword = ConfirmPwd_TB.Text;

            _resultModel = _userBLL.UpdateUserBLL(_userBEL);

            if (_resultModel.Status == true)
            {
                if (CreateFacultyRecord_CB.Checked ==true)
                {
                    _facultyUserBEL.Id = Convert.ToInt32(FacultyID_TB.Text);
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
                    _facultyUserBEL.UserId = Convert.ToInt32(UserID_TB.Text);

                    _resultModel = _userBLL.UpdateFacultyBLL(_facultyUserBEL);

                }
                
                if (_resultModel.Status == true)
                {
                    _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    this.Close();
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
            if (CreateFacultyRecord_CB.Checked)
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
    }
}
