using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI
{
    public partial class UpdateCourseSection : Form
    {
        Institute _instForm = new Institute();
        Course_BLL _courseBLL = new Course_BLL();
        Semester_BLL _semesterBLL = new Semester_BLL();
        ResultModel _resultModel = new ResultModel();
        School_BLL _schoolBLL = new School_BLL();
        User_BLL _userBLL = new User_BLL();
        CourseSection_BLL _courseSectionBLL = new CourseSection_BLL();
        OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection _courseSectionBEL = new OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection();
        private int Id;


        public UpdateCourseSection()
        {
            InitializeComponent();
        }
        public UpdateCourseSection(int ID)
        {
            this.Id = ID;
            InitializeComponent();
        }
        

        private void HideErrorLbls()
        {
            Course_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;
            Department_errorLbl.Visible = false;
            Semester_errorLbl.Visible = false;
            Students_errorLbl.Visible = false;
            Teacher_errorLbl.Visible = false;
            Marks_errorLbl.Visible = false;
        }

        private void FillDropDowns()
        {
            getDepartments();
            getSemesters();
            getCourse();
            getFaculty();
            getGenders();
        }

        private void getFaculty()
        {
            Teacher_CB.DisplayMember = "Name";
            Teacher_CB.ValueMember = "Id";
            Teacher_CB.DataSource = _userBLL.GetFacultiesBLL();
        }

        private void getGenders()
        {
            Gender_CB.DisplayMember = "Name";
            Gender_CB.ValueMember = "Id";
            Gender_CB.DataSource = _userBLL.GetGendersBLL();
        }

        private void getCourse()
        {
            Course_CB.DisplayMember = "Name";
            Course_CB.ValueMember = "SerialNumber";
            Course_CB.DataSource = _courseBLL.GetCoursesBLL();
        }

        private void getSemesters()
        {
            Semester_CB.DisplayMember = "Name";
            Semester_CB.ValueMember = "Id";
            Semester_CB.DataSource = _semesterBLL.GetSemestersBLL();
        }

        private void getDepartments()
        {
            Department_CB.DisplayMember = "Name";
            Department_CB.ValueMember = "Id";
            Department_CB.DataSource = new DepartmentBLL().GetDepartmentsBLL();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void Semester_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Semester_CB == null)
            {
                Semester_errorFlag.Visible = true;
            }
            else
            {
                Semester_errorFlag.Visible = false;
            }
        }

        private void Course_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Course_CB == null)
            {
                Course_errorFlag.Visible = true;

            }
            else
            {
                Course_errorFlag.Visible = false;
            }
        }

        private void Teacher_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Teacher_CB == null)
            {
                Teacher_errorFlag.Visible = true;
            }
            else
            {
                Teacher_errorFlag.Visible = false;
            }
        }

        private void MarksPercentage_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (MarksPercentage_NUD.Value == 0)
            {
                Marks_errorFlag.Visible = true;

            }
            else
            {
                Marks_errorFlag.Visible = false;
            }
        }

        private void StudentsPercentage_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (StudentsPercentage_NUD.Value == 0)
            {
                Student_errorFlag.Visible = true;

            }
            else
            {
                Student_errorFlag.Visible = false;
            }
        }

        private void UpdateCourseSection_Btn_Click(object sender, EventArgs e)
        {
            if (Course_errorFlag.Visible == true || Marks_errorFlag.Visible == true || Name_errorFlag.Visible == true || School_errorFlag.Visible == true || Semester_errorFlag.Visible == true || Student_errorFlag.Visible == true || Teacher_errorFlag.Visible == true)
            {

                if (Course_errorFlag.Visible == true)
                {

                    Course_errorLbl.Visible = true;
                }
                else if (Marks_errorFlag.Visible == true)
                {

                    Marks_errorLbl.Visible = true;
                }
                else if (Name_errorFlag.Visible == true)
                {
                    Name_errorLbl.Visible = true;
                }
                else if (School_errorFlag.Visible == true)
                {
                    Department_errorLbl.Visible = true;
                }
                else if (Semester_errorFlag.Visible == true)
                {
                    Semester_errorLbl.Visible = true;
                }
                else if (Student_errorFlag.Visible == true)
                {
                    Students_errorLbl.Visible = true;
                }
                else
                {
                    Teacher_errorLbl.Visible = true;

                }
                _instForm.NotifyAlert("Fields marked with * are required", Form_Alert.enmType.Error);
            }
            else
            {
                UpdateACourseSection();
            }
        }

        private void UpdateACourseSection()
        {
            _courseSectionBEL.Id = this.Id;
            _courseSectionBEL.Name = Name_TB.Text;
            _courseSectionBEL.MarksPercentage = MarksPercentage_NUD.Value;
            _courseSectionBEL.StudentsPercentage = StudentsPercentage_NUD.Value;
            _courseSectionBEL.UseInOBE = UseInOBE_CB.Checked;
            _courseSectionBEL.SemesterId = Convert.ToInt32(Semester_CB.SelectedValue);
            _courseSectionBEL.DepartmentId = Convert.ToInt32(Department_CB.SelectedValue);
            _courseSectionBEL.Notes = Notes_RTB.Text;
            _courseSectionBEL.Section = Section_TB.Text;
            _courseSectionBEL.Finished = Finished_CB.Checked;
            _courseSectionBEL.CourseId = Convert.ToInt32(Course_CB.SelectedValue);
            _courseSectionBEL.GenderId = Convert.ToInt32(Gender_CB.SelectedValue);
            _courseSectionBEL.FacultyId = Convert.ToInt32(Teacher_CB.SelectedValue);

            _resultModel = _courseSectionBLL.UpdateCourseSectionBLL(_courseSectionBEL);
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

        private void UpdateCourseSection_Load(object sender, EventArgs e)
        {
            FillDropDowns();
            FillPreviousData();
            HideErrorLbls();
        }

        private void FillPreviousData()
        {
            var Ent = _courseSectionBLL.GetCourseSectionByIdBLL(Id);

            Course_CB.SelectedValue = Ent.CourseId;
            Department_CB.SelectedValue = Ent.DepartmentId;
            Name_TB.Text = Ent.Name;
            MarksPercentage_NUD.Value = Ent.MarksPercentage;
            Gender_CB.SelectedValue = Ent.GenderId;
            Section_TB.Text = Ent.Section;
            Finished_CB.Checked = Ent.Finished;
            UseInOBE_CB.Checked = Ent.UseInOBE;
            Semester_CB.SelectedValue = Ent.SemesterId;
            StudentsPercentage_NUD.Value = Ent.StudentsPercentage;
            Teacher_CB.SelectedValue = Ent.FacultyId;
        }


        private void Department_CB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            School_errorFlag.Visible = Department_CB.SelectedValue == null;
        }
    }
}
