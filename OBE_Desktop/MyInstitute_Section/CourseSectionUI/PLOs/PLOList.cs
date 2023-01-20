using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.PLOs
{
    public partial class PLOList : Form
    {
        private int courseSecId;
        public PLOList()
        {
            InitializeComponent();
        }
        public PLOList(int Id)
        {
            courseSecId = Id;
            InitializeComponent();
        }

        private void PLOList_Load(object sender, EventArgs e)
        {
            //PLODataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            PLODataGrid.ScrollBars = ScrollBars.Both;
            GetPLOs();

        }

        private void GetPLOs()
        {
            PLODataGrid.AutoGenerateColumns = false;
            PLODataGrid.DataSource = new CourseSection_BLL().GetPLOsInCurrentCourseSecBLL(courseSecId);

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in PLODataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }
    }
}
