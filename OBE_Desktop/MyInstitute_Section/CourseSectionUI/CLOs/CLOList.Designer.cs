namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.CLOs
{
    partial class CLOList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLOList));
            this.CLODataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KnowledgeProfiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CLODataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CLODataGrid
            // 
            this.CLODataGrid.AllowUserToAddRows = false;
            this.CLODataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CLODataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CLODataGrid.BackgroundColor = System.Drawing.Color.White;
            this.CLODataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CLODataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.CLODataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CLODataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CLODataGrid.ColumnHeadersHeight = 40;
            this.CLODataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.user_lastname,
            this.login_username,
            this.user_firstname,
            this.PEO,
            this.user_isActive,
            this.KnowledgeProfiles});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CLODataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.CLODataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CLODataGrid.DoubleBuffered = true;
            this.CLODataGrid.EnableHeadersVisualStyles = false;
            this.CLODataGrid.GridColor = System.Drawing.Color.White;
            this.CLODataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.CLODataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.CLODataGrid.Location = new System.Drawing.Point(0, 0);
            this.CLODataGrid.Name = "CLODataGrid";
            this.CLODataGrid.ReadOnly = true;
            this.CLODataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CLODataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CLODataGrid.RowHeadersVisible = false;
            this.CLODataGrid.RowHeadersWidth = 50;
            this.CLODataGrid.RowTemplate.Height = 25;
            this.CLODataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CLODataGrid.Size = new System.Drawing.Size(828, 427);
            this.CLODataGrid.TabIndex = 8;
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
            this.SerialNumber.DataPropertyName = "Id";
            this.SerialNumber.HeaderText = "Id";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Visible = false;
            // 
            // user_lastname
            // 
            this.user_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.user_lastname.DataPropertyName = "CourseId";
            this.user_lastname.HeaderText = "Course";
            this.user_lastname.Name = "user_lastname";
            this.user_lastname.ReadOnly = true;
            this.user_lastname.Width = 80;
            // 
            // login_username
            // 
            this.login_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.login_username.DataPropertyName = "Code";
            this.login_username.HeaderText = "Code";
            this.login_username.Name = "login_username";
            this.login_username.ReadOnly = true;
            this.login_username.Width = 70;
            // 
            // user_firstname
            // 
            this.user_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.user_firstname.DataPropertyName = "Description";
            this.user_firstname.HeaderText = "Description";
            this.user_firstname.Name = "user_firstname";
            this.user_firstname.ReadOnly = true;
            this.user_firstname.Width = 103;
            // 
            // PEO
            // 
            this.PEO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PEO.DataPropertyName = "PLOId";
            this.PEO.HeaderText = "PLO";
            this.PEO.Name = "PEO";
            this.PEO.ReadOnly = true;
            this.PEO.Width = 62;
            // 
            // user_isActive
            // 
            this.user_isActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.user_isActive.DataPropertyName = "isActive";
            this.user_isActive.HeaderText = "Active";
            this.user_isActive.Name = "user_isActive";
            this.user_isActive.ReadOnly = true;
            this.user_isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.user_isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.user_isActive.Width = 74;
            // 
            // KnowledgeProfiles
            // 
            this.KnowledgeProfiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KnowledgeProfiles.DataPropertyName = "TypeId";
            this.KnowledgeProfiles.HeaderText = "Type";
            this.KnowledgeProfiles.Name = "KnowledgeProfiles";
            this.KnowledgeProfiles.ReadOnly = true;
            // 
            // CLOList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(828, 427);
            this.Controls.Add(this.CLODataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CLOList";
            this.Text = "CLOList";
            this.Load += new System.EventHandler(this.CLOList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CLODataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid CLODataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn user_isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnowledgeProfiles;
    }
}