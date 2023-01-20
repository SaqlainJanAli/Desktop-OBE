using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.MyInstitute_BLL;
using static OBE_Desktop.Form_Alert;

namespace OBE_Desktop.MyInstitute_Section.InstituteUI
{
    public partial class UpdateInstituteForm : Form
    {
        private readonly int Id;
        private string _fullImagePath;
        private InstituteBLL _instituteBLL = new InstituteBLL();
        private OBE_BEL.MyInstitute_Section.InstituteBEL.Institute _instituteBEL = new OBE_BEL.MyInstitute_Section.InstituteBEL.Institute();
        private ResultModel _resultModel = new ResultModel();
        private Institute _instituteForm = new Institute();
        private int waitToFilter = 0;

        //Constructor
        public UpdateInstituteForm()
        {
            InitializeComponent();
        }
        public UpdateInstituteForm(int ID)
        {
            this.Id = ID;
            InitializeComponent();
            InstituteID_TB.Text = Id.ToString();
        }

        //On Load
        private void UpdateInstituteForm_Load(object sender, EventArgs e)
        {
            GetAuthorities();
            GetInstituteType();
            GetCountries();
            GetPLOMethods();

            HideErrorLabels();

            GetInstituteById(Id);
            if (Logo_Img != null)
            {
                LogoPath_Flag.Visible = false;
            }
        }

        private void HideErrorLabels()
        {
            //Error Lbls
            Logo_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;
            IssuingAuth_errorLbl.Visible = false;
            Type_errorLbl.Visible = false;
            PLOCalcmethod_errorLbl.Visible = false;
            Country_errorLbl.Visible = false;
            Region_errorLbl.Visible = false;
            City_errorLbl.Visible = false;
            Website_errorLbl.Visible = false;
            Address_errorLbl.Visible = false;
            Vision_errorLbl.Visible = false;
            Mission_errorLbl.Visible = false;
        }
  
        public void GetAuthorities()
        {
            IssuingAuth_CB.DataSource = _instituteBLL.GetAuthoritiesBLL();

        }
        public void GetInstituteType()
        {
            InstituteType_CB.DataSource = _instituteBLL.GetInstituteTypesBLL();
        }
        public void GetCountries()
        {
            Country_CB.DataSource = _instituteBLL.GetCountriesBLL();
        }
        private void FilterRegionByCountryId(int CountryId)
        {
            Region_CB.DisplayMember = "Name";
            Region_CB.ValueMember = "Id";
            Region_CB.DataSource = _instituteBLL.FilterRegionByCountryIdBLL(CountryId);
        }
        private void FilterCityByRegionId(int RegionId)
        {
            City_CB.DisplayMember = "Name";
            City_CB.ValueMember = "Id";
            City_CB.DataSource = _instituteBLL.FilterCityByRegionIdBLL(RegionId);
        }
        public void GetPLOMethods()
        {
            PLOCalMethod_CB.DataSource = _instituteBLL.GetPLOMethodsBLL();
        }



        //Get Institute By Id
        public void GetInstituteById(int id)
        {
            var Inst = _instituteBLL.GetInstituteByIdBLL(id);
            InstituteName_TB.Text = Inst.Name;
            IssuingAuth_CB.SelectedValue = Inst.IssuingAuthorityId;
            InstituteType_CB.SelectedValue = Inst.InstituteTypeId;
            PLOCalMethod_CB.SelectedValue = Inst.MethodId;
            Country_CB.SelectedValue = Inst.CountryId;
            Region_CB.SelectedValue = Inst.RegionId;
            City_CB.SelectedValue = Inst.CityId;
            FullGPA_NUD.Value = Inst.FullGPA;
            AllowAttendance_NUD.Value = Inst.AllowAttendance;
            PublicSector_CB.Checked = Inst.PublicSector;
            YearEstablished_DTP.Value = Inst.YearEstablished;
            Website_TB.Text = Inst.WebsiteURL;
            Notes_RTB.Text = Inst.Notes;
            Address_TB.Text = Inst.Address;
            Vision_RTB.Text = Inst.Vision;
            Mission_RTB.Text = Inst.Mission;
            _fullImagePath = Inst.Logo_Path;
            Logo_Img.Image = Inst.LogoImage;
        }

    

