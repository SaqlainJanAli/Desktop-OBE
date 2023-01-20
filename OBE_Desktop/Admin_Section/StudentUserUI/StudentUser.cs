using System;
using System.Drawing;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.AdminSection_BLL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.Admin_Section.StudentUserUI
{
    public partial class StudentUser : Form
    {
        private OBE_BEL.Admin_Section.StudentUserBEL.StudentUser _studentUserBEL =
            new OBE_BEL.Admin_Section.StudentUserBEL.StudentUser();

        private Institute _instituteForm = new Institute();
        private ResultModel _resultModel = new ResultModel();
        private StudentUser_BLL _studentUserBll = new StudentUser_BLL();
        private InstituteBLL _instituteBll = new InstituteBLL();
        private int waitToFilter = 0;



        //Contstructor
        public StudentUser()
        {
            InitializeComponent();
        }

        //ON Load
        private void StudentUser_Load(object sender, EventArgs e)
        {
            HideFewControls();
            //GetStudentUsers();
            FillDropDowns();
        }

        private void HideFewControls()
        {
            flagForFilter = false;
            FilterActive_CB.Enabled = false;
            FilterName_TB.Enabled = false;
            FilterRollNo_TB.Enabled = false;

            Code_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;

            Code_errorFlag.Visible = false;
            Name_errorFlag.Visible = false;
        }

        private void FillDropDowns()
        {
            GetCountries();
            GetGenders();
            GetProgramBatches();
            GetStudyModes();
            GetReligions();
            GetStatuses();
            GetHSSCTypes();
            GetBSCTypes();
            GetAdmissionTypes();
            GetAdmissionCategories();
            GetQuotas();


        }
        
        
        //Read Data
        private void GetStudentUsers()
        {
            StudentUserDataGrid.AutoGenerateColumns = false;
            StudentUserDataGrid.DataSource = _studentUserBll.GetStudentUsersBLL();

            foreach (DataGridViewRow dataGridViewRow in StudentUserDataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }
        private void GetCountries()
        {
            country_CB.DisplayMember = "Name";
            country_CB.ValueMember = "Id";
            country_CB.DataSource = _instituteBll.GetCountriesBLL();
        }
        private void FilterRegionByCountryId(int countryId)
        {
            province_CB.DisplayMember = "Name";
            province_CB.ValueMember = "Id";
            province_CB.DataSource = _instituteBll.FilterRegionByCountryIdBLL(countryId);
        }
        private void FilterCityByRegionId(int regionId)
        {
            currentCity_CB.DisplayMember = "Name";
            currentCity_CB.ValueMember = "Id";
            currentCity_CB.DataSource = _instituteBll.FilterCityByRegionIdBLL(regionId);
        }
        private void GetGenders()
        {
            gender_CB.DisplayMember = "Name";
            gender_CB.ValueMember = "Id";
            gender_CB.DataSource = new User_BLL().GetGendersBLL();
        }
        private void GetProgramBatches()
        {
            programBatch_CB.DisplayMember = "ProgramBatch";
            programBatch_CB.ValueMember = "SerialNumber";
            programBatch_CB.DataSource = new ProgramBatch_BLL().GetProgramBatchesBLL();
        }
        private void GetStudyModes()
        {
            studyMode_CB.DisplayMember = "Name";
            studyMode_CB.ValueMember = "Id";
            studyMode_CB.DataSource = _studentUserBll.getStudyModesBLL();
        }
        private void GetReligions()
        {
            religion_CB.DisplayMember = "Name";
            religion_CB.ValueMember = "Id";
            religion_CB.DataSource = _studentUserBll.getReligionsBLL();
        }
        private void GetStatuses()
        {
            status_CB.DisplayMember = "Name";
            status_CB.ValueMember = "Id";
            status_CB.DataSource = _studentUserBll.getStatusesBLL();
        }
        private void GetHSSCTypes()
        {
            hsscType_CB.DisplayMember = "Name";
            hsscType_CB.ValueMember = "Id";
            hsscType_CB.DataSource = _studentUserBll.getHsscTypesBLL();
        }
        private void GetBSCTypes()
        {
            bscType_TB.DisplayMember = "Name";
            bscType_TB.ValueMember = "Id";
            bscType_TB.DataSource = _studentUserBll.getBscTypesBLL();
        }
        private void GetAdmissionTypes()
        {
            admissionType_CB.DisplayMember = "Name";
            admissionType_CB.ValueMember = "Id";
            admissionType_CB.DataSource = _studentUserBll.getAdmissionTypesBLL();
        }
        private void GetAdmissionCategories()
        {
            admissionCategory_CB.DisplayMember = "Name";
            admissionCategory_CB.ValueMember = "Id";
            admissionCategory_CB.DataSource = _studentUserBll.getAdmissionCategoBLL();
        }
        private void GetQuotas()
        {

            qouta_CB.DisplayMember = "Name";
            qouta_CB.ValueMember = "Id";
            qouta_CB.DataSource = _studentUserBll.GetQuotasBLL();
        }

        //Create Button Click
        private void createStudent_Btn_Click(object sender, System.EventArgs e)
        { 
            createStudentUser();
        }
        private void createStudentUser()
        {
            _studentUserBEL.RegistrationNo = RegNo_TB.Text;
            _studentUserBEL.Name = Name_TB.Text;
            _studentUserBEL.RollNo = RollNo_TB.Text;
            _studentUserBEL.ERPId = erpId_TB.Text;
            _studentUserBEL.ProgramBatchId = Convert.ToInt32(programBatch_CB.SelectedValue);
            _studentUserBEL.GenderId = Convert.ToInt32(gender_CB.SelectedValue);
            _studentUserBEL.ReligionId = Convert.ToInt32(religion_CB.SelectedValue);
            _studentUserBEL.DateOfBirth = dob_DTP.Value;
            _studentUserBEL.StudyModeId = Convert.ToInt32(studyMode_CB.SelectedValue);
            _studentUserBEL.StatusId = Convert.ToInt32(status_CB.SelectedValue);
            _studentUserBEL.isLocal = isLocal_CB.Checked;
            _studentUserBEL.FatherName = fatherName_TB.Text;
            _studentUserBEL.Email = email_TB.Text;
            _studentUserBEL.CNIC = cnic_TB.Text;
            _studentUserBEL.Passport = passport_TB.Text;
            _studentUserBEL.PhoneNo = homePh_TB.Text;
            _studentUserBEL.MobileNo = mobileNo_TB.Text;
            _studentUserBEL.PermanentAddress = permanentAdd_RTB.Text;
            _studentUserBEL.CityId = Convert.ToInt32(currentCity_CB.SelectedValue);
            _studentUserBEL.District = district_TB.Text;
            _studentUserBEL.RegionId = Convert.ToInt32(province_CB.SelectedValue);
            _studentUserBEL.CountryId = Convert.ToInt32(country_CB.SelectedValue);
            _studentUserBEL.PostalAddress = postalAdd_RTB.Text;
            _studentUserBEL.HsscTypeId = Convert.ToInt32(hsscType_CB.SelectedValue);
            _studentUserBEL.HsscMarksPercent = Convert.ToDecimal(hsscMarksPerc_TB.Text);
            _studentUserBEL.BscTypeId = Convert.ToInt32(bscType_TB.SelectedValue);
            _studentUserBEL.BscMarksPercent = (bscMarksPerc_TB.Text==string.Empty)?0:Convert.ToDecimal(bscMarksPerc_TB.Text);
            _studentUserBEL.QuotaId = Convert.ToInt32(qouta_CB.SelectedValue);
            _studentUserBEL.EntryTestMarks = Convert.ToDecimal(entryTestMarks_TB.Text);
            _studentUserBEL.ApplicationNo = applicationNo_TB.Text;
            _studentUserBEL.AdmissionDate = admissionDate_d.Value;
            _studentUserBEL.AdmissionTypeId = Convert.ToInt32(admissionType_CB.SelectedValue);
            _studentUserBEL.AdmissionCategoryId = Convert.ToInt32(admissionCategory_CB.SelectedValue);
            _studentUserBEL.ExtraNotes = extraInfo_RTB.Text;

            _resultModel = _studentUserBll.createStudentUserBLL(_studentUserBEL);
            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetStudentUsers();
                StdUser_TabControl.SelectTab(1);
            }
            else
            {

                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }

        }

        //TExt and Selected Changed Event

        private void country_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (country_CB.SelectedValue == null)
            {

                // Country_flag.Visible = true;
            }
            else
            {
                // Country_flag.Visible = false;
                if (waitToFilter != 0)
                {
                    FilterRegionByCountryId(Convert.ToInt32(country_CB.SelectedValue));
                }

                waitToFilter++;

            }
        }

        private void province_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (province_CB.SelectedValue == null)
            {
                // Region_errorFlag.Visible = true;
            }
            else
            {
                //  Region_errorFlag.Visible = false;
                if (waitToFilter != 0 || waitToFilter != 1)
                {
                    FilterCityByRegionId(Convert.ToInt32(province_CB.SelectedValue));
                }

                waitToFilter++;
            }
        }


        //Manage Button Click
        private void ManageStdUsers_Btn_Click(object sender, EventArgs e)
        {
            StdUser_TabControl.SelectTab(1);
        }

        private void StudentUserDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(StudentUserDataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());

            if (StudentUserDataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewAStudentUser(ID);
            }

            if (StudentUserDataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                UpdateStudentUser _updateStudentUser = new UpdateStudentUser(ID);
                _updateStudentUser.Show();
                GetStudentUsers();
            }


            if (StudentUserDataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Student?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    DeleteStudentUser(ID);
                    GetStudentUsers();
                }
            }
        }

        private void DeleteStudentUser(int id)
        {
            _resultModel = _studentUserBll.DeleteStudentUserBLL(id);
            if (_resultModel.Status == true)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        private void ViewAStudentUser(int id)
        {
            ViewStudentUser _viewStudentUser = new ViewStudentUser(id);
            _viewStudentUser.Show();
        }

        private void FilterRollNo_TB_TextChanged(object sender, EventArgs e)
        {

        }

        private void StdUser_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStudentUsers();
        }

        //Apply Filter button
        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterActive_CB.Enabled = true;
                FilterName_TB.Enabled = true;
                FilterRollNo_TB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterActive_CB.Enabled = false;
                FilterName_TB.Enabled = false;
                FilterRollNo_TB.Enabled = false;

                applyFilter_Btn.BackColor = Color.White;
                GetStudentUsers();
            }
        }
    }
}
