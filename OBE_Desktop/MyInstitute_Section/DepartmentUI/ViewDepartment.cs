using System;
using System.Linq;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.DepartmentUI
{
    public partial class ViewDepartment : Form
    {
        private int iD;
        private string _fullImagePath;
        public DepartmentBLL _departmentBLL = new DepartmentBLL();
        public ViewDepartment()
        {
            InitializeComponent();
        }

        public ViewDepartment(int iD)
        {
            this.iD = iD;
            InitializeComponent();
        }

        private void ViewDepartment_Load(object sender, EventArgs e)
        {
            FillData(iD);
        }

        private void FillData(int iD)
        {
            var DeptEnt = _departmentBLL.GetDepartmentByIdBLL(iD);
            DepartmentName_TB.Text = DeptEnt.Name;
            ShortName_TB.Text = DeptEnt.ShortName;
            isActive_CB.Checked = DeptEnt.isActive;
            SchoolName_TB.Text = new School_BLL().GetSchoolByIdBLL(DeptEnt.SchoolId).Name;
            GpaMethod_TB.Text = new DepartmentBLL().GetGPAMethodsBLL().FirstOrDefault(g => g.Id == DeptEnt.GPAMethodId)
                .MethodName;
            AssessmentMethod_TB.Text = new DepartmentBLL().GetAssessmentMethodsBLL()
                .FirstOrDefault(a => a.Id == DeptEnt.AssessmentMethodId).MethodName;
            Attendance_TB.Text = DeptEnt.Attendance.ToString();
            ActivitiesInDays_TB.Text = DeptEnt.ActivitiesInDays.ToString();
            DeptVision_RTB.Text = DeptEnt.Vision;
            DeptMission_RTB.Text = DeptEnt.Mission;
            DeptLogo_PicBox.Image = DeptEnt.Depart_Logo;
            _fullImagePath = DeptEnt.Logo_Path;

        }
    }
}
