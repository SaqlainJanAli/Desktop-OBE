using System;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.SchoolUI
{
    public partial class ViewSchool : Form
    {
        private int iD;
        private School_BLL _schoolBLL = new School_BLL();
        public ViewSchool()
        {
            InitializeComponent();
        }

        public ViewSchool(int iD)
        {
            this.iD = iD;
            InitializeComponent();
        }

        private void ViewSchool_Load(object sender, EventArgs e)
        {



            FillData();
        }

        private void FillData()
        {
            var _schoolEnt = _schoolBLL.GetSchoolByIdBLL(iD);
            if (_schoolEnt.SchoolIcon == null)
            {
                
                SchoolIcon_PicBox.Image = SchoolIcon_PicBox.ErrorImage;
            }
            else
            {
                SchoolIcon_PicBox.Image = _schoolEnt.SchoolIcon;
            }

            Campus_TB.Text = new Campus_BLL().GetCampusById(_schoolEnt.CampusId).Name;
            SchoolName_TB.Text = _schoolEnt.Name;
            //City_TB.Text = _schoolEnt.CityId.ToString();
            Address_RTB.Text = _schoolEnt.Address;
            Notes_RTB.Text = _schoolEnt.Notes;
            //SchoolIcon_PicBox.Image = _schoolEnt.SchoolIcon;
            //SchoolIcon_PicBox.ErrorImage = Resources.download1;

        }
    }
}
