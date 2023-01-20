using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.CampusUI;
using Institute = OBE_Desktop.MyInstitute_Section.InstituteUI.Institute;

namespace OBE_Desktop.MyInstitute_Section.SchoolUI
{
    public partial class UpdateSchool : Form
    {

        //Fields
        private int iD;
        private string _fullImagePath;
        InstituteBLL _instituteBLL = new InstituteBLL();
        Campus_BLL _campusBLL = new Campus_BLL();
        ResultModel _resultModel = new ResultModel();
        Institute _instituteForm = new Institute();
        OBE_BEL.MyInstitute_Section.SchoolsBEL.School _school = new OBE_BEL.MyInstitute_Section.SchoolsBEL.School();
        School_BLL _schoolBLL = new School_BLL();

        //Constructors
        public UpdateSchool()
        {
            InitializeComponent();
        }
        public UpdateSchool(int iD)
        {
            this.iD = iD;
            InitializeComponent();
        }


        //ON load
        private void UpdateSchool_Load(object sender, EventArgs e)
        {

            FillDropDowns();
            HideErrorLbls();
            GetSchoolById(iD);
        }
        private void HideErrorLbls()
        {
            //Error Labels
            Campus_errorLbl.Visible = false;
            SchoolName_errorLbl.Visible = false;
        }

        //Read
        private void FillDropDowns()
        {
            Campus_CB.DataSource = _campusBLL.GetCampusesBLL();
        }
        private void GetCities(int campusId)
        {
            var campusFound = _campusBLL.GetCampusById(campusId);
            var instituteFound = _instituteBLL.GetInstituteByIdBLL(campusFound.University_Id);
            var citiesOfThisRegion = _instituteBLL.GetCityByRegionId(instituteFound.RegionId);

            City_CB.DisplayMember = "Name";
            City_CB.ValueMember = "Id";
            City_CB.DataSource = citiesOfThisRegion;
        }
        private void GetSchoolById(int iD)
        {
            var _schoolEnt = _schoolBLL.GetSchoolByIdBLL(iD);
            SchoolId_TB.Text = _schoolEnt.Id.ToString();
            SchoolName_TB.Text = _schoolEnt.Name;
            Campus_CB.SelectedValue = _schoolEnt.CampusId;
            City_CB.SelectedValue = _schoolEnt.CityId;
            Address_TB.Text = _schoolEnt.Address;
            Notes_RTB.Text = _schoolEnt.Notes;
            SchoolIcon_PicBox.Image = _schoolEnt.SchoolIcon;

        }


        //Text Changed Events
        private void Campus_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Campus_CB.Text == string.Empty)
            {
                Campus_errorFlag.Visible = true;
            }
            else
            {
                GetCities((int)Campus_CB.SelectedValue);
                Campus_errorFlag.Visible = false;
            }
        }
        private void SchoolName_TB_TextChanged(object sender, EventArgs e)
        {
            if (SchoolName_TB.Text == string.Empty)
            {
                School_errorFlag.Visible = true;
            }
            else
            {
                School_errorFlag.Visible = false;
            }
        }


        //Upload Image button click
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
                SchoolIcon_PicBox.Image = newBitmap;
            }

            var currentDirectory = Directory.GetCurrentDirectory();
            var imageFolderPath = Path.Combine(currentDirectory, "Institutes", "Campuses", "Schools", "Icons");
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

        //Update buton click

        private void UpdateSchool_Btn_Click(object sender, EventArgs e)
        {
            if (Campus_errorFlag.Visible == true || SchoolName_errorLbl.Visible == true)
            {
                if (Campus_errorFlag.Visible == true)
                {
                    Campus_errorLbl.Visible = true;
                }
                else
                {
                    School_errorFlag.Visible = true;
                }

                _instituteForm.NotifyAlert("Fields marked with * are mendatory", Form_Alert.enmType.Error);

            }
            else
            {
                UpdateASchool(iD);

            }
        }
        private void UpdateASchool(int iD)
        {
            _school.Id = Convert.ToInt32(SchoolId_TB.Text);
            _school.Name = SchoolName_TB.Text;
            _school.CampusId = Convert.ToInt32(Campus_CB.SelectedValue);
            _school.CityId = Convert.ToInt32(City_CB.SelectedValue);
            _school.Address = Address_TB.Text;
            _school.Notes = Notes_RTB.Text;
            _school.SchoolIcon_Path = _fullImagePath;


            _resultModel = _schoolBLL.UpdateSchoolBLL(_school);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                this.Close();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

    }
}
