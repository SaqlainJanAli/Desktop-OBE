namespace OBE_Desktop.MyInstitute_Section.SemesterUI
{
    partial class UpdateSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSemester));
            this.AcademicYear_TB = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ShowResult_CB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Completed_CB = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SemName_TB = new System.Windows.Forms.TextBox();
            this.Name_errorLbl = new System.Windows.Forms.Label();
            this.Name_errorFlag = new System.Windows.Forms.Label();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Notes_RTB = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AcademicYear_errorLbl = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AcademicYear_errorFlag = new System.Windows.Forms.Label();
            this.UpdateSemester_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.EndDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.StartDate_DTP = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SemeserID_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AcademicYear_TB
            // 
            this.AcademicYear_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcademicYear_TB.Location = new System.Drawing.Point(130, 94);
            this.AcademicYear_TB.Multiline = true;
            this.AcademicYear_TB.Name = "AcademicYear_TB";
            this.AcademicYear_TB.Size = new System.Drawing.Size(392, 29);
            this.AcademicYear_TB.TabIndex = 140;
            this.AcademicYear_TB.TextChanged += new System.EventHandler(this.AcademicYear_TB_TextChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(641, 326);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(179, 17);
            this.bunifuCustomLabel7.TabIndex = 139;
            this.bunifuCustomLabel7.Text = "Show Result in Transcript (GPA)";
            // 
            // ShowResult_CB
            // 
            this.ShowResult_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ShowResult_CB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ShowResult_CB.Checked = true;
            this.ShowResult_CB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ShowResult_CB.ForeColor = System.Drawing.Color.White;
            this.ShowResult_CB.Location = new System.Drawing.Point(613, 323);
            this.ShowResult_CB.Margin = new System.Windows.Forms.Padding(7, 13, 7, 13);
            this.ShowResult_CB.Name = "ShowResult_CB";
            this.ShowResult_CB.Size = new System.Drawing.Size(20, 20);
            this.ShowResult_CB.TabIndex = 138;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(641, 271);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(69, 17);
            this.bunifuCustomLabel4.TabIndex = 137;
            this.bunifuCustomLabel4.Text = "Completed";
            // 
            // Completed_CB
            // 
            this.Completed_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Completed_CB.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Completed_CB.Checked = true;
            this.Completed_CB.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Completed_CB.ForeColor = System.Drawing.Color.White;
            this.Completed_CB.Location = new System.Drawing.Point(613, 269);
            this.Completed_CB.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Completed_CB.Name = "Completed_CB";
            this.Completed_CB.Size = new System.Drawing.Size(20, 20);
            this.Completed_CB.TabIndex = 136;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(569, 169);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(75, 22);
            this.bunifuCustomLabel6.TabIndex = 134;
            this.bunifuCustomLabel6.Text = "End Date";
            // 
            // SemName_TB
            // 
            this.SemName_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemName_TB.Location = new System.Drawing.Point(644, 94);
            this.SemName_TB.Multiline = true;
            this.SemName_TB.Name = "SemName_TB";
            this.SemName_TB.Size = new System.Drawing.Size(392, 29);
            this.SemName_TB.TabIndex = 130;
            this.SemName_TB.TextChanged += new System.EventHandler(this.SemName_TB_TextChanged);
            // 
            // Name_errorLbl
            // 
            this.Name_errorLbl.AutoSize = true;
            this.Name_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Name_errorLbl.Location = new System.Drawing.Point(641, 122);
            this.Name_errorLbl.Name = "Name_errorLbl";
            this.Name_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.Name_errorLbl.TabIndex = 132;
            this.Name_errorLbl.Text = "Name is required.";
            // 
            // Name_errorFlag
            // 
            this.Name_errorFlag.AutoSize = true;
            this.Name_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Name_errorFlag.Location = new System.Drawing.Point(611, 98);
            this.Name_errorFlag.Name = "Name_errorFlag";
            this.Name_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Name_errorFlag.TabIndex = 131;
            this.Name_errorFlag.Text = "*";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(569, 102);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(46, 17);
            this.bunifuCustomLabel5.TabIndex = 129;
            this.bunifuCustomLabel5.Text = "Name";
            // 
            // Notes_RTB
            // 
            this.Notes_RTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Notes_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Notes_RTB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes_RTB.Location = new System.Drawing.Point(130, 222);
            this.Notes_RTB.Name = "Notes_RTB";
            this.Notes_RTB.Size = new System.Drawing.Size(392, 185);
            this.Notes_RTB.TabIndex = 128;
            this.Notes_RTB.Text = "";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(23, 236);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(47, 19);
            this.bunifuCustomLabel15.TabIndex = 127;
            this.bunifuCustomLabel15.Text = "Notes";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 32);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(81, 21);
            this.bunifuCustomLabel2.TabIndex = 126;
            this.bunifuCustomLabel2.Text = "Semester";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 13;
            this.bunifuSeparator2.Location = new System.Drawing.Point(30, 30);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1012, 24);
            this.bunifuSeparator2.TabIndex = 125;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(228, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 123;
            this.label5.Text = "*";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(127, 58);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel3.TabIndex = 122;
            this.bunifuCustomLabel3.Text = "Fields marked with       are required";
            // 
            // AcademicYear_errorLbl
            // 
            this.AcademicYear_errorLbl.AutoSize = true;
            this.AcademicYear_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcademicYear_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.AcademicYear_errorLbl.Location = new System.Drawing.Point(129, 125);
            this.AcademicYear_errorLbl.Name = "AcademicYear_errorLbl";
            this.AcademicYear_errorLbl.Size = new System.Drawing.Size(136, 15);
            this.AcademicYear_errorLbl.TabIndex = 121;
            this.AcademicYear_errorLbl.Text = "Academic Year is required.";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 94);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 37);
            this.bunifuCustomLabel1.TabIndex = 118;
            this.bunifuCustomLabel1.Text = "Academic Year";
            // 
            // AcademicYear_errorFlag
            // 
            this.AcademicYear_errorFlag.AutoSize = true;
            this.AcademicYear_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcademicYear_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.AcademicYear_errorFlag.Location = new System.Drawing.Point(89, 92);
            this.AcademicYear_errorFlag.Name = "AcademicYear_errorFlag";
            this.AcademicYear_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.AcademicYear_errorFlag.TabIndex = 120;
            this.AcademicYear_errorFlag.Text = "*";
            // 
            // UpdateSemester_Btn
            // 
            this.UpdateSemester_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateSemester_Btn.FlatAppearance.BorderSize = 0;
            this.UpdateSemester_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateSemester_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSemester_Btn.ForeColor = System.Drawing.Color.White;
            this.UpdateSemester_Btn.Location = new System.Drawing.Point(130, 449);
            this.UpdateSemester_Btn.Name = "UpdateSemester_Btn";
            this.UpdateSemester_Btn.Size = new System.Drawing.Size(135, 30);
            this.UpdateSemester_Btn.TabIndex = 119;
            this.UpdateSemester_Btn.Text = "Update Semesters";
            this.UpdateSemester_Btn.UseVisualStyleBackColor = false;
            this.UpdateSemester_Btn.Click += new System.EventHandler(this.UpdateSemester_Btn_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(23, 169);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(75, 22);
            this.bunifuCustomLabel8.TabIndex = 124;
            this.bunifuCustomLabel8.Text = "Start Date";
            // 
            // EndDate_DTP
            // 
            this.EndDate_DTP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_DTP.Location = new System.Drawing.Point(644, 165);
            this.EndDate_DTP.Name = "EndDate_DTP";
            this.EndDate_DTP.Size = new System.Drawing.Size(392, 25);
            this.EndDate_DTP.TabIndex = 142;
            // 
            // StartDate_DTP
            // 
            this.StartDate_DTP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_DTP.Location = new System.Drawing.Point(132, 165);
            this.StartDate_DTP.Name = "StartDate_DTP";
            this.StartDate_DTP.Size = new System.Drawing.Size(392, 25);
            this.StartDate_DTP.TabIndex = 141;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(307, 455);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(20, 18);
            this.bunifuCustomLabel9.TabIndex = 118;
            this.bunifuCustomLabel9.Text = "Id";
            // 
            // SemeserID_TB
            // 
            this.SemeserID_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemeserID_TB.Location = new System.Drawing.Point(342, 450);
            this.SemeserID_TB.Multiline = true;
            this.SemeserID_TB.Name = "SemeserID_TB";
            this.SemeserID_TB.Size = new System.Drawing.Size(392, 29);
            this.SemeserID_TB.TabIndex = 140;
            this.SemeserID_TB.TextChanged += new System.EventHandler(this.AcademicYear_TB_TextChanged);
            // 
            // UpdateSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 607);
            this.Controls.Add(this.EndDate_DTP);
            this.Controls.Add(this.StartDate_DTP);
            this.Controls.Add(this.SemeserID_TB);
            this.Controls.Add(this.AcademicYear_TB);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.ShowResult_CB);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.Completed_CB);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.SemName_TB);
            this.Controls.Add(this.Name_errorLbl);
            this.Controls.Add(this.Name_errorFlag);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.Notes_RTB);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.AcademicYear_errorLbl);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.AcademicYear_errorFlag);
            this.Controls.Add(this.UpdateSemester_Btn);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSemester";
            this.Text = "UpdateSemester";
            this.Load += new System.EventHandler(this.UpdateSemester_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AcademicYear_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCheckbox ShowResult_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCheckbox Completed_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox SemName_TB;
        private System.Windows.Forms.Label Name_errorLbl;
        private System.Windows.Forms.Label Name_errorFlag;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.RichTextBox Notes_RTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label AcademicYear_errorLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label AcademicYear_errorFlag;
        private System.Windows.Forms.Button UpdateSemester_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.DateTimePicker EndDate_DTP;
        private System.Windows.Forms.DateTimePicker StartDate_DTP;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.TextBox SemeserID_TB;
    }
}