using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseBEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseUI
{
    public partial class UpdateCourse : Form
    {
        private int id;
        private Program_BLL _programBLL = new Program_BLL();
        private DepartmentBLL _departBLL = new DepartmentBLL();
        private Institute _instituteForm = new Institute();
        private ProgramBatch_BLL _programBatchBLL = new ProgramBatch_BLL();
        private ProgramCourse _programCourseBEL = new ProgramCourse();
        private ResultModel _resultModel = new ResultModel();
        private Course_BLL _courseBLL = new Course_BLL();
        private Course _courseBEL = new Course();
        private int countBatches = 1;
        public UpdateCourse()
        {
            InitializeComponent();
        }

        public UpdateCourse(int id)
        {
            this.id = id;
            InitializeComponent();

        }

        //Filling Data in Drop Downs
        private void FillDropDowns()
        {
            GetKnowledgeProfiles();
            GetKnowledgeAreas();
            GetDepartments();
            GetProgramBatches();
            GetSemesterTypes();
            GetDeliveryFormats();
            GetCourseLevels();
            GetCoursesForPrerequisites();
            GetBaseTypes();
        }
        private void GetBaseTypes()
        {
            BaseType_CB.DisplayMember = "Name";
            BaseType_CB.ValueMember = "Id";
            BaseType_CB.DataSource = _courseBLL.GetBaseTypesBLL();
        }
        private void GetCoursesForPrerequisites()
        {
            PrerequisiteCourse_CB.DisplayMember = "Name";
            PrerequisiteCourse_CB.ValueMember = "Id";
            PrerequisiteCourse_CB.DataSource = _courseBLL.GetCoursesForPrereqBLL();

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


        //Load Program
        private void UpdateCourse_Load(object sender, EventArgs e)
        {
            FillDropDowns();
            HideErrorLbls();
            HideFewControls();
            FillExistingData();
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
        }
        private void FillExistingData()
        {
            var Ent = _courseBLL.GetCourseByIdBLL(id);
            CourseId_TB.Text = Ent.Id.ToString();
            CourseName_TB.Text = Ent.Name;
            CourseCode_TB.Text = Ent.Code;
            SupervisorBased_CB.Checked = Ent.SupervisorBased;
            Active_CB.Checked = Ent.Active;
            TheoryCreditHours_NUD.Value = Ent.TheoryCreditHours;
            LabCreditHours_NUD.Value = Ent.LabCreditHours;
            DeliveryFormat_CB.SelectedValue = Ent.DeliveryFormatId;
            BaseType_CB.SelectedValue = Ent.BaseTypeId;
            CourseLevel_CB.SelectedValue = Ent.CourseLevelId;
            KnowledgeArea_CB.SelectedValue = Ent.KnowledgeAreaId;
            KnowledgeProfile_CB.SelectedValue = Ent.KnowledgeProfileId;
            Department_CB.SelectedValue = Ent.DepartmentId;
            if (Ent.PreReqCourseId != null)
            {
                PrerequisiteCourse_CB.SelectedValue = Ent.PreReqCourseId;

            }

            var Ent_PC = _courseBLL.getProgramCourseBLL(id);
            countBatches = Ent_PC.Count;
            for (int i = 0;i<Ent_PC.Count;i++)
            {
                switch (i)
                {
                    case 0:
                        PId_TB.Text = Ent_PC[i].Id.ToString();
                        ProgramBatch_CB.SelectedValue = Ent_PC[i].ProgramBatchId;
                        Type_CB.SelectedValue = Ent_PC[i].SemesterTypeId;
                        TaughtInSemester_NUD.Text = Ent_PC[i].TaughInSemester.ToString();

                        break;
                    case 1:
                        ProgramBatch_01_CB.Visible = true;
                        Type_01_CB.Visible = true;
                        TaughtInSemester_01_NUD.Visible = true;

                        PId01_TB.Text = Ent_PC[i].Id.ToString();
                        ProgramBatch_01_CB.SelectedValue = Ent_PC[i].ProgramBatchId;
                        Type_01_CB.SelectedValue = Ent_PC[i].SemesterTypeId;
                        TaughtInSemester_01_NUD.Text = Ent_PC[i].TaughInSemester.ToString();

                        break;
                    case 2:
                        ProgramBatch_02_CB.Visible = true;
                        Type_02_CB.Visible = true;
                        TaughtInSemester_02_NUD.Visible = true;

                        PId02_TB.Text = Ent_PC[i].Id.ToString();
                        ProgramBatch_02_CB.SelectedValue = Ent_PC[i].ProgramBatchId;
                        Type_02_CB.SelectedValue = Ent_PC[i].SemesterTypeId;
                        TaughtInSemester_02_NUD.Text = Ent_PC[i].TaughInSemester.ToString();
                        break;
                    case 3:
                        ProgramBatch_03_CB.Visible = true;
                        Type_03_CB.Visible = true;
                        TaughtInSemester_03_NUD.Visible = true;

                        PId03_TB.Text = Ent_PC[i].Id.ToString();
                        ProgramBatch_03_CB.SelectedValue = Ent_PC[i].ProgramBatchId;
                        Type_03_CB.SelectedValue = Ent_PC[i].SemesterTypeId;
                        TaughtInSemester_03_NUD.Text = Ent_PC[i].TaughInSemester.ToString();

                        break;
                }

            }

        }
        private void HideErrorLbls()
        {
            PreReq_CB.Checked = false;
            PrerequisiteCourse_CB.Enabled = false;

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
        }


        //Button Click Events
        private void AddProgram_Btn_Click(object sender, EventArgs e)
        {

            if (countBatches < 4)
            {
                if (countBatches == 1)
                {
                    ProgramBatch_01_CB.Visible = true;
                    Type_01_CB.Visible = true;
                    TaughtInSemester_01_NUD.Visible = true;

                }
                else if (countBatches == 2)
                {
                    ProgramBatch_02_CB.Visible = true;
                    Type_02_CB.Visible = true;
                    TaughtInSemester_02_NUD.Visible = true;

                }
                else
                {
                    ProgramBatch_03_CB.Visible = true;
                    Type_03_CB.Visible = true;
                    TaughtInSemester_03_NUD.Visible = true;

                }

                countBatches++;


            }

        }
        private void DeleteProgram_Btn_Click(object sender, EventArgs e)
        {
            if (countBatches > 1)
            {
                if (countBatches == 2)
                {
                    ProgramBatch_01_CB.Visible = false;
                    ProgramBatch_01_errorLbl.Visible = false;
                    Type_01_CB.Visible = false;
                    TaughtInSemester_01_NUD.Visible = false;
                    TaughtInSem_01_errorLbl.Visible = false;
                }
                else if (countBatches == 3)
                {
                    ProgramBatch_02_CB.Visible = false;
                    ProgramBatch_02_errorLbl.Visible = false;
                    Type_02_CB.Visible = false;
                    TaughtInSemester_02_NUD.Visible = false;
                    TaughtInSem_02_errorLbl.Visible = false;
                }
                else if (countBatches == 4)
                {
                    ProgramBatch_03_CB.Visible = false;
                    ProgramBatch_03_errorLbl.Visible = false;
                    Type_03_CB.Visible = false;
                    TaughtInSemester_03_NUD.Visible = false;
                    TaughtInSem_03_errorLbl.Visible = false;
                }

                countBatches--;


            }
        }
        private void UpdateCourse_Btn_Click(object sender, EventArgs e)
        {
            if (CourseCode_errorFlag.Visible || CourseName_errorFlag.Visible || Department_errorFlag.Visible || ProgramBatch_errorFlag.Visible || TaughtInSem_errorFlag.Visible || Theory_errorFlag.Visible)
            {
                if (CourseName_errorFlag.Visible)
                {
                    CourseName_errorLbl.Visible = true;
                }
                else if (CourseCode_errorFlag.Visible)
                {
                    CourseCode_errorLbl.Visible = true;
                }
                else if (Department_errorFlag.Visible)
                {
                    Department_errorLbl.Visible = true;
                }
                else if (ProgramBatch_errorFlag.Visible)
                {
                    ProgramBatch_errorLbl.Visible = true;

                }
                else if (TaughtInSem_errorFlag.Visible)
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
                UpdateACourse();
            }
        }
        private void UpdateACourse()

        {
            _courseBEL.Id = id;
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
                        ProgramCourse _programCourseBEL = new ProgramCourse();

                        if (PId_TB.Text != string.Empty)
                        {
                            _programCourseBEL.Id = Convert.ToInt32(PId_TB.Text);
                        }
                        _programCourseBEL.ProgramBatchId = Convert.ToInt32(ProgramBatch_CB.SelectedValue);
                        _programCourseBEL.SemesterTypeId = Convert.ToInt32(Type_CB.SelectedValue);
                        _programCourseBEL.TaughInSemester = Convert.ToInt32(TaughtInSemester_NUD.Value);
                        _programCourseBEL.CourseId = CourseID;
                        _newList.Add(_programCourseBEL);
                    }
                    if (j == 1)
                    {
                        ProgramCourse _programCourseBEL = new ProgramCourse();
                        if (PId01_TB.Text != string.Empty)
                        {
                            _programCourseBEL.Id = Convert.ToInt32(PId01_TB.Text);
                        }
                        _programCourseBEL.ProgramBatchId = Convert.ToInt32(ProgramBatch_01_CB.SelectedValue);
                        _programCourseBEL.SemesterTypeId = Convert.ToInt32(Type_01_CB.SelectedValue);
                        _programCourseBEL.TaughInSemester = Convert.ToInt32(TaughtInSemester_01_NUD.Value);
                        _programCourseBEL.CourseId = CourseID;
                        _newList.Add(_programCourseBEL);
                    }
                    if (j == 2)
                    {
                        ProgramCourse _programCourseBEL = new ProgramCourse();
                        if (PId02_TB.Text != string.Empty)
                        {
                            _programCourseBEL.Id = Convert.ToInt32(PId02_TB.Text);
                        }
                        _programCourseBEL.ProgramBatchId = Convert.ToInt32(ProgramBatch_02_CB.SelectedValue);
                        _programCourseBEL.SemesterTypeId = Convert.ToInt32(Type_02_CB.SelectedValue);
                        _programCourseBEL.TaughInSemester = Convert.ToInt32(TaughtInSemester_02_NUD.Value);
                        _programCourseBEL.CourseId = CourseID;
                        _newList.Add(_programCourseBEL);
                    }
                    if (j == 3)
                    {
                        ProgramCourse _programCourseBEL = new ProgramCourse();
                        if (PId02_TB.Text != string.Empty)
                        {
                            _programCourseBEL.Id = Convert.ToInt32(PId03_TB.Text);
                        }
                        _programCourseBEL.ProgramBatchId = Convert.ToInt32(ProgramBatch_03_CB.SelectedValue);
                        _programCourseBEL.SemesterTypeId = Convert.ToInt32(Type_03_CB.SelectedValue);
                        _programCourseBEL.TaughInSemester = Convert.ToInt32(TaughtInSemester_03_NUD.Value);
                        _programCourseBEL.CourseId = CourseID;
                        _newList.Add(_programCourseBEL);
                    }
                }
                _resultModel = _courseBLL.UpdateProgramCoursesBLL(_newList);
                if (_resultModel.Status)
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);

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



        //Text Changed Events
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
            if (CourseName_TB.Text == string.Empty)
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
            if (Department_CB == null)
            {
                Department_errorFlag.Visible = true;

            }
            else
            {
                Department_errorFlag.Visible = false;
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

        private void PreReq_CB_OnChange(object sender, EventArgs e)
        {
            PrerequisiteCourse_CB.Enabled = PreReq_CB.Checked;
        }
    }
}
