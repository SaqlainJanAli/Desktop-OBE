using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BEL.MyInstitute_Section.CourseBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseUI
{
    public partial class Courses : Form
    {
        private Program_BLL _programBLL = new Program_BLL();
        private DepartmentBLL _departBLL = new DepartmentBLL();
        private Institute _instituteForm = new Institute();
        private ProgramBatch_BLL _programBatchBLL = new ProgramBatch_BLL();
        private ProgramCourse _programCourseBEL = new ProgramCourse();
        private ResultModel _resultModel = new ResultModel();
        private User_BLL _userBLL = new User_BLL();
        Course_BLL _courseBLL = new Course_BLL();
        Course _courseBEL = new Course();
        private User loggedInUser;
        private int countBatches = 1;
        public Courses()
        {
            InitializeComponent();

        }

        public Courses(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }


        private void onCoursesLoad(object sender, EventArgs e)
        {
            FillDropDowns();
            HideErrorLbls();
            HideFewControls();
            HandleCoursePrivacies();
        }

        private void HideFewControls()
        {
            ProgramBatch_01_CB.Visible = false;
            ProgramBatch_02_CB.Visible = false;
            ProgramBatch_03_CB.Visible = false;

            Type_01_CB.Visible = false;
            Type_02_CB.Visible = false;
            Type_03_CB.Visible = false;

            TaughtInSemester_01_NUD.Visible = false;
            TaughtInSemester_02_NUD.Visible = false;
            TaughtInSemester_03_NUD.Visible = false;

            //Filter Controls
            flagForFilter = false;
            FilterCourseCode_TB.Enabled = false;
            FilterCourseName_CB.Enabled = false;
            FilterDept_CB.Enabled = false;
        }

        private void HandleCoursePrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);

            if (!_rolePrivacy.CourseCreate)
            {
                Courses_TabControl.TabPages.RemoveAt(0);
            }


            if (_rolePrivacy.CourseRead)
            {
                coursesDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                coursesDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.CourseUpdate)
            {
                coursesDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                coursesDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.CourseDelete)
            {
                coursesDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                coursesDataGrid.Columns["Delete_DGV"].Visible = false;
            }
        }
        private void FillDropDowns()
        {
            GetKnowledgeProfiles();
            GetKnowledgeAreas();
            GetDepartments();
            GetProgramBatches();
            GetSemesterTypes();
            GetDeliveryFormats();
            GetCourseLevels();
            //GetCourses();
            GetCoursesForPrerequisites();
            GetBaseTypes();
        }

        private void GetBaseTypes()
        {
            BaseType_CB.DisplayMember = "Name";
            BaseType_CB.ValueMember = "Id";
            BaseType_CB.DataSource = _courseBLL.GetBaseTypesBLL();
        }

        private void HideErrorLbls()
        {
            CourseCode_errorLbl.Visible = false;
            CourseName_errorLbl.Visible = false;
            Department_errorLbl.Visible = false;
            ProgramBatch_errorLbl.Visible = false;
            ProgramBatch_01_errorLbl.Visible = false;
            ProgramBatch_02_errorLbl.Visible = false;
            ProgramBatch_03_errorLbl.Visible = false;

            TaughtInSem_errorLbl.Visible = false;
            TaughtInSem_01_errorLbl.Visible = false;
            TaughtInSem_02_errorLbl.Visible = false;
            TaughtInSem_03_errorLbl.Visible = false;
            TheoryCreditHour_errorLbl.Visible = false;

            PreReq_Lbl.Enabled = false;
            PrerequisiteCourse_CB.Enabled = false;
        }

        private void GetCoursesForPrerequisites()
        {
            PrerequisiteCourse_CB.DisplayMember = "Name";
            PrerequisiteCourse_CB.ValueMember = "Id";
            PrerequisiteCourse_CB.DataSource = _courseBLL.GetCoursesBLL();

        }

        private void GetCourses()
        {
            coursesDataGrid.AutoGenerateColumns = false;
            coursesDataGrid.DataSource = _courseBLL.GetCoursesBLL();


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in coursesDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterDept_CB.DisplayMember = "Name";
            FilterDept_CB.ValueMember = "Id";
            FilterDept_CB.DataSource = _departBLL.GetDepartmentsBLL();

            FilterCourseName_CB.DisplayMember = "Name";
            FilterCourseName_CB.ValueMember = "SerialNumber";
            FilterCourseName_CB.DataSource = _courseBLL.GetCoursesBLL();

        }

        private void GetCourseLevels()
        {
            CourseLevel_CB.DisplayMember = "LevelName";
            CourseLevel_CB.ValueMember = "Id";
            CourseLevel_CB.DataSource = _courseBLL.GetCourseLevelsBLL();
        }

        private void GetDeliveryFormats()
        {
            DeliveryFormat_CB.DisplayMember = "Name";
            DeliveryFormat_CB.ValueMember = "Id";
            DeliveryFormat_CB.DataSource = _courseBLL.GetDeliveryFormatsBLL();
        }

        private void GetSemesterTypes()
        {
            Type_CB.DisplayMember = "Name";
            Type_CB.ValueMember = "Id";
            Type_CB.DataSource = _programBLL.GetSemesterTypesBLL();

            Type_01_CB.DisplayMember = "Name";
            Type_01_CB.ValueMember = "Id";
            Type_01_CB.DataSource = _programBLL.GetSemesterTypesBLL();

            Type_02_CB.DisplayMember = "Name";
            Type_02_CB.ValueMember = "Id";
            Type_02_CB.DataSource = _programBLL.GetSemesterTypesBLL();

            Type_03_CB.DisplayMember = "Name";
            Type_03_CB.ValueMember = "Id";
            Type_03_CB.DataSource = _programBLL.GetSemesterTypesBLL();

        }

        private void GetProgramBatches()
        {
            ProgramBatch_CB.DisplayMember = "ProgramBatch";
            ProgramBatch_CB.ValueMember = "SerialNumber";
            ProgramBatch_CB.DataSource = _programBatchBLL.GetProgramBatchesBLL();

            ProgramBatch_01_CB.DisplayMember = "ProgramBatch";
            ProgramBatch_01_CB.ValueMember = "SerialNumber";
            ProgramBatch_01_CB.DataSource = _programBatchBLL.GetProgramBatchesBLL();

            ProgramBatch_02_CB.DisplayMember = "ProgramBatch";
            ProgramBatch_02_CB.ValueMember = "SerialNumber";
            ProgramBatch_02_CB.DataSource = _programBatchBLL.GetProgramBatchesBLL();

            ProgramBatch_03_CB.DisplayMember = "ProgramBatch";
            ProgramBatch_03_CB.ValueMember = "SerialNumber";
            ProgramBatch_03_CB.DataSource = _programBatchBLL.GetProgramBatchesBLL();

        }

        private void GetDepartments()
        {
            Department_CB.DisplayMember = "Name";
            Department_CB.ValueMember = "Id";
            Department_CB.DataSource = _departBLL.GetDepartmentsBLL();

        }

        private void GetKnowledgeAreas()
        {
            KnowledgeArea_CB.DisplayMember = "Name";
            KnowledgeArea_CB.ValueMember = "Id";
            KnowledgeArea_CB.DataSource = _courseBLL.GetKnowledgeAreasBLL();
        }

        private void GetKnowledgeProfiles()
        {
            KnowledgeProfile_CB.DisplayMember = "Name";
            KnowledgeProfile_CB.ValueMember = "Id";
            KnowledgeProfile_CB.DataSource = _courseBLL.GetKnowledgeProfilesBLL();
        }

        private void ManageCourses_Btn_Click(object sender, EventArgs e)
        {
            Courses_TabControl.SelectTab(1);
        }

        private void CreateCourse_Btn_Click(object sender, EventArgs e)
        {
            if (CourseCode_errorFlag.Visible || CourseName_errorFlag.Visible || Department_errorFlag.Visible || ProgramBatch_errorFlag.Visible || TaughtInSem_errorFlag.Visible || Theory_errorFlag.Visible)
            {
                if (CourseName_errorFlag.Visible)
                {
                    CourseName_errorLbl.Visible = true;
                }
                else if (CourseCode_errorFlag.Visible == true)
                {
                    CourseCode_errorLbl.Visible = true;

                }
                else if (Department_errorFlag.Visible == true)
                {
                    Department_errorLbl.Visible = true;
                }
                else if (ProgramBatch_errorFlag.Visible == true)
                {
                    ProgramBatch_errorLbl.Visible = true;

                }
                else if (TaughtInSem_errorFlag.Visible == true)
                {
                    TaughtInSem_errorLbl.Visible = true;

                }
                else
                {
                    TheoryCreditHour_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are mandatory", Form_Alert.enmType.Error);
            }
            else
            {
                CreateCourse();
            }
        }

        private void CreateCourse()

        {


            _courseBEL.Active = Active_CB.Checked;
            _courseBEL.Code = CourseCode_TB.Text;
            _courseBEL.Name = CourseName_TB.Text;
            _courseBEL.TheoryCreditHours = Convert.ToInt32(TheoryCreditHours_NUD.Value);
            _courseBEL.LabCreditHours = Convert.ToInt32(LabCreditHours_NUD.Value);
            _courseBEL.BaseTypeId = Convert.ToInt32(BaseType_CB.SelectedValue);
            _courseBEL.CourseLevelId = Convert.ToInt32(CourseLevel_CB.SelectedValue);
            if (PrerequisiteCourse_CB.SelectedValue != null && PreReq_CB.Checked)
            {
                _courseBEL.PreReqCourseId = Convert.ToInt32(PrerequisiteCourse_CB.SelectedValue);
            }
            _courseBEL.DepartmentId = Convert.ToInt32(Department_CB.SelectedValue);
            _courseBEL.DeliveryFormatId = Convert.ToInt32(DeliveryFormat_CB.SelectedValue);
            _courseBEL.KnowledgeAreaId = Convert.ToInt32(KnowledgeArea_CB.SelectedValue);
            _courseBEL.KnowledgeProfileId = Convert.ToInt32(KnowledgeArea_CB.SelectedValue);
            _courseBEL.SupervisorBased = SupervisorBased_CB.Checked;
            _resultModel = _courseBLL.CreateCourseBLL(_courseBEL);
            if (_resultModel.Status == true)
            {
                int CourseID = Convert.ToInt32(_resultModel.Data);
                List<ProgramCourse> _newList = new List<ProgramCourse>();
                for (int j = 0; j < countBatches; j++)
                {
                    if (j == 0)
                    {
                        ProgramCourse _programCourse = new ProgramCourse();
                        _programCourse.ProgramBatchId = Convert.ToInt32(ProgramBatch_CB.SelectedValue);
                        _programCourse.SemesterTypeId = Convert.ToInt32(Type_CB.SelectedValue);
                        _programCourse.TaughInSemester = Convert.ToInt32(TaughtInSemester_NUD.Value);
                        _programCourse.CourseId = CourseID;
                        _newList.Add(_programCourse);
                    }
                    if (j == 1)
                    {
                        ProgramCourse _programCourse = new ProgramCourse();
                        _programCourse.ProgramBatchId = Convert.ToInt32(ProgramBatch_01_CB.SelectedValue);
                        _programCourse.SemesterTypeId = Convert.ToInt32(Type_01_CB.SelectedValue);
                        _programCourse.TaughInSemester = Convert.ToInt32(TaughtInSemester_01_NUD.Value);
                        _programCourse.CourseId = CourseID;
                        _newList.Add(_programCourse);
                    }
                    if (j == 2)
                    {
                        ProgramCourse _programCourse = new ProgramCourse();
                        _programCourse.ProgramBatchId = Convert.ToInt32(ProgramBatch_02_CB.SelectedValue);
                        _programCourse.SemesterTypeId = Convert.ToInt32(Type_02_CB.SelectedValue);
                        _programCourse.TaughInSemester = Convert.ToInt32(TaughtInSemester_02_NUD.Value);
                        _programCourse.CourseId = CourseID;
                        _newList.Add(_programCourse);
                    }
                    if (j == 3)
                    {
                        ProgramCourse _PCBEL = new ProgramCourse();
                        _PCBEL.ProgramBatchId = Convert.ToInt32(ProgramBatch_03_CB.SelectedValue);
                        _PCBEL.SemesterTypeId = Convert.ToInt32(Type_03_CB.SelectedValue);
                        _PCBEL.TaughInSemester = Convert.ToInt32(TaughtInSemester_03_NUD.Value);
                        _PCBEL.CourseId = CourseID;
                        _newList.Add(_PCBEL);
                    }
                }
                _resultModel = _courseBLL.CreateProgramCoursesBLL(_newList);
                if (_resultModel.Status)
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    Courses_TabControl.SelectTab(1);
                    GetCourses();
                }
                else
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                }
                _newList.Clear();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);

            }



        }

        private void CourseCode_TB_TextChanged(object sender, EventArgs e)
        {
            if (CourseCode_TB.Text == string.Empty)
            {
                CourseCode_errorFlag.Visible = true;

            }
            else
            {
                CourseCode_errorFlag.Visible = false;
            }
        }

        private void CourseName_TB_TextChanged(object sender, EventArgs e)
        {
            if (CourseCode_TB.Text == string.Empty)
            {

                CourseName_errorFlag.Visible = true;
            }
            else
            {
                CourseName_errorFlag.Visible = false;
            }
        }

        private void TheoryCreditHours_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (TheoryCreditHours_NUD.Value == 0)
            {
                Theory_errorFlag.Visible = true;
            }
            else
            {
                Theory_errorFlag.Visible = false;

            }
        }

        private void Department_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Department_CB.Text == string.Empty)
            {
                Department_errorFlag.Visible = true;

            }
            else
            {
                Department_errorFlag.Visible = false;
            }
        }

        private void ProgramBatch_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProgramBatch_CB.Text == string.Empty)
            {

                ProgramBatch_errorFlag.Visible = true;
            }
            else
            {
                ProgramBatch_errorFlag.Visible = false;
            }
        }

        private void TaughtInSemester_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (TaughtInSemester_NUD.Value == 0)
            {

                TaughtInSem_errorFlag.Visible = true;

            }
            else
            {
                TaughtInSem_errorFlag.Visible = false;
            }
        }


        //Add Program Btn

        private void AddProgram_Btn_Click(object sender, EventArgs e)
        {

            if (countBatches < 4)
            {
                switch (countBatches)
                {
                    case 1:
                        ProgramBatch_01_CB.Visible = true;
                        Type_01_CB.Visible = true;
                        TaughtInSemester_01_NUD.Visible = true;
                        break;
                    case 2:
                        ProgramBatch_02_CB.Visible = true;
                        Type_02_CB.Visible = true;
                        TaughtInSemester_02_NUD.Visible = true;
                        break;
                    case 3:
                        ProgramBatch_03_CB.Visible = true;
                        Type_03_CB.Visible = true;
                        TaughtInSemester_03_NUD.Visible = true;
                        break;
                }


                countBatches++;


            }

        }
        private void DeleteProgram_Btn_Click(object sender, EventArgs e)
        {
            if (countBatches > 1)
            {


                switch (countBatches)
                {
                    case 2:
                        ProgramBatch_01_CB.Visible = false;
                        ProgramBatch_01_errorLbl.Visible = false;
                        Type_01_CB.Visible = false;
                        TaughtInSemester_01_NUD.Visible = false;
                        TaughtInSem_01_errorLbl.Visible = false;
                        break;
                    case 3:
                        ProgramBatch_02_CB.Visible = false;
                        ProgramBatch_02_errorLbl.Visible = false;
                        Type_02_CB.Visible = false;
                        TaughtInSemester_02_NUD.Visible = false;
                        TaughtInSem_02_errorLbl.Visible = false;
                        break;
                    case 4:
                        ProgramBatch_03_CB.Visible = false;
                        ProgramBatch_03_errorLbl.Visible = false;
                        Type_03_CB.Visible = false;
                        TaughtInSemester_03_NUD.Visible = false;
                        TaughtInSem_03_errorLbl.Visible = false;
                        break;
                }
                countBatches--;
            }
        }



        private void Type_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnDGVCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (coursesDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int Id = Convert.ToInt32(coursesDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                ViewCourse _ViewACourse = new ViewCourse(Id);
                _ViewACourse.Show();
            }
            if (coursesDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int Id = Convert.ToInt32(coursesDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                UpdateCourse _updateACourse = new UpdateCourse(Id);
                _updateACourse.Show();
                coursesDataGrid.Update();
            }
            if (coursesDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult _dgr = MessageBox.Show("Are You Sure to Delete This Course?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (_dgr == DialogResult.Yes)
                {

                    int Id = Convert.ToInt32(coursesDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
                    DeleteCourse(Id);

                }
            }
        }

        private void DeleteCourse(int id)
        {
            _resultModel = _courseBLL.DeleteCourseBLL(id);
            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetCourses();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void onEnterKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterDGVByCode();
            }

        }

        private void FilterDGVByCode()
        {
            coursesDataGrid.DataSource = _courseBLL.FilterDGVByCodeBLL(FilterCourseCode_TB.Text);


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in coursesDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterCourseCode_TB.Clear();
        }
        private void FilterCourseName_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByName();
        }

        private void FilterDGVByName()
        {
            coursesDataGrid.DataSource = _courseBLL.FilterDGVByNameBLL(Convert.ToInt32(FilterCourseName_CB.SelectedValue));


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in coursesDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        private void FilterDept_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByDept();
        }

        private void FilterDGVByDept()
        {
            coursesDataGrid.DataSource = _courseBLL.FilterDGVByDeptBLL(Convert.ToInt32(FilterDept_CB.SelectedValue));



            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in coursesDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        private void TaughtInSemester_01_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (TaughtInSemester_01_NUD.Value == 0)
            {

                TaughtInSem_errorFlag.Visible = true;
                TaughtInSem_01_errorLbl.Visible = true;
            }
            else
            {
                TaughtInSem_errorFlag.Visible = false;
                TaughtInSem_01_errorLbl.Visible = false;
            }
        }

        private void TaughtInSemester_02_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (TaughtInSemester_02_NUD.Value == 0)
            {

                TaughtInSem_errorFlag.Visible = true;
                TaughtInSem_02_errorLbl.Visible = true;

            }
            else
            {
                TaughtInSem_errorFlag.Visible = false;
                TaughtInSem_02_errorLbl.Visible = true;
            }
        }

        private void TaughtInSemester_03_NUD_ValueChanged(object sender, EventArgs e)
        {
            if (TaughtInSemester_03_NUD.Value == 0)
            {

                TaughtInSem_errorFlag.Visible = true;
                TaughtInSem_03_errorLbl.Visible = true;
            }
            else
            {
                TaughtInSem_errorFlag.Visible = false;
                TaughtInSem_03_errorLbl.Visible = true;
            }
        }

        private void PreReq_CB_OnChange(object sender, EventArgs e)
        {
            if (PreReq_CB.Checked)
            {
                PreReq_Lbl.Enabled = true;
                PrerequisiteCourse_CB.Enabled = true;
            }
            else
            {
                PreReq_Lbl.Enabled = false;
                PrerequisiteCourse_CB.Enabled = false;
            }
        }

        //Refresh DGV btn click

        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetCourses();
        }

        private void Courses_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCourses();
        }
        //Apply Filter button

        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterCourseCode_TB.Enabled = true;
                FilterCourseName_CB.Enabled = true;
                FilterDept_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterCourseCode_TB.Enabled = false;
                FilterCourseName_CB.Enabled = false;
                FilterDept_CB.Enabled = false;


                applyFilter_Btn.BackColor = Color.White;
                GetCourses();
            }
        }
    }
}

