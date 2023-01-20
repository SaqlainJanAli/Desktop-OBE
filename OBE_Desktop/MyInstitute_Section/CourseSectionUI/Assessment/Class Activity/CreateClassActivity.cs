using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.ActivityWeight;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Activity_Weight;
using OBE_BLL.MyInstitute_BLL.CourseSection.Assessment;
using OBE_BLL.OBESection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;
using Control = System.Windows.Forms.Control;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity
{
    public partial class CreateClassActivity : Form
    {
        //Fields
        private int CountSubActivity = 1;
        private int CourseSectionId = 0;
        private List<SubActivity> _subActivities = new List<SubActivity>();
        private CLO_BLL _cloBll = new CLO_BLL();
        private Activity_BLL _activityBll = new Activity_BLL();
        private ResultModel _resultModel = new ResultModel();
        private ClassActivity_BLL _ClassActivityBll = new ClassActivity_BLL();
        private OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment.ClassActivity _classActivityBEL =
            new OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment.ClassActivity();
        private Institute _instForm = new Institute();
        private ActivityWeightBLL _activityWeightBll = new ActivityWeightBLL();
        decimal _totalweight = Convert.ToDecimal(0.00);
        private List<ActivityWeight> activityWeights = new List<ActivityWeight>();

        private decimal usedActivityWeight = Convert.ToDecimal(0.00);
        //Constructor
        public CreateClassActivity()
        {
            InitializeComponent();
        }

        public CreateClassActivity(int courseSectionId)
        {
            this.CourseSectionId = courseSectionId;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        //On Load
        private void ClassActivity_Load(object sender, EventArgs e)
        {
            HideFewControls();
            FillDropDowns();
            GetActivityWeights();

            TotalMarks_TB.ReadOnly = true;
            TotalMarks_TB.Enabled = false;
            TotalMarks_TB.Text = 0.ToString();
            ActivityDate_DTP.MaxDate = DateTime.Now;

        }



        //Get Weights
        private void GetActivityWeights()
        {
            activityWeights = _activityWeightBll.GetWeightsByCourseSecIdBLL(CourseSectionId);
            foreach (var activityWeight in activityWeights)
            {
                _totalweight += activityWeight.Weight;
            }
        }

        //Hiding Error Labels
        private void HideFewControls()
        {
            Activity_errorLbl.Visible = false;
            MaxMarks_errorLbl.Visible = false;
            Name_errorLbl.Visible = false;
            SubName_errorLbl.Visible = false;
            TotalMarks_errorLbl.Visible = false;
            totalWarningLbl.Visible = false;
            TotalWeight_Lbl.Visible = false;
            gpaWeight_errorLbl.Visible = false;
        }

        //Populating Combobox
        private void FillDropDowns()
        {
            GetActivities();
            GetClos();
            AutoScroll = true;
        }
        private void GetClos()
        {
            CLO_CB.DisplayMember = "CodePlusDescription";
            CLO_CB.ValueMember = "Id";
            CLO_CB.DataSource = _cloBll.GetCLOsByCourseIdBLL(CourseSectionId);
        }
        private void GetActivities()
        {
            Activity_CB.DisplayMember = "Name";
            Activity_CB.ValueMember = "Id";
            Activity_CB.DataSource = _activityBll.GetActTypesByCourseSecIdBLL(CourseSectionId);
        }





        // DYNAMIC CONTROLS

        //Add Sub Activity Button Click
        private void AddSubActivity_Btn_Click(object sender, EventArgs e)
        {
            AddNameLabel();
            AddNameTextBox();
            AddNameErrorFlag();

            AddMaxMarksLabel();
            AddMaxMarksNUD();
            AddMaxMarksErrorFlag();

            AddOBELabel();
            AddOBEWeightNUD();

            AddCLOLabel();
            AddCLOComboBox();

            AddSubActivity_Btn.Location = new Point(this.AddSubActivity_Btn.Location.X, this.AddSubActivity_Btn.Location.Y + 160);
            DeleteSubActivity_Btn.Location = new Point(this.DeleteSubActivity_Btn.Location.X,
                this.DeleteSubActivity_Btn.Location.Y + 160);

            CountSubActivity++;
        }

        //Add Name Controls
        private void AddNameLabel()
        {
            BunifuCustomLabel NameLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            NameLbl.AutoSize = true;
            NameLbl.Font = this.Name_Lbl.Font;
            NameLbl.Size = this.Name_Lbl.Size;
            NameLbl.Text = "Name";
            NameLbl.Location = new System.Drawing.Point(33, this.Name_Lbl.Location.Y + 160 * CountSubActivity);
            NameLbl.Name = "Name_Lbl" + CountSubActivity.ToString();

            this.Controls.Add(NameLbl);
        }
        private void AddNameTextBox()
        {
            TextBox NameTB = new TextBox();
            NameTB.BackColor = System.Drawing.SystemColors.Control;
            NameTB.Font = this.Name_TB.Font;
            NameTB.Location = new System.Drawing.Point(Name_TB.Location.X, this.Name_TB.Location.Y + 160 * CountSubActivity);
            NameTB.Multiline = true;
            NameTB.Name = "Name_TB" + CountSubActivity.ToString();
            NameTB.Size = this.Name_TB.Size;

            NameTB.TextChanged += new EventHandler(NameTextChangedEvent);
            this.Controls.Add(NameTB);
        }
        private void AddNameErrorFlag()
        {
            Label NameErrorFlag = new Label();

            NameErrorFlag.Text = "*";
            NameErrorFlag.Font = this.SubActName_errorFlag.Font;
            NameErrorFlag.ForeColor = System.Drawing.Color.Red;
            NameErrorFlag.Location = new Point(SubActName_errorFlag.Location.X, SubActName_errorFlag.Location.Y + 160 * CountSubActivity);
            NameErrorFlag.Name = "SubActName_errorFlag" + CountSubActivity.ToString();
            NameErrorFlag.Size = SubActName_errorFlag.Size;

            this.Controls.Add(NameErrorFlag);
        }
        private void NameTextChangedEvent(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            foreach (Label item in Controls.OfType<Label>())
            {
                for (int i = 1; i < CountSubActivity; i++)
                {
                    if (item.Name == "SubActName_errorFlag" + (i).ToString())
                    {
                        item.Visible = (tb.Text == string.Empty) ? true : false;
                    }
                }
            }
        }

        //Add Max Marks Controls
        private void AddMaxMarksLabel()
        {
            BunifuCustomLabel MaxMrksLbl = new BunifuCustomLabel();

            MaxMrksLbl.AutoSize = true;
            MaxMrksLbl.Font = this.MaxMrks_Lbl.Font;
            MaxMrksLbl.Location = new System.Drawing.Point(MaxMrks_Lbl.Location.X, this.MaxMrks_Lbl.Location.Y + 160 * CountSubActivity);
            MaxMrksLbl.Name = "MaxMrks_Lbl" + CountSubActivity.ToString();
            MaxMrksLbl.Size = this.MaxMrks_Lbl.Size;
            MaxMrksLbl.Text = "Max. Marks";

            this.Controls.Add(MaxMrksLbl);
        }
        private void AddMaxMarksNUD()
        {
            NumericUpDown maxMarksNUD = new NumericUpDown();

            maxMarksNUD.BackColor = System.Drawing.SystemColors.Control;
            maxMarksNUD.Font = this.MaxMarks_NUD.Font;
            maxMarksNUD.Location = new System.Drawing.Point(this.MaxMarks_NUD.Location.X, this.MaxMarks_NUD.Location.Y + 160 * CountSubActivity);
            maxMarksNUD.DecimalPlaces = 2;
            maxMarksNUD.Increment = MaxMarks_NUD.Increment;
            maxMarksNUD.Name = "MaxMarks_NUD" + CountSubActivity.ToString();
            maxMarksNUD.Size = this.MaxMarks_NUD.Size;
            maxMarksNUD.ValueChanged += new EventHandler(MaxMarksValueChanged);
            maxMarksNUD.Leave += new EventHandler(LeavingMaxMarksNUD);
            this.Controls.Add(maxMarksNUD);

        }
        private void MaxMarksValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            foreach (Label item in Controls.OfType<Label>())
            {
                for (int i = 1; i < CountSubActivity; i++)
                {
                    if (item.Name == "MaxMarks_errorFlag" + (i).ToString())
                    {
                        item.Visible = nud.Value == Convert.ToDecimal(0.00);
                    }
                }
            }


        }
        private void LeavingMaxMarksNUD(object sender, EventArgs e)
        {
            var CollectMaxMarks = new List<decimal>();
            NumericUpDown tb = (NumericUpDown)sender;
            if (tb.Text != string.Empty)
            {
                foreach (NumericUpDown item in Controls.OfType<NumericUpDown>())
                {
                    if (item.Name.StartsWith("MaxMarks_NUD") && item.Value != Convert.ToDecimal(0.00))
                    {
                        CollectMaxMarks.Add(item.Value);
                    }
                }
                TotalMarks_TB.Clear();
                TotalMarks_TB.Text = (0.00).ToString();
                foreach (var item in CollectMaxMarks)
                {
                    TotalMarks_TB.Text = (Convert.ToDecimal(TotalMarks_TB.Text) + (item)).ToString();
                }
            }
        }
        private void AddMaxMarksErrorFlag()
        {
            Label maxMarksflag = new Label();

            maxMarksflag.Text = "*";
            maxMarksflag.Location = new Point(MaxMarks_errorFlag.Location.X, MaxMarks_errorFlag.Location.Y + 160 * CountSubActivity);
            maxMarksflag.Size = MaxMarks_errorFlag.Size;
            maxMarksflag.Font = MaxMarks_errorFlag.Font;
            maxMarksflag.ForeColor = Color.Red;
            maxMarksflag.Name = "MaxMarks_errorFlag" + CountSubActivity.ToString();

            this.Controls.Add(maxMarksflag);


        }

        //Add OBE Weight % Controls
        private void AddOBELabel()
        {
            BunifuCustomLabel obeWghtLbl = new BunifuCustomLabel();

            obeWghtLbl.AutoSize = true;
            obeWghtLbl.Font = this.obeWght_Lbl.Font;
            obeWghtLbl.Location = new System.Drawing.Point(obeWght_Lbl.Location.X, this.obeWght_Lbl.Location.Y + 160 * CountSubActivity);
            obeWghtLbl.Name = "obeWght_Lbl" + CountSubActivity.ToString();
            obeWghtLbl.Size = this.obeWght_Lbl.Size;
            obeWghtLbl.Text = "% OBE Weight";
            obeWghtLbl.Visible = false;
            this.Controls.Add(obeWghtLbl);
        }
        private void AddOBEWeightNUD()
        {
            NumericUpDown OBEWeightNUD = new NumericUpDown();

            OBEWeightNUD.BackColor = System.Drawing.SystemColors.Control;
            OBEWeightNUD.Font = this.OBEWeight_NUD.Font;
            OBEWeightNUD.Location = new System.Drawing.Point(OBEWeight_NUD.Location.X, this.OBEWeight_NUD.Location.Y + 160 * CountSubActivity);
            OBEWeightNUD.DecimalPlaces = 2;
            OBEWeightNUD.Increment = this.OBEWeight_NUD.Increment;
            OBEWeightNUD.Name = "OBEWeight_NUD" + CountSubActivity.ToString();
            OBEWeightNUD.Size = this.OBEWeight_NUD.Size;
            OBEWeightNUD.Value = Convert.ToDecimal(0.00);
            OBEWeightNUD.Visible = false;
            this.Controls.Add(OBEWeightNUD);

        }

        //Add CLO Controls
        private void AddCLOLabel()
        {
            BunifuCustomLabel CloLbl = new BunifuCustomLabel();

            CloLbl.AutoSize = true;
            CloLbl.Font = this.Clo_Lbl.Font;
            CloLbl.Location = new System.Drawing.Point(Clo_Lbl.Location.X, this.Clo_Lbl.Location.Y + 160 * CountSubActivity);
            CloLbl.Name = "Clo_Lbl" + CountSubActivity.ToString();
            CloLbl.Size = this.Clo_Lbl.Size;
            CloLbl.Text = "CLO";

            this.Controls.Add(CloLbl);
        }
        private void AddCLOComboBox()
        {
            ComboBox CLOCB = new ComboBox();
            CLOCB.DropDownStyle = this.CLO_CB.DropDownStyle;
            CLOCB.Font = this.CLO_CB.Font;
            CLOCB.FormattingEnabled = true;
            CLOCB.IntegralHeight = false;
            CLOCB.Location = new System.Drawing.Point(CLO_CB.Location.X, this.CLO_CB.Location.Y + 160 * CountSubActivity);
            CLOCB.Name = "CLO_CB" + CountSubActivity.ToString();
            CLOCB.Size = this.CLO_CB.Size;

            CLOCB.DisplayMember = "CodePlusDescription";
            CLOCB.ValueMember = "Id";
            CLOCB.DataSource = _cloBll.GetCLOsByCourseIdBLL(CourseSectionId);

            this.Controls.Add(CLOCB);
        }



        //Delete Sub Activity Button Click
        private void DeleteSubActivity_Btn_Click(object sender, EventArgs e)
        {
            bool Nameflag = false;
            bool MaxMrksflag = false;
            bool obeflag = false;
            bool cloflag = false;


            if (CountSubActivity > 1)
            {
                //Search & Remove Name Label
                Nameflag = SearchAndRemoveControl("Name_Lbl" + (CountSubActivity - 1).ToString());
                //Search & Remove Error Flag
                Nameflag = SearchAndRemoveControl("SubActName_errorFlag" + (CountSubActivity - 1).ToString());
                //Search & Remove Name Text Box
                Nameflag = SearchAndRemoveControl("Name_TB" + (CountSubActivity - 1).ToString());


                //Search & Remove Max Marks Label
                MaxMrksflag = SearchAndRemoveControl("MaxMrks_Lbl" + (CountSubActivity - 1).ToString());
                //Search & Remove Error Flag
                MaxMrksflag = SearchAndRemoveControl("MaxMarks_errorFlag" + (CountSubActivity - 1).ToString());
                //Search & Remove Max Marks Text Box
                MaxMrksflag = SearchAndRemoveControl("MaxMarks_NUD" + (CountSubActivity - 1).ToString());


                //Search & Remove OBE Weight Label
                obeflag = SearchAndRemoveControl("obeWght_Lbl" + (CountSubActivity - 1).ToString());
                //Search & Remove OBE Weight Text Box
                obeflag = SearchAndRemoveControl("OBEWeight_NUD" + (CountSubActivity - 1).ToString());


                //Search & Remove CLO Label
                cloflag = SearchAndRemoveControl("Clo_Lbl" + (CountSubActivity - 1).ToString());
                //Search & Remove Name ComboBox
                cloflag = SearchAndRemoveControl("CLO_CB" + (CountSubActivity - 1).ToString());

            }
            if (Nameflag && MaxMrksflag && obeflag && cloflag)
            {
                DeleteSubActivity_Btn.Location = new Point(DeleteSubActivity_Btn.Location.X,
                    DeleteSubActivity_Btn.Location.Y - 160);
                AddSubActivity_Btn.Location = new Point(AddSubActivity_Btn.Location.X,
                    AddSubActivity_Btn.Location.Y - 160);


                CountSubActivity--;
            }
        }
        private bool SearchAndRemoveControl(string v)
        {
            bool flag = false;
            foreach (Control item in Controls)
            {
                if (item.Name == v)
                {
                    if (item.Name == "MaxMarks_NUD" + (CountSubActivity - 1).ToString())
                    {
                        if (item.Text != string.Empty)
                        {
                            Decimal totalmarks = Convert.ToDecimal(TotalMarks_TB.Text) - Convert.ToDecimal(item.Text);
                            TotalMarks_TB.Text = totalmarks.ToString();
                        }
                    }

                    Controls.Remove(item);
                    flag = true;
                    break;
                }
            }

            return flag;
        }


        //Value and text Changed Events
        private void TotalMarks_TB_TextChanged(object sender, EventArgs e)
        {
            TotalMarks_errorFlag.Visible = (TotalMarks_TB.Text == string.Empty) ? true : false;
        }
        private void ActivityName_TB_TextChanged(object sender, EventArgs e)
        {
            Name_errorFlag.Visible = (ActivityName_TB.Text == string.Empty) ? true : false;
        }
        private void Name_TB_TextChanged(object sender, EventArgs e)
        {
            SubActName_errorFlag.Visible = (Name_TB.Text == string.Empty) ? true : false;
        }
        private void Activity_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Activity_errorFlag.Visible = (Activity_CB.Text == string.Empty) ? true : false;
            int selectedActTypeId = Convert.ToInt32(Activity_CB.SelectedValue);
            usedActivityWeight = new ClassActivity_BLL().GetUsedActWeightByActTypeIdBLL(selectedActTypeId, CourseSectionId);

        }
        private void MaxMarks_NUD_Leave(object sender, EventArgs e)
        {
            //if (MaxMarks_NUD.Text != string.Empty)
            //{
            //    TotalMarks_TB.Text = Convert.ToString(Convert.ToDecimal(TotalMarks_TB.Text) + MaxMarks_NUD.Value);
            //}
            var CollectMaxMarks = new List<decimal>();
            NumericUpDown tb = (NumericUpDown)sender;
            if (tb.Text != string.Empty)
            {
                foreach (NumericUpDown item in Controls.OfType<NumericUpDown>())
                {
                    if (item.Name.StartsWith("MaxMarks_NUD") && item.Value != Convert.ToDecimal(0.00))
                    {
                        CollectMaxMarks.Add(item.Value);
                    }
                }
                TotalMarks_TB.Clear();
                TotalMarks_TB.Text = (0.00).ToString();
                foreach (var item in CollectMaxMarks)
                {
                    TotalMarks_TB.Text = (Convert.ToDecimal(TotalMarks_TB.Text) + (item)).ToString();
                }
            }
        }
        private void MaxMarks_NUD_ValueChanged(object sender, EventArgs e)
        {
            MaxMarks_errorFlag.Visible = MaxMarks_NUD.Value == Convert.ToDecimal(0.00);
        }
        private void GPAWeight_NUD_ValueChanged(object sender, EventArgs e)
        {
            gpaWeight_errorFlag.Visible = GPAWeight_NUD.Value == Convert.ToDecimal(0.00);
            foreach (var activityWeight in activityWeights)
            {
                if (activityWeight.ActivityId == Convert.ToInt32(Activity_CB.SelectedValue))
                {
                    if ((GPAWeight_NUD.Value + usedActivityWeight) > activityWeight.Weight)
                    {
                        totalWarningLbl.Visible = true;
                        TotalWeight_Lbl.Text = activityWeight.Weight.ToString();
                        TotalWeight_Lbl.Visible = true;
                    }
                    else
                    {
                        totalWarningLbl.Visible = false;
                        TotalWeight_Lbl.Visible = false;
                    }
                }
            }
        }

        //Create Activity Button Click
        private void CreateActivity_Btn_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < CountSubActivity; i++)
            {
                foreach (Label itemControl in Controls.OfType<Label>())
                {
                    if (itemControl.Name == "SubActName_errorFlag" + (i - 1).ToString())
                    {
                        SubActName_errorFlag.Visible = itemControl.Visible;
                    }

                    if (itemControl.Name == "MaxMarks_errorFlag" + (i - 1).ToString())
                    {
                        MaxMarks_errorFlag.Visible = itemControl.Visible;
                    }
                }
            }

            if (gpaWeight_errorFlag.Visible || totalWarningLbl.Visible || Activity_errorFlag.Visible || SubActName_errorFlag.Visible || MaxMarks_errorFlag.Visible || Name_errorFlag.Visible || TotalMarks_errorFlag.Visible)
            {
                if (gpaWeight_errorFlag.Visible)
                {
                    gpaWeight_errorLbl.Visible = true;
                }
                if (Activity_errorFlag.Visible)
                {
                    Activity_errorLbl.Visible = true;
                }
                else if (MaxMarks_errorFlag.Visible)
                {
                    MaxMarks_errorLbl.Visible = true;
                }
                else if (Name_errorFlag.Visible)
                {
                    Name_errorLbl.Visible = true;
                }
                else if (SubActName_errorFlag.Visible)
                {
                    SubName_errorLbl.Visible = true;
                }
                else if (TotalMarks_errorFlag.Visible)
                {
                    TotalMarks_errorLbl.Visible = true;
                }

                else if (totalWarningLbl.Visible)
                {
                    _instForm.NotifyAlert($"Activity weight for this activity is {TotalWeight_Lbl.Text}", Form_Alert.enmType.Error);
                }
                _instForm.NotifyAlert("Fields Marked with * are mandatory", Form_Alert.enmType.Error);
            }
            else
            {
                CreateActivity();
            }
        }

        //Creating class Activity
        private void CreateActivity()
        {
            int _ClassActivityId;

            _classActivityBEL.ActivityId = Convert.ToInt32(Activity_CB.SelectedValue);
            _classActivityBEL.Name = ActivityName_TB.Text;
            _classActivityBEL.ActivityDate = ActivityDate_DTP.Value;
            _classActivityBEL.TotalMarks = Convert.ToDecimal(TotalMarks_TB.Text);
            if (GPAWeight_NUD.Text != string.Empty)
            {
                _classActivityBEL.GpaWeight = Convert.ToDecimal(GPAWeight_NUD.Text);
            }
            _classActivityBEL.ComplexEP = ComplexEP_CB.Checked;
            _classActivityBEL.IncludeGpaCal = includeGPACalc_CB.Checked;
            _classActivityBEL.CourseSecId = CourseSectionId;


            _resultModel = _ClassActivityBll.CreateClassActivityBLL(_classActivityBEL);

            if (_resultModel.Status)
            {
                _ClassActivityId = Convert.ToInt32(_resultModel.Data);
                SubActivity _subActivityBEL = new SubActivity();
                _subActivityBEL.CloId = Convert.ToInt32(CLO_CB.SelectedValue);
                _subActivityBEL.ActivityId = _ClassActivityId;
                _subActivityBEL.MaxMarks = MaxMarks_NUD.Value;
                _subActivityBEL.Name = Name_TB.Text;
                _subActivityBEL.OBEWeight = OBEWeight_NUD.Value;
                _subActivities.Add(_subActivityBEL);

                for (int i = 1; i < CountSubActivity; i++)
                {
                    SubActivity _subActivity = new SubActivity();
                    _subActivity.ActivityId = _ClassActivityId;

                    foreach (TextBox item in Controls.OfType<TextBox>())
                    {
                        if (item.Name == "Name_TB" + i.ToString())
                        {
                            _subActivity.Name = item.Text;
                        }
                    }

                    foreach (var item in Controls.OfType<NumericUpDown>())
                    {
                        if (item.Name == "MaxMarks_NUD" + i.ToString())
                        {
                            _subActivity.MaxMarks = item.Value;
                        }
                        if (item.Name == "OBEWeight_NUD" + i.ToString())
                        {
                            _subActivity.OBEWeight = item.Value;
                        }
                    }
                    foreach (ComboBox item in Controls.OfType<ComboBox>())
                    {
                        if (item.Name == "CLO_CB" + i.ToString())
                        {
                            _subActivity.CloId = Convert.ToInt32(item.SelectedValue);
                        }
                    }

                    _subActivities.Add(_subActivity);
                }

                _resultModel = _ClassActivityBll.CreateSubActivityBLL(_subActivities);
                _subActivities.Clear();
                if (_resultModel.Status)
                {
                    _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Success);
                    this.Close();
                }
                else
                {
                    _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
                }
            }
            else
            {
                _instForm.NotifyAlert(_resultModel.Message, Form_Alert.enmType.Error);
            }

        }
        //Button Click
        private void ManageActivitites_Btn_Click(object sender, EventArgs e)
        {
            ClassActivityHome _classActivityHome = new ClassActivityHome(CourseSectionId);
            _classActivityHome.Show();
            this.Hide();

        }

        private void CLO_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
