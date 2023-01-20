namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    partial class EnrollClassStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrollClassStudent));
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Student_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Student_errorLbl = new System.Windows.Forms.Label();
            this.Student_errorFlag = new System.Windows.Forms.Label();
            this.saveStudent_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(25, 26);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(166, 21);
            this.bunifuCustomLabel2.TabIndex = 56;
            this.bunifuCustomLabel2.Text = "Enroll Class Student";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 10791;
            this.bunifuSeparator2.Location = new System.Drawing.Point(29, 28);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(443, 20);
            this.bunifuSeparator2.TabIndex = 55;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // Student_CB
            // 
            this.Student_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Student_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_CB.FormattingEnabled = true;
            this.Student_CB.IntegralHeight = false;
            this.Student_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.Student_CB.Location = new System.Drawing.Point(46, 117);
            this.Student_CB.Name = "Student_CB";
            this.Student_CB.Size = new System.Drawing.Size(426, 29);
            this.Student_CB.TabIndex = 57;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(46, 93);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(65, 21);
            this.bunifuCustomLabel10.TabIndex = 58;
            this.bunifuCustomLabel10.Text = "Student";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(43, 56);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel3.TabIndex = 61;
            this.bunifuCustomLabel3.Text = "Fields marked with       are required";
            // 
            // Student_errorLbl
            // 
            this.Student_errorLbl.AutoSize = true;
            this.Student_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Student_errorLbl.Location = new System.Drawing.Point(46, 149);
            this.Student_errorLbl.Name = "Student_errorLbl";
            this.Student_errorLbl.Size = new System.Drawing.Size(101, 15);
            this.Student_errorLbl.TabIndex = 60;
            this.Student_errorLbl.Text = "Student is required.";
            // 
            // Student_errorFlag
            // 
            this.Student_errorFlag.AutoSize = true;
            this.Student_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Student_errorFlag.Location = new System.Drawing.Point(99, 85);
            this.Student_errorFlag.Name = "Student_errorFlag";
            this.Student_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Student_errorFlag.TabIndex = 59;
            this.Student_errorFlag.Text = "*";
            // 
            // saveStudent_Btn
            // 
            this.saveStudent_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.saveStudent_Btn.FlatAppearance.BorderSize = 0;
            this.saveStudent_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveStudent_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveStudent_Btn.ForeColor = System.Drawing.Color.White;
            this.saveStudent_Btn.Location = new System.Drawing.Point(46, 181);
            this.saveStudent_Btn.Name = "saveStudent_Btn";
            this.saveStudent_Btn.Size = new System.Drawing.Size(118, 30);
            this.saveStudent_Btn.TabIndex = 64;
            this.saveStudent_Btn.Text = "Save Student";
            this.saveStudent_Btn.UseVisualStyleBackColor = false;
            this.saveStudent_Btn.Click += new System.EventHandler(this.saveStudent_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(140, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "*";
            // 
            // EnrollClassStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveStudent_Btn);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Student_errorLbl);
            this.Controls.Add(this.Student_errorFlag);
            this.Controls.Add(this.Student_CB);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnrollClassStudent";
            this.Text = "EnrollClassStudent";
            this.Load += new System.EventHandler(this.EnrollClassStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.ComboBox Student_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label Student_errorLbl;
        private System.Windows.Forms.Label Student_errorFlag;
        private System.Windows.Forms.Button saveStudent_Btn;
        private System.Windows.Forms.Label label1;
    }
}