namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    partial class ClassStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassStudents));
            this.ClassStudentDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RefreshDataGrid_Btn = new System.Windows.Forms.PictureBox();
            this.importFromProgramBatches_Btn = new System.Windows.Forms.Button();
            this.enrollStudents_Btn = new System.Windows.Forms.Button();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WA_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLO_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProgramBatchDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClassStudentDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassStudentDataGrid
            // 
            this.ClassStudentDataGrid.AllowUserToAddRows = false;
            this.ClassStudentDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClassStudentDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassStudentDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ClassStudentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassStudentDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ClassStudentDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassStudentDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassStudentDataGrid.ColumnHeadersHeight = 40;
            this.ClassStudentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.RegNoDGV,
            this.WA_Code,
            this.PLO_Name,
            this.ProgramBatchDGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassStudentDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassStudentDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassStudentDataGrid.DoubleBuffered = true;
            this.ClassStudentDataGrid.EnableHeadersVisualStyles = false;
            this.ClassStudentDataGrid.GridColor = System.Drawing.Color.White;
            this.ClassStudentDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClassStudentDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ClassStudentDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ClassStudentDataGrid.Name = "ClassStudentDataGrid";
            this.ClassStudentDataGrid.ReadOnly = true;
            this.ClassStudentDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassStudentDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassStudentDataGrid.RowHeadersVisible = false;
            this.ClassStudentDataGrid.RowHeadersWidth = 50;
            this.ClassStudentDataGrid.RowTemplate.Height = 25;
            this.ClassStudentDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassStudentDataGrid.Size = new System.Drawing.Size(1015, 388);
            this.ClassStudentDataGrid.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClassStudentDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 388);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.RefreshDataGrid_Btn);
            this.panel1.Controls.Add(this.importFromProgramBatches_Btn);
            this.panel1.Controls.Add(this.enrollStudents_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 80);
            this.panel1.TabIndex = 19;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(339, 33);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 17);
            this.bunifuCustomLabel4.TabIndex = 390;
            this.bunifuCustomLabel4.Text = "Refresh :";
            // 
            // RefreshDataGrid_Btn
            // 
            this.RefreshDataGrid_Btn.Image = global::OBE_Desktop.Properties.Resources.RefreshIcon;
            this.RefreshDataGrid_Btn.Location = new System.Drawing.Point(411, 27);
            this.RefreshDataGrid_Btn.Name = "RefreshDataGrid_Btn";
            this.RefreshDataGrid_Btn.Size = new System.Drawing.Size(41, 29);
            this.RefreshDataGrid_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshDataGrid_Btn.TabIndex = 389;
            this.RefreshDataGrid_Btn.TabStop = false;
            this.RefreshDataGrid_Btn.Click += new System.EventHandler(this.RefreshDataGrid_Btn_Click);
            // 
            // importFromProgramBatches_Btn
            // 
            this.importFromProgramBatches_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.importFromProgramBatches_Btn.FlatAppearance.BorderSize = 0;
            this.importFromProgramBatches_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importFromProgramBatches_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFromProgramBatches_Btn.ForeColor = System.Drawing.Color.White;
            this.importFromProgramBatches_Btn.Location = new System.Drawing.Point(143, 27);
            this.importFromProgramBatches_Btn.Name = "importFromProgramBatches_Btn";
            this.importFromProgramBatches_Btn.Size = new System.Drawing.Size(176, 33);
            this.importFromProgramBatches_Btn.TabIndex = 17;
            this.importFromProgramBatches_Btn.Text = "Import from Program Baches";
            this.importFromProgramBatches_Btn.UseVisualStyleBackColor = false;
            this.importFromProgramBatches_Btn.Click += new System.EventHandler(this.importFromProgramBatches_Btn_Click);
            // 
            // enrollStudents_Btn
            // 
            this.enrollStudents_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.enrollStudents_Btn.FlatAppearance.BorderSize = 0;
            this.enrollStudents_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.enrollStudents_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrollStudents_Btn.ForeColor = System.Drawing.Color.White;
            this.enrollStudents_Btn.Location = new System.Drawing.Point(19, 27);
            this.enrollStudents_Btn.Name = "enrollStudents_Btn";
            this.enrollStudents_Btn.Size = new System.Drawing.Size(118, 33);
            this.enrollStudents_Btn.TabIndex = 4;
            this.enrollStudents_Btn.Text = "Enroll Students";
            this.enrollStudents_Btn.UseVisualStyleBackColor = false;
            this.enrollStudents_Btn.Click += new System.EventHandler(this.enrollStudents_Btn_Click);
            // 
            // SrNo_DGV
            // 
            this.SrNo_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SrNo_DGV.HeaderText = "Sr. No.";
            this.SrNo_DGV.Name = "SrNo_DGV";
            this.SrNo_DGV.ReadOnly = true;
            this.SrNo_DGV.Width = 77;
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SerialNumber.DataPropertyName = "Id";
            this.SerialNumber.HeaderText = "Id";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Visible = false;
            // 
            // RegNoDGV
            // 
            this.RegNoDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegNoDGV.DataPropertyName = "RegistrationNo";
            this.RegNoDGV.HeaderText = "Registration Number";
            this.RegNoDGV.Name = "RegNoDGV";
            this.RegNoDGV.ReadOnly = true;
            // 
            // WA_Code
            // 
            this.WA_Code.DataPropertyName = "RollNo";
            this.WA_Code.HeaderText = "Roll No";
            this.WA_Code.Name = "WA_Code";
            this.WA_Code.ReadOnly = true;
            // 
            // PLO_Name
            // 
            this.PLO_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLO_Name.DataPropertyName = "Name";
            this.PLO_Name.HeaderText = "Name";
            this.PLO_Name.Name = "PLO_Name";
            this.PLO_Name.ReadOnly = true;
            // 
            // ProgramBatchDGV
            // 
            this.ProgramBatchDGV.DataPropertyName = "ProgramBatchId";
            this.ProgramBatchDGV.HeaderText = "Program Batches";
            this.ProgramBatchDGV.Name = "ProgramBatchDGV";
            this.ProgramBatchDGV.ReadOnly = true;
            // 
            // ClassStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassStudents";
            this.Text = "ClassStudents";
            this.Load += new System.EventHandler(this.ClassStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassStudentDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid ClassStudentDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button importFromProgramBatches_Btn;
        private System.Windows.Forms.Button enrollStudents_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox RefreshDataGrid_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn WA_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLO_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramBatchDGV;
    }
}