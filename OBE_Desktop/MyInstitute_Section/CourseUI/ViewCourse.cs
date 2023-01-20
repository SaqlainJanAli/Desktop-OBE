using System;
using System.Linq;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.CourseUI
{
    public partial class ViewCourse : Form
    {
        private int id;
        private Course_BLL _courseBLL = new Course_BLL();
        
        public ViewCourse()
        {
            InitializeComponent();
        }

        public ViewCourse(int id)
        {
            this.id = id;
            InitializeComponent();

        }

        private void ViewCourse_Load(object sender, EventArgs e)
        {
            HideFewControls();
            FillExistingData();
        }

        private void HideFewControls()
        {
            ProgramBatch_01_TB.Visible = false;
            ProgramBatch_02_TB.Visible = false;
            ProgramBatch_03_TB.Visible = false;

            Type_01_TB.Visible = false;
            Type_02_TB.Visible = false;
            Type_03_TB.Visible = false;

            TaughtInSem_01_TB.Visible = false;
            TaughtInSem_02_TB.Visible = false;
            TaughtInSem_03_TB.Visible = false;
        }

        private void FillExistingData()
        {

            var programBatchBLL = new ProgramBatch_BLL();
            var programBLL = new Program_BLL();


            var Ent = _courseBLL.GetCourseByIdBLL(id);
            
            CourseName_TB.Text = Ent.Name;
            CourseCode_TB.Text = Ent.Code;
            SupervisorBased_CB.Checked = Ent.SupervisorBased;
            Active_CB.Checked = Ent.Active;
            TheoryCreditHours_TB.Text= Ent.TheoryCreditHours.ToString();
            LabCreditHours_TB.Text = Ent.LabCreditHours.ToString();
            DeliveryFormat_TB.Text = _courseBLL.GetDeliveryFormatsBLL()
                .FirstOrDefault(df => df.Id == Ent.DeliveryFormatId).Name;
            BaseType_TB.Text= _courseBLL.GetBaseTypesBLL().FirstOrDefault(df => df.Id == Ent.BaseTypeId).Name;
            CourseLevel_TB.Text = _courseBLL.GetCourseLevelsBLL().FirstOrDefault(cl => cl.Id == Ent.CourseLevelId)
                .LevelName;
            KnowledgeArea_TB.Text= _courseBLL.GetKnowledgeAreasBLL().FirstOrDefault(cl => cl.Id == Ent.KnowledgeAreaId).Name;
            KnowledgeProfile_TB.Text= _courseBLL.GetKnowledgeProfilesBLL().FirstOrDefault(kp => kp.Id == Ent.KnowledgeProfileId)
                .Name;
            Department_TB.Text = new DepartmentBLL().GetDepartmentByIdBLL(Ent.DepartmentId).Name;
            if (Ent.PreReqCourseId != null)
            {
                Prerequisite_TB.Text= Ent.PreReqCourseId.ToString();

            }
            var Ent_PC = _courseBLL.getProgramCourseBLL(id);
            int countBatches = Ent_PC.Count;
            foreach (var item in Ent_PC)
            {
                if (countBatches == 1)
                {
                    ProgramBatch_TB.Text = programBatchBLL.GetProgramBatchByIdBLL(item.ProgramBatchId).ProgramBatchName;
                    Type_TB.Text = programBLL.GetSemesterTypesBLL().FirstOrDefault(st=>st.Id == item.SemesterTypeId).Name;
                    TaughtInSem_TB.Text = item.TaughInSemester.ToString();
                }
                else if (countBatches == 2)
                {
                    ProgramBatch_01_TB.Visible = true;
                    Type_01_TB.Visible = true;
                    TaughtInSem_01_TB.Visible = true;
                    ProgramBatch_01_TB.Text = programBatchBLL.GetProgramBatchByIdBLL(item.ProgramBatchId).ProgramBatchName;
                    Type_01_TB.Text = programBLL.GetSemesterTypesBLL().FirstOrDefault(st => st.Id == item.SemesterTypeId).Name;
                    TaughtInSem_01_TB.Text = item.TaughInSemester.ToString();
                }
                else if (countBatches == 3)
                {
                    ProgramBatch_02_TB.Visible = true;
                    Type_02_TB.Visible = true;
                    TaughtInSem_02_TB.Visible = true;

                    ProgramBatch_02_TB.Text = programBatchBLL.GetProgramBatchByIdBLL(item.ProgramBatchId).ProgramBatchName;
                    Type_02_TB.Text = programBLL.GetSemesterTypesBLL().FirstOrDefault(st => st.Id == item.SemesterTypeId).Name;
                    TaughtInSem_02_TB.Text = item.TaughInSemester.ToString();

                }
                else if (countBatches == 4)
                {
                    ProgramBatch_03_TB.Visible = true;
                    Type_03_TB.Visible = true;
                    TaughtInSem_03_TB.Visible = true;

                    ProgramBatch_03_TB.Text = programBatchBLL.GetProgramBatchByIdBLL(item.ProgramBatchId).ProgramBatchName;
                    Type_03_TB.Text = programBLL.GetSemesterTypesBLL().FirstOrDefault(st => st.Id == item.SemesterTypeId).Name;
                    TaughtInSem_03_TB.Text = item.TaughInSemester.ToString();

                }

                countBatches--;

            }
            

        }
    }
}
