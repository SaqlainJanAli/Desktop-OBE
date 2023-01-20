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
using System.Collections;

namespace OBE_Desktop.MyInstitute_Section.CampusUI
{
    public partial class Campus : Form
    {
        //Fields
        InstituteBLL _instituteBLL = new InstituteBLL();
        OBE_BEL.MyInstitute_Section.InstituteBEL.Institute _instituteBEL = new OBE_BEL.MyInstitute_Section.InstituteBEL.Institute();
        OBE_BEL.MyInstitute_Section.CampusesBEL.Campus _CampusBEL = new OBE_BEL.MyInstitute_Section.CampusesBEL.Campus();
        Campus_BLL _campusBLL = new Campus_BLL();
        ResultModel _resultModel = new ResultModel();
        Institute _instituteForm = new Institute();
        private string _fullImagePath;
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();

        //Constructors
        public Campus()
        {
            InitializeComponent();

        }
        public Campus(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //On Load Campus form
        private void onCampusesLoad(object sender, EventArgs e)
        {
            HideFewControls();
            GetInstitutes();
            //GetCampuses();
            HandlCampusPrivacies();
        }

        private void HideFewControls()
        {
            University_errorLbl.Visible = false;
            Campus_errorLbl.Visible = false;
            flagForFilter = false;

            FilterInstitute_CB.Enabled = false;
            FilterName_TB.Enabled = false;

            FilterInstitute_Lbl.Enabled = false;
            FilterName_Lbl.Enabled = false;
        }
  
        private void HandlCampusPrivacies()
        {

            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (!_rolePrivacy.CampusCreate)
            {
                Campus_TabControl.TabPages.RemoveAt(0);
            }


            if (_rolePrivacy.CampusRead)
            {
                campusesDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                campusesDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.CampusUpdate)
            {
                campusesDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                campusesDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.CampusDelete)
            {
                campusesDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                campusesDataGrid.Columns["Delete_DGV"].Visible = false;
            }
        }

        //Read
        private void GetInstitutes()
        {
            var abc = _instituteBLL.GetInstitutesBLL();
            Institute_CB.DataSource = abc;
        }
        public void GetCampuses()
        {
            campusesDataGrid.AutoGenerateColumns = false;
            var campuses = _campusBLL.GetCampusesBLL();
            campusesDataGrid.DataSource = campuses;


            foreach (DataGridViewRow dataGridViewRow in campusesDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(campuses[i].HeaderImage_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(campuses[i].HeaderImage_Path);
                }
            }

            FilterInstitute_CB.DisplayMember = "Name";
            FilterInstitute_CB.ValueMember = "Id";
            FilterInstitute_CB.DataSource = _instituteBLL.GetInstitutesBLL();
        }
        private void GetCities(int instituteId)
        {
            var instituteFound = _instituteBLL.GetInstituteByIdBLL(instituteId);
            var citiesOfThisRegion = _instituteBLL.GetCityByRegionId(instituteFound.RegionId);


            City_CB.DisplayMember = "Name";
            City_CB.ValueMember = "Id";
            City_CB.DataSource = citiesOfThisRegion;

        }



        //Upload Image Button Click
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
                File.Copy(_openFileDialog.FileName, Path.Combine(imageFolderPath, newImageName));
            }
            else
            {
                _fullImagePath = null;
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
        private void City_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Create Button Click
        private void CreateCampus_Btn_Click(object sender, EventArgs e)
        {
            if (University_errorflag.Visible == true || Campus_errorflag.Visible == true)
            {
                if (University_errorflag.Visible == true)
                {
                    University_errorLbl.Visible = true;

                }
                else if (Campus_errorflag.Visible == true)
                {
                    Campus_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are mendatory", Form_Alert.enmType.Error);
            }
            else
            {
                CreateCampus();

                GetCampuses();
                campusesDataGrid.Refresh();

            }


        }
        public void CreateCampus()
        {

            _CampusBEL.Name = CampusName_TB.Text;
            _CampusBEL.University_Id = Convert.ToInt32(Institute_CB.SelectedValue);
            _CampusBEL.CityId = Convert.ToInt32(City_CB.SelectedValue);
            _CampusBEL.Address = Address_TB.Text;
            _CampusBEL.Notes = Notes_RTB.Text;
            _CampusBEL.HeaderImage_Path = _fullImagePath;

            _resultModel = _campusBLL.CreateCampusBLL(_CampusBEL);

            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                Campus_TabControl.SelectTab(1);
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        //Manage Campus Button Click
        private void ManageCampus_Btn_Click(object sender, EventArgs e)
        {
            Campus_TabControl.SelectTab(1);
        }


        //Data Grid View Content Click
        private void OnDGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(campusesDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());

            if (campusesDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewACampus(ID);
            }
            if (campusesDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                UpdateCampus _UpdateCampus = new UpdateCampus(ID);
                _UpdateCampus.Show();
            }
            if (campusesDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Campus?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    DeleteCampus(ID);
                }
            }
        }
        //Delete Method
        private void DeleteCampus(int iD)
        {
            _resultModel = _campusBLL.DeleteCampusBLL(iD);
            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetCampuses();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }
        //View Method
        private void ViewACampus(int iD)
        {
            ViewCampus _ViewCampus = new ViewCampus(iD);
            _ViewCampus.Show();
        }


        //Filters of Data grid
        private void FilterInstitute_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByInstitute();
        }

        private void FilterDGVByInstitute()
        {
            var campuses = _campusBLL.FilterByInstituteBLL(Convert.ToInt32(FilterInstitute_CB.SelectedValue));
            campusesDataGrid.DataSource = campuses;
            foreach (DataGridViewRow dataGridViewRow in campusesDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(campuses[i].HeaderImage_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(campuses[i].HeaderImage_Path);
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
            var campuses = _campusBLL.FilterByNameBLL(FilterName_TB.Text);
            FilterName_TB.Clear();
            campusesDataGrid.DataSource = campuses;
            foreach (DataGridViewRow dataGridViewRow in campusesDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(campuses[i].HeaderImage_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(campuses[i].HeaderImage_Path);
                }
            }
        }

  

        //Refresh DGV
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetCampuses();
        }
        private void Campus_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCampuses();
        }


        //Apply Filter button
        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterInstitute_CB.Enabled = true;
                FilterName_TB.Enabled = true;

                FilterInstitute_Lbl.Enabled = true;
                FilterName_Lbl.Enabled = true;
            }
            else
            {
                flagForFilter = false;
                FilterInstitute_CB.Enabled = false;
                FilterName_TB.Enabled = false;

                FilterInstitute_Lbl.Enabled = false;
                FilterName_Lbl.Enabled = false;

                GetCampuses();
            }
        }
    }
}

