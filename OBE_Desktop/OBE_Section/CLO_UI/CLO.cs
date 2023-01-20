using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using OBE_BEL;
using OBE_BEL.OBE_Section.CLO_BEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_BLL.OBESection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.OBE_Section.CLO_UI
{
    public partial class CLO : Form
    {
        //Fields
        private Institute _instituteForm = new Institute();
        private OBE_BEL.OBE_Section.CLO_BEL.CLO _cloBEL = new OBE_BEL.OBE_Section.CLO_BEL.CLO();
        private CLO_BLL _cloBll = new CLO_BLL();
        private Course_BLL _courseBll = new Course_BLL();
        private PLO_BLL _ploBll = new PLO_BLL();
        private ResultModel _resultModel = new ResultModel();

        private int countCourses = 1;


        //Constructor
        public CLO()
        {
            InitializeComponent();
        }


        //On Load
        private void CLO_Load(object sender, System.EventArgs e)
        {
            HideLbls();
            HideFewControls();
            FillDropDowns();
            //GetCLOs();
        }

        private void HideLbls()
        {
            Code_errorLbl.Visible = false;
            Description_errorLbl.Visible = false;
        }
        private void HideFewControls()
        {

            //Filter Controls
            flagForFilter = false;
            FilterActive_CB.Enabled = false;
            FilterCode_TB.Enabled = false;
            FilterCourse_CB.Enabled = false;


            //Dynamic Control :)
            Course_02_CB.Visible = false;
            Course_03_CB.Visible = false;
            Course_04_CB.Visible = false;
            Course_05_CB.Visible = false;
            Course_06_CB.Visible = false;
            Course_07_CB.Visible = false;
            Course_08_CB.Visible = false;
            Course_09_CB.Visible = false;
            Course_10_CB.Visible = false;

            Type_02_CB.Visible = false;
            Type_03_CB.Visible = false;
            Type_04_CB.Visible = false;
            Type_05_CB.Visible = false;
            Type_06_CB.Visible = false;
            Type_07_CB.Visible = false;
            Type_08_CB.Visible = false;
            Type_09_CB.Visible = false;
            Type_10_CB.Visible = false;

            PLO_02_CB.Visible = false;
            PLO_03_CB.Visible = false;
            PLO_04_CB.Visible = false;
            PLO_05_CB.Visible = false;
            PLO_06_CB.Visible = false;
            PLO_07_CB.Visible = false;
            PLO_08_CB.Visible = false;
            PLO_09_CB.Visible = false;
            PLO_10_CB.Visible = false;

        }
        private void FillDropDowns()
        {
            GetPLOs();
            GetCLOTypes();
            GetCourses();
        }

        //Read data for Drop downs
        private void GetPLOs()
        {
            PLO_01_CB.DisplayMember = "CodePlusName";
            PLO_01_CB.ValueMember = "Id";
            PLO_01_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_02_CB.DisplayMember = "CodePlusName";
            PLO_02_CB.ValueMember = "Id";
            PLO_02_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_03_CB.DisplayMember = "CodePlusName";
            PLO_03_CB.ValueMember = "Id";
            PLO_03_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_04_CB.DisplayMember = "CodePlusName";
            PLO_04_CB.ValueMember = "Id";
            PLO_04_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_05_CB.DisplayMember = "CodePlusName";
            PLO_05_CB.ValueMember = "Id";
            PLO_05_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_06_CB.DisplayMember = "CodePlusName";
            PLO_06_CB.ValueMember = "Id";
            PLO_06_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_07_CB.DisplayMember = "CodePlusName";
            PLO_07_CB.ValueMember = "Id";
            PLO_07_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_08_CB.DisplayMember = "CodePlusName";
            PLO_08_CB.ValueMember = "Id";
            PLO_08_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_09_CB.DisplayMember = "CodePlusName";
            PLO_09_CB.ValueMember = "Id";
            PLO_09_CB.DataSource = _ploBll.GetPLOsBLL();

            PLO_10_CB.DisplayMember = "CodePlusName";
            PLO_10_CB.ValueMember = "Id";
            PLO_10_CB.DataSource = _ploBll.GetPLOsBLL();

        }

        private void GetCLOTypes()
        {
            Type_01_CB.DisplayMember = "Name";
            Type_01_CB.ValueMember = "Id";
            Type_01_CB.DataSource = _cloBll.GetTypesBLL();

            Type_02_CB.DisplayMember = "Name";
            Type_02_CB.ValueMember = "Id";
            Type_02_CB.DataSource = _cloBll.GetTypesBLL();

            Type_03_CB.DisplayMember = "Name";
            Type_03_CB.ValueMember = "Id";
            Type_03_CB.DataSource = _cloBll.GetTypesBLL();

            Type_04_CB.DisplayMember = "Name";
            Type_04_CB.ValueMember = "Id";
            Type_04_CB.DataSource = _cloBll.GetTypesBLL();

            Type_05_CB.DisplayMember = "Name";
            Type_05_CB.ValueMember = "Id";
            Type_05_CB.DataSource = _cloBll.GetTypesBLL();

            Type_06_CB.DisplayMember = "Name";
            Type_06_CB.ValueMember = "Id";
            Type_06_CB.DataSource = _cloBll.GetTypesBLL();

            Type_07_CB.DisplayMember = "Name";
            Type_07_CB.ValueMember = "Id";
            Type_07_CB.DataSource = _cloBll.GetTypesBLL();

            Type_08_CB.DisplayMember = "Name";
            Type_08_CB.ValueMember = "Id";
            Type_08_CB.DataSource = _cloBll.GetTypesBLL();

            Type_09_CB.DisplayMember = "Name";
            Type_09_CB.ValueMember = "Id";
            Type_09_CB.DataSource = _cloBll.GetTypesBLL();

            Type_10_CB.DisplayMember = "Name";
            Type_10_CB.ValueMember = "Id";
            Type_10_CB.DataSource = _cloBll.GetTypesBLL();

        }

        private void GetCourses()
        {
            Course_01_CB.DisplayMember = "Name";
            Course_01_CB.ValueMember = "SerialNumber";
            Course_01_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_02_CB.DisplayMember = "Name";
            Course_02_CB.ValueMember = "SerialNumber";
            Course_02_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_03_CB.DisplayMember = "Name";
            Course_03_CB.ValueMember = "SerialNumber";
            Course_03_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_04_CB.DisplayMember = "Name";
            Course_04_CB.ValueMember = "SerialNumber";
            Course_04_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_05_CB.DisplayMember = "Name";
            Course_05_CB.ValueMember = "SerialNumber";
            Course_05_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_06_CB.DisplayMember = "Name";
            Course_06_CB.ValueMember = "SerialNumber";
            Course_06_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_07_CB.DisplayMember = "Name";
            Course_07_CB.ValueMember = "SerialNumber";
            Course_07_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_08_CB.DisplayMember = "Name";
            Course_08_CB.ValueMember = "SerialNumber";
            Course_08_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_09_CB.DisplayMember = "Name";
            Course_09_CB.ValueMember = "SerialNumber";
            Course_09_CB.DataSource = _courseBll.GetCoursesBLL();

            Course_10_CB.DisplayMember = "Name";
            Course_10_CB.ValueMember = "SerialNumber";
            Course_10_CB.DataSource = _courseBll.GetCoursesBLL();

            FilterCourse_CB.DisplayMember = "Name";
            FilterCourse_CB.ValueMember = "SerialNumber";
            FilterCourse_CB.DataSource = _courseBll.GetCoursesBLL();
        }


        //Read Data for Data grid
        private void GetCLOs()
        {
            CLODataGrid.AutoGenerateColumns = false;
            CLODataGrid.DataSource = _cloBll.GetCLOsBLL();

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in CLODataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        //On Data Grid Cell Content Click
        private void CLODataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(CLODataGrid.Rows[e.RowIndex].Cells["SerialNumber"].Value.ToString());

            if (CLODataGrid.Columns[e.ColumnIndex].Name == "View_DGV")
            {
                ViewCLO _viewClo = new ViewCLO(ID);
                _viewClo.Show();
            }
            if (CLODataGrid.Columns[e.ColumnIndex].Name == "Update_DGV")
            {
                UpdateCLO _updateClo = new UpdateCLO(ID);
                _updateClo.Show();
            }
            if (CLODataGrid.Columns[e.ColumnIndex].Name == "Delete_DGV")
            {
                DialogResult ResultDialoge = MessageBox.Show("Are You Sure to Delete This Campus?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ResultDialoge == DialogResult.Yes)
                {
                    DeleteCLO(ID);
                }
            }
        }

        //Delete CLO
        private void DeleteCLO(int iD)
        {
            _resultModel = _cloBll.DeleteCLOBLL(iD);
            if (_resultModel.Status)
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                GetCLOs();
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }
        }

        //Button Clicks
        private void AddCourse_Btn_Click(object sender, EventArgs e)
        {
            if (countCourses<10)
            {
                switch (countCourses)
                {
                    case 1:
                        Course_02_CB.Visible = true;
                        Type_02_CB.Visible = true;
                        PLO_02_CB.Visible = true;
                        break;
                    case 2:
                        Course_03_CB.Visible = true;
                        Type_03_CB.Visible = true;
                        PLO_03_CB.Visible = true;
                        break;
                    case 3:
                        Course_04_CB.Visible = true;
                        Type_04_CB.Visible = true;
                        PLO_04_CB.Visible = true;
                        break;
                    case 4:
                        Course_05_CB.Visible = true;
                        Type_05_CB.Visible = true;
                        PLO_05_CB.Visible = true;
                        break;
                    case 5:
                        Course_06_CB.Visible = true;
                        Type_06_CB.Visible = true;
                        PLO_06_CB.Visible = true;
                        break;
                    case 6:
                        Course_07_CB.Visible = true;
                        Type_07_CB.Visible = true;
                        PLO_07_CB.Visible = true;
                        break;
                    case 7:
                        Course_08_CB.Visible = true;
                        Type_08_CB.Visible = true;
                        PLO_08_CB.Visible = true;
                        break;
                    case 8:
                        Course_09_CB.Visible = true;
                        Type_09_CB.Visible = true;
                        PLO_09_CB.Visible = true;
                        break;
                    case 9:
                        Course_10_CB.Visible = true;
                        Type_10_CB.Visible = true;
                        PLO_10_CB.Visible = true;
                        break;
                }

                
            }
            countCourses++;
        }
        private void DeleteCourse_Btn_Click(object sender, EventArgs e)
        {
            if (countCourses > 1)
            {
                switch (countCourses)
                {
                    case 1:
                        Course_02_CB.Visible = false;
                        Type_02_CB.Visible = false;
                        PLO_02_CB.Visible = false;
                        break;
                    case 2:
                        Course_03_CB.Visible = false;
                        Type_03_CB.Visible = false;
                        PLO_03_CB.Visible = false;
                        break;
                    case 3:
                        Course_04_CB.Visible = false;
                        Type_04_CB.Visible = false;
                        PLO_04_CB.Visible = false;
                        break;
                    case 4:
                        Course_05_CB.Visible = false;
                        Type_05_CB.Visible = false;
                        PLO_05_CB.Visible = false;
                        break;
                    case 5:
                        Course_06_CB.Visible = false;
                        Type_06_CB.Visible = false;
                        PLO_06_CB.Visible = false;
                        break;
                    case 6:
                        Course_07_CB.Visible = false;
                        Type_07_CB.Visible = false;
                        PLO_07_CB.Visible = false;
                        break;
                    case 7:
                        Course_08_CB.Visible = false;
                        Type_08_CB.Visible = false;
                        PLO_08_CB.Visible = false;
                        break;
                    case 8:
                        Course_09_CB.Visible = false;
                        Type_09_CB.Visible = false;
                        PLO_09_CB.Visible = false;
                        break;
                    case 9:
                        Course_10_CB.Visible = false;
                        Type_10_CB.Visible = false;
                        PLO_10_CB.Visible = false;
                        break;
                }

                countCourses--;
            }
           
        }
        private void ManageCLOs_Btn_Click(object sender, EventArgs e)
        {
            CLOs_TabControl.SelectTab(1);
        }

        //Create CLO
        private void CreateCLO_Btn_Click(object sender, EventArgs e)
        {
            if (Code_errorFlag.Visible || Description_errorFlag.Visible)
            {
                if (Code_errorFlag.Visible)
                {
                    Code_errorLbl.Visible = true;
                }
                else
                {
                    Description_errorLbl.Visible = true;
                }
                _instituteForm.NotifyAlert("Fields marked with * are required",Form_Alert.enmType.Error);
            }
            else
            {
                CreateCLO();
            }
        }
        private void CreateCLO()
        {
            _cloBEL.Code = Code_TB.Text;
            _cloBEL.Description = Description_RTB.Text;
            _cloBEL.isActive = Active_CB.Checked;

            //Sql Transaction is needed
                //start from here

            _resultModel = _cloBll.CreateCLOBLL(_cloBEL);
            if (_resultModel.Status)
            {
                int CLOId = Convert.ToInt32(_resultModel.Data);
                List<CLOCourse> _cloCourses = new List<CLOCourse>();

                for (int i = 0; i < countCourses; i++)
                {
                    if (i==0)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_01_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_01_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_01_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 1)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_02_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_02_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_02_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 2)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_03_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_03_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_03_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 3)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_04_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_04_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_04_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 4)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_05_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_05_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_05_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 5)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_06_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_06_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_06_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 6)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_07_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_07_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_07_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 7)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_08_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_08_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_08_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 8)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_09_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_09_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_09_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 9)
                    {
                        CLOCourse _cloBel = new CLOCourse();
                        _cloBel.CourseId = Convert.ToInt32(Course_10_CB.SelectedValue);
                        _cloBel.PLO_Id = Convert.ToInt32(PLO_10_CB.SelectedValue);
                        _cloBel.Type_Id = Convert.ToInt32(Type_10_CB.SelectedValue);
                        _cloBel.CLOId = CLOId;
                        _cloCourses.Add(_cloBel);
                    }
                }

                _resultModel = _cloBll.CreateCLOCourseBLL(_cloCourses);

                //Clearing the list to avoid duplicate data
                _cloCourses.Clear();

                if (_resultModel.Status)
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    CLOs_TabControl.SelectTab(1);
                    GetCLOs();
                }
                else
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                }
            }
            else
            {
                _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }

        }


        //Text Box Changed Events
        private void Code_TB_TextChanged(object sender, EventArgs e)
        {
            Code_errorFlag.Visible = (Code_TB.Text == string.Empty)?true:false;
        }

        private void Description_RTB_TextChanged(object sender, EventArgs e)
        {
            Description_errorFlag.Visible = (Description_RTB.Text == string.Empty) ? true : false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        //Filtering DGV
        private void FilterCourse_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CLODataGrid.DataSource = _cloBll.filterbyCourseBll(Convert.ToInt32(FilterCourse_CB.SelectedValue));

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in CLODataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }

        private void FilterActive_CB_CheckedChanged(object sender, EventArgs e)
        {
            CLODataGrid.DataSource = _cloBll.filterbyActiveBll(FilterActive_CB.Checked);

            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in CLODataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }
        }


        //On Enter key down
        private void onEnterKey(object sender, KeyEventArgs e)
        {
            CLODataGrid.DataSource = _cloBll.filterbyCodeBll(FilterCode_TB.Text);
            //Setting Serial Numbers for rows
            foreach (DataGridViewRow dataGridViewRow in CLODataGrid.Rows)
            {
                dataGridViewRow.Cells[0].Value = dataGridViewRow.Index + 1;
            }

            FilterCode_TB.Clear();
        }

        //Refreshing data in grid view
        private void RefreshDataGrid_Btn_Click(object sender, EventArgs e)
        {
            GetCLOs();
        }

        private void CLOs_TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCLOs();
        }

        //Apply Filter button

        private bool flagForFilter;
        private void applyFilter_Btn_Click(object sender, EventArgs e)
        {
            if (flagForFilter == false)
            {
                flagForFilter = true;
                FilterActive_CB.Enabled = true;
                FilterCode_TB.Enabled = true;
                FilterCourse_CB.Enabled = true;

                applyFilter_Btn.BackColor = Color.Gray;
            }
            else
            {
                flagForFilter = false;
                FilterActive_CB.Enabled = false;
                FilterCode_TB.Enabled = false;
                FilterCourse_CB.Enabled = false;


                applyFilter_Btn.BackColor = Color.White;
                GetCLOs();
            }
        }
    }
}
