using System;
using System.Windows.Forms;
using OBE_BLL.OBESection_BLL;

namespace OBE_Desktop.OBE_Section.PLO_UI
{
    public partial class ViewPLO : Form
    {
        //Fields
        private int iD;
        private PLO_BLL _ploBll = new PLO_BLL();


        public ViewPLO()
        {
            InitializeComponent();
        }

        public ViewPLO(int iD)
        {
            this.iD = iD;
            InitializeComponent();
        }

        //On Load Form
        private void ViewPLO_Load(object sender, EventArgs e)
        {
            FillPrevData();
        }
        private void FillPrevData()
        {
            var _ploBel = _ploBll.GetPLOByIdBLL(iD);
            ID_TB.Text = _ploBel.Id.ToString();
            Code_TB.Text = _ploBel.Code;
            Name_TB.Text = _ploBel.Name;
            Description_RTB.Text = _ploBel.Description;
            Strategies_RTB.Text = _ploBel.Strategies;
            Active_TB.Text = (_ploBel.isActive == false)?"No":"Yes";
            WA_Code_TB.Text = _ploBel.WACode;

        }
    }
}