        //Button Clicks
        private void UpdateInstitute_Btn_Click(object sender, EventArgs e)
        {
            if (Name_flag.Visible == true || IssuingAuth_flag.Visible == true || Type_flag.Visible == true || PLOCalcMethod_flag.Visible == true || Country_flag.Visible == true || City_flag.Visible == true || Website_flag.Visible == true || Vision_flag.Visible == true || Mission_flag.Visible == true || Address_flag.Visible == true || LogoPath_Flag.Visible == true)
            {
                if (Name_flag.Visible == true)
                {
                    Name_errorLbl.Visible = true;
                }
                else if (IssuingAuth_flag.Visible == true)
                {
                    IssuingAuth_errorLbl.Visible = true;
                }
                else if (Type_flag.Visible == true)
                {
                    Type_errorLbl.Visible = true;
                }
                else if (PLOCalcMethod_flag.Visible == true)
                {
                    PLOCalcmethod_errorLbl.Visible = true;
                }
                else if (Country_flag.Visible == true)
                {
                    Country_errorLbl.Visible = true;
                }
                else if (City_flag.Visible == true)
                {
                    City_errorLbl.Visible = true;
                }
                else if (Vision_flag.Visible == true)
                {
                    Vision_errorLbl.Visible = true;
                }
                else if (Mission_flag.Visible == true)
                {
                    Mission_errorLbl.Visible = true;
                }
                else if (Address_flag.Visible == true)
                {
                    Address_errorLbl.Visible = true;
                }
                else
                {
                    Logo_errorLbl.Visible = true;
                }


                _instituteForm.NotifyAlert("Fields marked with * are mendatory", enmType.Error);
            }
            else
            {
                UpdateInstitute(Id);
                this.Close();


            }

        }

        //Update
        private void UpdateInstitute(int id)
        {
            _instituteBEL.Id = Convert.ToInt32(InstituteID_TB.Text);
            _instituteBEL.Name = InstituteName_TB.Text;
            _instituteBEL.IssuingAuthorityId = Convert.ToInt32(IssuingAuth_CB.SelectedValue.ToString());
            _instituteBEL.InstituteTypeId = Convert.ToInt32(InstituteType_CB.SelectedValue.ToString());
            _instituteBEL.MethodId = Convert.ToInt32(PLOCalMethod_CB.SelectedValue.ToString());
            _instituteBEL.CountryId = Convert.ToInt32(Country_CB.SelectedValue.ToString());
            _instituteBEL.CityId = Convert.ToInt32(City_CB.SelectedValue.ToString());
            _instituteBEL.FullGPA = Convert.ToInt32(FullGPA_NUD.Text);
            _instituteBEL.AllowAttendance = Convert.ToInt32(AllowAttendance_NUD.Text);
            _instituteBEL.PublicSector = PublicSector_CB.Checked;
            _instituteBEL.YearEstablished = YearEstablished_DTP.Value;
            _instituteBEL.WebsiteURL = Website_TB.Text;
            _instituteBEL.Notes = Notes_RTB.Text;
            _instituteBEL.Address = Address_TB.Text;
            _instituteBEL.Vision = Vision_RTB.Text;
            _instituteBEL.Mission = Mission_RTB.Text;
            _instituteBEL.Logo_Path = _fullImagePath;
            if (InstituteID_TB.Text != null)
            {
                _resultModel = _instituteBLL.UpdateInstituteBLL(_instituteBEL);
                if (_resultModel.Status == true)
                {
                    //MessageBox.Show(_resultModel.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _instituteForm.NotifyAlert(_resultModel.Message, enmType.Success);

                }
                else
                {
                    //MessageBox.Show(_resultModel.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _instituteForm.NotifyAlert(_resultModel.Message, enmType.Error);

                }

            }


        }

        private void UploadImg_Btn_Click (object sender, EventArgs e)
        {
            UploadImage();
        }

