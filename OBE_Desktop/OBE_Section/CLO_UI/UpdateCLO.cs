using System.Windows.Forms;
using OBE_BEL;
using OBE_BLL.OBESection_BLL;
using System;
using System.Collections.Generic;
using OBE_BEL.OBE_Section.CLO_BEL;
using OBE_BLL.MyInstitute_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.OBE_Section.CLO_UI
{
    public partial class UpdateCLO : Form
    {

        //Fields
        private int _CloId;
        private Institute _instituteForm = new Institute();
        private OBE_BEL.OBE_Section.CLO_BEL.CLO _cloBEL = new OBE_BEL.OBE_Section.CLO_BEL.CLO();
        private CLO_BLL _cloBll = new CLO_BLL();
        private Course_BLL _courseBll = new Course_BLL();
        private PLO_BLL _ploBll = new PLO_BLL();
        private ResultModel _resultModel = new ResultModel();
        private int countCourses = 1;


        //Constructor
        public UpdateCLO()
        {
            InitializeComponent();
        }

        public UpdateCLO(int iD)
        {
            this._CloId = iD;
            InitializeComponent();
            CLOId_TB.Text = iD.ToString();

        }


        //ON Load
        private void UpdateCLO_Load(object sender, System.EventArgs e)
        {

            HideLbls();
            HideFewControls();
            FillDropDowns();
            FillPrevData();

        }

        private void FillPrevData()
        {
            Program_BC.Visible = true;

            var _cloById = _cloBll.getCLOByIdBLL(_CloId);
            Code_TB.Text = _cloById.Code;
            Description_RTB.Text = _cloById.Description;
            Active_CB.Checked = _cloById.isActive;

            var _cloCourses = _cloBll.getCCourseByCloIdBLL(_CloId);
            countCourses = _cloCourses.Count;
            for (int i = 0; i < countCourses; i++)
            {
                switch (i)
                {
                    case 0:

                        PLO_01_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_01_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_01_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 1:
                        PLO_02_CB.Visible = true;
                        Course_02_CB.Visible = true;
                        Type_02_CB.Visible = true;

                        PLO_02_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_02_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_02_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 2:
                        PLO_03_CB.Visible = true;
                        Course_03_CB.Visible = true;
                        Type_03_CB.Visible = true;

                        PLO_03_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_03_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_03_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 3:
                        PLO_04_CB.Visible = true;
                        Course_04_CB.Visible = true;
                        Type_04_CB.Visible = true;

                        PLO_04_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_04_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_04_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 4:
                        PLO_05_CB.Visible = true;
                        Course_05_CB.Visible = true;
                        Type_05_CB.Visible = true;

                        PLO_05_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_05_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_05_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 5:
                        PLO_06_CB.Visible = true;
                        Course_06_CB.Visible = true;
                        Type_06_CB.Visible = true;

                        PLO_06_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_06_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_06_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 6:
                        PLO_07_CB.Visible = true;
                        Course_07_CB.Visible = true;
                        Type_07_CB.Visible = true;

                        PLO_07_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_07_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_07_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 7:
                        PLO_08_CB.Visible = true;
                        Course_08_CB.Visible = true;
                        Type_08_CB.Visible = true;

                        PLO_08_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_08_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_08_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 8:
                        PLO_09_CB.Visible = true;
                        Course_09_CB.Visible = true;
                        Type_09_CB.Visible = true;

                        PLO_09_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_09_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_09_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                    case 9:
                        PLO_10_CB.Visible = true;
                        Course_10_CB.Visible = true;
                        Type_10_CB.Visible = true;

                        PLO_10_CB.SelectedValue = _cloCourses[i].PLO_Id;
                        Course_10_CB.SelectedValue = _cloCourses[i].CourseId;
                        Type_10_CB.SelectedValue = _cloCourses[i].Type_Id;
                        break;
                }
            }
        }

        private void HideLbls()
        {
            Code_errorLbl.Visible = false;
            Description_errorLbl.Visible = false;
        }
        private void HideFewControls()
        {

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

        }



        //Text Box Change Events
        private void Code_TB_TextChanged(object sender, EventArgs e)
        {
            Code_errorFlag.Visible = (Code_TB.Text == string.Empty) ? true : false;
        }

        private void Description_RTB_TextChanged(object sender, EventArgs e)
        {
            Description_errorFlag.Visible = (Description_RTB.Text == string.Empty) ? true : false;
        }


        //Button Clicks
        private void AddCourse_Btn_Click(object sender, EventArgs e)
        {
            if (countCourses < 10)
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
                countCourses++;
            }
           
        }

        private void DeleteCourse_Btn_Click(object sender, EventArgs e)
        {
            if (countCourses > 1)
            {
                switch (countCourses)
                {
                    case 2:
                        Course_02_CB.Visible = false;
                        Type_02_CB.Visible = false;
                        PLO_02_CB.Visible = false;
                        break;
                    case 3:
                        Course_03_CB.Visible = false;
                        Type_03_CB.Visible = false;
                        PLO_03_CB.Visible = false;
                        break;
                    case 4:
                        Course_04_CB.Visible = false;
                        Type_04_CB.Visible = false;
                        PLO_04_CB.Visible = false;
                        break;
                    case 5:
                        Course_05_CB.Visible = false;
                        Type_05_CB.Visible = false;
                        PLO_05_CB.Visible = false;
                        break;
                    case 6:
                        Course_06_CB.Visible = false;
                        Type_06_CB.Visible = false;
                        PLO_06_CB.Visible = false;
                        break;
                    case 7:
                        Course_07_CB.Visible = false;
                        Type_07_CB.Visible = false;
                        PLO_07_CB.Visible = false;
                        break;
                    case 8:
                        Course_08_CB.Visible = false;
                        Type_08_CB.Visible = false;
                        PLO_08_CB.Visible = false;
                        break;
                    case 9:
                        Course_09_CB.Visible = false;
                        Type_09_CB.Visible = false;
                        PLO_09_CB.Visible = false;
                        break;
                    case 10:
                        Course_10_CB.Visible = false;
                        Type_10_CB.Visible = false;
                        PLO_10_CB.Visible = false;
                        break;
                }
                countCourses--;
            }
           
        }


        private void UpdateCLO_Btn_Click(object sender, EventArgs e)
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
                _instituteForm.NotifyAlert("Fields marked with * are required", Form_Alert.enmType.Error);
            }
            else
            {
                UpdateACLO();
            }
        }

        private void UpdateACLO()
        {
            _cloBEL.Id = Convert.ToInt32(CLOId_TB.Text);
            _cloBEL.Code = Code_TB.Text;
            _cloBEL.Description = Description_RTB.Text;
            _cloBEL.isActive = Active_CB.Checked;

            _resultModel = _cloBll.UpdateCLOBLL(_cloBEL);
            if (_resultModel.Status)
            {
                int CLOId = Convert.ToInt32(_resultModel.Data);
                List<CLOCourse> _cloCourses = new List<CLOCourse>();

                for (int i = 0; i < countCourses; i++)
                {
                    if (i == 0)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_01_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_01_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_01_CB.SelectedValue),
                            CLOId = CLOId
                        };
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 1)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_02_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_02_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_02_CB.SelectedValue),
                            CLOId = CLOId
                        };

                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 2)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_03_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_03_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_03_CB.SelectedValue),
                            CLOId = CLOId
                        };

                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 3)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_04_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_04_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_04_CB.SelectedValue),
                            CLOId = CLOId
                        };

                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 4)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_05_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_05_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_05_CB.SelectedValue),
                            CLOId = CLOId
                        };

                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 5)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_06_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_06_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_06_CB.SelectedValue),
                            CLOId = CLOId
                        };

                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 6)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_07_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_07_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_07_CB.SelectedValue),
                            CLOId = CLOId
                        };

                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 7)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_08_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_08_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_08_CB.SelectedValue),
                            CLOId = CLOId
                        };
                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 8)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_09_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_09_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_09_CB.SelectedValue),
                            CLOId = CLOId
                        };


                        _cloCourses.Add(_cloBel);
                    }
                    if (i == 9)
                    {
                        CLOCourse _cloBel = new CLOCourse
                        {
                            CourseId = Convert.ToInt32(Course_10_CB.SelectedValue),
                            PLO_Id = Convert.ToInt32(PLO_10_CB.SelectedValue),
                            Type_Id = Convert.ToInt32(Type_10_CB.SelectedValue),
                            CLOId = CLOId
                        };

                        _cloCourses.Add(_cloBel);
                    }
                }

                _resultModel = _cloBll.UpdateCLOCourseBLL(_cloCourses);

                //Clear the list to avoid duplicate entry for next time
                _cloCourses.Clear();
                if (_resultModel.Status)
                {
                    _instituteForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    Close();
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
    }
}
