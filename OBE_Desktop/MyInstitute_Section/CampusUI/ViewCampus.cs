using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.CampusUI
{
    public partial class ViewCampus : Form
    {
        private int iD;
        private Campus_BLL _campusBLL = new Campus_BLL();
        public ViewCampus()
        {
            InitializeComponent();
        }
        public ViewCampus(int id)
        {
            this.iD = id;
            InitializeComponent();
        }

        private void ViewCampus_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void FillData()
        {
            var CampusEnt = _campusBLL.GetCampusById(iD);
            if(CampusEnt.HeaderImage == null)
            {
                Header_PicBox.Image = Header_PicBox.ErrorImage;
            }
            else
            {
                Header_PicBox.Image = CampusEnt.HeaderImage;
            }


            CampusID_TB.Text = CampusEnt.Id.ToString();
            CampusName_TB.Text = CampusEnt.Name;

            UniversityName_TB.Text = new InstituteBLL().GetInstituteByIdBLL(CampusEnt.University_Id).Name;
            //City_TB.Text = CampusEnt.CityId.ToString();
            Address_TB.Text = CampusEnt.Address;
            Notes_RTB.Text = CampusEnt.Notes;
        }
    }
}
