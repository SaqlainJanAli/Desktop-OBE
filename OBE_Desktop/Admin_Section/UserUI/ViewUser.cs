using System;
using System.Windows.Forms;
using OBE_BLL.AdminSection_BLL;

namespace OBE_Desktop.Admin_Section.UserUI
{
    public partial class ViewUser : Form
    {
        private int Id;
        User_BLL _userBLL = new User_BLL();
        public ViewUser()
        {
            InitializeComponent();
        }
        public ViewUser(int id)
        {
            this.Id = id;
            InitializeComponent();
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
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
            Role_TB.Text= UserEnt.RoleId.ToString();
            School_TB.Text= UserEnt.SchoolId.ToString();
            Password_TB.Text = UserEnt.Password;
            ConfirmPwd_TB.Text = UserEnt.ConfirmPassword;

            var _faculty = _userBLL.getFacultyByIdBLL(Id);
            if (_faculty !=null)
            {
                MiddleName_TB.Text = _faculty.MiddleName;
                Faculty_TB.Text = _faculty.FacultyTypeId.ToString();
                Designation_TB.Text = _faculty.Designation;
                Gender_TB.Text = _faculty.GenderId.ToString();
                Type_TB.Text = _faculty.FTypeId.ToString();
                ActiveFaculty_CB.Checked = _faculty.Active;
                PhD_CB.Checked = _faculty.Ph_D;
                CNIC_TB.Text = _faculty.CNIC;
                Joining_DTP.Value = _faculty.JoiningDate;
                Leaving_DTP.Value = _faculty.LeavingDate;
                MobileNo_TB.Text = _faculty.MobileNo;
                Department_TB.Text = _faculty.DepartmentId.ToString();
                FacultyID_TB.Text = _faculty.Id.ToString();
            }
            
        }

    }
}
