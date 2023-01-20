namespace OBE_Desktop.MyInstitute_Section.DepartmentUI
{
    partial class UpdateDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDepartment));
            this.GpaMethod_CB = new System.Windows.Forms.ComboBox();
            this.GpaMethod_errorLbl = new System.Windows.Forms.Label();
            this.AssessmentMethd_CB = new System.Windows.Forms.ComboBox();
            this.School_CB = new System.Windows.Forms.ComboBox();
            this.AssessmentMethod_errorLbl = new System.Windows.Forms.Label();
            this.School_errorLbl = new System.Windows.Forms.Label();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeptMission_RTB = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AllowFaculty_CB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.CourseActvtiesDays_NUD = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AssessmentMethod_errorFlag = new System.Windows.Forms.Label();
            this.GpaMethod_errorFlag = new System.Windows.Forms.Label();
            this.AttendancePercent_NUD = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.isActive_CB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.DepartmentName_TB = new System.Windows.Forms.TextBox();
            this.ShortName_TB = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.UploadImage_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeptLogo_PicBox = new System.Windows.Forms.PictureBox();
            this.School_errorFlag = new System.Windows.Forms.Label();
            this.DeptVision_RTB = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeptName_errorLbl = new System.Windows.Forms.Label();
            this.DeptName_errorFlag = new System.Windows.Forms.Label();
            this.UpdateDept_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DeptID_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CourseActvtiesDays_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancePercent_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptLogo_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GpaMethod_CB
            // 
            this.GpaMethod_CB.DisplayMember = "MethodName";
            this.GpaMethod_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GpaMethod_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaMethod_CB.FormattingEnabled = true;
            this.GpaMethod_CB.IntegralHeight = false;
            this.GpaMethod_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.GpaMethod_CB.Location = new System.Drawing.Point(562, 168);
            this.GpaMethod_CB.Name = "GpaMethod_CB";
            this.GpaMethod_CB.Size = new System.Drawing.Size(161, 29);
            this.GpaMethod_CB.TabIndex = 151;
            this.GpaMethod_CB.ValueMember = "Id";
            this.GpaMethod_CB.SelectedIndexChanged += new System.EventHandler(this.GpaMethod_CB_SelectedIndexChanged);
            // 
            // GpaMethod_errorLbl
            // 
            this.GpaMethod_errorLbl.AutoSize = true;
            this.GpaMethod_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaMethod_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.GpaMethod_errorLbl.Location = new System.Drawing.Point(559, 195);
            this.GpaMethod_errorLbl.Name = "GpaMethod_errorLbl";
            this.GpaMethod_errorLbl.Size = new System.Drawing.Size(123, 15);
            this.GpaMethod_errorLbl.TabIndex = 164;
            this.GpaMethod_errorLbl.Text = "Gpa Method is required.";
            // 
            // AssessmentMethd_CB
            // 
            this.AssessmentMethd_CB.DisplayMember = "MethodName";
            this.AssessmentMethd_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssessmentMethd_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssessmentMethd_CB.FormattingEnabled = true;
            this.AssessmentMethd_CB.IntegralHeight = false;
            this.AssessmentMethd_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.AssessmentMethd_CB.Location = new System.Drawing.Point(121, 224);
            this.AssessmentMethd_CB.Name = "AssessmentMethd_CB";
            this.AssessmentMethd_CB.Size = new System.Drawing.Size(315, 29);
            this.AssessmentMethd_CB.TabIndex = 137;
            this.AssessmentMethd_CB.ValueMember = "Id";
            this.AssessmentMethd_CB.SelectedIndexChanged += new System.EventHandler(this.AssessmentMethd_CB_SelectedIndexChanged);
            // 
            // School_CB
            // 
            this.School_CB.DisplayMember = "Name";
            this.School_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.School_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.School_CB.FormattingEnabled = true;
            this.School_CB.IntegralHeight = false;
            this.School_CB.Items.AddRange(new object[] {
            "Select School"});
            this.School_CB.Location = new System.Drawing.Point(121, 168);
            this.School_CB.Name = "School_CB";
            this.School_CB.Size = new System.Drawing.Size(315, 29);
            this.School_CB.TabIndex = 149;
            this.School_CB.ValueMember = "Id";
            this.School_CB.SelectedIndexChanged += new System.EventHandler(this.School_CB_SelectedIndexChanged);
            // 
            // AssessmentMethod_errorLbl
            // 
            this.AssessmentMethod_errorLbl.AutoSize = true;
            this.AssessmentMethod_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssessmentMethod_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.AssessmentMethod_errorLbl.Location = new System.Drawing.Point(120, 251);
            this.AssessmentMethod_errorLbl.Name = "AssessmentMethod_errorLbl";
            this.AssessmentMethod_errorLbl.Size = new System.Drawing.Size(155, 15);
            this.AssessmentMethod_errorLbl.TabIndex = 163;
            this.AssessmentMethod_errorLbl.Text = "Assesment Method is required.";
            // 
            // School_errorLbl
            // 
            this.School_errorLbl.AutoSize = true;
            this.School_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.School_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.School_errorLbl.Location = new System.Drawing.Point(120, 195);
            this.School_errorLbl.Name = "School_errorLbl";
            this.School_errorLbl.Size = new System.Drawing.Size(97, 15);
            this.School_errorLbl.TabIndex = 162;
            this.School_errorLbl.Text = "School is required.";
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(452, 174);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(86, 17);
            this.bunifuCustomLabel13.TabIndex = 138;
            this.bunifuCustomLabel13.Text = "GPA Method";
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(452, 382);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(92, 17);
            this.bunifuCustomLabel14.TabIndex = 161;
            this.bunifuCustomLabel14.Text = "Dept.Mission";
            // 
            // DeptMission_RTB
            // 
            this.DeptMission_RTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeptMission_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptMission_RTB.Location = new System.Drawing.Point(562, 377);
            this.DeptMission_RTB.Name = "DeptMission_RTB";
            this.DeptMission_RTB.Size = new System.Drawing.Size(471, 68);
            this.DeptMission_RTB.TabIndex = 160;
            this.DeptMission_RTB.Text = "";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(452, 290);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(81, 17);
            this.bunifuCustomLabel11.TabIndex = 159;
            this.bunifuCustomLabel11.Text = "Dept.Vision";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(855, 93);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(178, 37);
            this.bunifuCustomLabel10.TabIndex = 158;
            this.bunifuCustomLabel10.Text = "Allow faculty to add CLOs from Course Section";
            // 
            // AllowFaculty_CB
            // 
            this.AllowFaculty_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.AllowFaculty_CB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.AllowFaculty_CB.Checked = true;
            this.AllowFaculty_CB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.AllowFaculty_CB.ForeColor = System.Drawing.Color.White;
            this.AllowFaculty_CB.Location = new System.Drawing.Point(825, 98);
            this.AllowFaculty_CB.Margin = new System.Windows.Forms.Padding(7, 13, 7, 13);
            this.AllowFaculty_CB.Name = "AllowFaculty_CB";
            this.AllowFaculty_CB.Size = new System.Drawing.Size(20, 20);
            this.AllowFaculty_CB.TabIndex = 157;
            // 
            // CourseActvtiesDays_NUD
            // 
            this.CourseActvtiesDays_NUD.Location = new System.Drawing.Point(704, 225);
            this.CourseActvtiesDays_NUD.Name = "CourseActvtiesDays_NUD";
            this.CourseActvtiesDays_NUD.Size = new System.Drawing.Size(329, 20);
            this.CourseActvtiesDays_NUD.TabIndex = 156;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(452, 230);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(248, 17);
            this.bunifuCustomLabel9.TabIndex = 155;
            this.bunifuCustomLabel9.Text = "Lock Course Section Activites in Days";
            // 
            // AssessmentMethod_errorFlag
            // 
            this.AssessmentMethod_errorFlag.AutoSize = true;
            this.AssessmentMethod_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssessmentMethod_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.AssessmentMethod_errorFlag.Location = new System.Drawing.Point(95, 221);
            this.AssessmentMethod_errorFlag.Name = "AssessmentMethod_errorFlag";
            this.AssessmentMethod_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.AssessmentMethod_errorFlag.TabIndex = 154;
            this.AssessmentMethod_errorFlag.Text = "*";
            // 
            // GpaMethod_errorFlag
            // 
            this.GpaMethod_errorFlag.AutoSize = true;
            this.GpaMethod_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpaMethod_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.GpaMethod_errorFlag.Location = new System.Drawing.Point(538, 165);
            this.GpaMethod_errorFlag.Name = "GpaMethod_errorFlag";
            this.GpaMethod_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.GpaMethod_errorFlag.TabIndex = 153;
            this.GpaMethod_errorFlag.Text = "*";
            // 
            // AttendancePercent_NUD
            // 
            this.AttendancePercent_NUD.Location = new System.Drawing.Point(830, 170);
            this.AttendancePercent_NUD.Name = "AttendancePercent_NUD";
            this.AttendancePercent_NUD.Size = new System.Drawing.Size(203, 20);
            this.AttendancePercent_NUD.TabIndex = 152;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(729, 174);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(95, 17);
            this.bunifuCustomLabel7.TabIndex = 150;
            this.bunifuCustomLabel7.Text = "Attendance %";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(769, 99);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(41, 17);
            this.bunifuCustomLabel6.TabIndex = 148;
            this.bunifuCustomLabel6.Text = "Active";
            // 
            // isActive_CB
            // 
            this.isActive_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.isActive_CB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.isActive_CB.Checked = true;
            this.isActive_CB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.isActive_CB.ForeColor = System.Drawing.Color.White;
            this.isActive_CB.Location = new System.Drawing.Point(738, 97);
            this.isActive_CB.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.isActive_CB.Name = "isActive_CB";
            this.isActive_CB.Size = new System.Drawing.Size(20, 20);
            this.isActive_CB.TabIndex = 147;
            // 
            // DepartmentName_TB
            // 
            this.DepartmentName_TB.Location = new System.Drawing.Point(121, 93);
            this.DepartmentName_TB.Multiline = true;
            this.DepartmentName_TB.Name = "DepartmentName_TB";
            this.DepartmentName_TB.Size = new System.Drawing.Size(315, 29);
            this.DepartmentName_TB.TabIndex = 146;
            this.DepartmentName_TB.TextChanged += new System.EventHandler(this.DepartmentName_TB_TextChanged);
            // 
            // ShortName_TB
            // 
            this.ShortName_TB.Location = new System.Drawing.Point(562, 93);
            this.ShortName_TB.Multiline = true;
            this.ShortName_TB.Name = "ShortName_TB";
            this.ShortName_TB.Size = new System.Drawing.Size(161, 29);
            this.ShortName_TB.TabIndex = 145;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(452, 98);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(84, 17);
            this.bunifuCustomLabel5.TabIndex = 144;
            this.bunifuCustomLabel5.Text = "Short Name";
            // 
            // UploadImage_Btn
            // 
            this.UploadImage_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.UploadImage_Btn.FlatAppearance.BorderSize = 0;
            this.UploadImage_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UploadImage_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImage_Btn.ForeColor = System.Drawing.Color.White;
            this.UploadImage_Btn.Location = new System.Drawing.Point(323, 332);
            this.UploadImage_Btn.Name = "UploadImage_Btn";
            this.UploadImage_Btn.Size = new System.Drawing.Size(113, 30);
            this.UploadImage_Btn.TabIndex = 143;
            this.UploadImage_Btn.Text = "Upload Photo";
            this.UploadImage_Btn.UseVisualStyleBackColor = false;
            this.UploadImage_Btn.Click += new System.EventHandler(this.UploadImage_Btn_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(18, 324);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(90, 38);
            this.bunifuCustomLabel4.TabIndex = 142;
            this.bunifuCustomLabel4.Text = "Department Logo ";
            // 
            // DeptLogo_PicBox
            // 
            this.DeptLogo_PicBox.Image = global::OBE_Desktop.Properties.Resources.SELogo;
            this.DeptLogo_PicBox.Location = new System.Drawing.Point(121, 285);
            this.DeptLogo_PicBox.Name = "DeptLogo_PicBox";
            this.DeptLogo_PicBox.Size = new System.Drawing.Size(182, 124);
            this.DeptLogo_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeptLogo_PicBox.TabIndex = 141;
            this.DeptLogo_PicBox.TabStop = false;
            // 
            // School_errorFlag
            // 
            this.School_errorFlag.AutoSize = true;
            this.School_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.School_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.School_errorFlag.Location = new System.Drawing.Point(72, 167);
            this.School_errorFlag.Name = "School_errorFlag";
            this.School_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.School_errorFlag.TabIndex = 140;
            this.School_errorFlag.Text = "*";
            // 
            // DeptVision_RTB
            // 
            this.DeptVision_RTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DeptVision_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeptVision_RTB.Location = new System.Drawing.Point(562, 285);
            this.DeptVision_RTB.Name = "DeptVision_RTB";
            this.DeptVision_RTB.Size = new System.Drawing.Size(471, 68);
            this.DeptVision_RTB.TabIndex = 139;
            this.DeptVision_RTB.Text = "";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(18, 224);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(83, 36);
            this.bunifuCustomLabel12.TabIndex = 136;
            this.bunifuCustomLabel12.Text = "Assesment Method";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(100, 21);
            this.bunifuCustomLabel2.TabIndex = 135;
            this.bunifuCustomLabel2.Text = "Department";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 13;
            this.bunifuSeparator2.Location = new System.Drawing.Point(21, 23);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1012, 24);
            this.bunifuSeparator2.TabIndex = 134;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(219, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 132;
            this.label5.Text = "*";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(118, 63);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel3.TabIndex = 131;
            this.bunifuCustomLabel3.Text = "Fields marked with       are required";
            // 
            // DeptName_errorLbl
            // 
            this.DeptName_errorLbl.AutoSize = true;
            this.DeptName_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptName_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.DeptName_errorLbl.Location = new System.Drawing.Point(120, 121);
            this.DeptName_errorLbl.Name = "DeptName_errorLbl";
            this.DeptName_errorLbl.Size = new System.Drawing.Size(121, 15);
            this.DeptName_errorLbl.TabIndex = 130;
            this.DeptName_errorLbl.Text = "Department is required.";
            // 
            // DeptName_errorFlag
            // 
            this.DeptName_errorFlag.AutoSize = true;
            this.DeptName_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptName_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.DeptName_errorFlag.Location = new System.Drawing.Point(101, 93);
            this.DeptName_errorFlag.Name = "DeptName_errorFlag";
            this.DeptName_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.DeptName_errorFlag.TabIndex = 129;
            this.DeptName_errorFlag.Text = "*";
            // 
            // UpdateDept_Btn
            // 
            this.UpdateDept_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateDept_Btn.FlatAppearance.BorderSize = 0;
            this.UpdateDept_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateDept_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDept_Btn.ForeColor = System.Drawing.Color.White;
            this.UpdateDept_Btn.Location = new System.Drawing.Point(121, 455);
            this.UpdateDept_Btn.Name = "UpdateDept_Btn";
            this.UpdateDept_Btn.Size = new System.Drawing.Size(141, 30);
            this.UpdateDept_Btn.TabIndex = 128;
            this.UpdateDept_Btn.Text = "Update Department";
            this.UpdateDept_Btn.UseVisualStyleBackColor = false;
            this.UpdateDept_Btn.Click += new System.EventHandler(this.UpdateDept_Btn_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(18, 170);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(71, 21);
            this.bunifuCustomLabel8.TabIndex = 133;
            this.bunifuCustomLabel8.Text = "School";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 93);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(94, 39);
            this.bunifuCustomLabel1.TabIndex = 127;
            this.bunifuCustomLabel1.Text = "Department Name";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(452, 456);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(20, 17);
            this.bunifuCustomLabel15.TabIndex = 144;
            this.bunifuCustomLabel15.Text = "Id";
            this.bunifuCustomLabel15.Visible = false;
            // 
            // DeptID_TB
            // 
            this.DeptID_TB.Location = new System.Drawing.Point(562, 451);
            this.DeptID_TB.Multiline = true;
            this.DeptID_TB.Name = "DeptID_TB";
            this.DeptID_TB.Size = new System.Drawing.Size(161, 29);
            this.DeptID_TB.TabIndex = 145;
            this.DeptID_TB.Visible = false;
            // 
            // UpdateDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 507);
            this.Controls.Add(this.GpaMethod_CB);
            this.Controls.Add(this.GpaMethod_errorLbl);
            this.Controls.Add(this.AssessmentMethd_CB);
            this.Controls.Add(this.School_CB);
            this.Controls.Add(this.AssessmentMethod_errorLbl);
            this.Controls.Add(this.School_errorLbl);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel14);
            this.Controls.Add(this.DeptMission_RTB);
            this.Controls.Add(this.bunifuCustomLabel11);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.AllowFaculty_CB);
            this.Controls.Add(this.CourseActvtiesDays_NUD);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.AssessmentMethod_errorFlag);
            this.Controls.Add(this.GpaMethod_errorFlag);
            this.Controls.Add(this.AttendancePercent_NUD);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.isActive_CB);
            this.Controls.Add(this.DepartmentName_TB);
            this.Controls.Add(this.DeptID_TB);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.ShortName_TB);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.UploadImage_Btn);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.DeptLogo_PicBox);
            this.Controls.Add(this.School_errorFlag);
            this.Controls.Add(this.DeptVision_RTB);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.DeptName_errorLbl);
            this.Controls.Add(this.DeptName_errorFlag);
            this.Controls.Add(this.UpdateDept_Btn);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateDepartment";
            this.Text = "UpdateDepartment";
            this.Load += new System.EventHandler(this.UpdateDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CourseActvtiesDays_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancePercent_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptLogo_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GpaMethod_CB;
        private System.Windows.Forms.Label GpaMethod_errorLbl;
        private System.Windows.Forms.ComboBox AssessmentMethd_CB;
        private System.Windows.Forms.ComboBox School_CB;
        private System.Windows.Forms.Label AssessmentMethod_errorLbl;
        private System.Windows.Forms.Label School_errorLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.RichTextBox DeptMission_RTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCheckbox AllowFaculty_CB;
        private System.Windows.Forms.NumericUpDown CourseActvtiesDays_NUD;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.Label AssessmentMethod_errorFlag;
        private System.Windows.Forms.Label GpaMethod_errorFlag;
        private System.Windows.Forms.NumericUpDown AttendancePercent_NUD;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCheckbox isActive_CB;
        private System.Windows.Forms.TextBox DepartmentName_TB;
        private System.Windows.Forms.TextBox ShortName_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.Button UploadImage_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox DeptLogo_PicBox;
        private System.Windows.Forms.Label School_errorFlag;
        private System.Windows.Forms.RichTextBox DeptVision_RTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label DeptName_errorLbl;
        private System.Windows.Forms.Label DeptName_errorFlag;
        private System.Windows.Forms.Button UpdateDept_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private System.Windows.Forms.TextBox DeptID_TB;
    }
}