namespace OBE_Desktop.MyInstitute_Section.ProgramUI
{
    partial class UpdateProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProgram));
            this.StudentPercentage_errorflag = new System.Windows.Forms.Label();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.StudentPercentage_NUD = new System.Windows.Forms.NumericUpDown();
            this.Marks_errorFlag = new System.Windows.Forms.Label();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MarksPercentage_NUD = new System.Windows.Forms.NumericUpDown();
            this.LearningType_CB = new System.Windows.Forms.ComboBox();
            this.LearningType_errorFlag = new System.Windows.Forms.Label();
            this.AssesmentMethod_errorFlag = new System.Windows.Forms.Label();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AssessmentMethod_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ShortName_TB = new System.Windows.Forms.TextBox();
            this.Mission_RTB = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel17 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Vision_RTB = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Session_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SemesterType_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ProgramLevel_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SemesterType_errorFlag = new System.Windows.Forms.Label();
            this.ShortName_errorFlag = new System.Windows.Forms.Label();
            this.ShortName_errorLbl = new System.Windows.Forms.Label();
            this.SemesterType_errorLbl = new System.Windows.Forms.Label();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Department_CB = new System.Windows.Forms.ComboBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.StudentPercentage_errorLbl = new System.Windows.Forms.Label();
            this.Marks_errorLbl = new System.Windows.Forms.Label();
            this.LearningType_errorLbl = new System.Windows.Forms.Label();
            this.AssesmentMethod_errorLbl = new System.Windows.Forms.Label();
            this.Name_errorLbl = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name_errorFlag = new System.Windows.Forms.Label();
            this.UpdateProgram_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ProgramID_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPercentage_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksPercentage_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentPercentage_errorflag
            // 
            this.StudentPercentage_errorflag.AutoSize = true;
            this.StudentPercentage_errorflag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPercentage_errorflag.ForeColor = System.Drawing.Color.Red;
            this.StudentPercentage_errorflag.Location = new System.Drawing.Point(430, 295);
            this.StudentPercentage_errorflag.Name = "StudentPercentage_errorflag";
            this.StudentPercentage_errorflag.Size = new System.Drawing.Size(20, 21);
            this.StudentPercentage_errorflag.TabIndex = 157;
            this.StudentPercentage_errorflag.Text = "*";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(349, 300);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(85, 20);
            this.bunifuCustomLabel11.TabIndex = 156;
            this.bunifuCustomLabel11.Text = "Students %";
            // 
            // StudentPercentage_NUD
            // 
            this.StudentPercentage_NUD.DecimalPlaces = 2;
            this.StudentPercentage_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPercentage_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StudentPercentage_NUD.Location = new System.Drawing.Point(463, 297);
            this.StudentPercentage_NUD.Name = "StudentPercentage_NUD";
            this.StudentPercentage_NUD.Size = new System.Drawing.Size(220, 26);
            this.StudentPercentage_NUD.TabIndex = 155;
            this.StudentPercentage_NUD.ValueChanged += new System.EventHandler(this.StudentPercentage_NUD_ValueChanged);
            // 
            // Marks_errorFlag
            // 
            this.Marks_errorFlag.AutoSize = true;
            this.Marks_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Marks_errorFlag.Location = new System.Drawing.Point(85, 295);
            this.Marks_errorFlag.Name = "Marks_errorFlag";
            this.Marks_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Marks_errorFlag.TabIndex = 154;
            this.Marks_errorFlag.Text = "*";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(18, 300);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(85, 20);
            this.bunifuCustomLabel6.TabIndex = 153;
            this.bunifuCustomLabel6.Text = "Marks %";
            // 
            // MarksPercentage_NUD
            // 
            this.MarksPercentage_NUD.DecimalPlaces = 2;
            this.MarksPercentage_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarksPercentage_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MarksPercentage_NUD.Location = new System.Drawing.Point(123, 297);
            this.MarksPercentage_NUD.Name = "MarksPercentage_NUD";
            this.MarksPercentage_NUD.Size = new System.Drawing.Size(220, 26);
            this.MarksPercentage_NUD.TabIndex = 152;
            this.MarksPercentage_NUD.ValueChanged += new System.EventHandler(this.MarksPercentage_NUD_ValueChanged);
            // 
            // LearningType_CB
            // 
            this.LearningType_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LearningType_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningType_CB.FormattingEnabled = true;
            this.LearningType_CB.IntegralHeight = false;
            this.LearningType_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.LearningType_CB.Location = new System.Drawing.Point(461, 232);
            this.LearningType_CB.Name = "LearningType_CB";
            this.LearningType_CB.Size = new System.Drawing.Size(559, 29);
            this.LearningType_CB.TabIndex = 149;
            this.LearningType_CB.SelectedIndexChanged += new System.EventHandler(this.LearningType_CB_SelectedIndexChanged);
            // 
            // LearningType_errorFlag
            // 
            this.LearningType_errorFlag.AutoSize = true;
            this.LearningType_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningType_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.LearningType_errorFlag.Location = new System.Drawing.Point(442, 229);
            this.LearningType_errorFlag.Name = "LearningType_errorFlag";
            this.LearningType_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.LearningType_errorFlag.TabIndex = 151;
            this.LearningType_errorFlag.Text = "*";
            // 
            // AssesmentMethod_errorFlag
            // 
            this.AssesmentMethod_errorFlag.AutoSize = true;
            this.AssesmentMethod_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssesmentMethod_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.AssesmentMethod_errorFlag.Location = new System.Drawing.Point(95, 226);
            this.AssesmentMethod_errorFlag.Name = "AssesmentMethod_errorFlag";
            this.AssesmentMethod_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.AssesmentMethod_errorFlag.TabIndex = 150;
            this.AssesmentMethod_errorFlag.Text = "*";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(349, 227);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(99, 38);
            this.bunifuCustomLabel9.TabIndex = 148;
            this.bunifuCustomLabel9.Text = "Learning Type Category";
            // 
            // AssessmentMethod_CB
            // 
            this.AssessmentMethod_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssessmentMethod_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssessmentMethod_CB.FormattingEnabled = true;
            this.AssessmentMethod_CB.IntegralHeight = false;
            this.AssessmentMethod_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.AssessmentMethod_CB.Location = new System.Drawing.Point(121, 232);
            this.AssessmentMethod_CB.Name = "AssessmentMethod_CB";
            this.AssessmentMethod_CB.Size = new System.Drawing.Size(222, 29);
            this.AssessmentMethod_CB.TabIndex = 146;
            this.AssessmentMethod_CB.SelectedIndexChanged += new System.EventHandler(this.AssessmentMethod_CB_SelectedIndexChanged);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(18, 229);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(85, 35);
            this.bunifuCustomLabel10.TabIndex = 147;
            this.bunifuCustomLabel10.Text = "Assesment Method";
            // 
            // ShortName_TB
            // 
            this.ShortName_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortName_TB.Location = new System.Drawing.Point(460, 99);
            this.ShortName_TB.Multiline = true;
            this.ShortName_TB.Name = "ShortName_TB";
            this.ShortName_TB.Size = new System.Drawing.Size(222, 29);
            this.ShortName_TB.TabIndex = 145;
            this.ShortName_TB.TextChanged += new System.EventHandler(this.ShortName_TB_TextChanged);
            // 
            // Mission_RTB
            // 
            this.Mission_RTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Mission_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mission_RTB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mission_RTB.Location = new System.Drawing.Point(628, 371);
            this.Mission_RTB.Name = "Mission_RTB";
            this.Mission_RTB.Size = new System.Drawing.Size(392, 109);
            this.Mission_RTB.TabIndex = 144;
            this.Mission_RTB.Text = "";
            // 
            // bunifuCustomLabel17
            // 
            this.bunifuCustomLabel17.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel17.Location = new System.Drawing.Point(558, 387);
            this.bunifuCustomLabel17.Name = "bunifuCustomLabel17";
            this.bunifuCustomLabel17.Size = new System.Drawing.Size(64, 19);
            this.bunifuCustomLabel17.TabIndex = 143;
            this.bunifuCustomLabel17.Text = "Mission";
            // 
            // Vision_RTB
            // 
            this.Vision_RTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Vision_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vision_RTB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vision_RTB.Location = new System.Drawing.Point(121, 371);
            this.Vision_RTB.Name = "Vision_RTB";
            this.Vision_RTB.Size = new System.Drawing.Size(392, 109);
            this.Vision_RTB.TabIndex = 142;
            this.Vision_RTB.Text = "";
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(22, 387);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(47, 19);
            this.bunifuCustomLabel16.TabIndex = 141;
            this.bunifuCustomLabel16.Text = "Vision";
            // 
            // Session_CB
            // 
            this.Session_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Session_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Session_CB.FormattingEnabled = true;
            this.Session_CB.IntegralHeight = false;
            this.Session_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.Session_CB.Location = new System.Drawing.Point(798, 171);
            this.Session_CB.Name = "Session_CB";
            this.Session_CB.Size = new System.Drawing.Size(222, 29);
            this.Session_CB.TabIndex = 140;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(698, 177);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(97, 17);
            this.bunifuCustomLabel12.TabIndex = 139;
            this.bunifuCustomLabel12.Text = "No of Session";
            // 
            // SemesterType_CB
            // 
            this.SemesterType_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterType_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterType_CB.FormattingEnabled = true;
            this.SemesterType_CB.IntegralHeight = false;
            this.SemesterType_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.SemesterType_CB.Location = new System.Drawing.Point(798, 99);
            this.SemesterType_CB.Name = "SemesterType_CB";
            this.SemesterType_CB.Size = new System.Drawing.Size(222, 29);
            this.SemesterType_CB.TabIndex = 138;
            this.SemesterType_CB.SelectedIndexChanged += new System.EventHandler(this.SemesterType_CB_SelectedIndexChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(16, 35);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel2.TabIndex = 137;
            this.bunifuCustomLabel2.Text = "Programs";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 5;
            this.bunifuSeparator2.Location = new System.Drawing.Point(21, 33);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1012, 24);
            this.bunifuSeparator2.TabIndex = 136;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ProgramLevel_CB
            // 
            this.ProgramLevel_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgramLevel_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLevel_CB.FormattingEnabled = true;
            this.ProgramLevel_CB.IntegralHeight = false;
            this.ProgramLevel_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.ProgramLevel_CB.Location = new System.Drawing.Point(461, 171);
            this.ProgramLevel_CB.Name = "ProgramLevel_CB";
            this.ProgramLevel_CB.Size = new System.Drawing.Size(222, 29);
            this.ProgramLevel_CB.TabIndex = 135;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(349, 177);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(99, 17);
            this.bunifuCustomLabel7.TabIndex = 134;
            this.bunifuCustomLabel7.Text = "Program Level";
            // 
            // SemesterType_errorFlag
            // 
            this.SemesterType_errorFlag.AutoSize = true;
            this.SemesterType_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterType_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.SemesterType_errorFlag.Location = new System.Drawing.Point(766, 96);
            this.SemesterType_errorFlag.Name = "SemesterType_errorFlag";
            this.SemesterType_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.SemesterType_errorFlag.TabIndex = 132;
            this.SemesterType_errorFlag.Text = "*";
            // 
            // ShortName_errorFlag
            // 
            this.ShortName_errorFlag.AutoSize = true;
            this.ShortName_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortName_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.ShortName_errorFlag.Location = new System.Drawing.Point(428, 96);
            this.ShortName_errorFlag.Name = "ShortName_errorFlag";
            this.ShortName_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.ShortName_errorFlag.TabIndex = 131;
            this.ShortName_errorFlag.Text = "*";
            // 
            // ShortName_errorLbl
            // 
            this.ShortName_errorLbl.AutoSize = true;
            this.ShortName_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortName_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.ShortName_errorLbl.Location = new System.Drawing.Point(460, 130);
            this.ShortName_errorLbl.Name = "ShortName_errorLbl";
            this.ShortName_errorLbl.Size = new System.Drawing.Size(120, 15);
            this.ShortName_errorLbl.TabIndex = 130;
            this.ShortName_errorLbl.Text = "Short name is required.";
            // 
            // SemesterType_errorLbl
            // 
            this.SemesterType_errorLbl.AutoSize = true;
            this.SemesterType_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterType_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.SemesterType_errorLbl.Location = new System.Drawing.Point(799, 128);
            this.SemesterType_errorLbl.Name = "SemesterType_errorLbl";
            this.SemesterType_errorLbl.Size = new System.Drawing.Size(87, 15);
            this.SemesterType_errorLbl.TabIndex = 129;
            this.SemesterType_errorLbl.Text = "Type is required.";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(700, 94);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(72, 39);
            this.lbl1.TabIndex = 128;
            this.lbl1.Text = "Semester Type";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(349, 105);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(85, 16);
            this.bunifuCustomLabel4.TabIndex = 127;
            this.bunifuCustomLabel4.Text = "Short Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(219, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 126;
            this.label5.Text = "*";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(118, 61);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel3.TabIndex = 125;
            this.bunifuCustomLabel3.Text = "Fields marked with       are required";
            // 
            // Department_CB
            // 
            this.Department_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Department_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_CB.FormattingEnabled = true;
            this.Department_CB.IntegralHeight = false;
            this.Department_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.Department_CB.Location = new System.Drawing.Point(121, 171);
            this.Department_CB.Name = "Department_CB";
            this.Department_CB.Size = new System.Drawing.Size(222, 29);
            this.Department_CB.TabIndex = 118;
            // 
            // Name_TB
            // 
            this.Name_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_TB.Location = new System.Drawing.Point(121, 99);
            this.Name_TB.Multiline = true;
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(222, 29);
            this.Name_TB.TabIndex = 119;
            this.Name_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // StudentPercentage_errorLbl
            // 
            this.StudentPercentage_errorLbl.AutoSize = true;
            this.StudentPercentage_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentPercentage_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.StudentPercentage_errorLbl.Location = new System.Drawing.Point(460, 324);
            this.StudentPercentage_errorLbl.Name = "StudentPercentage_errorLbl";
            this.StudentPercentage_errorLbl.Size = new System.Drawing.Size(142, 15);
            this.StudentPercentage_errorLbl.TabIndex = 124;
            this.StudentPercentage_errorLbl.Text = "Maximum percentage is 100";
            // 
            // Marks_errorLbl
            // 
            this.Marks_errorLbl.AutoSize = true;
            this.Marks_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marks_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Marks_errorLbl.Location = new System.Drawing.Point(118, 324);
            this.Marks_errorLbl.Name = "Marks_errorLbl";
            this.Marks_errorLbl.Size = new System.Drawing.Size(145, 15);
            this.Marks_errorLbl.TabIndex = 123;
            this.Marks_errorLbl.Text = "Maximum percentage is 100.";
            // 
            // LearningType_errorLbl
            // 
            this.LearningType_errorLbl.AutoSize = true;
            this.LearningType_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearningType_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.LearningType_errorLbl.Location = new System.Drawing.Point(460, 261);
            this.LearningType_errorLbl.Name = "LearningType_errorLbl";
            this.LearningType_errorLbl.Size = new System.Drawing.Size(129, 15);
            this.LearningType_errorLbl.TabIndex = 122;
            this.LearningType_errorLbl.Text = "Learning type is required.";
            // 
            // AssesmentMethod_errorLbl
            // 
            this.AssesmentMethod_errorLbl.AutoSize = true;
            this.AssesmentMethod_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssesmentMethod_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.AssesmentMethod_errorLbl.Location = new System.Drawing.Point(118, 261);
            this.AssesmentMethod_errorLbl.Name = "AssesmentMethod_errorLbl";
            this.AssesmentMethod_errorLbl.Size = new System.Drawing.Size(155, 15);
            this.AssesmentMethod_errorLbl.TabIndex = 121;
            this.AssesmentMethod_errorLbl.Text = "Assesment method is required.";
            // 
            // Name_errorLbl
            // 
            this.Name_errorLbl.AutoSize = true;
            this.Name_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Name_errorLbl.Location = new System.Drawing.Point(120, 128);
            this.Name_errorLbl.Name = "Name_errorLbl";
            this.Name_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.Name_errorLbl.TabIndex = 120;
            this.Name_errorLbl.Text = "Name is required.";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 105);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(46, 17);
            this.bunifuCustomLabel1.TabIndex = 115;
            this.bunifuCustomLabel1.Text = "Name";
            // 
            // Name_errorFlag
            // 
            this.Name_errorFlag.AutoSize = true;
            this.Name_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Name_errorFlag.Location = new System.Drawing.Point(58, 94);
            this.Name_errorFlag.Name = "Name_errorFlag";
            this.Name_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Name_errorFlag.TabIndex = 117;
            this.Name_errorFlag.Text = "*";
            // 
            // UpdateProgram_Btn
            // 
            this.UpdateProgram_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateProgram_Btn.FlatAppearance.BorderSize = 0;
            this.UpdateProgram_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateProgram_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProgram_Btn.ForeColor = System.Drawing.Color.White;
            this.UpdateProgram_Btn.Location = new System.Drawing.Point(121, 504);
            this.UpdateProgram_Btn.Name = "UpdateProgram_Btn";
            this.UpdateProgram_Btn.Size = new System.Drawing.Size(114, 30);
            this.UpdateProgram_Btn.TabIndex = 116;
            this.UpdateProgram_Btn.Text = "Update Program";
            this.UpdateProgram_Btn.UseVisualStyleBackColor = false;
            this.UpdateProgram_Btn.Click += new System.EventHandler(this.UpdateProgram_Btn_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(18, 175);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(85, 20);
            this.bunifuCustomLabel8.TabIndex = 133;
            this.bunifuCustomLabel8.Text = "Department";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(761, 302);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(20, 17);
            this.bunifuCustomLabel5.TabIndex = 115;
            this.bunifuCustomLabel5.Text = "Id";
            this.bunifuCustomLabel5.Visible = false;
            // 
            // ProgramID_TB
            // 
            this.ProgramID_TB.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramID_TB.Location = new System.Drawing.Point(798, 296);
            this.ProgramID_TB.Multiline = true;
            this.ProgramID_TB.Name = "ProgramID_TB";
            this.ProgramID_TB.Size = new System.Drawing.Size(222, 29);
            this.ProgramID_TB.TabIndex = 119;
            this.ProgramID_TB.Visible = false;
            this.ProgramID_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // UpdateProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 608);
            this.Controls.Add(this.StudentPercentage_errorflag);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.StudentPercentage_NUD);
            this.Controls.Add(this.Marks_errorFlag);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.MarksPercentage_NUD);
            this.Controls.Add(this.LearningType_CB);
            this.Controls.Add(this.LearningType_errorFlag);
            this.Controls.Add(this.AssesmentMethod_errorFlag);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.AssessmentMethod_CB);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.ShortName_TB);
            this.Controls.Add(this.Mission_RTB);
            this.Controls.Add(this.bunifuCustomLabel17);
            this.Controls.Add(this.Vision_RTB);
            this.Controls.Add(this.bunifuCustomLabel16);
            this.Controls.Add(this.Session_CB);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.SemesterType_CB);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.ProgramLevel_CB);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.SemesterType_errorFlag);
            this.Controls.Add(this.ShortName_errorFlag);
            this.Controls.Add(this.ShortName_errorLbl);
            this.Controls.Add(this.SemesterType_errorLbl);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Department_CB);
            this.Controls.Add(this.ProgramID_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.StudentPercentage_errorLbl);
            this.Controls.Add(this.Marks_errorLbl);
            this.Controls.Add(this.LearningType_errorLbl);
            this.Controls.Add(this.AssesmentMethod_errorLbl);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.Name_errorLbl);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Name_errorFlag);
            this.Controls.Add(this.UpdateProgram_Btn);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateProgram";
            this.Text = "UpdateProgram";
            this.Load += new System.EventHandler(this.UpdateProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentPercentage_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksPercentage_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentPercentage_errorflag;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private System.Windows.Forms.NumericUpDown StudentPercentage_NUD;
        private System.Windows.Forms.Label Marks_errorFlag;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.NumericUpDown MarksPercentage_NUD;
        private System.Windows.Forms.ComboBox LearningType_CB;
        private System.Windows.Forms.Label LearningType_errorFlag;
        private System.Windows.Forms.Label AssesmentMethod_errorFlag;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.ComboBox AssessmentMethod_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.TextBox ShortName_TB;
        private System.Windows.Forms.RichTextBox Mission_RTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel17;
        private System.Windows.Forms.RichTextBox Vision_RTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.ComboBox Session_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.ComboBox SemesterType_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.ComboBox ProgramLevel_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Label SemesterType_errorFlag;
        private System.Windows.Forms.Label ShortName_errorFlag;
        private System.Windows.Forms.Label ShortName_errorLbl;
        private System.Windows.Forms.Label SemesterType_errorLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.ComboBox Department_CB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label StudentPercentage_errorLbl;
        private System.Windows.Forms.Label Marks_errorLbl;
        private System.Windows.Forms.Label LearningType_errorLbl;
        private System.Windows.Forms.Label AssesmentMethod_errorLbl;
        private System.Windows.Forms.Label Name_errorLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label Name_errorFlag;
        private System.Windows.Forms.Button UpdateProgram_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox ProgramID_TB;
    }
}