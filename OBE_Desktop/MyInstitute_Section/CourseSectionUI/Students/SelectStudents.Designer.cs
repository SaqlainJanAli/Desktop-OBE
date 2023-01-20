namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    partial class SelectStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStudents));
            this.StudentUserDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkToAdd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RegistrationNoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLO_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WA_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsLocalDGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.user_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.add_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectAllCheck_CB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentUserDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentUserDataGrid
            // 
            this.StudentUserDataGrid.AllowUserToAddRows = false;
            this.StudentUserDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StudentUserDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentUserDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.StudentUserDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentUserDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.StudentUserDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentUserDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentUserDataGrid.ColumnHeadersHeight = 40;
            this.StudentUserDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.checkToAdd,
            this.RegistrationNoDGV,
            this.PLO_Name,
            this.WA_Code,
            this.PEO,
            this.MobileNo,
            this.IsLocalDGV,
            this.user_firstname});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentUserDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentUserDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentUserDataGrid.DoubleBuffered = true;
            this.StudentUserDataGrid.EnableHeadersVisualStyles = false;
            this.StudentUserDataGrid.GridColor = System.Drawing.Color.White;
            this.StudentUserDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.StudentUserDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.StudentUserDataGrid.Location = new System.Drawing.Point(0, 0);
            this.StudentUserDataGrid.Name = "StudentUserDataGrid";
            this.StudentUserDataGrid.ReadOnly = true;
            this.StudentUserDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentUserDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentUserDataGrid.RowHeadersVisible = false;
            this.StudentUserDataGrid.RowHeadersWidth = 50;
            this.StudentUserDataGrid.RowTemplate.Height = 25;
            this.StudentUserDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentUserDataGrid.Size = new System.Drawing.Size(824, 343);
            this.StudentUserDataGrid.TabIndex = 8;
            this.StudentUserDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentUserDataGrid_CellContentClick);
            // 
            // SrNo_DGV
            // 
            this.SrNo_DGV.HeaderText = "Sr. No.";
            this.SrNo_DGV.Name = "SrNo_DGV";
            this.SrNo_DGV.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SerialNumber.DataPropertyName = "Id";
            this.SerialNumber.HeaderText = "Id";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Visible = false;
            this.SerialNumber.Width = 51;
            // 
            // checkToAdd
            // 
            this.checkToAdd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.checkToAdd.HeaderText = "";
            this.checkToAdd.Name = "checkToAdd";
            this.checkToAdd.ReadOnly = true;
            this.checkToAdd.Width = 11;
            // 
            // RegistrationNoDGV
            // 
            this.RegistrationNoDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RegistrationNoDGV.DataPropertyName = "RegistrationNo";
            this.RegistrationNoDGV.HeaderText = "Registration No";
            this.RegistrationNoDGV.Name = "RegistrationNoDGV";
            this.RegistrationNoDGV.ReadOnly = true;
            this.RegistrationNoDGV.Width = 126;
            // 
            // PLO_Name
            // 
            this.PLO_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PLO_Name.DataPropertyName = "Name";
            this.PLO_Name.HeaderText = "Name";
            this.PLO_Name.Name = "PLO_Name";
            this.PLO_Name.ReadOnly = true;
            this.PLO_Name.Width = 75;
            // 
            // WA_Code
            // 
            this.WA_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WA_Code.DataPropertyName = "FatherName";
            this.WA_Code.HeaderText = "Father Name";
            this.WA_Code.Name = "WA_Code";
            this.WA_Code.ReadOnly = true;
            this.WA_Code.Width = 114;
            // 
            // PEO
            // 
            this.PEO.DataPropertyName = "CNIC";
            this.PEO.HeaderText = "CNIC";
            this.PEO.Name = "PEO";
            this.PEO.ReadOnly = true;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            // 
            // IsLocalDGV
            // 
            this.IsLocalDGV.DataPropertyName = "isLocal";
            this.IsLocalDGV.HeaderText = "IsLocal";
            this.IsLocalDGV.Name = "IsLocalDGV";
            this.IsLocalDGV.ReadOnly = true;
            // 
            // user_firstname
            // 
            this.user_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_firstname.DataPropertyName = "Email";
            this.user_firstname.HeaderText = "Email";
            this.user_firstname.Name = "user_firstname";
            this.user_firstname.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.add_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 105);
            this.panel1.TabIndex = 9;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(33, 26);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(131, 21);
            this.bunifuCustomLabel2.TabIndex = 72;
            this.bunifuCustomLabel2.Text = "Select Students";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 10791;
            this.bunifuSeparator2.Location = new System.Drawing.Point(37, 31);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(131, 20);
            this.bunifuSeparator2.TabIndex = 71;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // add_Btn
            // 
            this.add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.add_Btn.FlatAppearance.BorderSize = 0;
            this.add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Btn.ForeColor = System.Drawing.Color.White;
            this.add_Btn.Location = new System.Drawing.Point(40, 64);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(80, 30);
            this.add_Btn.TabIndex = 70;
            this.add_Btn.Text = "Add";
            this.add_Btn.UseVisualStyleBackColor = false;
            this.add_Btn.Click += new System.EventHandler(this.add_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.selectAllCheck_CB);
            this.panel2.Controls.Add(this.StudentUserDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 343);
            this.panel2.TabIndex = 10;
            // 
            // selectAllCheck_CB
            // 
            this.selectAllCheck_CB.AutoSize = true;
            this.selectAllCheck_CB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.selectAllCheck_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllCheck_CB.Location = new System.Drawing.Point(64, 14);
            this.selectAllCheck_CB.Name = "selectAllCheck_CB";
            this.selectAllCheck_CB.Size = new System.Drawing.Size(15, 14);
            this.selectAllCheck_CB.TabIndex = 39;
            this.selectAllCheck_CB.UseVisualStyleBackColor = false;
            this.selectAllCheck_CB.CheckedChanged += new System.EventHandler(this.selectAllCheck_CB_CheckedChanged);
            // 
            // SelectStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 448);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectStudents";
            this.Text = "SelectStudents";
            this.Load += new System.EventHandler(this.SelectStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentUserDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid StudentUserDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox selectAllCheck_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkToAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLO_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn WA_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsLocalDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_firstname;
    }
}