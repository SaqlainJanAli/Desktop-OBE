using System;
using System.Windows.Forms;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.Admin_Section.RolesUI;
using OBE_Desktop.Admin_Section.StudentUserUI;
using OBE_Desktop.Admin_Section.UserUI;
using OBE_Desktop.AssessmentMethod.Activity;
using OBE_Desktop.MyInstitute_Section.CampusUI;
using OBE_Desktop.MyInstitute_Section.CourseSectionUI;
using OBE_Desktop.MyInstitute_Section.CourseUI;
using OBE_Desktop.MyInstitute_Section.DepartmentUI;
using OBE_Desktop.MyInstitute_Section.InstituteUI;
using OBE_Desktop.MyInstitute_Section.ProgramBatchUI;
using OBE_Desktop.MyInstitute_Section.ProgramUI;
using OBE_Desktop.MyInstitute_Section.SchoolUI;
using OBE_Desktop.MyInstitute_Section.SemesterUI;
using OBE_Desktop.OBE_Section.CLO_UI;
using OBE_Desktop.OBE_Section.PEO_UI;
using OBE_Desktop.OBE_Section.PLO_UI;
using OBE_Desktop.Reports.SemsterGPA;

namespace OBE_Desktop
{
    public partial class Home : Form
    {
        //Fields
        Form activeForm = null;
        private User LoggedInUser;
        private User_BLL _userBLL = new User_BLL();


        //Constructor
        public Home()
        {
            InitializeComponent();
            CustomDesginSubMenus();
        }
        public Home(User ent)
        {
            this.LoggedInUser = ent;
            InitializeComponent();
            CustomDesginSubMenus();
        }


