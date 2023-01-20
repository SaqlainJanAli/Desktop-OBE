using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Class_Students;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Class_Students;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    public partial class SelectStudents : Form
    {
        private readonly List<int> selectedStudentsIDs = new List<int>();
        private readonly List<EnrollStudent> enrollStudentListBEL = new List<EnrollStudent>();
        private int selectedBatchId;
        private int courseSecid;

        public SelectStudents()
        {
            InitializeComponent();
        }

        public SelectStudents(int selectedBatchId, int courseSecid)
        {
            this.selectedBatchId = selectedBatchId;
            this.courseSecid = courseSecid;
            InitializeComponent();
        }

        private void SelectStudents_Load(object sender, EventArgs e)
        {
            GetStudentListByBatchId();
        }

        private void GetStudentListByBatchId()
        {
            StudentUserDataGrid.AutoGenerateColumns = false;
            var StdUsers = new StudentUser_BLL().GetStudentusersByBatchIdBLL(selectedBatchId);
            StudentUserDataGrid.DataSource = StdUsers;


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in StudentUserDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        private void selectAllCheck_CB_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in StudentUserDataGrid.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckToAdd"];
                chk.Value = selectAllCheck_CB.Checked;
            }
        }

        private void StudentUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StudentUserDataGrid.Columns[e.ColumnIndex].Name == "checkToAdd")
            {
                if (e.ColumnIndex == 1)
                {
                    bool chk = Convert.ToBoolean(StudentUserDataGrid.Rows[e.RowIndex].Cells["CheckToAdd"].Value);
                    if (chk)
                    {
                        StudentUserDataGrid.Rows[e.RowIndex].Cells["CheckToAdd"].Value = false;
                    }
                    else
                    {
                        StudentUserDataGrid.Rows[e.RowIndex].Cells["CheckToAdd"].Value = true;
                    }
                }

            }
        }

        private void add_Btn_Click(object sender, EventArgs e)
        {
            AddStudentIDsInList();
            EnrollStudentIDs();
            //selectedStudentsIDs.Clear();
        }


        private void AddStudentIDsInList()
        {
            foreach (DataGridViewRow row in StudentUserDataGrid.Rows)
            {

                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["CheckToAdd"];
                bool checkSelected = Convert.ToBoolean(chk.Value);
                if (checkSelected)
                {
                    int ID = Convert.ToInt32(row.Cells["SerialNumber"].Value.ToString());
                    selectedStudentsIDs.Add(ID);
                }
            }
        }
        private void EnrollStudentIDs()
        {
            foreach (var selectedStudentId in selectedStudentsIDs)
            {
                EnrollStudent enrollStudentBEL = new EnrollStudent();
                enrollStudentBEL.CourseSectionId = courseSecid;
                enrollStudentBEL.StudentUserId = selectedStudentId;
                enrollStudentListBEL.Add(enrollStudentBEL);
            }

            ResultModel _resultModel = new ResultModel();
            Institute _instituteForm = new Institute();
            _resultModel = new EnrollStudent_BLL().SaveStudentsBLL(enrollStudentListBEL);

            //Clearing both lists to avoid ambiguity
            enrollStudentListBEL.Clear();
            selectedStudentsIDs.Clear();

            //Showing results
            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                this.Hide();
                new ClassStudents().GetClassStudents();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                _instituteForm.NotifyAlert("Trying to enroll one student multiple times", Form_Alert.enmType.Error);
            }

        }
    }
}
