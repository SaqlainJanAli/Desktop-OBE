using System;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    public partial class EnrollClassStudent : Form
    {
        private StudentUser_BLL _studentUserBll = new StudentUser_BLL();
        private ResultModel _resultModel = new ResultModel();
        private EnrollStudent _enrollStudentBEL = new EnrollStudent();
        Institute _instituteForm = new Institute();


        private int _courseSecid;
        public EnrollClassStudent()
        {
            InitializeComponent();
        }
        public EnrollClassStudent(int courseSecid)
        {
            this._courseSecid = courseSecid;
            InitializeComponent();
        }

        private void EnrollClassStudent_Load(object sender, EventArgs e)
        {
            GetStudents();
        }


        private void GetStudents()
        {
            Student_CB.DisplayMember = "Name";
            Student_CB.ValueMember = "Id";
            var StudUsers = _studentUserBll.GetStudentUsersBLL();
            Student_CB.DataSource = StudUsers;
        }

        private void saveStudent_Btn_Click(object sender, EventArgs e)
        {
            SaveEnrollStudent();
        }

        private void SaveEnrollStudent()
        {
            _enrollStudentBEL.CourseSectionId = _courseSecid;
            _enrollStudentBEL.StudentUserId = Convert.ToInt32(Student_CB.SelectedValue);

            _resultModel = new EnrollStudent_BLL().SaveStudentBLL(_enrollStudentBEL);
            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                Close();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                _instituteForm.NotifyAlert("Trying to enroll one student multiple times", Form_Alert.enmType.Error);

            }

        }
    }
}
