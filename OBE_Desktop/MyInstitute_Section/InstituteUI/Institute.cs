using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using static OBE_Desktop.Form_Alert;

namespace OBE_Desktop.MyInstitute_Section.InstituteUI
{
    public partial class Institute : Form
    {
        private string _fullImagePath;
        readonly InstituteBLL _instituteBLL = new InstituteBLL();
        private OBE_BEL.MyInstitute_Section.InstituteBEL.Institute _instituteBEL = new OBE_BEL.MyInstitute_Section.InstituteBEL.Institute();
        private ResultModel _resultModel = new ResultModel();
        private User loggedInUser;
        private User_BLL _userBLL = new User_BLL();
        private int waitToFilter = 0;
        public Institute()
        {
            InitializeComponent();

        }

        public Institute(User loggedInUser)
        {
            this.loggedInUser = loggedInUser;
            InitializeComponent();
        }

        //On Load
        private void onInsittueLoad(object sender, EventArgs e)
        {
            HideErrorLabels();
            GetAuthorities();
            GetInstituteType();
            GetCountries();
            GetPLOMethods();

            //HideErrorLabels();
            HandleInstitutePrivacies();
        }
        private void HandleInstitutePrivacies()
        {
            var _rolePrivacy = _userBLL.getPrivacyByIdBLL(loggedInUser.RoleId);
            if (!_rolePrivacy.InstituteCreate)
            {
                CreateInstitute_TabControl.TabPages.RemoveAt(0);
            }


            if (_rolePrivacy.InstituteRead)
            {
                institutesDataGrid.Columns["View_DGV"].Visible = true;
            }
            else
            {
                institutesDataGrid.Columns["View_DGV"].Visible = false;
            }

            if (_rolePrivacy.InstituteUpdate)
            {
                institutesDataGrid.Columns["Update_DGV"].Visible = true;
            }
            else
            {
                institutesDataGrid.Columns["Update_DGV"].Visible = false;
            }

            if (_rolePrivacy.InstituteDelete)
            {
                institutesDataGrid.Columns["Delete_DGV"].Visible = true;
            }
            else
            {
                institutesDataGrid.Columns["Delete_DGV"].Visible = false;
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


            //Filter Controls
            flagForFilter = false;
            FilterName_TB.Enabled = false;
            FilterAuthority_CB.Enabled = false;
        }
        public void GetInstitutes()
        {
            institutesDataGrid.AutoGenerateColumns = false;
            var institutes = _instituteBLL.GetInstitutesBLL();
            institutesDataGrid.DataSource = institutes;
            
            
            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in institutesDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(institutes[i].Logo_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(institutes[i].Logo_Path);
                }
            }
       

            FilterAuthority_CB.DisplayMember = "AuthorityName";
            FilterAuthority_CB.ValueMember = "Id";
            FilterAuthority_CB.DataSource = _instituteBLL.GetAuthoritiesBLL();

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


        //Text changed event for validation

        private void InstituteName_TB_TextChanged(object sender, EventArgs e)
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
        private void IssuingAuth_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IssuingAuth_CB.SelectedItem == null)
            {
                IssuingAuth_flag.Visible = true;
            }
            else
            {
                IssuingAuth_flag.Visible = false;
            }
        }
        private void InstituteType_CB_SelectedIndexChanged(object sender, EventArgs e)
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
        private void PLOCalMethod_CB_SelectedIndexChanged(object sender, EventArgs e)
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
        private void Country_CB_SelectedIndexChanged(object sender, EventArgs e)
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
        private void City_CB_SelectedIndexChanged(object sender, EventArgs e)
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
        private void Website_TB_TextChanged(object sender, EventArgs e)
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
        private void Address_TB_TextChanged(object sender, EventArgs e)
        {
            if (Address_TB.Text == string.Empty)
            {
                Address_flag.Visible = true;
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
        private void Mission_RTB_TextChanged(object sender, EventArgs e)
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

        //Button Clicks

        //Upload Image Button Click
        private void UploadImg_Btn_Click(object sender, EventArgs e)
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
                Logo_Img.Image = newBitmap;
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
            else
            {
                _fullImagePath = null;
            }


        }

        //Create Button Click
        private void CreateInstitute_Btn_Click(object sender, EventArgs e)
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


                NotifyAlert("Fields marked with * are mendatory", enmType.Error);
                //MessageBox.Show("Fields marked with * are required","Empty Field Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                CreateInstitute();
                GetInstitutes();
            }



        }

        public void CreateInstitute()
        {

            _instituteBEL.Name = InstituteName_TB.Text;
            _instituteBEL.IssuingAuthorityId = Convert.ToInt32(IssuingAuth_CB.SelectedValue.ToString());
            _instituteBEL.InstituteTypeId = Convert.ToInt32(InstituteType_CB.SelectedValue.ToString());
            _instituteBEL.MethodId = Convert.ToInt32(PLOCalMethod_CB.SelectedValue.ToString());
            _instituteBEL.CountryId = Convert.ToInt32(Country_CB.SelectedValue.ToString());
            _instituteBEL.RegionId = Convert.ToInt32(Region_CB.SelectedValue.ToString());
            _instituteBEL.CityId = Convert.ToInt32(City_CB.SelectedValue.ToString());
            _instituteBEL.FullGPA = Convert.ToInt32(FullGPA_NUD.Text);
            _instituteBEL.AllowAttendance = Convert.ToInt32(AllowAttendance_NUD.Text);
            _instituteBEL.PublicSector = (PublicSector_CB.Checked == true) ? true : false;
            _instituteBEL.YearEstablished = YearEstablished_DTP.Value;
            _instituteBEL.WebsiteURL = Website_TB.Text;
            _instituteBEL.Notes = Notes_RTB.Text;
            _instituteBEL.Address = Address_TB.Text;
            _instituteBEL.Vision = Vision_RTB.Text;
            _instituteBEL.Mission = Mission_RTB.Text;

            _instituteBEL.Logo_Path = _fullImagePath;
            _resultModel = _instituteBLL.CreateInstituteBLL(_instituteBEL);

            if (_resultModel.Status == true)
            {
                this.NotifyAlert(_resultModel.Message, enmType.Success);

                CreateInstitute_TabControl.SelectTab(1);

            }
            else
            {
                this.NotifyAlert(_resultModel.Message, enmType.Error);

            }

        }


        //DGV Cell COntent Click
        private void OnDGV_CellContent_Click(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(institutesDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());

            if (institutesDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewAnInstitute(ID);
            }

            if (institutesDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                UpdateInstituteForm _updateInstituteForm = new UpdateInstituteForm(ID);
                _updateInstituteForm.Show();
                GetInstitutes();
            }


            if (institutesDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Institute?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    DeleteInstitute(ID);
                    GetInstitutes();
                }
            }
        }

        private void ViewAnInstitute(int ID)
        {
            ViewInstitute _viewInstitute = new ViewInstitute(ID);
            _viewInstitute.Show();

        }

        //Delete cell click
        private void DeleteInstitute(int ID)
        {

            _resultModel = _instituteBLL.DeleteInstituteBLL(ID);
            if (_resultModel.Status == true)
            {
                this.NotifyAlert(_resultModel.Message, enmType.Success);
            }
            else
            {
                this.NotifyAlert(_resultModel.Message, enmType.Error);
            }
        }

        //Manage button click
        private void ManageInstitute_Btn_Click(object sender, EventArgs e)
        {
            CreateInstitute_TabControl.SelectTab(1);
        }

        //Notification on action
        public void NotifyAlert(string Msg, enmType Type)
        {
            Form_Alert NewAlertFrm = new Form_Alert();
            NewAlertFrm.TopMost = true;
            NewAlertFrm.TopLevel = true;
            NewAlertFrm.showAert(Msg, Type);

        }

        //Filtering DGV 
        private void FilterAuthority_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDGVByIssuingAuthId();
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
            institutesDataGrid.AutoGenerateColumns = false;

            var institutes = _instituteBLL.FilterByNameBLL(FilterName_TB.Text);
            institutesDataGrid.DataSource = institutes;


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in institutesDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(institutes[i].Logo_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(institutes[i].Logo_Path);
                }
            }


            FilterName_TB.Clear();
        }

        private void FilterDGVByIssuingAuthId()
        {
            institutesDataGrid.AutoGenerateColumns = false;

            var institutes = _instituteBLL.FilterByAuthority(Convert.ToInt32(FilterAuthority_CB.SelectedValue));
            institutesDataGrid.DataSource = institutes;


            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in institutesDataGrid.Rows)
            {
                int i = dataGridViewRow.Index;
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
                if (!string.IsNullOrWhiteSpace(institutes[i].Logo_Path))
                {
                    dataGridViewRow.Cells[2].Value = Image.FromFile(institutes[i].Logo_Path);
                }
            }


        }


        //Refresh Button Click
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetInstitutes();
        }

        private void CreateInstitute_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetInstitutes();
        }


        //Apply Filter button

        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterName_TB.Enabled = true;
                FilterAuthority_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterName_TB.Enabled = false;
                FilterAuthority_CB.Enabled = false;


                applyFilter_Btn.BackColor = Color.White;
                GetInstitutes();
            }
        }
    }
}