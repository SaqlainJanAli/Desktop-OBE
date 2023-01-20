namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Activity_Weights
{
    partial class GPAWeight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPAWeight));
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.addActivityWeight_Btn = new System.Windows.Forms.Button();
            this.totalWarningLbl = new System.Windows.Forms.Label();
            this.ActivityWeightDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNoDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WA_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RefreshDataGrid_Btn = new System.Windows.Forms.PictureBox();
            this.TotalWeight_Lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWeightDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(24, 22);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(207, 21);
            this.bunifuCustomLabel9.TabIndex = 250;
            this.bunifuCustomLabel9.Text = "Add Activity Weight (GPA)";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 24);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(210, 24);
            this.bunifuSeparator1.TabIndex = 249;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // addActivityWeight_Btn
            // 
            this.addActivityWeight_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.addActivityWeight_Btn.FlatAppearance.BorderSize = 0;
            this.addActivityWeight_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addActivityWeight_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addActivityWeight_Btn.ForeColor = System.Drawing.Color.White;
            this.addActivityWeight_Btn.Location = new System.Drawing.Point(28, 59);
            this.addActivityWeight_Btn.Name = "addActivityWeight_Btn";
            this.addActivityWeight_Btn.Size = new System.Drawing.Size(193, 33);
            this.addActivityWeight_Btn.TabIndex = 251;
            this.addActivityWeight_Btn.Text = "Add Class Activity Weight";
            this.addActivityWeight_Btn.UseVisualStyleBackColor = false;
            this.addActivityWeight_Btn.Click += new System.EventHandler(this.addActivityWeight_Btn_Click);
            // 
            // totalWarningLbl
            // 
            this.totalWarningLbl.AutoSize = true;
            this.totalWarningLbl.BackColor = System.Drawing.Color.LemonChiffon;
            this.totalWarningLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalWarningLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.totalWarningLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWarningLbl.Location = new System.Drawing.Point(28, 106);
            this.totalWarningLbl.Name = "totalWarningLbl";
            this.totalWarningLbl.Size = new System.Drawing.Size(268, 20);
            this.totalWarningLbl.TabIndex = 252;
            this.totalWarningLbl.Text = "Total activity weight should be equal to 100";
            // 
            // ActivityWeightDataGrid
            // 
            this.ActivityWeightDataGrid.AllowUserToAddRows = false;
            this.ActivityWeightDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ActivityWeightDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ActivityWeightDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ActivityWeightDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActivityWeightDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ActivityWeightDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivityWeightDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ActivityWeightDataGrid.ColumnHeadersHeight = 40;
            this.ActivityWeightDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.RegNoDGV,
            this.WA_Code,
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
            this.ActivityWeightDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ActivityWeightDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivityWeightDataGrid.DoubleBuffered = true;
            this.ActivityWeightDataGrid.EnableHeadersVisualStyles = false;
            this.ActivityWeightDataGrid.GridColor = System.Drawing.Color.White;
            this.ActivityWeightDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ActivityWeightDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ActivityWeightDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ActivityWeightDataGrid.Name = "ActivityWeightDataGrid";
            this.ActivityWeightDataGrid.ReadOnly = true;
            this.ActivityWeightDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivityWeightDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ActivityWeightDataGrid.RowHeadersVisible = false;
            this.ActivityWeightDataGrid.RowHeadersWidth = 50;
            this.ActivityWeightDataGrid.RowTemplate.Height = 25;
            this.ActivityWeightDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActivityWeightDataGrid.Size = new System.Drawing.Size(621, 288);
            this.ActivityWeightDataGrid.TabIndex = 253;
            this.ActivityWeightDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActivityWeightDataGrid_CellContentClick);
            // 
            // SrNo_DGV
            // 
            this.SrNo_DGV.HeaderText = "Sr. No.";
            this.SrNo_DGV.Name = "SrNo_DGV";
            this.SrNo_DGV.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SerialNumber.DataPropertyName = "ActivityId";
            this.SerialNumber.HeaderText = "Sr.No";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Visible = false;
            // 
            // RegNoDGV
            // 
            this.RegNoDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegNoDGV.DataPropertyName = "ActivityName";
            this.RegNoDGV.HeaderText = "Activity";
            this.RegNoDGV.Name = "RegNoDGV";
            this.RegNoDGV.ReadOnly = true;
            // 
            // WA_Code
            // 
            this.WA_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WA_Code.DataPropertyName = "Weight";
            this.WA_Code.HeaderText = "Weight";
            this.WA_Code.Name = "WA_Code";
            this.WA_Code.ReadOnly = true;
            // 
            // View_DGV
            // 
            this.View_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.View_DGV.HeaderText = "";
            this.View_DGV.Image = global::OBE_Desktop.Properties.Resources.view;
            this.View_DGV.Name = "View_DGV";
            this.View_DGV.ReadOnly = true;
            this.View_DGV.Width = 11;
            // 
            // Update_DGV
            // 
            this.Update_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Update_DGV.HeaderText = "";
            this.Update_DGV.Image = global::OBE_Desktop.Properties.Resources.update;
            this.Update_DGV.Name = "Update_DGV";
            this.Update_DGV.ReadOnly = true;
            this.Update_DGV.Width = 11;
            // 
            // Delete_DGV
            // 
            this.Delete_DGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Delete_DGV.HeaderText = "";
            this.Delete_DGV.Image = global::OBE_Desktop.Properties.Resources.delete;
            this.Delete_DGV.Name = "Delete_DGV";
            this.Delete_DGV.ReadOnly = true;
            this.Delete_DGV.Width = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bunifuCustomLabel16);
            this.panel1.Controls.Add(this.RefreshDataGrid_Btn);
            this.panel1.Controls.Add(this.TotalWeight_Lbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addActivityWeight_Btn);
            this.panel1.Controls.Add(this.bunifuCustomLabel9);
            this.panel1.Controls.Add(this.totalWarningLbl);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 139);
            this.panel1.TabIndex = 254;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(551, 85);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(58, 17);
            this.bunifuCustomLabel16.TabIndex = 394;
            this.bunifuCustomLabel16.Text = "Refresh";
            // 
            // RefreshDataGrid_Btn
            // 
            this.RefreshDataGrid_Btn.Image = global::OBE_Desktop.Properties.Resources.RefreshIcon;
            this.RefreshDataGrid_Btn.Location = new System.Drawing.Point(564, 103);
            this.RefreshDataGrid_Btn.Name = "RefreshDataGrid_Btn";
            this.RefreshDataGrid_Btn.Size = new System.Drawing.Size(32, 23);
            this.RefreshDataGrid_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshDataGrid_Btn.TabIndex = 393;
            this.RefreshDataGrid_Btn.TabStop = false;
            this.RefreshDataGrid_Btn.Click += new System.EventHandler(this.RefreshDataGrid_Btn_Click);
            // 
            // TotalWeight_Lbl
            // 
            this.TotalWeight_Lbl.AutoSize = true;
            this.TotalWeight_Lbl.BackColor = System.Drawing.Color.Yellow;
            this.TotalWeight_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalWeight_Lbl.Location = new System.Drawing.Point(509, 105);
            this.TotalWeight_Lbl.Name = "TotalWeight_Lbl";
            this.TotalWeight_Lbl.Size = new System.Drawing.Size(41, 21);
            this.TotalWeight_Lbl.TabIndex = 253;
            this.TotalWeight_Lbl.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 253;
            this.label1.Text = "Total Weight :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ActivityWeightDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(621, 288);
            this.panel2.TabIndex = 254;
            // 
            // GPAWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GPAWeight";
            this.Text = "GPAWeight";
            this.Load += new System.EventHandler(this.GPAWeight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivityWeightDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshDataGrid_Btn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button addActivityWeight_Btn;
        private System.Windows.Forms.Label totalWarningLbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ActivityWeightDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalWeight_Lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private System.Windows.Forms.PictureBox RefreshDataGrid_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNoDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn WA_Code;
        private System.Windows.Forms.DataGridViewImageColumn View_DGV;
        private System.Windows.Forms.DataGridViewImageColumn Update_DGV;
        private System.Windows.Forms.DataGridViewImageColumn Delete_DGV;
    }
}