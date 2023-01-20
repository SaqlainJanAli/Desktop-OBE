
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.CLOs
{
    public partial class CLOList : Form
    {
        private int _courseSecId;
        private CourseSection_BLL _courseSectionBll = new CourseSection_BLL();
        public CLOList()
        {
            InitializeComponent();
        }

        public CLOList(int id)
        {
            this._courseSecId = id;
            InitializeComponent();
        }

        //On load
        private void CLOList_Load(object sender, System.EventArgs e)
        {
            GetClosInCurrentCourseSection();
        }

        private void GetClosInCurrentCourseSection()
        {
            var clos = _courseSectionBll.GetCLOsOfCurrentCourseSectionBLL(_courseSecId);
            CLODataGrid.AutoGenerateColumns = false;
            CLODataGrid.DataSource = clos;

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in CLODataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }
    }
}
