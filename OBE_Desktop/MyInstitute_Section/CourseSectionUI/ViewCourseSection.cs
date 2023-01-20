using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.AssessmentMethod.Activity;
using OBE_Desktop.MyInstitute_Section.CourseSectionUI.Activity_Weights;
using OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity;
using OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.GPA;
using OBE_Desktop.MyInstitute_Section.CourseSectionUI.CLOs;
using OBE_Desktop.MyInstitute_Section.CourseSectionUI.PLOs;
using OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI
{
    public partial class ViewCourseSection : Form
    {
        private int Id;
        CourseSection_BLL _courseSectionBLL = new CourseSection_BLL();
        private Form activeForm = null;

        //Constructor
        public ViewCourseSection()
        {
            InitializeComponent();
        }
        public ViewCourseSection(int id)
        {
            this.Id = id;
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CustomDesignSubMenus();
        }


        //Load Form
        private void ViewCourseSection_Load(object sender, EventArgs e)
        {
            FillDataFields();
        
        }

        private void FillDataFields()
        {
            var Ent = _courseSectionBLL.GetCourseSectionByIdBLL(Id);
            //ViewCourseSection _viewC = new ViewCourseSection();
            //_viewC.DataBindings =  
            Course_TB.Text = Ent.CourseId.ToString();
            School_TB.Text = Ent.DepartmentId.ToString();
            Name_TB.Text = Ent.Name;
            Marks_TB.Text = Ent.MarksPercentage.ToString();
            Gender_TB.Text = Ent.GenderId.ToString();
            Section_TB.Text = Ent.Section;
            Finished_CB.Checked = Ent.Finished;
            UseInOBE_CB.Checked = Ent.UseInOBE;
            Semester_TB.Text = Ent.SemesterId.ToString();
            Students_TB.Text = Ent.StudentsPercentage.ToString();
            Teacher_TB.Text = Ent.FacultyId.ToString();
        }
        private void CustomDesignSubMenus()
        {
            CloSubMenuPanel.Visible = false;
            //ploSubMenuPanel.Visible = false;
            assesmentMethodSubMenuPanel.Visible = false;
            classStudentsSubMenuPanel.Visible = false;
            activityWeightSubMenuPanel.Visible = false;
            activityTypeSubMenuPanel.Visible = false;
        }
        private void HideSubMenus()
        {
            if (CloSubMenuPanel.Visible)
                CloSubMenuPanel.Visible = false;
            //if (ploSubMenuPanel.Visible)
            //    ploSubMenuPanel.Visible = false;
            if (assesmentMethodSubMenuPanel.Visible)
                assesmentMethodSubMenuPanel.Visible = false;
            if (classStudentsSubMenuPanel.Visible)
                classStudentsSubMenuPanel.Visible = false;
            if (activityWeightSubMenuPanel.Visible)
                activityWeightSubMenuPanel.Visible = false;
            if (activityTypeSubMenuPanel.Visible)
                activityTypeSubMenuPanel.Visible = false;
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



        //Menu Button clicks
        private void CloBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(CloSubMenuPanel);
        }
        //private void PloBtn_Click(object sender, EventArgs e)
        //{
        //    ShowSubMenus(ploSubMenuPanel);
        //}
        private void assesmentMethodsBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(assesmentMethodSubMenuPanel);
        }
        private void studentsBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(classStudentsSubMenuPanel);
        }
        private void activityWeightsBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(activityWeightSubMenuPanel);
        }
        private void activityBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenus(activityTypeSubMenuPanel);
        }

        //Sub Menu Button clicks
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.StartPosition = FormStartPosition.CenterParent;
            childForm.Show();
        }
        private void CloList_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CLOList(Id));
        }
        private void ClassActiviy_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassActivityHome(Id));
        }
        //private void PloList_Btn_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new PLOList(Id));
        //}
        private void classStudent_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClassStudents(Id));
        }
        private void gpaWeight_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GPAWeight(Id));
        }

        private void gpa_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MarksGPA(Id));
        }

        private void activityType_Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Activity(Id));
        }

    }
}
