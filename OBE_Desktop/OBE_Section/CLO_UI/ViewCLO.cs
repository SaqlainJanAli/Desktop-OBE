using System;
using System.Windows.Forms;
using OBE_BLL.OBESection_BLL;

namespace OBE_Desktop.OBE_Section.CLO_UI
{
    public partial class ViewCLO : Form
    {
        //Fields
        private int iD;
        CLO_BLL _cloBll = new CLO_BLL();

        //Constructor
        public ViewCLO()
        {
            InitializeComponent();
        }

        public ViewCLO(int iD)
        {
            this.iD = iD;
            InitializeComponent();
        }

        //OnLoad
        private void ViewCLO_Load(object sender, EventArgs e)
        {
            FillPrevData();
        }
        private void FillPrevData()
        {
            var _cloById = _cloBll.getCLOByIdBLL(iD);
            Code_TB.Text = _cloById.Code;
            Description_RTB.Text = _cloById.Description;
            Active_TB.Text= (_cloById.isActive == false) ? "No" : "Yes";
            ID_TB.Text = iD.ToString();

        }

    }

}
