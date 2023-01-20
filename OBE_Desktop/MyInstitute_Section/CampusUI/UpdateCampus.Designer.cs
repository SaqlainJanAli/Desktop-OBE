namespace OBE_Desktop.MyInstitute_Section.CampusUI
{
    partial class UpdateCampus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCampus));
            this.UploadImage_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Header_PicBox = new System.Windows.Forms.PictureBox();
            this.CampusName_TB = new System.Windows.Forms.TextBox();
            this.Campus_errorflag = new System.Windows.Forms.Label();
            this.Institute_CB = new System.Windows.Forms.ComboBox();
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
            this.Campus_errorLbl = new System.Windows.Forms.Label();
            this.University_errorLbl = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.University_errorflag = new System.Windows.Forms.Label();
            this.UpdateCampus_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CampusID_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Header_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadImage_Btn
            // 
            this.UploadImage_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.UploadImage_Btn.FlatAppearance.BorderSize = 0;
            this.UploadImage_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UploadImage_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadImage_Btn.ForeColor = System.Drawing.Color.White;
            this.UploadImage_Btn.Location = new System.Drawing.Point(408, 339);
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
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(18, 335);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(63, 38);
            this.bunifuCustomLabel4.TabIndex = 126;
            this.bunifuCustomLabel4.Text = "Header Image";
            // 
            // Header_PicBox
            // 
            this.Header_PicBox.Image = global::OBE_Desktop.Properties.Resources.download1;
            this.Header_PicBox.Location = new System.Drawing.Point(129, 292);
            this.Header_PicBox.Name = "Header_PicBox";
            this.Header_PicBox.Size = new System.Drawing.Size(251, 124);
            this.Header_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Header_PicBox.TabIndex = 125;
            this.Header_PicBox.TabStop = false;
            // 
            // CampusName_TB
            // 
            this.CampusName_TB.Location = new System.Drawing.Point(129, 175);
            this.CampusName_TB.Multiline = true;
            this.CampusName_TB.Name = "CampusName_TB";
            this.CampusName_TB.Size = new System.Drawing.Size(392, 29);
            this.CampusName_TB.TabIndex = 123;
            this.CampusName_TB.TextChanged += new System.EventHandler(this.CampusName_TB_TextChanged);
            // 
            // Campus_errorflag
            // 
            this.Campus_errorflag.AutoSize = true;
            this.Campus_errorflag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campus_errorflag.ForeColor = System.Drawing.Color.Red;
            this.Campus_errorflag.Location = new System.Drawing.Point(82, 174);
            this.Campus_errorflag.Name = "Campus_errorflag";
            this.Campus_errorflag.Size = new System.Drawing.Size(20, 21);
            this.Campus_errorflag.TabIndex = 124;
            this.Campus_errorflag.Text = "*";
            // 
            // Institute_CB
            // 
            this.Institute_CB.DisplayMember = "Name";
            this.Institute_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Institute_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Institute_CB.FormattingEnabled = true;
            this.Institute_CB.IntegralHeight = false;
            this.Institute_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.Institute_CB.Location = new System.Drawing.Point(129, 100);
            this.Institute_CB.Name = "Institute_CB";
            this.Institute_CB.Size = new System.Drawing.Size(899, 29);
            this.Institute_CB.TabIndex = 122;
            this.Institute_CB.ValueMember = "Id";
            this.Institute_CB.SelectedIndexChanged += new System.EventHandler(this.University_CB_SelectedIndexChanged);
            // 
            // Notes_RTB
            // 
            this.Notes_RTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Notes_RTB.Location = new System.Drawing.Point(636, 231);
            this.Notes_RTB.Name = "Notes_RTB";
            this.Notes_RTB.Size = new System.Drawing.Size(392, 185);
            this.Notes_RTB.TabIndex = 121;
            this.Notes_RTB.Text = "";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(571, 241);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(47, 19);
            this.bunifuCustomLabel15.TabIndex = 120;
            this.bunifuCustomLabel15.Text = "Notes";
            // 
            // Address_TB
            // 
            this.Address_TB.Location = new System.Drawing.Point(636, 175);
            this.Address_TB.Multiline = true;
            this.Address_TB.Name = "Address_TB";
            this.Address_TB.Size = new System.Drawing.Size(392, 29);
            this.Address_TB.TabIndex = 119;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(571, 180);
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
            this.City_CB.Location = new System.Drawing.Point(129, 231);
            this.City_CB.Name = "City_CB";
            this.City_CB.Size = new System.Drawing.Size(392, 29);
            this.City_CB.TabIndex = 117;
            this.City_CB.ValueMember = "Id";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(18, 240);
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
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(18, 34);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 21);
            this.bunifuCustomLabel2.TabIndex = 115;
            this.bunifuCustomLabel2.Text = "Campus";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 8;
            this.bunifuSeparator2.Location = new System.Drawing.Point(21, 32);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(1007, 24);
            this.bunifuSeparator2.TabIndex = 114;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(227, 64);
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
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(126, 64);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel3.TabIndex = 111;
            this.bunifuCustomLabel3.Text = "Fields marked with       are required";
            // 
            // Campus_errorLbl
            // 
            this.Campus_errorLbl.AutoSize = true;
            this.Campus_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campus_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Campus_errorLbl.Location = new System.Drawing.Point(128, 207);
            this.Campus_errorLbl.Name = "Campus_errorLbl";
            this.Campus_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.Campus_errorLbl.TabIndex = 110;
            this.Campus_errorLbl.Text = "Name is required.";
            // 
            // University_errorLbl
            // 
            this.University_errorLbl.AutoSize = true;
            this.University_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.University_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.University_errorLbl.Location = new System.Drawing.Point(128, 128);
            this.University_errorLbl.Name = "University_errorLbl";
            this.University_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.University_errorLbl.TabIndex = 109;
            this.University_errorLbl.Text = "Name is required.";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(18, 106);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(71, 26);
            this.bunifuCustomLabel1.TabIndex = 106;
            this.bunifuCustomLabel1.Text = "University";
            // 
            // University_errorflag
            // 
            this.University_errorflag.AutoSize = true;
            this.University_errorflag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.University_errorflag.ForeColor = System.Drawing.Color.Red;
            this.University_errorflag.Location = new System.Drawing.Point(88, 103);
            this.University_errorflag.Name = "University_errorflag";
            this.University_errorflag.Size = new System.Drawing.Size(20, 21);
            this.University_errorflag.TabIndex = 108;
            this.University_errorflag.Text = "*";
            // 
            // UpdateCampus_Btn
            // 
            this.UpdateCampus_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateCampus_Btn.FlatAppearance.BorderSize = 0;
            this.UpdateCampus_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateCampus_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCampus_Btn.ForeColor = System.Drawing.Color.White;
            this.UpdateCampus_Btn.Location = new System.Drawing.Point(129, 445);
            this.UpdateCampus_Btn.Name = "UpdateCampus_Btn";
            this.UpdateCampus_Btn.Size = new System.Drawing.Size(130, 30);
            this.UpdateCampus_Btn.TabIndex = 107;
            this.UpdateCampus_Btn.Text = "Update Campus";
            this.UpdateCampus_Btn.UseVisualStyleBackColor = false;
            this.UpdateCampus_Btn.Click += new System.EventHandler(this.UpdateCampus_Btn_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(18, 173);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(71, 35);
            this.bunifuCustomLabel8.TabIndex = 113;
            this.bunifuCustomLabel8.Text = "Campus Name";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(571, 449);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(32, 21);
            this.bunifuCustomLabel6.TabIndex = 116;
            this.bunifuCustomLabel6.Text = "Id";
            this.bunifuCustomLabel6.Visible = false;
            // 
            // CampusID_TB
            // 
            this.CampusID_TB.Location = new System.Drawing.Point(636, 441);
            this.CampusID_TB.Multiline = true;
            this.CampusID_TB.Name = "CampusID_TB";
            this.CampusID_TB.Size = new System.Drawing.Size(392, 29);
            this.CampusID_TB.TabIndex = 123;
            this.CampusID_TB.Visible = false;
            // 
            // UpdateCampus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 496);
            this.Controls.Add(this.UploadImage_Btn);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.Header_PicBox);
            this.Controls.Add(this.CampusID_TB);
            this.Controls.Add(this.CampusName_TB);
            this.Controls.Add(this.Campus_errorflag);
            this.Controls.Add(this.Institute_CB);
            this.Controls.Add(this.Notes_RTB);
            this.Controls.Add(this.bunifuCustomLabel15);
            this.Controls.Add(this.Address_TB);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.City_CB);
            this.Controls.Add(this.bunifuCustomLabel12);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Campus_errorLbl);
            this.Controls.Add(this.University_errorLbl);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.University_errorflag);
            this.Controls.Add(this.UpdateCampus_Btn);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateCampus";
            this.Text = "UpdateCampus";
            this.Load += new System.EventHandler(this.UpdateCampus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Header_PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadImage_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox Header_PicBox;
        private System.Windows.Forms.TextBox CampusName_TB;
        private System.Windows.Forms.Label Campus_errorflag;
        private System.Windows.Forms.ComboBox Institute_CB;
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
        private System.Windows.Forms.Label Campus_errorLbl;
        private System.Windows.Forms.Label University_errorLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label University_errorflag;
        private System.Windows.Forms.Button UpdateCampus_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox CampusID_TB;
    }
}