        private void UploadImage()
        {
            OpenFileDialog _openFileDialog = new OpenFileDialog();
            _openFileDialog.Filter = "Image Files (*.jpg ; *.jpeg; *.png; *.gif;)|*.jpg; *.jpeg; *png; *gif;";
            DialogResult dr = _openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //MessageBox.Show("Image Selected Successfully", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bitmap newBitmap = new Bitmap(_openFileDialog.FileName);
                Logo_Img.Image = newBitmap;
            }

            var currentDirectory = Directory.GetCurrentDirectory();
            var imageFolderPath = Path.Combine(currentDirectory, "Institutes", "Logos");
            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }

            string extension = Path.GetExtension(_openFileDialog.FileName);
            var UniqueImageName = Guid.NewGuid();
            var newImageName = UniqueImageName + extension;
            _fullImagePath = Path.Combine(imageFolderPath, newImageName);
            File.Copy(_openFileDialog.FileName, _fullImagePath);

            LogoPath_Flag.Visible = false;

        }


        //Text Box Changed Events
        private void InstituteName_TB_TextChanged (object sender, EventArgs e)
        {
            if (InstituteName_TB.Text == string.Empty)
            {
                Name_flag.Visible = true;
            }
            else
            {

                Name_flag.Visible = false;
            }
        }

        private void IssuingAuth_CB_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (IssuingAuth_CB.SelectedItem == null)
            {
                //IssuingAuth_errorLbl.Visible = true;
                IssuingAuth_flag.Visible = true;
            }
            else
            {

                IssuingAuth_flag.Visible = false;
            }

        }

        private void InstituteType_CB_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (InstituteType_CB.SelectedItem == null)
            {

                Type_flag.Visible = true;
            }
            else
            {

                Type_flag.Visible = false;
            }
        }

        private void PLOCalMethod_CB_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (PLOCalMethod_CB.SelectedItem == null)
            {
                PLOCalcMethod_flag.Visible = true;
            }
            else
            {
                PLOCalcMethod_flag.Visible = false;

            }
        }

        private void Country_CB_SelectedIndexChanged (object sender, EventArgs e)
        {

            if (Country_CB.SelectedValue == null)
            {

                Country_flag.Visible = true;
            }
            else
            {
                Country_flag.Visible = false;
                if (waitToFilter != 0)
                {
                    FilterRegionByCountryId(Convert.ToInt32(Country_CB.SelectedValue));
                }

                waitToFilter++;

            }
        }
        private void Region_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Region_CB.SelectedValue == null)
            {
                Region_errorFlag.Visible = true;
            }
            else
            {
                Region_errorFlag.Visible = false;
                if (waitToFilter != 0 || waitToFilter != 1)
                {
                    FilterCityByRegionId(Convert.ToInt32(Region_CB.SelectedValue));
                }

                waitToFilter++;
            }
        }


        private void City_CB_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (City_CB.SelectedItem == null)
            {

                City_flag.Visible = true;
            }
            else
            {

                City_flag.Visible = false;
            }
        }

        private void Website_TB_TextChanged (object sender, EventArgs e)
        {
            if (Website_TB.Text == string.Empty)
            {

                Website_flag.Visible = true;
            }
            else
            {

                Website_flag.Visible = false;
            }
        }

        private void Address_TB_TextChanged (object sender, EventArgs e)
        {
            if (Address_TB.Text == string.Empty)
            {
                Address_errorLbl.Visible = true;
            }
            else
            {

                Address_flag.Visible = false;
            }
        }

        private void Vision_RTB_TextChanged(object sender, EventArgs e)
        {
            if (Vision_RTB.Text == String.Empty)
            {
                Vision_flag.Visible = true;
            }
            else
            {

                Vision_flag.Visible = false;
            }
        }

        private void Mission_RTB_TextChanged (object sender, EventArgs e)
        {
            if (Mission_RTB.Text == String.Empty)
            {
                Mission_flag.Visible = true;
            }
            else
            {
                Mission_flag.Visible = false;
            }
        }

      
    }
}
