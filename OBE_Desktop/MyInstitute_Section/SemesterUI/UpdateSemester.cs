using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.SemesterUI
{
    public partial class UpdateSemester : Form
    {
        private int id;
        Institute _instituteForm = new Institute();
        OBE_BEL.MyInstitute_Section.SemesterBEL.Semester _semesterBEL = new OBE_BEL.MyInstitute_Section.SemesterBEL.Semester();
        Semester_BLL _semesterBLL = new Semester_BLL();
        ResultModel _resultModel = new ResultModel();
        Semester _semesterForm = new Semester();
        public UpdateSemester()
        {
            InitializeComponent();
        }

        public UpdateSemester(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void AcademicYear_TB_TextChanged(object sender, EventArgs e)
        {
            if (AcademicYear_TB.Text == string.Empty)
            {
                AcademicYear_errorFlag.Visible = true;
            }
            else
            {
                AcademicYear_errorFlag.Visible = false;
            }
        }

        private void SemName_TB_TextChanged(object sender, EventArgs e)
        {
            if (SemName_TB.Text == string.Empty)
            {
                Name_errorFlag.Visible = true;
            }
            else
            {
                Name_errorFlag.Visible = false;
            }
        }

        private void UpdateSemester_Btn_Click(object sender, EventArgs e)
        {
            if (AcademicYear_errorFlag.Visible == true || Name_errorFlag.Visible == true)
            {
                if (AcademicYear_errorFlag.Visible == true)
                {
                    AcademicYear_errorLbl.Visible = true;

                }
                else
                {
                    Name_errorLbl.Visible = true;
                }
            }
            else
            {
                UpdateASemester();
                _semesterForm.GetSemesters();
            }
        }

        private void UpdateASemester()
        {
            _semesterBEL.Id = Convert.ToInt32(SemeserID_TB.Text);
            _semesterBEL.AcademicYear = AcademicYear_TB.Text;
            _semesterBEL.Name = SemName_TB.Text;
            _semesterBEL.StartDate = StartDate_DTP.Value;
            _semesterBEL.EndDate = EndDate_DTP.Value;
            _semesterBEL.Notes = Notes_RTB.Text;
            _semesterBEL.Completed = Completed_CB.Checked;
            _semesterBEL.ShowResultInGPA = ShowResult_CB.Checked;

            _resultModel = _semesterBLL.UpdateSemesterBLL(_semesterBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                this.Close();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void UpdateSemester_Load(object sender, EventArgs e)
        {
            AcademicYear_errorLbl.Visible = true;
            Name_errorLbl.Visible = true;
            SemeserID_TB.Text = id.ToString();
            GetSemesterById(id);

        }

        private void GetSemesterById(int id)
        {
            var SemEnt = _semesterBLL.GetSemesterByIdBLL(id);

            SemeserID_TB.Text = SemEnt.Id.ToString();
            AcademicYear_TB.Text = SemEnt.AcademicYear;
            SemName_TB.Text = SemEnt.Name;
            StartDate_DTP.Text = SemEnt.StartDate.ToString();
            EndDate_DTP.Text = SemEnt.EndDate.ToString();
            Notes_RTB.Text = SemEnt.Notes;
            Completed_CB.Checked = SemEnt.Completed;
            ShowResult_CB.Checked = SemEnt.ShowResultInGPA;
        }
    }
}
