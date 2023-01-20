namespace OBE_Desktop.MyInstitute_Section.SchoolUI
{
    partial class UpdateSchool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSchool));
            this.UploadImage_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SchoolIcon_PicBox = new System.Windows.Forms.PictureBox();
            this.SchoolName_TB = new System.Windows.Forms.TextBox();
            this.School_errorFlag = new System.Windows.Forms.Label();
            this.Campus_CB = new System.Windows.Forms.ComboBox();
            this.Notes_RTB = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Address_TB = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.City_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SchoolName_errorLbl = new System.Windows.Forms.Label();
            this.Campus_errorLbl = new System.Windows.Forms.Label();
            this.Campus_errorFlag = new System.Windows.Forms.Label();
            this.UpdateSchool_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SchoolId_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolIcon_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadImage_Btn
            // 
            this.UploadImage_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.UploadImage_Btn.FlatAppearance.BorderSize = 0;
            this.UploadImage_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UploadImage_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImage_Btn.ForeColor = System.Drawing.Color.White;
            this.UploadImage_Btn.Location = new System.Drawing.Point(399, 322);
            this.UploadImage_Btn.Name = "UploadImage_Btn";
            this.UploadImage_Btn.Size = new System.Drawing.Size(113, 30);
            this.UploadImage_Btn.TabIndex = 127;
            this.UploadImage_Btn.Text = "Upload Photo";
            this.UploadImage_Btn.UseVisualStyleBackColor = false;
            this.UploadImage_Btn.Click += new System.EventHandler(this.UploadImage_Btn_Click);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(23, 318);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(63, 38);
            this.bunifuCustomLabel4.TabIndex = 126;
            this.bunifuCustomLabel4.Text = "School Icon";
            // 
            // SchoolIcon_PicBox
            // 
            this.SchoolIcon_PicBox.Image = global::OBE_Desktop.Properties.Resources.download1;
            this.SchoolIcon_PicBox.Location = new System.Drawing.Point(120, 275);
            this.SchoolIcon_PicBox.Name = "SchoolIcon_PicBox";
            this.SchoolIcon_PicBox.Size = new System.Drawing.Size(251, 124);
            this.SchoolIcon_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SchoolIcon_PicBox.TabIndex = 125;
            this.SchoolIcon_PicBox.TabStop = false;
            // 
            // SchoolName_TB
            // 
            this.SchoolName_TB.Location = new System.Drawing.Point(120, 158);
            this.SchoolName_TB.Multiline = true;
            this.SchoolName_TB.Name = "SchoolName_TB";
            this.SchoolName_TB.Size = new System.Drawing.Size(392, 29);
            this.SchoolName_TB.TabIndex = 123;
            this.SchoolName_TB.TextChanged += new System.EventHandler(this.SchoolName_TB_TextChanged);
            // 
            // School_errorFlag
            // 
            this.School_errorFlag.AutoSize = true;
            this.School_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.School_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.School_errorFlag.Location = new System.Drawing.Point(75, 152);
            this.School_errorFlag.Name = "School_errorFlag";
            this.School_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.School_errorFlag.TabIndex = 124;
            this.School_errorFlag.Text = "*";
            // 
            // Campus_CB
            // 
            this.Campus_CB.DisplayMember = "Name";
            this.Campus_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Campus_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campus_CB.FormattingEnabled = true;
            this.Campus_CB.IntegralHeight = false;
            this.Campus_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.Campus_CB.Location = new System.Drawing.Point(120, 83);
            this.Campus_CB.Name = "Campus_CB";
            this.Campus_CB.Size = new System.Drawing.Size(899, 29);
            this.Campus_CB.TabIndex = 122;
            this.Campus_CB.ValueMember = "Id";
            this.Campus_CB.SelectedIndexChanged += new System.EventHandler(this.Campus_CB_SelectedIndexChanged);
            // 
            // Notes_RTB
            // 
            this.Notes_RTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Notes_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Notes_RTB.Location = new System.Drawing.Point(627, 214);
            this.Notes_RTB.Name = "Notes_RTB";
            this.Notes_RTB.Size = new System.Drawing.Size(392, 185);
            this.Notes_RTB.TabIndex = 121;
            this.Notes_RTB.Text = "";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(574, 224);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(47, 19);
            this.bunifuCustomLabel15.TabIndex = 120;
            this.bunifuCustomLabel15.Text = "Notes";
            // 
            // Address_TB
            // 
            this.Address_TB.Location = new System.Drawing.Point(627, 158);
            this.Address_TB.Multiline = true;
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(392, 29);
            this.Address_TB.TabIndex = 119;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(562, 163);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(59, 17);
            this.bunifuCustomLabel13.TabIndex = 118;
            this.bunifuCustomLabel13.Text = "Address";
            // 
            // City_CB
            // 
            this.City_CB.DisplayMember = "Name";
            this.City_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.City_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_CB.FormattingEnabled = true;
            this.City_CB.IntegralHeight = false;
            this.City_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.City_CB.Location = new System.Drawing.Point(120, 214);
            this.City_CB.Name = "City_CB";
            this.City_CB.Size = new System.Drawing.Size(392, 29);
            this.City_CB.TabIndex = 117;
            this.City_CB.ValueMember = "Id";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(23, 223);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(32, 26);
            this.bunifuCustomLabel12.TabIndex = 116;
            this.bunifuCustomLabel12.Text = "City";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(23, 27);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(61, 21);
            this.bunifuCustomLabel2.TabIndex = 115;
            this.bunifuCustomLabel2.Text = "School";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 5;
            this.bunifuSeparator2.Location = new System.Drawing.Point(26, 26);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(992, 24);
            this.bunifuSeparator2.TabIndex = 114;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(218, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 112;
            this.label5.Text = "*";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(117, 47);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel3.TabIndex = 111;
            this.bunifuCustomLabel3.Text = "Fields marked with       are required";
            // 
            // SchoolName_errorLbl
            // 
            this.SchoolName_errorLbl.AutoSize = true;
            this.SchoolName_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolName_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.SchoolName_errorLbl.Location = new System.Drawing.Point(117, 190);
            this.SchoolName_errorLbl.Name = "SchoolName_errorLbl";
            this.SchoolName_errorLbl.Size = new System.Drawing.Size(97, 15);
            this.SchoolName_errorLbl.TabIndex = 110;
            this.SchoolName_errorLbl.Text = "School is required.";
            // 
            // Campus_errorLbl
            // 
            this.Campus_errorLbl.AutoSize = true;
            this.Campus_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campus_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Campus_errorLbl.Location = new System.Drawing.Point(119, 111);
            this.Campus_errorLbl.Name = "Campus_errorLbl";
            this.Campus_errorLbl.Size = new System.Drawing.Size(103, 15);
            this.Campus_errorLbl.TabIndex = 109;
            this.Campus_errorLbl.Text = "Campus is required.";
            // 
            // Campus_errorFlag
            // 
            this.Campus_errorFlag.AutoSize = true;
            this.Campus_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campus_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Campus_errorFlag.Location = new System.Drawing.Point(78, 80);
            this.Campus_errorFlag.Name = "Campus_errorFlag";
            this.Campus_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Campus_errorFlag.TabIndex = 108;
            this.Campus_errorFlag.Text = "*";
            // 
            // UpdateSchool_Btn
            // 
            this.UpdateSchool_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateSchool_Btn.FlatAppearance.BorderSize = 0;
            this.UpdateSchool_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateSchool_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSchool_Btn.ForeColor = System.Drawing.Color.White;
            this.UpdateSchool_Btn.Location = new System.Drawing.Point(120, 445);
            this.UpdateSchool_Btn.Name = "UpdateSchool_Btn";
            this.UpdateSchool_Btn.Size = new System.Drawing.Size(102, 30);
            this.UpdateSchool_Btn.TabIndex = 107;
            this.UpdateSchool_Btn.Text = "Update School";
            this.UpdateSchool_Btn.UseVisualStyleBackColor = false;
            this.UpdateSchool_Btn.Click += new System.EventHandler(this.UpdateSchool_Btn_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(23, 157);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(71, 35);
            this.bunifuCustomLabel8.TabIndex = 113;
            this.bunifuCustomLabel8.Text = "School Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 87);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 26);
            this.bunifuCustomLabel1.TabIndex = 106;
            this.bunifuCustomLabel1.Text = "Campus";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(562, 452);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 18);
            this.bunifuCustomLabel5.TabIndex = 113;
            this.bunifuCustomLabel5.Text = "Id";
            this.bunifuCustomLabel5.Visible = false;
            // 
            // SchoolId_TB
            // 
            this.SchoolId_TB.Location = new System.Drawing.Point(627, 446);
            this.SchoolId_TB.Multiline = true;
            this.SchoolId_TB.Name = "SchoolId_TB";
            this.SchoolId_TB.Size = new System.Drawing.Size(365, 29);
            this.SchoolId_TB.TabIndex = 123;
            this.SchoolId_TB.Visible = false;
            this.SchoolId_TB.TextChanged += new System.EventHandler(this.SchoolName_TB_TextChanged);
            // 
            // UpdateSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1063, 514);
            this.Controls.Add(this.UploadImage_Btn);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.SchoolIcon_PicBox);
            this.Controls.Add(this.SchoolId_TB);
            this.Controls.Add(this.SchoolName_TB);
            this.Controls.Add(this.School_errorFlag);
            this.Controls.Add(this.Campus_CB);
            this.Controls.Add(this.Notes_RTB);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.Address_TB);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.City_CB);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.SchoolName_errorLbl);
            this.Controls.Add(this.Campus_errorLbl);
            this.Controls.Add(this.Campus_errorFlag);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.UpdateSchool_Btn);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateSchool";
            this.Text = "UpdateSchool";
            this.Load += new System.EventHandler(this.UpdateSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolIcon_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadImage_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox SchoolIcon_PicBox;
        private System.Windows.Forms.TextBox SchoolName_TB;
        private System.Windows.Forms.Label School_errorFlag;
        private System.Windows.Forms.ComboBox Campus_CB;
        private System.Windows.Forms.RichTextBox Notes_RTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private System.Windows.Forms.TextBox Address_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.ComboBox City_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label SchoolName_errorLbl;
        private System.Windows.Forms.Label Campus_errorLbl;
        private System.Windows.Forms.Label Campus_errorFlag;
        private System.Windows.Forms.Button UpdateSchool_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox SchoolId_TB;
    }
}