using System;
using System.Drawing;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI
{
    public partial class CourseSection : Form
    {
        private Institute _instForm = new Institute();
        private Course_BLL _courseBLL = new Course_BLL();
        private Semester_BLL _semesterBLL = new Semester_BLL();
        private ResultModel _resultModel = new ResultModel();
        private User_BLL _userBLL = new User_BLL();
        private DepartmentBLL _deptBLL = new DepartmentBLL();
        private CourseSection_BLL _courseSectionBLL = new CourseSection_BLL();
        private OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection _courseSectionBEL = new OBE_BEL.MyInstitute_Section.CourseSectionBEL.CourseSection();
        private User loggedInUser;
        public CourseSection()
        {
            InitializeComponent();

        }

        public CourseSection(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }


        private void onCourseSectionLoad(object sender, EventArgs e)
        {
            FillDropDowns();
            HideErrorLbls();
            //GetCourseSections();
            SectionPrivacies();
        }
        private void SectionPrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (!_rolePrivacy.SectionCreate)
            {
                CourseSection_TabControl.TabPages.RemoveAt(0);
            }
            

            if (_rolePrivacy.SectionRead)
            {
                courseSectiosnDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                courseSectiosnDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.SectionUpdate)
            {
                courseSectiosnDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                courseSectiosnDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.SectionDelete)
            {
                courseSectiosnDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                courseSectiosnDataGrid.Columns["Delete_DGV"].Visible = false;
            }
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

            //Hide Filter Controls
            flagForFilter = false;
            FilterCourse_CB.Enabled = false;
            FilterName_TB.Enabled = false;
            FilterDepartment_CB.Enabled = false;
            FilterSem_CB.Enabled = false;

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
            Department_CB.DataSource = _deptBLL.GetDepartmentsBLL();
        }

        private void manage_courseSections_Btn_Click(object sender, EventArgs e)
        {
            //Courses courses = new Courses();
            //courses.Show();
            CourseSection_TabControl.SelectTab(1);
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

        private void School_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Department_CB == null)
            {
                School_errorFlag.Visible = true;

            }
            else
            {
                School_errorFlag.Visible = false;
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

        private void CreateCourseSection_Btn_Click(object sender, EventArgs e)
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
                CreateCourseSection();
            }
        }

        private void CreateCourseSection()
        {
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

            _resultModel = _courseSectionBLL.CreateCourseSectionBLL(_courseSectionBEL);
            if (_resultModel.Status == true)
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetCourseSections();
            }
            else
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void GetCourseSections()
        {
            courseSectiosnDataGrid.AutoGenerateColumns = false;
            courseSectiosnDataGrid.DataSource = _courseSectionBLL.GetCourseSectionBLL();

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in courseSectiosnDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterCourse_CB.DisplayMember = "Name";
            FilterCourse_CB.ValueMember = "SerialNumber";
            FilterCourse_CB.DataSource = _courseBLL.GetCoursesBLL();

            FilterDepartment_CB.DisplayMember = "Name";
            FilterDepartment_CB.ValueMember = "Id";
            FilterDepartment_CB.DataSource = _deptBLL.GetDepartmentsBLL();

            FilterSem_CB.ValueMember = "Name";
            FilterSem_CB.ValueMember = "Id";
            FilterSem_CB.DataSource = _semesterBLL.GetSemestersBLL();
        }
        private void OnDGVCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (courseSectiosnDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int Id = Convert.ToInt32(courseSectiosnDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                ViewCourseSection _ViewACourseSection = new ViewCourseSection(Id);
                _ViewACourseSection.Show();
            }
            if (courseSectiosnDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int Id = Convert.ToInt32(courseSectiosnDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                UpdateCourseSection _updateACourseSection = new UpdateCourseSection(Id);
                _updateACourseSection.Show();
                courseSectiosnDataGrid.Update();
            }
            if (courseSectiosnDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult _dgr = MessageBox.Show("Are You Sure to Delete This Course Section?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {
                    int Id = Convert.ToInt32(courseSectiosnDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                    DeleteCourseSection(Id);

                }
            }
        }

        private void DeleteCourseSection(int id)
        {
            _resultModel = _courseSectionBLL.DeleteCourseSectionBLL(id);
            if (_resultModel.Status == true)
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetCourseSections();
            }
            else
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void OnEnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterDGVByName();
            }
        }

        private void FilterDGVByName()
        {
            courseSectiosnDataGrid.DataSource = _courseSectionBLL.FilterByNameBLL(FilterName_TB.Text);


            foreach (DataGridViewRow dataGridViewRow in courseSectiosnDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterName_TB.Clear();

        }

        private void FilterCourse_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByCourseId();
        }

        private void FilterDGVByCourseId()
        {
            courseSectiosnDataGrid.DataSource = _courseSectionBLL.FilterByCourseIdBLL(Convert.ToInt32(FilterCourse_CB.SelectedValue));


            foreach (DataGridViewRow dataGridViewRow in courseSectiosnDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void FilterDepartment_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByDeptId();
        }

        private void FilterDGVByDeptId()
        {
            courseSectiosnDataGrid.DataSource = _courseSectionBLL.FilterByDeptIdBLL(Convert.ToInt32(FilterDepartment_CB.SelectedValue));

            foreach (DataGridViewRow dataGridViewRow in courseSectiosnDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

        }

        private void FilterSemester_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVBySemId();
        }

        private void FilterDGVBySemId()
        {
            courseSectiosnDataGrid.DataSource =
                _courseSectionBLL.FilterBySemBLL(Convert.ToInt32(FilterSem_CB.SelectedValue));


            foreach (DataGridViewRow dataGridViewRow in courseSectiosnDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        //Refresh Button Click
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetCourseSections();
        }

        private void CourseSection_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCourseSections();
        }

        //Apply Filter button
        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterCourse_CB.Enabled = true;
                FilterName_TB.Enabled = true;
                FilterDepartment_CB.Enabled = true;
                FilterSem_CB.Enabled = true;

                applyFilterBtn.BackColor = Color.Gray;
                //FilterInstitute_Lbl.Enabled = true;
                //FilterName_Lbl.Enabled = true;
            }
            else
            {
                flagForFilter = false;
                FilterCourse_CB.Enabled = false;
                FilterName_TB.Enabled = false;
                FilterDepartment_CB.Enabled = false;
                FilterSem_CB.Enabled = false;

                applyFilterBtn.BackColor = Color.White;

                GetCourseSections();
                //FilterInstitute_Lbl.Enabled = false;
                //FilterName_Lbl.Enabled = false;
            }
        }
    }
}

