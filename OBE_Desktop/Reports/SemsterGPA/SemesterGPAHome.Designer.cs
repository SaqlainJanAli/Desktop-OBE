namespace OBE_Desktop.Reports.SemsterGPA
{
    partial class SemesterGPAHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemesterGPAHome));
            this.EnrolledStdDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollNoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShowResult_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Type_BCL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Department_CB = new System.Windows.Forms.ComboBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RefreshDataGrid_Btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EnrolledStdDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // EnrolledStdDataGrid
            // 
            this.EnrolledStdDataGrid.AllowUserToAddRows = false;
            this.EnrolledStdDataGrid.AllowUserToDeleteRows = false;
            this.EnrolledStdDataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EnrolledStdDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EnrolledStdDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.EnrolledStdDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnrolledStdDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.EnrolledStdDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EnrolledStdDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EnrolledStdDataGrid.ColumnHeadersHeight = 50;
            this.EnrolledStdDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.login_username,
            this.RegNoDGV,
            this.RollNoDGV,
            this.ShowResult_DGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EnrolledStdDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.EnrolledStdDataGrid.DoubleBuffered = true;
            this.EnrolledStdDataGrid.EnableHeadersVisualStyles = false;
            this.EnrolledStdDataGrid.GridColor = System.Drawing.Color.White;
            this.EnrolledStdDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.EnrolledStdDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.EnrolledStdDataGrid.Location = new System.Drawing.Point(0, 96);
            this.EnrolledStdDataGrid.Name = "EnrolledStdDataGrid";
            this.EnrolledStdDataGrid.ReadOnly = true;
            this.EnrolledStdDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EnrolledStdDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.EnrolledStdDataGrid.RowHeadersVisible = false;
            this.EnrolledStdDataGrid.RowHeadersWidth = 50;
            this.EnrolledStdDataGrid.RowTemplate.Height = 25;
            this.EnrolledStdDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnrolledStdDataGrid.Size = new System.Drawing.Size(983, 486);
            this.EnrolledStdDataGrid.TabIndex = 373;
            this.EnrolledStdDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActivityResultDataGrid_CellContentClick);
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
            // login_username
            // 
            this.login_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.login_username.DataPropertyName = "Name";
            this.login_username.HeaderText = "Name";
            this.login_username.Name = "login_username";
            this.login_username.ReadOnly = true;
            // 
            // RegNoDGV
            // 
            this.RegNoDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegNoDGV.DataPropertyName = "RegistrationNo";
            this.RegNoDGV.HeaderText = "Registration No";
            this.RegNoDGV.Name = "RegNoDGV";
            this.RegNoDGV.ReadOnly = true;
            // 
            // RollNoDGV
            // 
            this.RollNoDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RollNoDGV.DataPropertyName = "RollNo";
            this.RollNoDGV.HeaderText = "Roll Number";
            this.RollNoDGV.Name = "RollNoDGV";
            this.RollNoDGV.ReadOnly = true;
            // 
            // ShowResult_DGV
            // 
            this.ShowResult_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShowResult_DGV.HeaderText = "";
            this.ShowResult_DGV.Image = global::OBE_Desktop.Properties.Resources.createResult;
            this.ShowResult_DGV.Name = "ShowResult_DGV";
            this.ShowResult_DGV.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HeaderPanel);
            this.panel2.Controls.Add(this.EnrolledStdDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 582);
            this.panel2.TabIndex = 375;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.bunifuCustomLabel16);
            this.HeaderPanel.Controls.Add(this.bunifuCustomLabel1);
            this.HeaderPanel.Controls.Add(this.RefreshDataGrid_Btn);
            this.HeaderPanel.Controls.Add(this.Type_BCL);
            this.HeaderPanel.Controls.Add(this.Department_CB);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(983, 100);
            this.HeaderPanel.TabIndex = 374;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(51, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(202, 17);
            this.bunifuCustomLabel1.TabIndex = 90;
            this.bunifuCustomLabel1.Text = "Department Enrolled Students";
            // 
            // Type_BCL
            // 
            this.Type_BCL.AutoSize = true;
            this.Type_BCL.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_BCL.Location = new System.Drawing.Point(51, 53);
            this.Type_BCL.Name = "Type_BCL";
            this.Type_BCL.Size = new System.Drawing.Size(84, 17);
            this.Type_BCL.TabIndex = 88;
            this.Type_BCL.Text = "Department";
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
            this.Department_CB.Location = new System.Drawing.Point(155, 47);
            this.Department_CB.Name = "Department_CB";
            this.Department_CB.Size = new System.Drawing.Size(284, 29);
            this.Department_CB.TabIndex = 89;
            this.Department_CB.SelectedIndexChanged += new System.EventHandler(this.Department_CB_SelectedIndexChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::OBE_Desktop.Properties.Resources.createResult;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(453, 26);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabel16.TabIndex = 396;
            this.bunifuCustomLabel16.Text = "Refresh";
            // 
            // RefreshDataGrid_Btn
            // 
            this.RefreshDataGrid_Btn.Image = global::OBE_Desktop.Properties.Resources.RefreshIcon;
            this.RefreshDataGrid_Btn.Location = new System.Drawing.Point(467, 47);
            this.RefreshDataGrid_Btn.Name = "RefreshDataGrid_Btn";
            this.RefreshDataGrid_Btn.Size = new System.Drawing.Size(30, 26);
            this.RefreshDataGrid_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshDataGrid_Btn.TabIndex = 395;
            this.RefreshDataGrid_Btn.TabStop = false;
            this.RefreshDataGrid_Btn.Click += new System.EventHandler(this.RefreshDataGrid_Btn_Click);
            // 
            // SemesterGPAHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 582);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SemesterGPAHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateResult";
            this.Load += new System.EventHandler(this.CreateActivityResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnrolledStdDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid EnrolledStdDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollNoDGV;
        private System.Windows.Forms.DataGridViewImageColumn ShowResult_DGV;
        private System.Windows.Forms.Panel HeaderPanel;
        private Bunifu.Framework.UI.BunifuCustomLabel Type_BCL;
        private System.Windows.Forms.ComboBox Department_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.PictureBox RefreshDataGrid_Btn;
    }
}