        //On Load event
        private void Home_Load(object sender, EventArgs e)
        {
            LoggedInUserName.Text = LoggedInUser.FirstName + " " + LoggedInUser.LastName;
            Home_BLL _homeBLL = new Home_BLL();
            var Role = _homeBLL.getRoleNameBLL(LoggedInUser);
            if (Role != null)
            {
                LoggedInRole.Text = Role.Name;
            }
            HandleHomePrivacy();
            FillStatisticsTab();
            HomeFooter();
        }
        //Functions
        private void CustomDesginSubMenus()
        {
            insituteSubMenuPanel.Visible = false;
            obeSubMenuPanel.Visible = false;
            adminSubMenuPanel.Visible = false;
            reportsSubMenuPanel.Visible = false;
        }
        private void HideSubMenus()
        {
            if (insituteSubMenuPanel.Visible)
                insituteSubMenuPanel.Visible = false;
            if (obeSubMenuPanel.Visible)
                obeSubMenuPanel.Visible = false;
            if (adminSubMenuPanel.Visible)
                adminSubMenuPanel.Visible = false;
            if (reportsSubMenuPanel.Visible)
            {
                reportsSubMenuPanel.Visible = false;
            }
        }
        private void ShowSubMenus(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenus();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        //Fill Statistics tab on home
        private void FillStatisticsTab()
        {
            Count_Institutes.Text = new InstituteBLL().CountInstitutes().ToString();
            Count_Campuses.Text = new Campus_BLL().CountCampuses().ToString();
            Count_Schools.Text = new School_BLL().CountSchools().ToString();
            Count_Departments.Text = new DepartmentBLL().CountDepartments().ToString();
            Count_Users.Text = new User_BLL().CountUsersBLL().ToString();
            //Count_Students.Text = ;
            Count_Courses.Text = new Course_BLL().CountCourseBLL().ToString();
        }

        //Footer 
        private void HomeFooter()
        {
            Copyrights_Lbl.Text = "All Rights Reserved " + DateTime.Now.Year + " © D-OBE Development Team";
        }

        //Rights to do
        private void HandleHomePrivacy()
        {
            //var _rolePrivacy = _userBLL.getPrivacyByIdBLL(LoggedInUser.RoleId);
            if (LoggedInRole.Text == "App Admin" || LoggedInRole.Text == "University Admin")
            {
                My_Institute_Btn.Visible = true;
                campus_Btn.Visible = true;
                schools_btn.Visible = true;
                departments_Btn.Visible = true;
                semester_Btn.Visible = true;
                programs_Btn.Visible = true;
                program_Batches_btn.Visible = true;
                courses_Btn.Visible = true;
                course_Sections_Btn.Visible = true;

                obeBtn.Visible = true;

                roles_Btn.Visible = true;
                users_Btn.Visible = true;


            }
            else if (LoggedInRole.Text == "Campus Admin")
            {
                My_Institute_Btn.Visible = false;
                campus_Btn.Visible = true;
                schools_btn.Visible = true;
                departments_Btn.Visible = true;
                semester_Btn.Visible = true;
                programs_Btn.Visible = true;
                program_Batches_btn.Visible = true;
                courses_Btn.Visible = true;
                course_Sections_Btn.Visible = true;

                obeBtn.Visible = true;

                roles_Btn.Visible = true;
                users_Btn.Visible = true;

            }
            else if (LoggedInRole.Text == "School Admin")
            {
                My_Institute_Btn.Visible = false;
                campus_Btn.Visible = false;
                schools_btn.Visible = true;
                departments_Btn.Visible = true;
                semester_Btn.Visible = true;
                programs_Btn.Visible = true;
                program_Batches_btn.Visible = true;
                courses_Btn.Visible = true;
                course_Sections_Btn.Visible = true;

                obeBtn.Visible = true;

                roles_Btn.Visible = true;
                users_Btn.Visible = true;

            }
            else if (LoggedInRole.Text == "Department Admin")
            {
                My_Institute_Btn.Visible = false;
                campus_Btn.Visible = false;
                schools_btn.Visible = false;
                departments_Btn.Visible = true;
                semester_Btn.Visible = true;
                programs_Btn.Visible = true;
                program_Batches_btn.Visible = true;
                courses_Btn.Visible = true;
                course_Sections_Btn.Visible = true;

                obeBtn.Visible = true;

                roles_Btn.Visible = true;
                users_Btn.Visible = true;

            }
            else if (LoggedInRole.Text == "Staff" || LoggedInRole.Text == "Teacher")
            {
                My_Institute_Btn.Visible = false;
                campus_Btn.Visible = false;
                schools_btn.Visible = false;
                departments_Btn.Visible = false;
                semester_Btn.Visible = false;
                programs_Btn.Visible = false;
                program_Batches_btn.Visible = false;
                courses_Btn.Visible = true;
                course_Sections_Btn.Visible = false;

                obeBtn.Visible = true;

                roles_Btn.Visible = false;
                users_Btn.Visible = false;
            }
        }


        //Menu Button Click
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Home_TabControl.Visible = true;
            Home_TabControl.Show();
            Home_TabControl.BringToFront();
        }
        private void institueBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(insituteSubMenuPanel);
        }
        private void obeBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(obeSubMenuPanel);
        }
        private void adminBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(adminSubMenuPanel);
        }
        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(reportsSubMenuPanel);
        }
        //Logout Btn
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }


        //On form closing
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
      
        
        //Sub menu button click
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildFormContainer.Controls.Add(childForm);
            panelChildFormContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Show();
        }

        //My Institute section Sub menus
        private void My_Institute_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Institute(LoggedInUser));
        }
        private void campus_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Campus(LoggedInUser));
        }
        private void schools_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new School(LoggedInUser));
        }
        private void departments_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Department(LoggedInUser));
        }
        private void semester_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Semester(LoggedInUser));
        }
        private void programs_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Programs(LoggedInUser));
        }
        private void program_Batches_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProgramsBatches(LoggedInUser));
        }
        private void courses_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Courses(LoggedInUser));
        }
        private void course_Sections_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CourseSection(LoggedInUser));
        }


        //OBE Section sub menus
        private void PEOs_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PEO());
        }

        private void PLOs_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PLO());
        }

        private void CLOs_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CLO());
        }

        //Admin Section sub menus
        private void roles_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Role(LoggedInUser));
        }
        private void users_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Users(LoggedInUser));
        }
        private void StudentUsers_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentUser());
        }
        private void dmcTranscript_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SemesterGPAHome());
        }

      
    }
}
