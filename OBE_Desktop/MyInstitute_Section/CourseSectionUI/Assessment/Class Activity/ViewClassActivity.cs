using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using OBE_BEL;
using OBE_BEL.MyInstitute_Section.CourseSectionBEL.Assessment;
using OBE_BEL.OBE_Section.CLO_BEL;
using OBE_BLL.AssessmentSection_BLL;
using OBE_BLL.MyInstitute_BLL.CourseSection.Assessment;
using OBE_BLL.OBESection_BLL;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity
{
    public partial class ViewClassActivity : Form
    {
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
        private int id;

        public ViewClassActivity()
        {
            InitializeComponent();
        }

        public ViewClassActivity(int id)
        {
            this.id = id;
            InitializeComponent();

        }


        private void ViewClassActivity_Load(object sender, EventArgs e)
        {
            FillPrevData();
        }
        private void FillPrevData()
        {
            var _classActivity = _ClassActivityBll.getclassActByIdBLL(id);
            ActivityID_TB.Text = _classActivity.Id.ToString();

            //Getting activity Type Name
            var activityType = new Activity_BLL().GetActivityByIdBLL(_classActivity.ActivityId);
            Activity_CB.Text = activityType.Name;

            ActivityName_TB.Text = _classActivity.Name;
            ActivityDate_DTP.Text= _classActivity.ActivityDate.ToString();

            TotalMarks_TB.Text = _classActivity.TotalMarks.ToString();

            //checking if gpa weight is not null
            if (_classActivity.GpaWeight != 0)
            {
                GPAWeight_NUD.Text = _classActivity.GpaWeight.ToString();
            }
            includeGPACalc_CB.Text = _classActivity.IncludeGpaCal?"Yes":"No";
            ComplexEP_CB.Text = _classActivity.ComplexEP?"Yes":"No";
            CourseSectionId = _classActivity.CourseSecId;

            //Getting Sub Activities Joined with This Class Activity
            var prevSubActivities = _ClassActivityBll.GetSubActByActIdBLL(id);
            CountSubActivity = prevSubActivities.Count;
            for (int i = 0; i < CountSubActivity; i++)
            {
                if (i == 0)
                {
                    SubActivityID_TB.Text = prevSubActivities[i].Id.ToString();
                    Name_TB.Text = prevSubActivities[i].Name;
                    MaxMarks_NUD.Text = prevSubActivities[i].MaxMarks.ToString();
                    if (prevSubActivities[i].OBEWeight != 0)
                    {
                        OBEWeight_NUD.Text = prevSubActivities[i].OBEWeight.ToString();
                        OBEWeight_NUD.Visible = false;
                    }

                    CLO_CB.Text = prevSubActivities[i].CloId.ToString();

                }
                else
                {
                    AddNewControls(i);
                    foreach (var item in this.Controls.OfType<TextBox>())
                    {
                        if (item.Name == "SubActivityID_TB" + i.ToString())
                        {
                            item.Text = prevSubActivities[i].Id.ToString();
                        }
                        else if (item.Name == "Name_TB" + i.ToString())
                        {
                            item.Text = prevSubActivities[i].Name;
                        }

                        else if (item.Name == "MaxMarks_NUD" + i.ToString())
                        {
                            item.Text = Convert.ToString(prevSubActivities[i].MaxMarks);
                        }

                        else if (item.Name == "OBEWeight_NUD" + i.ToString())
                        {
                            item.Text = (prevSubActivities[i].OBEWeight != 0) ? prevSubActivities[i].OBEWeight.ToString() : 0.ToString();
                            item.Visible = false;
                        }

                        else if (item.Name =="CLO_CB" + i.ToString())
                        {
                            CLO clo = _cloBll.getCLOByIdBLL(prevSubActivities[i].CloId);
                            item.Text = clo.Code + " - " + clo.Description;
                        }

                    }

                  
                }

            }
        }



        private void AddNewControls(int count)
        {
            AddSubActIDLabel(count);
            AddSubActIDTextBox(count);

            AddNameLabel(count);
            AddNameTextBox(count);
            AddMaxMarksLabel(count);
            AddMaxMarksTextBox(count);

            AddOBELabel(count);
            AddOBETextBox(count);

            AddCLOLabel(count);
            AddCLOComboBox(count);

        }

        private void AddSubActIDLabel(int count)
        {
            BunifuCustomLabel SubIdLbl = new Bunifu.Framework.UI.BunifuCustomLabel();

            SubIdLbl.Visible = true;
            SubIdLbl.Font = this.SubActivityID_Lbl.Font;
            SubIdLbl.Location = new System.Drawing.Point(this.SubActivityID_Lbl.Location.X,
                this.SubActivityID_Lbl.Location.Y + 160 * (count - 1));
            SubIdLbl.Name = "SubActivityID_Lbl" + count.ToString();
            SubIdLbl.Size = this.SubActivityID_Lbl.Size;
            SubIdLbl.Text = "Sub Activity ID";
            SubIdLbl.Visible = false;
            this.Controls.Add(SubIdLbl);
        }

        private void AddSubActIDTextBox(int count)
        {
            TextBox SubActIDTB = new TextBox();

            SubActIDTB.BackColor = System.Drawing.SystemColors.Control;
            SubActIDTB.Font = this.SubActivityID_TB.Font;
            SubActIDTB.Location = new System.Drawing.Point(SubActivityID_TB.Location.X, SubActivityID_TB.Location.Y + 160 * (count - 1));
            SubActIDTB.Multiline = true;
            SubActIDTB.Name = "SubActivityID_TB" + count.ToString();
            SubActIDTB.Size = SubActivityID_TB.Size;
            SubActIDTB.Text = 0.ToString();
            SubActIDTB.Visible = false;
            SubActIDTB.Enabled = false;

            this.Controls.Add(SubActIDTB);
        }

        //Add Name Controls
        private void AddNameLabel(int count)
        {
            BunifuCustomLabel NameLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            NameLbl.AutoSize = true;
            NameLbl.Font = this.Name_Lbl.Font;
            NameLbl.Size = this.Name_Lbl.Size;
            NameLbl.Text = "Name";
            NameLbl.Location = new System.Drawing.Point(Name_Lbl.Location.X, this.Name_Lbl.Location.Y + 160 * count);
            NameLbl.Name = "Name_Lbl" + count.ToString();

            this.Controls.Add(NameLbl);
        }
        private void AddNameTextBox(int count)
        {
            TextBox NameTB = new TextBox();
            NameTB.BackColor = System.Drawing.SystemColors.Control;
            NameTB.Font = this.Name_TB.Font;
            NameTB.Location = new System.Drawing.Point(Name_TB.Location.X, this.Name_TB.Location.Y + 160 * count);
            NameTB.Multiline = true;
            NameTB.Name = "Name_TB" + count.ToString();
            NameTB.Size = this.Name_TB.Size;

            NameTB.Enabled = false;
            this.Controls.Add(NameTB);
        }

        //Add Max Marks Controls
        private void AddMaxMarksLabel(int count)
        {
            BunifuCustomLabel MaxMrksLbl = new BunifuCustomLabel();

            MaxMrksLbl.AutoSize = true;
            MaxMrksLbl.Font = this.MaxMrks_Lbl.Font;
            MaxMrksLbl.Location = new System.Drawing.Point(MaxMrks_Lbl.Location.X, this.MaxMrks_Lbl.Location.Y + 160 * count);
            MaxMrksLbl.Name = "MaxMrks_Lbl" + count.ToString();
            MaxMrksLbl.Size = this.MaxMrks_Lbl.Size;
            MaxMrksLbl.Text = "Max. Marks";

            this.Controls.Add(MaxMrksLbl);
        }
        private void AddMaxMarksTextBox(int count)
        {
            TextBox MaxMarksTB = new TextBox();

            MaxMarksTB.BackColor = System.Drawing.SystemColors.Control;
            MaxMarksTB.Font = this.MaxMarks_NUD.Font;
            MaxMarksTB.Location = new System.Drawing.Point(this.MaxMarks_NUD.Location.X, this.MaxMarks_NUD.Location.Y + 160 * count);
            MaxMarksTB.Multiline = true;
            MaxMarksTB.Name = "MaxMarks_NUD" + count.ToString();
            MaxMarksTB.Size = this.MaxMarks_NUD.Size;
            MaxMarksTB.Enabled = false;
            this.Controls.Add(MaxMarksTB);

        }
    
        //Add OBE Weight % Controls
        private void AddOBELabel(int count)
        {
            BunifuCustomLabel obeWghtLbl = new BunifuCustomLabel();

            obeWghtLbl.AutoSize = true;
            obeWghtLbl.Font = this.obeWght_Lbl.Font;
            obeWghtLbl.Location = new System.Drawing.Point(obeWght_Lbl.Location.X, this.obeWght_Lbl.Location.Y + 160 * count);
            obeWghtLbl.Name = "obeWght_Lbl" + count.ToString();
            obeWghtLbl.Size = this.obeWght_Lbl.Size;
            obeWghtLbl.Text = "% OBE Weight";
            obeWghtLbl.Visible = false;
            this.Controls.Add(obeWghtLbl);
        }
        private void AddOBETextBox(int count)
        {
                        NumericUpDown OBEWeightNUD = new NumericUpDown();

            OBEWeightNUD.BackColor = System.Drawing.SystemColors.Control;
            OBEWeightNUD.Font = this.OBEWeight_NUD.Font;
            OBEWeightNUD.Location = new System.Drawing.Point(OBEWeight_NUD.Location.X, this.OBEWeight_NUD.Location.Y + 160 * count);
             
            OBEWeightNUD.Name = "OBEWeight_NUD" + count.ToString();
            OBEWeightNUD.Size = this.OBEWeight_NUD.Size;
            OBEWeightNUD.Visible = false;
            OBEWeightNUD.Enabled = false;
            this.Controls.Add(OBEWeightNUD);

        }

        //Add CLO Controls
        private void AddCLOLabel(int count)
        {
            BunifuCustomLabel CloLbl = new BunifuCustomLabel();

            CloLbl.AutoSize = true;
            CloLbl.Font = this.Clo_Lbl.Font;
            CloLbl.Location = new System.Drawing.Point(Clo_Lbl.Location.X, this.Clo_Lbl.Location.Y + 160 * count);
            CloLbl.Name = "Clo_Lbl" + count.ToString();
            CloLbl.Size = this.Clo_Lbl.Size;
            CloLbl.Text = "CLO";

            this.Controls.Add(CloLbl);
        }
        private void AddCLOComboBox(int count)
        {
            TextBox CLOCB = new TextBox();
            CLOCB.BackColor = System.Drawing.SystemColors.Control;
            CLOCB.Font = this.CLO_CB.Font;
            CLOCB.Location = new System.Drawing.Point(CLO_CB.Location.X, this.CLO_CB.Location.Y + 160 * count);
            CLOCB.Multiline = true;
            CLOCB.Name = "CLO_CB" + count.ToString();
            CLOCB.Size = this.CLO_CB.Size;
            CLOCB.Enabled = false;
            this.Controls.Add(CLOCB);
        }
    }
}
