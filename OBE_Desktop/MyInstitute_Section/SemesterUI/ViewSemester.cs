using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.SemesterUI
{
    public partial class ViewSemester : Form
    {
        private int id;

        public ViewSemester()
        {
            InitializeComponent();
        }

        public ViewSemester(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ViewSemester_Load(object sender, System.EventArgs e)
        {
            GetSemesterById(id);
        }

        private void GetSemesterById(int id)
        {
            var SemEnt = new Semester_BLL().GetSemesterByIdBLL(id);
            SemeserID_TB.Text = SemEnt.Id.ToString();
            AcademicYear_TB.Text = SemEnt.AcademicYear;
            SemName_TB.Text = SemEnt.Name;
            startDate_TB.Text = SemEnt.StartDate.ToString();
            endDate_TB.Text = SemEnt.EndDate.ToString();
            Notes_RTB.Text = SemEnt.Notes;
            completed_TB.Text= (SemEnt.Completed) ? "Yes":"No";
            showResult_TB.Text= (SemEnt.ShowResultInGPA)?"Yes":"No";
        }
    }
}
