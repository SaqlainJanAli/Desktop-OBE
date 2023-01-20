namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Assessment.Class_Activity
{
    partial class ClassActivityHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassActivityHome));
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClassActivityDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityTypeId_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarks_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPAWeight_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.View_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RefreshDataGrid_Btn = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.CreateActivity_Btn = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassActivityDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ClassActivityDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 335);
            this.panel2.TabIndex = 265;
            // 
            // ClassActivityDataGrid
            // 
            this.ClassActivityDataGrid.AllowUserToAddRows = false;
            this.ClassActivityDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClassActivityDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassActivityDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ClassActivityDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClassActivityDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ClassActivityDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassActivityDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClassActivityDataGrid.ColumnHeadersHeight = 50;
            this.ClassActivityDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.login_username,
            this.ActivityTypeId_DGV,
            this.TotalMarks_DGV,
            this.GPAWeight_DGV,
            this.Result_DGV,
            this.View_DGV,
            this.Update_DGV,
            this.Delete_DGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClassActivityDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClassActivityDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassActivityDataGrid.DoubleBuffered = true;
            this.ClassActivityDataGrid.EnableHeadersVisualStyles = false;
            this.ClassActivityDataGrid.GridColor = System.Drawing.Color.White;
            this.ClassActivityDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClassActivityDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ClassActivityDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ClassActivityDataGrid.Name = "ClassActivityDataGrid";
            this.ClassActivityDataGrid.ReadOnly = true;
            this.ClassActivityDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClassActivityDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClassActivityDataGrid.RowHeadersVisible = false;
            this.ClassActivityDataGrid.RowHeadersWidth = 50;
            this.ClassActivityDataGrid.RowTemplate.Height = 25;
            this.ClassActivityDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClassActivityDataGrid.Size = new System.Drawing.Size(793, 335);
            this.ClassActivityDataGrid.TabIndex = 261;
            this.ClassActivityDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassActivityDataGrid_CellContentClick);
            // 
            // SrNo_DGV
            // 
            this.SrNo_DGV.HeaderText = "Sr. No.";
            this.SrNo_DGV.Name = "SrNo_DGV";
            this.SrNo_DGV.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
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
            // ActivityTypeId_DGV
            // 
            this.ActivityTypeId_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ActivityTypeId_DGV.DataPropertyName = "ActivityId";
            this.ActivityTypeId_DGV.HeaderText = "Activity Type";
            this.ActivityTypeId_DGV.Name = "ActivityTypeId_DGV";
            this.ActivityTypeId_DGV.ReadOnly = true;
            this.ActivityTypeId_DGV.Width = 99;
            // 
            // TotalMarks_DGV
            // 
            this.TotalMarks_DGV.DataPropertyName = "TotalMarks";
            this.TotalMarks_DGV.HeaderText = "Total Marks";
            this.TotalMarks_DGV.Name = "TotalMarks_DGV";
            this.TotalMarks_DGV.ReadOnly = true;
            // 
            // GPAWeight_DGV
            // 
            this.GPAWeight_DGV.DataPropertyName = "GPAWeight";
            this.GPAWeight_DGV.HeaderText = "GPA Weight";
            this.GPAWeight_DGV.Name = "GPAWeight_DGV";
            this.GPAWeight_DGV.ReadOnly = true;
            // 
            // Result_DGV
            // 
            this.Result_DGV.HeaderText = "";
            this.Result_DGV.Image = global::OBE_Desktop.Properties.Resources.createResult;
            this.Result_DGV.Name = "Result_DGV";
            this.Result_DGV.ReadOnly = true;
            this.Result_DGV.ToolTipText = "Create Result";
            // 
            // View_DGV
            // 
            this.View_DGV.HeaderText = "";
            this.View_DGV.Image = global::OBE_Desktop.Properties.Resources.view;
            this.View_DGV.Name = "View_DGV";
            this.View_DGV.ReadOnly = true;
            this.View_DGV.ToolTipText = "View";
            // 
            // Update_DGV
            // 
            this.Update_DGV.HeaderText = "";
            this.Update_DGV.Image = global::OBE_Desktop.Properties.Resources.update;
            this.Update_DGV.Name = "Update_DGV";
            this.Update_DGV.ReadOnly = true;
            this.Update_DGV.ToolTipText = "Update";
            // 
            // Delete_DGV
            // 
            this.Delete_DGV.HeaderText = "";
            this.Delete_DGV.Image = global::OBE_Desktop.Properties.Resources.delete;
            this.Delete_DGV.Name = "Delete_DGV";
            this.Delete_DGV.ReadOnly = true;
            this.Delete_DGV.ToolTipText = "Delete";
            this.Delete_DGV.Width = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.RefreshDataGrid_Btn);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.CreateActivity_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 124);
            this.panel1.TabIndex = 264;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(201, 79);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 17);
            this.bunifuCustomLabel4.TabIndex = 388;
            this.bunifuCustomLabel4.Text = "Refresh :";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(19, 21);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(125, 21);
            this.bunifuCustomLabel9.TabIndex = 246;
            this.bunifuCustomLabel9.Text = "Class Activities";
            // 
            // RefreshDataGrid_Btn
            // 
            this.RefreshDataGrid_Btn.Image = global::OBE_Desktop.Properties.Resources.RefreshIcon;
            this.RefreshDataGrid_Btn.Location = new System.Drawing.Point(273, 73);
            this.RefreshDataGrid_Btn.Name = "RefreshDataGrid_Btn";
            this.RefreshDataGrid_Btn.Size = new System.Drawing.Size(41, 29);
            this.RefreshDataGrid_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshDataGrid_Btn.TabIndex = 387;
            this.RefreshDataGrid_Btn.TabStop = false;
            this.RefreshDataGrid_Btn.Click += new System.EventHandler(this.RefreshDataGrid_Btn_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(22, 22);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(129, 24);
            this.bunifuSeparator1.TabIndex = 245;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // CreateActivity_Btn
            // 
            this.CreateActivity_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.CreateActivity_Btn.FlatAppearance.BorderSize = 0;
            this.CreateActivity_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateActivity_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateActivity_Btn.ForeColor = System.Drawing.Color.White;
            this.CreateActivity_Btn.Location = new System.Drawing.Point(23, 69);
            this.CreateActivity_Btn.Name = "CreateActivity_Btn";
            this.CreateActivity_Btn.Size = new System.Drawing.Size(145, 37);
            this.CreateActivity_Btn.TabIndex = 259;
            this.CreateActivity_Btn.Text = "Add Class Activity";
            this.CreateActivity_Btn.UseVisualStyleBackColor = false;
            this.CreateActivity_Btn.Click += new System.EventHandler(this.CreateActivity_Btn_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::OBE_Desktop.Properties.Resources.createResult;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Create Result";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::OBE_Desktop.Properties.Resources.view;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "View";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::OBE_Desktop.Properties.Resources.update;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ToolTipText = "Update";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::OBE_Desktop.Properties.Resources.delete;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ToolTipText = "Delete";
            this.dataGridViewImageColumn4.Width = 90;
            // 
            // ClassActivityHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 459);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClassActivityHome";
            this.Text = "ClassActivityHome";
            this.Load += new System.EventHandler(this.ClassActivityHome_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassActivityDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ClassActivityDataGrid;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button CreateActivity_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox RefreshDataGrid_Btn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityTypeId_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarks_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPAWeight_DGV;
        private System.Windows.Forms.DataGridViewImageColumn Result_DGV;
        private System.Windows.Forms.DataGridViewImageColumn View_DGV;
        private System.Windows.Forms.DataGridViewImageColumn Update_DGV;
        private System.Windows.Forms.DataGridViewImageColumn Delete_DGV;
    }
}