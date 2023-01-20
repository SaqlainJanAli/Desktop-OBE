using System.Windows.Forms;
using OBE_BLL.OBESection_BLL;

namespace OBE_Desktop.OBE_Section.PEO_UI
{
    public partial class ViewPEO : Form
    {
        private int id;
        private PEO_BLL _peoBll = new PEO_BLL();

        public ViewPEO()
        {
            InitializeComponent();
        }

        public ViewPEO(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ViewPEO_Load(object sender, System.EventArgs e)
        {
            FillPrevData();
        }

        private void FillPrevData()
        {
            var _PEO = _peoBll.getPeoByIdBLL(id);
            Code_TB.Text = _PEO.Code;
            Description_RTB.Text = _PEO.Description;
            Elements_RTB.Text = _PEO.Elements;
            Strategies_RTB.Text = _PEO.Strategies;
            Active_TB.Text = (_PEO.isActive == false) ? "No" : "Yes";
            MapMission_TB.Text = (_PEO.MapInstituteMission == false) ? "No" : "Yes";
            MapVision_TB.Text = (_PEO.MapInstituteVision == false) ? "No" : "Yes";
        }


    }
}
