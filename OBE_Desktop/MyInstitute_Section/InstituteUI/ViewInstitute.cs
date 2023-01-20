using System;
using System.Linq;
using System.Windows.Forms;
using OBE_BLL.MyInstitute_BLL;

namespace OBE_Desktop.MyInstitute_Section.InstituteUI
{
    public partial class ViewInstitute : Form
    {
        public ViewInstitute()
        {
            InitializeComponent();
        }
        public ViewInstitute(int Id)
        {
            this.id = Id;
            InitializeComponent();
        }

        public int id { get; private set; }
        InstituteBLL _instituteBLL = new InstituteBLL();
        OBE_BEL.MyInstitute_Section.InstituteBEL.Institute _instituteBEL = new OBE_BEL.MyInstitute_Section.InstituteBEL.Institute();
        private void ViewInstitute_Load(object sender, EventArgs e)
        {
           _instituteBEL  = _instituteBLL.GetInstituteByIdBLL(id);
            FillData(_instituteBEL);

        }
        public void FillData(OBE_BEL.MyInstitute_Section.InstituteBEL.Institute Inst)
        {
            if(Inst.LogoImage == null)
            {
                //When Institute has no logo
                Logo_Img.Image = Logo_Img.ErrorImage;
            }
            else
            {
                Logo_Img.Image = Inst.LogoImage;
            }
            Name_TB.Text = Inst.Name;
            IssuingAuth_TB.Text = Inst.IssuingAuthorityId.ToString();
            Type_TB.Text = Inst.InstituteTypeId.ToString();
            PLOCalcMethod_TB.Text = Inst.MethodId.ToString();
            Country_TB.Text = _instituteBLL.GetCountriesBLL().FirstOrDefault(c => c.Id == Inst.CountryId).Name;
            City_TB.Text = _instituteBLL.FilterRegionByCountryIdBLL(Inst.CountryId)
                .FirstOrDefault(r => r.Id == Inst.RegionId).Name;
            FullGPA_TB.Text = Inst.FullGPA.ToString();
            Attendance_TB.Text = Inst.AllowAttendance.ToString();
            Website_TB.Text = Inst.WebsiteURL;
            YearEstablished_TB.Text = Inst.YearEstablished.Year.ToString();
            Address_RTB.Text = Inst.Address;
            Notes_RTB.Text = Inst.Notes;
            Vision_RTB.Text = Inst.Vision;
            Mission_RTB.Text = Inst.Mission;


        }
   
    }
}
