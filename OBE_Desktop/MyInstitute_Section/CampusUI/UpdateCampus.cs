using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;
using OBE_BLL.MyInstitute_BLL;
using Institute = OBE_Desktop.MyInstitute_Section.InstituteUI.Institute;

namespace OBE_Desktop.MyInstitute_Section.CampusUI
{
    public partial class UpdateCampus : Form
    {
        //Fields
        private int Id;
        public string _fullImagePath;
        InstituteBLL _instituteBLL = new InstituteBLL();
        OBE_BEL.MyInstitute_Section.InstituteBEL.Institute _instituteBEL = new OBE_BEL.MyInstitute_Section.InstituteBEL.Institute();
        OBE_BEL.MyInstitute_Section.CampusesBEL.Campus _CampusBEL = new OBE_BEL.MyInstitute_Section.CampusesBEL.Campus();
        Campus_BLL _campusBLL = new Campus_BLL();
        ResultModel _resultModel = new ResultModel();
        Institute _instituteForm = new Institute();
        Campus _campusForm = new Campus();

        public UpdateCampus()
        {
            InitializeComponent();
        }
        public UpdateCampus(int id)
        {
            this.Id = id;
            InitializeComponent();
            CampusID_TB.Text = Id.ToString();

        }



        //OnLoad Campus
        private void UpdateCampus_Load(object sender, EventArgs e)
        {
            HideFewControls();
            GetInstitutes();
            GetCampusById(Id);
        }

        //Reading data
        private void HideFewControls()
        {
            University_errorLbl.Visible = false;
            Campus_errorLbl.Visible = false;
        }
        private void GetInstitutes()
        {
            var abc = _instituteBLL.GetInstitutesBLL();
            Institute_CB.DataSource = abc;
        }
        private void GetCities(int instituteId)
        {
            var instituteFound = _instituteBLL.GetInstituteByIdBLL(instituteId);
            var citiesOfThisRegion = _instituteBLL.GetCityByRegionId(instituteFound.RegionId);


            City_CB.DisplayMember = "Name";
            City_CB.ValueMember = "Id";
            City_CB.DataSource = citiesOfThisRegion;

        }
        private void GetCampusById(int ID)
        {
            var _campus = _campusBLL.GetCampusById(ID);

            Address_TB.Text = _campus.Address;
            Institute_CB.SelectedValue = _campus.University_Id;
            City_CB.SelectedValue = _campus.CityId;
            CampusName_TB.Text = _campus.Name;
            Notes_RTB.Text = _campus.Notes; 
            Header_PicBox.Image = _campus.HeaderImage;

        }

        //Button Clicks

        private void UploadImage_Btn_Click(object sender, EventArgs e)
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
                Bitmap newBitmap = new Bitmap(_openFileDialog.FileName);
                Header_PicBox.Image = newBitmap;
            }

            var currentDirectory = Directory.GetCurrentDirectory();
            var imageFolderPath = Path.Combine(currentDirectory, "Institutes", "Campuses", "HeaderImages");
            if (!Directory.Exists(imageFolderPath))
            {
                Directory.CreateDirectory(imageFolderPath);
            }

            string extension = Path.GetExtension(_openFileDialog.FileName);
            var UniqueImageName = Guid.NewGuid();
            var newImageName = UniqueImageName + extension;
            _fullImagePath = Path.Combine(imageFolderPath, newImageName);
            File.Copy(_openFileDialog.FileName, _fullImagePath);


        }

        //Update
        private void UpdateCampus_Btn_Click(object sender, EventArgs e)
        {
            if (University_errorflag.Visible == true || Campus_errorflag.Visible == true)
            {
                if (University_errorflag.Visible == true)
                {
                    University_errorLbl.Visible = true;

                }
                else
                {
                    Campus_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are mendatory", Form_Alert.enmType.Error);
            }
            else
            {
                UpdateCampuses(Id);
                _campusForm.GetCampuses();
                this.Close();
            }
           
        }
        public void UpdateCampuses(int id)
        {
            _CampusBEL.Id = Convert.ToInt32(CampusID_TB.Text);
            _CampusBEL.Name = CampusName_TB.Text;
            _CampusBEL.University_Id = Convert.ToInt32(Institute_CB.SelectedValue);
            _CampusBEL.CityId = Convert.ToInt32(City_CB.SelectedValue);
            _CampusBEL.Address = Address_TB.Text;
            _CampusBEL.Notes = Notes_RTB.Text;
            _CampusBEL.HeaderImage_Path = _fullImagePath;

            _resultModel = _campusBLL.UpdateCampusBLL(_CampusBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }


        //Text Box Changed Events
        private void University_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Institute_CB.SelectedValue == null)
            {
                University_errorflag.Visible = true;
            }
            else
            {
                GetCities((int)Institute_CB.SelectedValue);
                University_errorflag.Visible = false;
            }
        }
        private void CampusName_TB_TextChanged(object sender, EventArgs e)
        {
            if (CampusName_TB.Text == string.Empty)
            {
                Campus_errorflag.Visible = true;
            }
            else
            {
                Campus_errorflag.Visible = false;
            }
        }
    }
}
