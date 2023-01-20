using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.DepartmentUI
{
    public partial class UpdateDepartment : Form
    {
        private int iD;
        private string _fullImagePath;
        ResultModel _resultModel = new ResultModel();
        Institute _instituteForm = new Institute();
        OBE_BEL.MyInstitute_Section.SchoolsBEL.School _school = new OBE_BEL.MyInstitute_Section.SchoolsBEL.School();
        OBE_BEL.MyInstitute_Section.DepartmentBEL.Department _departmentBEL = new OBE_BEL.MyInstitute_Section.DepartmentBEL.Department();
        School_BLL _schoolBLL = new School_BLL();
        DepartmentBLL _departmentBLL = new DepartmentBLL();
        Department _deptForm = new Department();
        public UpdateDepartment()
        {
            InitializeComponent();
        }

        public UpdateDepartment(int iD)
        {
            this.iD = iD;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UploadImage_Btn_Click(object sender, EventArgs e)
        {

            UploadImage();

        }
        public void UploadImage()
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Image Files (*.jpg ; *.jpeg; *.png; *.gif;)|*.jpg; *.jpeg; *png; *gif;";
            DialogResult dr = _openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Bitmap newBitmap = new Bitmap(_openFileDialog.FileName);
                DeptLogo_PicBox.Image = newBitmap;
            }

            var currentDirectory = Directory.GetCurrentDirectory();
            var imageFolderPath = Path.Combine(currentDirectory, "Institutes", "Campuses", "Schools", "Departments", "Logos");
            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }

            string extension = Path.GetExtension(_openFileDialog.FileName);
            var UniqueImageName = Guid.NewGuid();
            var newImageName = UniqueImageName + extension;
            _fullImagePath = Path.Combine(imageFolderPath, newImageName);
            File.Copy(_openFileDialog.FileName, _fullImagePath);

        }
        private void UpdateADepartment()
        {
            _departmentBEL.Id = Convert.ToInt32(DeptID_TB.Text);
            _departmentBEL.Name = DepartmentName_TB.Text;
            _departmentBEL.ShortName = ShortName_TB.Text;
            _departmentBEL.isActive = isActive_CB.Checked;
            _departmentBEL.AllowFaculty = AllowFaculty_CB.Checked;
            _departmentBEL.SchoolId = Convert.ToInt32(School_CB.SelectedValue);
            _departmentBEL.GPAMethodId = Convert.ToInt32(GpaMethod_CB.SelectedValue);
            _departmentBEL.Attendance = Convert.ToInt32(AttendancePercent_NUD.Value);
            _departmentBEL.AssessmentMethodId = Convert.ToInt32(AssessmentMethd_CB.SelectedValue);
            _departmentBEL.ActivitiesInDays = Convert.ToInt32(CourseActvtiesDays_NUD.Value);
            _departmentBEL.Logo_Path = _fullImagePath;
            _departmentBEL.Vision = DeptVision_RTB.Text;
            _departmentBEL.Mission = DeptMission_RTB.Text;


            _resultModel = _departmentBLL.UpdateDepartmentBLL(_departmentBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                _deptForm.GetDepartments();


            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void UpdateDepartment_Load(object sender, EventArgs e)
        {
            School_CB.DataSource = _schoolBLL.GetSchoolsBLL();
            GpaMethod_CB.DataSource = _departmentBLL.GetGPAMethodsBLL();
            AssessmentMethd_CB.DataSource=_departmentBLL.GetAssessmentMethodsBLL();
            AssessmentMethod_errorLbl.Visible = false;
            DeptName_errorLbl.Visible = false;
            GpaMethod_errorLbl.Visible = false;
            School_errorLbl.Visible = false;

            GetDeptById(iD);
        }

        private void GetDeptById(int iD)
        {
            var DeptEnt = _departmentBLL.GetDepartmentByIdBLL(iD);

            DeptID_TB.Text = DeptEnt.Id.ToString();
            DepartmentName_TB.Text = DeptEnt.Name;
            ShortName_TB.Text = DeptEnt.ShortName;
            isActive_CB.Checked = DeptEnt.isActive;
            AllowFaculty_CB.Checked = DeptEnt.AllowFaculty;
            School_CB.SelectedValue = DeptEnt.SchoolId;
            GpaMethod_CB.SelectedValue = DeptEnt.GPAMethodId;
            AssessmentMethd_CB.SelectedValue = DeptEnt.AssessmentMethodId;
            AttendancePercent_NUD.Text = DeptEnt.Attendance.ToString();
            CourseActvtiesDays_NUD.Text = DeptEnt.ActivitiesInDays.ToString();
            DeptVision_RTB.Text = DeptEnt.Vision;
            DeptMission_RTB.Text = DeptEnt.Mission;
            DeptLogo_PicBox.Image = DeptEnt.Depart_Logo;
            _fullImagePath = DeptEnt.Logo_Path;

        }

        private void UpdateDept_Btn_Click(object sender, EventArgs e)
        {
            if (DeptName_errorFlag.Visible == true || GpaMethod_errorFlag.Visible == true || AssessmentMethod_errorFlag.Visible == true || School_errorFlag.Visible == true)
            {
                if (DeptName_errorFlag.Visible == true)
                {
                    DeptName_errorLbl.Visible = true;
                }
                else if (GpaMethod_errorFlag.Visible == true)
                {
                    GpaMethod_errorLbl.Visible = true;
                }
                else if (AssessmentMethod_errorFlag.Visible == true)
                {
                    AssessmentMethod_errorLbl.Visible = true;
                }
                else
                {
                    School_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are mendatory", Form_Alert.enmType.Error);

            }
            else
            {
                UpdateADepartment();
            }
        }

        private void DepartmentName_TB_TextChanged(object sender, EventArgs e)
        {
            if (DepartmentName_TB.Text == string.Empty)
            {
                DeptName_errorFlag.Visible = true;

            }
            else
            {
                DeptName_errorFlag.Visible = false;
            }
        }

        private void School_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (School_CB.Text == string.Empty)
            {
                School_errorFlag.Visible = true;
            }
            else
            {
                School_errorFlag.Visible = false;
            }
        }

        private void GpaMethod_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GpaMethod_CB.Text == string.Empty)
            {
                GpaMethod_errorFlag.Visible = true;
            }
            else
            {
                GpaMethod_errorFlag.Visible = false;
            }
        }

        private void AssessmentMethd_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AssessmentMethd_CB.Text == string.Empty)
            {
                AssessmentMethod_errorFlag.Visible = true;

            }
            else
            {
                AssessmentMethod_errorFlag.Visible = false;
            }
        }

    }
}
