using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students;

namespace OBE_Desktop.Reports.SemsterGPA
{
    public partial class SemesterGPAHome : Form
    {
        private int _studentUserId;
        private int _semesterId;
        private int _classActid;
        private int activityTypeID;
        public SemesterGPAHome()
        {
            InitializeComponent();
        }

        private void CreateActivityResult_Load(object sender, EventArgs e)
        {
            getDepartments();
            //GetEnrolledStudents();
            if (Department_CB.SelectedValue != null)
            {
                GetEnrolledStudentsByDepartId((int)Department_CB.SelectedValue);
            }
            //GetEnrolledStudentsByDepartId((int)Department_CB.SelectedValue);
        }
        private void getDepartments()
        {
            Department_CB.DisplayMember = "Name";
            Department_CB.ValueMember = "Id";
            Department_CB.DataSource = new DepartmentBLL().GetDepartmentsBLL();
        }


  
      
        //Data Grid Cell Content Click
        private void ActivityResultDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int StudentId = Convert.ToInt32(EnrolledStdDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value);
            if (EnrolledStdDataGrid.Columns[e.ColumnIndex].Name == "ShowResult_DGV")
            {
                StudentSemesterGPA _semesterGpaForm = new StudentSemesterGPA(StudentId);
                _semesterGpaForm.Show();
            }
        }
    

        private void Department_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetEnrolledStudentsByDepartId((int)Department_CB.SelectedValue);
        }

        private void GetEnrolledStudentsByDepartId(int departId)
        {
            foreach (DataGridViewRow dataGridViewRow in EnrolledStdDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            EnrolledStdDataGrid.AutoGenerateColumns = false;
            EnrolledStdDataGrid.DataSource = new EnrollStudent_BLL().GetEnrolledStudentsByDepartIdBLL(departId);

            foreach (DataGridViewRow dataGridViewRow in EnrolledStdDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        //Refresh Button click
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetEnrolledStudentsByDepartId((int)Department_CB.SelectedValue);
        }
    }
}
