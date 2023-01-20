using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BEL.MyInstitute_Section.InstituteBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using Institute = OBE_Desktop.MyInstitute_Section.InstituteUI.Institute;

namespace OBE_Desktop.MyInstitute_Section.SchoolUI
{
    public partial class School : Form
    {
        //Fields
        private string _fullImagePath;
        private InstituteBLL _instituteBLL = new InstituteBLL();
        private Campus_BLL _campusBLL = new Campus_BLL();
        private ResultModel _resultModel = new ResultModel();
        private Institute _instituteForm = new Institute();
        private OBE_BEL.MyInstitute_Section.SchoolsBEL.School _school = new OBE_BEL.MyInstitute_Section.SchoolsBEL.School();
        private School_BLL _schoolBLL = new School_BLL();
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();

        //Constructors
        public School()
        {
            InitializeComponent();

        }
        public School(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }


        //On Load
        private void onSchoolLoad(object sender, EventArgs e)
        {
            FillDropDowns();
            HideErrorLbls();
            //GetSchools();

            SchoolPrivacies();
        }
        private void HideErrorLbls()
        {
            //Error Labels
            Campus_errorLbl.Visible = false;
            SchoolName_errorLbl.Visible = false;

            //Filter Controls
            flagForFilter = false;
            FilterName_TB.Enabled = false;
            FilterCampus_CB.Enabled = false;
        }
        private void SchoolPrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (_rolePrivacy.SchoolCreate)
            {
                tabPage1.Visible = true;
            }
            else
            {
                tabPage1.Visible = false;
            }

            if (_rolePrivacy.SchoolRead)
            {
                schoolDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                schoolDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.SchoolUpdate)
            {
                schoolDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                schoolDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.SchoolDelete)
            {
                schoolDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                schoolDataGrid.Columns["Delete_DGV"].Visible = false;
            }
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
        private void GetSchools()
        {
            schoolDataGrid.AutoGenerateColumns = false;
            var schools = _schoolBLL.GetSchoolsBLL();
            schoolDataGrid.DataSource = schools;
            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in schoolDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(schools[i].Icon_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(schools[i].Icon_Path);
                }
            }
            FilterCampus_CB.DisplayMember = "Name";
            FilterCampus_CB.ValueMember = "Id";
            FilterCampus_CB.DataSource = _campusBLL.GetCampusesBLL();
        }


        //Upload image button click
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

        //Create button click
        private void CreateSchool_Btn_Click(object sender, EventArgs e)
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
                CreateSchool();

            }
        }
        private void CreateSchool()
        {
            _school.Name = SchoolName_TB.Text;
            _school.CampusId = Convert.ToInt32(Campus_CB.SelectedValue);
            _school.CityId = Convert.ToInt32(City_CB.SelectedValue);
            _school.Address = Address_TB.Text;
            _school.Notes = Notes_RTB.Text;
            _school.SchoolIcon_Path = _fullImagePath;


            _resultModel = _schoolBLL.CreateSchoolBLL(_school);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                School_TabControl.SelectTab(1);
                GetSchools();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        //Manage Button click
        private void ManageSchools_Btn_Click(object sender, EventArgs e)
        {
            School_TabControl.SelectTab(1);
        }

        //text changed events
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
 

        //DGV Cell Content Click
        private void OnDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (schoolDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                int ID = Convert.ToInt32(schoolDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                ViewASchool(ID);
            }


            if (schoolDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                int ID = Convert.ToInt32(schoolDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                UpdateSchool _UpdateSchool = new UpdateSchool(ID);
                _UpdateSchool.Show();
                GetSchools();
            }

            if (schoolDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This School?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(schoolDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());
                    DeleteSchool(ID);
                    GetSchools();
                }
            }




        }

        //Delete method
        private void DeleteSchool(int iD)
        {
            _resultModel = _schoolBLL.DeleteSchoolBLL(iD);
            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        //View A School
        private void ViewASchool(int iD)
        {
            ViewSchool _ViewSchool = new ViewSchool(iD);
            _ViewSchool.Show();
        }

        //Filtering DGV
        private void FilterCampus_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByCampus();
        }
        private void FilterDGVByCampus()
        {
            var schools = _schoolBLL.FilterbyCampusBLL(Convert.ToInt32(FilterCampus_CB.SelectedValue));
            schoolDataGrid.DataSource = schools;
            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in schoolDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(schools[i].Icon_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(schools[i].Icon_Path);
                }
            }
        }
        private void onEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FilterDGVByName();
            }
        }
        private void FilterDGVByName()
        {
            var schools = _schoolBLL.FilterByNameBLL(FilterName_TB.Text);
            schoolDataGrid.DataSource = schools;
            FilterName_TB.Clear();

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in schoolDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(schools[i].Icon_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(schools[i].Icon_Path);
                }
            }
        }



        //Refresh DGV
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetSchools();
        }

        private void School_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSchools();
        }

        //Apply Filter button
        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterName_TB.Enabled = true;
                FilterCampus_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterName_TB.Enabled = false;
                FilterCampus_CB.Enabled = false;

                applyFilter_Btn.BackColor = Color.White;
                GetSchools();
            }
        }
    }
}


