namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.PLOs
{
    partial class PLOList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLOList));
            this.PLODataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLO_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WA_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PEO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KnowledgeProfiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PLODataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PLODataGrid
            // 
            this.PLODataGrid.AllowUserToAddRows = false;
            this.PLODataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PLODataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PLODataGrid.BackgroundColor = System.Drawing.Color.White;
            this.PLODataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PLODataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.PLODataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PLODataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PLODataGrid.ColumnHeadersHeight = 40;
            this.PLODataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.login_username,
            this.PLO_Name,
            this.WA_Code,
            this.user_firstname,
            this.user_lastname,
            this.PEO,
            this.KnowledgeProfiles,
            this.user_isActive});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PLODataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.PLODataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PLODataGrid.DoubleBuffered = true;
            this.PLODataGrid.EnableHeadersVisualStyles = false;
            this.PLODataGrid.GridColor = System.Drawing.Color.White;
            this.PLODataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.PLODataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.PLODataGrid.Location = new System.Drawing.Point(0, 0);
            this.PLODataGrid.Name = "PLODataGrid";
            this.PLODataGrid.ReadOnly = true;
            this.PLODataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PLODataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.PLODataGrid.RowHeadersVisible = false;
            this.PLODataGrid.RowHeadersWidth = 50;
            this.PLODataGrid.RowTemplate.Height = 25;
            this.PLODataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PLODataGrid.Size = new System.Drawing.Size(1033, 452);
            this.PLODataGrid.TabIndex = 8;
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
            // login_username
            // 
            this.login_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.login_username.DataPropertyName = "Code";
            this.login_username.HeaderText = "Code";
            this.login_username.Name = "login_username";
            this.login_username.ReadOnly = true;
            // 
            // PLO_Name
            // 
            this.PLO_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PLO_Name.DataPropertyName = "Name";
            this.PLO_Name.HeaderText = "Name";
            this.PLO_Name.Name = "PLO_Name";
            this.PLO_Name.ReadOnly = true;
            // 
            // WA_Code
            // 
            this.WA_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WA_Code.DataPropertyName = "WACode";
            this.WA_Code.HeaderText = "WA Code";
            this.WA_Code.Name = "WA_Code";
            this.WA_Code.ReadOnly = true;
            // 
            // user_firstname
            // 
            this.user_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_firstname.DataPropertyName = "Description";
            this.user_firstname.HeaderText = "Description";
            this.user_firstname.Name = "user_firstname";
            this.user_firstname.ReadOnly = true;
            // 
            // user_lastname
            // 
            this.user_lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_lastname.DataPropertyName = "BatchId";
            this.user_lastname.HeaderText = "Program Batch";
            this.user_lastname.Name = "user_lastname";
            this.user_lastname.ReadOnly = true;
            // 
            // PEO
            // 
            this.PEO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PEO.DataPropertyName = "PEOId";
            this.PEO.HeaderText = "PEO";
            this.PEO.Name = "PEO";
            this.PEO.ReadOnly = true;
            // 
            // KnowledgeProfiles
            // 
            this.KnowledgeProfiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KnowledgeProfiles.DataPropertyName = "KnowledgeProfileId";
            this.KnowledgeProfiles.HeaderText = "Knowledge Profiles";
            this.KnowledgeProfiles.Name = "KnowledgeProfiles";
            this.KnowledgeProfiles.ReadOnly = true;
            // 
            // user_isActive
            // 
            this.user_isActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_isActive.DataPropertyName = "isActive";
            this.user_isActive.HeaderText = "Active";
            this.user_isActive.Name = "user_isActive";
            this.user_isActive.ReadOnly = true;
            this.user_isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.user_isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PLOList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1033, 452);
            this.Controls.Add(this.PLODataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PLOList";
            this.Text = "PLOList";
            this.Load += new System.EventHandler(this.PLOList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PLODataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid PLODataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLO_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn WA_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PEO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KnowledgeProfiles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn user_isActive;
    }
}