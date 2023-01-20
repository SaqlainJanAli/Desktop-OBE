using OBE_BLL.AssessmentSection_BLL;
using System.Windows.Forms;

namespace OBE_Desktop.AssessmentMethod.Activity
{
    public partial class ViewActivity : Form
    {
        private int id;
        //private int _courseSecId;

        public ViewActivity()
        {
            InitializeComponent();
        }

        public ViewActivity(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        //public ViewActivity(int id, int _courseSecId) : this(id)
        //{
        //    this._courseSecId = _courseSecId;
        //    InitializeComponent();
        //}

        private void ViewActivity_Load(object sender, System.EventArgs e)
        {
            GetActivityById();
        }

        private void GetActivityById()
        {
            ID_TB.Text = id.ToString();
            var existingActivity = new Activity_BLL().GetActivityByIdBLL(id);
            Name_TB.Text = existingActivity.Name;
            ShortName_TB.Text = existingActivity.ShortName;
        }
    }
}
