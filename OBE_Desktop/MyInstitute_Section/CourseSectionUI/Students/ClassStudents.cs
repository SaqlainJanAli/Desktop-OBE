using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    public partial class ClassStudents : Form
    {
        private int CourseSecid;

        public ClassStudents()
        {
            InitializeComponent();
        }

        public ClassStudents(int id)
        {
            this.CourseSecid = id;
            InitializeComponent();

        }

        private void ClassStudents_Load(object sender, EventArgs e)
        {
            GetClassStudents();
        }

        public void GetClassStudents()
        {
            ClassStudentDataGrid.AutoGenerateColumns = false;
            ClassStudentDataGrid.DataSource = new ClassStudent_BLL().GetStudentsBySecIdBLL(CourseSecid);

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in ClassStudentDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        private void importFromProgramBatches_Btn_Click(object sender, EventArgs e)
        {
            ImportFromProgramBatch _fromProgramBatch = new ImportFromProgramBatch(CourseSecid);
            _fromProgramBatch.Show();
        }

        private void enrollStudents_Btn_Click(object sender, EventArgs e)
        {
            EnrollClassStudent enrollStudent = new EnrollClassStudent(CourseSecid);
            enrollStudent.Show();
        }

        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetClassStudents();
        }
    }
}
