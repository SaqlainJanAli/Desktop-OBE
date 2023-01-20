using System.Windows.Forms;

namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity
{
    partial class CreateClassActivity:Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClassActivity));
            this.ManageActivitites_Btn = new System.Windows.Forms.Button();
            this.CreateActivity_Btn = new System.Windows.Forms.Button();
            this.Activity_errorLbl = new System.Windows.Forms.Label();
            this.TotalMarks_errorLbl = new System.Windows.Forms.Label();
            this.MaxMarks_errorLbl = new System.Windows.Forms.Label();
            this.SubName_errorLbl = new System.Windows.Forms.Label();
            this.Name_errorLbl = new System.Windows.Forms.Label();
            this.MaxMarks_errorFlag = new System.Windows.Forms.Label();
            this.SubActName_errorFlag = new System.Windows.Forms.Label();
            this.TotalMarks_errorFlag = new System.Windows.Forms.Label();
            this.Activity_errorFlag = new System.Windows.Forms.Label();
            this.Name_errorFlag = new System.Windows.Forms.Label();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.includeGPACalc_CB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ComplexEP_CB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Activity_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ActivityName_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.TotalMarks_TB = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CLO_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Clo_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MaxMrks_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.obeWght_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeleteSubActivity_Btn = new System.Windows.Forms.Button();
            this.AddSubActivity_Btn = new System.Windows.Forms.Button();
            this.ActivityDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.totalWarningLbl = new System.Windows.Forms.Label();
            this.TotalWeight_Lbl = new System.Windows.Forms.Label();
            this.OBEWeight_NUD = new System.Windows.Forms.NumericUpDown();
            this.GPAWeight_NUD = new System.Windows.Forms.NumericUpDown();
            this.MaxMarks_NUD = new System.Windows.Forms.NumericUpDown();
            this.gpaWeight_errorFlag = new System.Windows.Forms.Label();
            this.gpaWeight_errorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OBEWeight_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPAWeight_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMarks_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageActivitites_Btn
            // 
            this.ManageActivitites_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ManageActivitites_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageActivitites_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageActivitites_Btn.ForeColor = System.Drawing.Color.White;
            this.ManageActivitites_Btn.Location = new System.Drawing.Point(572, 75);
            this.ManageActivitites_Btn.Name = "ManageActivitites_Btn";
            this.ManageActivitites_Btn.Size = new System.Drawing.Size(148, 33);
            this.ManageActivitites_Btn.TabIndex = 340;
            this.ManageActivitites_Btn.Text = "Manage Activities";
            this.ManageActivitites_Btn.UseVisualStyleBackColor = false;
            this.ManageActivitites_Btn.Click += new System.EventHandler(this.ManageActivitites_Btn_Click);
            // 
            // CreateActivity_Btn
            // 
            this.CreateActivity_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.CreateActivity_Btn.FlatAppearance.BorderSize = 0;
            this.CreateActivity_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateActivity_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateActivity_Btn.ForeColor = System.Drawing.Color.White;
            this.CreateActivity_Btn.Location = new System.Drawing.Point(431, 75);
            this.CreateActivity_Btn.Name = "CreateActivity_Btn";
            this.CreateActivity_Btn.Size = new System.Drawing.Size(135, 33);
            this.CreateActivity_Btn.TabIndex = 339;
            this.CreateActivity_Btn.Text = "Create Activity";
            this.CreateActivity_Btn.UseVisualStyleBackColor = false;
            this.CreateActivity_Btn.Click += new System.EventHandler(this.CreateActivity_Btn_Click);
            // 
            // Activity_errorLbl
            // 
            this.Activity_errorLbl.AutoSize = true;
            this.Activity_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Activity_errorLbl.Location = new System.Drawing.Point(41, 177);
            this.Activity_errorLbl.Name = "Activity_errorLbl";
            this.Activity_errorLbl.Size = new System.Drawing.Size(98, 15);
            this.Activity_errorLbl.TabIndex = 338;
            this.Activity_errorLbl.Text = "Activity is required.";
            // 
            // TotalMarks_errorLbl
            // 
            this.TotalMarks_errorLbl.AutoSize = true;
            this.TotalMarks_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarks_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.TotalMarks_errorLbl.Location = new System.Drawing.Point(41, 253);
            this.TotalMarks_errorLbl.Name = "TotalMarks_errorLbl";
            this.TotalMarks_errorLbl.Size = new System.Drawing.Size(121, 15);
            this.TotalMarks_errorLbl.TabIndex = 337;
            this.TotalMarks_errorLbl.Text = "Total Marks is required.";
            // 
            // MaxMarks_errorLbl
            // 
            this.MaxMarks_errorLbl.AutoSize = true;
            this.MaxMarks_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMarks_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.MaxMarks_errorLbl.Location = new System.Drawing.Point(401, 354);
            this.MaxMarks_errorLbl.Name = "MaxMarks_errorLbl";
            this.MaxMarks_errorLbl.Size = new System.Drawing.Size(121, 15);
            this.MaxMarks_errorLbl.TabIndex = 336;
            this.MaxMarks_errorLbl.Text = "Max. Marks is required.";
            // 
            // SubName_errorLbl
            // 
            this.SubName_errorLbl.AutoSize = true;
            this.SubName_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubName_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.SubName_errorLbl.Location = new System.Drawing.Point(42, 354);
            this.SubName_errorLbl.Name = "SubName_errorLbl";
            this.SubName_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.SubName_errorLbl.TabIndex = 335;
            this.SubName_errorLbl.Text = "Name is required.";
            // 
            // Name_errorLbl
            // 
            this.Name_errorLbl.AutoSize = true;
            this.Name_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Name_errorLbl.Location = new System.Drawing.Point(254, 178);
            this.Name_errorLbl.Name = "Name_errorLbl";
            this.Name_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.Name_errorLbl.TabIndex = 334;
            this.Name_errorLbl.Text = "Name is required.";
            // 
            // MaxMarks_errorFlag
            // 
            this.MaxMarks_errorFlag.AutoSize = true;
            this.MaxMarks_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMarks_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.MaxMarks_errorFlag.Location = new System.Drawing.Point(480, 298);
            this.MaxMarks_errorFlag.Name = "MaxMarks_errorFlag";
            this.MaxMarks_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.MaxMarks_errorFlag.TabIndex = 329;
            this.MaxMarks_errorFlag.Text = "*";
            // 
            // SubActName_errorFlag
            // 
            this.SubActName_errorFlag.AutoSize = true;
            this.SubActName_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubActName_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.SubActName_errorFlag.Location = new System.Drawing.Point(84, 298);
            this.SubActName_errorFlag.Name = "SubActName_errorFlag";
            this.SubActName_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.SubActName_errorFlag.TabIndex = 330;
            this.SubActName_errorFlag.Text = "*";
            // 
            // TotalMarks_errorFlag
            // 
            this.TotalMarks_errorFlag.AutoSize = true;
            this.TotalMarks_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalMarks_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.TotalMarks_errorFlag.Location = new System.Drawing.Point(127, 196);
            this.TotalMarks_errorFlag.Name = "TotalMarks_errorFlag";
            this.TotalMarks_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.TotalMarks_errorFlag.TabIndex = 331;
            this.TotalMarks_errorFlag.Text = "*";
            // 
            // Activity_errorFlag
            // 
            this.Activity_errorFlag.AutoSize = true;
            this.Activity_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Activity_errorFlag.Location = new System.Drawing.Point(88, 123);
            this.Activity_errorFlag.Name = "Activity_errorFlag";
            this.Activity_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Activity_errorFlag.TabIndex = 332;
            this.Activity_errorFlag.Text = "*";
            // 
            // Name_errorFlag
            // 
            this.Name_errorFlag.AutoSize = true;
            this.Name_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Name_errorFlag.Location = new System.Drawing.Point(295, 122);
            this.Name_errorFlag.Name = "Name_errorFlag";
            this.Name_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Name_errorFlag.TabIndex = 333;
            this.Name_errorFlag.Text = "*";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(39, 39);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(165, 21);
            this.bunifuCustomLabel9.TabIndex = 328;
            this.bunifuCustomLabel9.Text = "Create Class Activity";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(36, 40);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(684, 24);
            this.bunifuSeparator1.TabIndex = 327;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // includeGPACalc_CB
            // 
            this.includeGPACalc_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.includeGPACalc_CB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.includeGPACalc_CB.Checked = true;
            this.includeGPACalc_CB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.includeGPACalc_CB.ForeColor = System.Drawing.Color.White;
            this.includeGPACalc_CB.Location = new System.Drawing.Point(376, 238);
            this.includeGPACalc_CB.Name = "includeGPACalc_CB";
            this.includeGPACalc_CB.Size = new System.Drawing.Size(20, 20);
            this.includeGPACalc_CB.TabIndex = 326;
            // 
            // ComplexEP_CB
            // 
            this.ComplexEP_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ComplexEP_CB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ComplexEP_CB.Checked = true;
            this.ComplexEP_CB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ComplexEP_CB.ForeColor = System.Drawing.Color.White;
            this.ComplexEP_CB.Location = new System.Drawing.Point(376, 207);
            this.ComplexEP_CB.Name = "ComplexEP_CB";
            this.ComplexEP_CB.Size = new System.Drawing.Size(20, 20);
            this.ComplexEP_CB.TabIndex = 325;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(400, 239);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(183, 17);
            this.bunifuCustomLabel8.TabIndex = 324;
            this.bunifuCustomLabel8.Text = "Include for GPA Calculation";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(400, 209);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(200, 17);
            this.bunifuCustomLabel5.TabIndex = 323;
            this.bunifuCustomLabel5.Text = "Complex Engineering Problem";
            // 
            // Activity_CB
            // 
            this.Activity_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Activity_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_CB.FormattingEnabled = true;
            this.Activity_CB.IntegralHeight = false;
            this.Activity_CB.Location = new System.Drawing.Point(40, 148);
            this.Activity_CB.Name = "Activity_CB";
            this.Activity_CB.Size = new System.Drawing.Size(178, 29);
            this.Activity_CB.TabIndex = 322;
            this.Activity_CB.SelectedIndexChanged += new System.EventHandler(this.Activity_CB_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(37, 128);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel1.TabIndex = 321;
            this.bunifuCustomLabel1.Text = "Activity";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(254, 127);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(46, 17);
            this.bunifuCustomLabel3.TabIndex = 308;
            this.bunifuCustomLabel3.Text = "Name";
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Lbl.Location = new System.Drawing.Point(42, 303);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(46, 17);
            this.Name_Lbl.TabIndex = 307;
            this.Name_Lbl.Text = "Name";
            // 
            // ActivityName_TB
            // 
            this.ActivityName_TB.BackColor = System.Drawing.SystemColors.Control;
            this.ActivityName_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.ActivityName_TB.Location = new System.Drawing.Point(257, 147);
            this.ActivityName_TB.Multiline = true;
            this.ActivityName_TB.Name = "ActivityName_TB";
            this.ActivityName_TB.Size = new System.Drawing.Size(178, 31);
            this.ActivityName_TB.TabIndex = 315;
            this.ActivityName_TB.TextChanged += new System.EventHandler(this.ActivityName_TB_TextChanged);
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.SystemColors.Control;
            this.Name_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.Name_TB.Location = new System.Drawing.Point(45, 323);
            this.Name_TB.Multiline = true;
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(321, 31);
            this.Name_TB.TabIndex = 314;
            this.Name_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // TotalMarks_TB
            // 
            this.TotalMarks_TB.BackColor = System.Drawing.SystemColors.Control;
            this.TotalMarks_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.TotalMarks_TB.Location = new System.Drawing.Point(44, 222);
            this.TotalMarks_TB.Multiline = true;
            this.TotalMarks_TB.Name = "TotalMarks_TB";
            this.TotalMarks_TB.ReadOnly = true;
            this.TotalMarks_TB.Size = new System.Drawing.Size(131, 31);
            this.TotalMarks_TB.TabIndex = 317;
            this.TotalMarks_TB.Text = "0";
            this.TotalMarks_TB.TextChanged += new System.EventHandler(this.TotalMarks_TB_TextChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(206, 200);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(88, 17);
            this.bunifuCustomLabel7.TabIndex = 310;
            this.bunifuCustomLabel7.Text = "GPA Weights";
            // 
            // CLO_CB
            // 
            this.CLO_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CLO_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLO_CB.FormattingEnabled = true;
            this.CLO_CB.IntegralHeight = false;
            this.CLO_CB.Location = new System.Drawing.Point(45, 392);
            this.CLO_CB.Name = "CLO_CB";
            this.CLO_CB.Size = new System.Drawing.Size(675, 29);
            this.CLO_CB.TabIndex = 320;
            this.CLO_CB.SelectedIndexChanged += new System.EventHandler(this.CLO_CB_SelectedIndexChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(41, 202);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(84, 17);
            this.bunifuCustomLabel6.TabIndex = 312;
            this.bunifuCustomLabel6.Text = "Total Marks";
            // 
            // Clo_Lbl
            // 
            this.Clo_Lbl.AutoSize = true;
            this.Clo_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clo_Lbl.Location = new System.Drawing.Point(42, 371);
            this.Clo_Lbl.Name = "Clo_Lbl";
            this.Clo_Lbl.Size = new System.Drawing.Size(33, 17);
            this.Clo_Lbl.TabIndex = 309;
            this.Clo_Lbl.Text = "CLO";
            // 
            // MaxMrks_Lbl
            // 
            this.MaxMrks_Lbl.AutoSize = true;
            this.MaxMrks_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMrks_Lbl.Location = new System.Drawing.Point(401, 303);
            this.MaxMrks_Lbl.Name = "MaxMrks_Lbl";
            this.MaxMrks_Lbl.Size = new System.Drawing.Size(83, 17);
            this.MaxMrks_Lbl.TabIndex = 311;
            this.MaxMrks_Lbl.Text = "Max. Marks";
            // 
            // obeWght_Lbl
            // 
            this.obeWght_Lbl.AutoSize = true;
            this.obeWght_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obeWght_Lbl.Location = new System.Drawing.Point(585, 303);
            this.obeWght_Lbl.Name = "obeWght_Lbl";
            this.obeWght_Lbl.Size = new System.Drawing.Size(96, 17);
            this.obeWght_Lbl.TabIndex = 313;
            this.obeWght_Lbl.Text = "% OBE Weight";
            this.obeWght_Lbl.Visible = false;
            // 
            // DeleteSubActivity_Btn
            // 
            this.DeleteSubActivity_Btn.BackColor = System.Drawing.Color.Red;
            this.DeleteSubActivity_Btn.FlatAppearance.BorderSize = 0;
            this.DeleteSubActivity_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteSubActivity_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSubActivity_Btn.ForeColor = System.Drawing.Color.White;
            this.DeleteSubActivity_Btn.Location = new System.Drawing.Point(45, 435);
            this.DeleteSubActivity_Btn.Name = "DeleteSubActivity_Btn";
            this.DeleteSubActivity_Btn.Size = new System.Drawing.Size(56, 23);
            this.DeleteSubActivity_Btn.TabIndex = 306;
            this.DeleteSubActivity_Btn.Text = "Delete";
            this.DeleteSubActivity_Btn.UseVisualStyleBackColor = false;
            this.DeleteSubActivity_Btn.Click += new System.EventHandler(this.DeleteSubActivity_Btn_Click);
            // 
            // AddSubActivity_Btn
            // 
            this.AddSubActivity_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.AddSubActivity_Btn.FlatAppearance.BorderSize = 0;
            this.AddSubActivity_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSubActivity_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubActivity_Btn.ForeColor = System.Drawing.Color.White;
            this.AddSubActivity_Btn.Location = new System.Drawing.Point(106, 435);
            this.AddSubActivity_Btn.Name = "AddSubActivity_Btn";
            this.AddSubActivity_Btn.Size = new System.Drawing.Size(47, 23);
            this.AddSubActivity_Btn.TabIndex = 305;
            this.AddSubActivity_Btn.Text = "Add";
            this.AddSubActivity_Btn.UseVisualStyleBackColor = false;
            this.AddSubActivity_Btn.Click += new System.EventHandler(this.AddSubActivity_Btn_Click);
            // 
            // ActivityDate_DTP
            // 
            this.ActivityDate_DTP.CustomFormat = "dd-MM-yyyy hh:mm";
            this.ActivityDate_DTP.Font = new System.Drawing.Font("Franklin Gothic Book", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivityDate_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ActivityDate_DTP.Location = new System.Drawing.Point(467, 149);
            this.ActivityDate_DTP.MaxDate = new System.DateTime(2021, 10, 24, 0, 0, 0, 0);
            this.ActivityDate_DTP.Name = "ActivityDate_DTP";
            this.ActivityDate_DTP.Size = new System.Drawing.Size(253, 27);
            this.ActivityDate_DTP.TabIndex = 304;
            this.ActivityDate_DTP.Value = new System.DateTime(2021, 9, 17, 0, 0, 0, 0);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(464, 128);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(38, 17);
            this.bunifuCustomLabel4.TabIndex = 303;
            this.bunifuCustomLabel4.Text = "Date";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(42, 273);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(182, 21);
            this.bunifuCustomLabel2.TabIndex = 302;
            this.bunifuCustomLabel2.Text = "Sub Activity/ Question";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 65535;
            this.bunifuSeparator2.Location = new System.Drawing.Point(44, 276);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(676, 19);
            this.bunifuSeparator2.TabIndex = 301;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // totalWarningLbl
            // 
            this.totalWarningLbl.AutoSize = true;
            this.totalWarningLbl.BackColor = System.Drawing.Color.Maroon;
            this.totalWarningLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalWarningLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalWarningLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWarningLbl.ForeColor = System.Drawing.Color.White;
            this.totalWarningLbl.Location = new System.Drawing.Point(36, 83);
            this.totalWarningLbl.Name = "totalWarningLbl";
            this.totalWarningLbl.Size = new System.Drawing.Size(233, 20);
            this.totalWarningLbl.TabIndex = 341;
            this.totalWarningLbl.Text = "Activity weight for this activity type is :";
            // 
            // TotalWeight_Lbl
            // 
            this.TotalWeight_Lbl.AutoSize = true;
            this.TotalWeight_Lbl.BackColor = System.Drawing.Color.Yellow;
            this.TotalWeight_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWeight_Lbl.Location = new System.Drawing.Point(266, 83);
            this.TotalWeight_Lbl.Name = "TotalWeight_Lbl";
            this.TotalWeight_Lbl.Size = new System.Drawing.Size(41, 21);
            this.TotalWeight_Lbl.TabIndex = 342;
            this.TotalWeight_Lbl.Text = "0.00";
            // 
            // OBEWeight_NUD
            // 
            this.OBEWeight_NUD.DecimalPlaces = 2;
            this.OBEWeight_NUD.Font = new System.Drawing.Font("Franklin Gothic Book", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OBEWeight_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.OBEWeight_NUD.Location = new System.Drawing.Point(588, 325);
            this.OBEWeight_NUD.Name = "OBEWeight_NUD";
            this.OBEWeight_NUD.Size = new System.Drawing.Size(130, 27);
            this.OBEWeight_NUD.TabIndex = 343;
            this.OBEWeight_NUD.Visible = false;
            // 
            // GPAWeight_NUD
            // 
            this.GPAWeight_NUD.DecimalPlaces = 2;
            this.GPAWeight_NUD.Font = new System.Drawing.Font("Franklin Gothic Book", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPAWeight_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.GPAWeight_NUD.Location = new System.Drawing.Point(209, 223);
            this.GPAWeight_NUD.Name = "GPAWeight_NUD";
            this.GPAWeight_NUD.Size = new System.Drawing.Size(138, 27);
            this.GPAWeight_NUD.TabIndex = 343;
            this.GPAWeight_NUD.ValueChanged += new System.EventHandler(this.GPAWeight_NUD_ValueChanged);
            // 
            // MaxMarks_NUD
            // 
            this.MaxMarks_NUD.DecimalPlaces = 2;
            this.MaxMarks_NUD.Font = new System.Drawing.Font("Franklin Gothic Book", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMarks_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MaxMarks_NUD.Location = new System.Drawing.Point(404, 325);
            this.MaxMarks_NUD.Name = "MaxMarks_NUD";
            this.MaxMarks_NUD.Size = new System.Drawing.Size(137, 27);
            this.MaxMarks_NUD.TabIndex = 343;
            this.MaxMarks_NUD.ValueChanged += new System.EventHandler(this.MaxMarks_NUD_ValueChanged);
            this.MaxMarks_NUD.Leave += new System.EventHandler(this.MaxMarks_NUD_Leave);
            // 
            // gpaWeight_errorFlag
            // 
            this.gpaWeight_errorFlag.AutoSize = true;
            this.gpaWeight_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaWeight_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.gpaWeight_errorFlag.Location = new System.Drawing.Point(292, 196);
            this.gpaWeight_errorFlag.Name = "gpaWeight_errorFlag";
            this.gpaWeight_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.gpaWeight_errorFlag.TabIndex = 331;
            this.gpaWeight_errorFlag.Text = "*";
            // 
            // gpaWeight_errorLbl
            // 
            this.gpaWeight_errorLbl.AutoSize = true;
            this.gpaWeight_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaWeight_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.gpaWeight_errorLbl.Location = new System.Drawing.Point(206, 253);
            this.gpaWeight_errorLbl.Name = "gpaWeight_errorLbl";
            this.gpaWeight_errorLbl.Size = new System.Drawing.Size(154, 15);
            this.gpaWeight_errorLbl.TabIndex = 337;
            this.gpaWeight_errorLbl.Text = "GPA weight should not be zero.";
            // 
            // CreateClassActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 497);
            this.Controls.Add(this.GPAWeight_NUD);
            this.Controls.Add(this.MaxMarks_NUD);
            this.Controls.Add(this.OBEWeight_NUD);
            this.Controls.Add(this.TotalWeight_Lbl);
            this.Controls.Add(this.totalWarningLbl);
            this.Controls.Add(this.ManageActivitites_Btn);
            this.Controls.Add(this.CreateActivity_Btn);
            this.Controls.Add(this.Activity_errorLbl);
            this.Controls.Add(this.gpaWeight_errorLbl);
            this.Controls.Add(this.TotalMarks_errorLbl);
            this.Controls.Add(this.MaxMarks_errorLbl);
            this.Controls.Add(this.SubName_errorLbl);
            this.Controls.Add(this.Name_errorLbl);
            this.Controls.Add(this.MaxMarks_errorFlag);
            this.Controls.Add(this.gpaWeight_errorFlag);
            this.Controls.Add(this.SubActName_errorFlag);
            this.Controls.Add(this.TotalMarks_errorFlag);
            this.Controls.Add(this.Activity_errorFlag);
            this.Controls.Add(this.Name_errorFlag);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.includeGPACalc_CB);
            this.Controls.Add(this.ComplexEP_CB);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.Activity_CB);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Name_Lbl);
            this.Controls.Add(this.ActivityName_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.TotalMarks_TB);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.CLO_CB);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.Clo_Lbl);
            this.Controls.Add(this.MaxMrks_Lbl);
            this.Controls.Add(this.obeWght_Lbl);
            this.Controls.Add(this.DeleteSubActivity_Btn);
            this.Controls.Add(this.AddSubActivity_Btn);
            this.Controls.Add(this.ActivityDate_DTP);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateClassActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassActivity";
            this.Load += new System.EventHandler(this.ClassActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OBEWeight_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GPAWeight_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMarks_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageActivitites_Btn;
        private System.Windows.Forms.Button CreateActivity_Btn;
        private System.Windows.Forms.Label Activity_errorLbl;
        private System.Windows.Forms.Label TotalMarks_errorLbl;
        private System.Windows.Forms.Label MaxMarks_errorLbl;
        private System.Windows.Forms.Label SubName_errorLbl;
        private System.Windows.Forms.Label Name_errorLbl;
        private System.Windows.Forms.Label MaxMarks_errorFlag;
        private System.Windows.Forms.Label SubActName_errorFlag;
        private System.Windows.Forms.Label TotalMarks_errorFlag;
        private System.Windows.Forms.Label Activity_errorFlag;
        private System.Windows.Forms.Label Name_errorFlag;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCheckbox includeGPACalc_CB;
        private Bunifu.Framework.UI.BunifuCheckbox ComplexEP_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.ComboBox Activity_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel Name_Lbl;
        private System.Windows.Forms.TextBox ActivityName_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox TotalMarks_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.ComboBox CLO_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel Clo_Lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel MaxMrks_Lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel obeWght_Lbl;
        private System.Windows.Forms.Button DeleteSubActivity_Btn;
        private System.Windows.Forms.Button AddSubActivity_Btn;
        private System.Windows.Forms.DateTimePicker ActivityDate_DTP;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label totalWarningLbl;
        private System.Windows.Forms.Label TotalWeight_Lbl;
        private System.Windows.Forms.NumericUpDown OBEWeight_NUD;
        private System.Windows.Forms.NumericUpDown GPAWeight_NUD;
        private System.Windows.Forms.NumericUpDown MaxMarks_NUD;
        private Label gpaWeight_errorFlag;
        private Label gpaWeight_errorLbl;
    }
}