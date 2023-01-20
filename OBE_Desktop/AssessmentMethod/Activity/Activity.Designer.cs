namespace OBE_Desktop.AssessmentMethod.Activity
{
    partial class Activity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activity));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.Activity_TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ShortName_errorLbl = new System.Windows.Forms.Label();
            this.Name_errorLbl = new System.Windows.Forms.Label();
            this.ShortName_errorFlag = new System.Windows.Forms.Label();
            this.Name_errorFlag = new System.Windows.Forms.Label();
            this.CreateActivity_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ManageActivitites_Btn = new System.Windows.Forms.Button();
            this.Name_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.ShortName_TB = new System.Windows.Forms.TextBox();
            this.MaxMrks_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ActivityDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.SrNo_DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete_DGV = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel27 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel25 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FilterShortName_TB = new System.Windows.Forms.TextBox();
            this.FilterName_TB = new System.Windows.Forms.TextBox();
            this.BackgroundPanel.SuspendLayout();
            this.Activity_TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.White;
            this.BackgroundPanel.Controls.Add(this.Activity_TabControl);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(713, 464);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // Activity_TabControl
            // 
            this.Activity_TabControl.Controls.Add(this.tabPage1);
            this.Activity_TabControl.Controls.Add(this.tabPage2);
            this.Activity_TabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Activity_TabControl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_TabControl.Location = new System.Drawing.Point(0, 0);
            this.Activity_TabControl.Name = "Activity_TabControl";
            this.Activity_TabControl.SelectedIndex = 0;
            this.Activity_TabControl.Size = new System.Drawing.Size(704, 464);
            this.Activity_TabControl.TabIndex = 0;
            this.Activity_TabControl.SelectedIndexChanged += new System.EventHandler(this.Activity_TabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ShortName_errorLbl);
            this.tabPage1.Controls.Add(this.Name_errorLbl);
            this.tabPage1.Controls.Add(this.ShortName_errorFlag);
            this.tabPage1.Controls.Add(this.Name_errorFlag);
            this.tabPage1.Controls.Add(this.CreateActivity_Btn);
            this.tabPage1.Controls.Add(this.bunifuCustomLabel2);
            this.tabPage1.Controls.Add(this.bunifuSeparator2);
            this.tabPage1.Controls.Add(this.ManageActivitites_Btn);
            this.tabPage1.Controls.Add(this.Name_Lbl);
            this.tabPage1.Controls.Add(this.Name_TB);
            this.tabPage1.Controls.Add(this.ShortName_TB);
            this.tabPage1.Controls.Add(this.MaxMrks_Lbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ShortName_errorLbl
            // 
            this.ShortName_errorLbl.AutoSize = true;
            this.ShortName_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortName_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.ShortName_errorLbl.Location = new System.Drawing.Point(439, 173);
            this.ShortName_errorLbl.Name = "ShortName_errorLbl";
            this.ShortName_errorLbl.Size = new System.Drawing.Size(121, 15);
            this.ShortName_errorLbl.TabIndex = 219;
            this.ShortName_errorLbl.Text = "Short Name is required.";
            // 
            // Name_errorLbl
            // 
            this.Name_errorLbl.AutoSize = true;
            this.Name_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Name_errorLbl.Location = new System.Drawing.Point(76, 173);
            this.Name_errorLbl.Name = "Name_errorLbl";
            this.Name_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.Name_errorLbl.TabIndex = 219;
            this.Name_errorLbl.Text = "Name is required.";
            // 
            // ShortName_errorFlag
            // 
            this.ShortName_errorFlag.AutoSize = true;
            this.ShortName_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShortName_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.ShortName_errorFlag.Location = new System.Drawing.Point(513, 111);
            this.ShortName_errorFlag.Name = "ShortName_errorFlag";
            this.ShortName_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.ShortName_errorFlag.TabIndex = 218;
            this.ShortName_errorFlag.Text = "*";
            // 
            // Name_errorFlag
            // 
            this.Name_errorFlag.AutoSize = true;
            this.Name_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Name_errorFlag.Location = new System.Drawing.Point(121, 114);
            this.Name_errorFlag.Name = "Name_errorFlag";
            this.Name_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Name_errorFlag.TabIndex = 218;
            this.Name_errorFlag.Text = "*";
            // 
            // CreateActivity_Btn
            // 
            this.CreateActivity_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.CreateActivity_Btn.FlatAppearance.BorderSize = 0;
            this.CreateActivity_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateActivity_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateActivity_Btn.ForeColor = System.Drawing.Color.White;
            this.CreateActivity_Btn.Location = new System.Drawing.Point(79, 215);
            this.CreateActivity_Btn.Name = "CreateActivity_Btn";
            this.CreateActivity_Btn.Size = new System.Drawing.Size(106, 30);
            this.CreateActivity_Btn.TabIndex = 215;
            this.CreateActivity_Btn.Text = "Create Activity";
            this.CreateActivity_Btn.UseVisualStyleBackColor = false;
            this.CreateActivity_Btn.Click += new System.EventHandler(this.CreateActivity_Btn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(75, 66);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(66, 21);
            this.bunifuCustomLabel2.TabIndex = 214;
            this.bunifuCustomLabel2.Text = "Activity";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 65535;
            this.bunifuSeparator2.Location = new System.Drawing.Point(76, 71);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(70, 21);
            this.bunifuSeparator2.TabIndex = 213;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ManageActivitites_Btn
            // 
            this.ManageActivitites_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ManageActivitites_Btn.FlatAppearance.BorderSize = 0;
            this.ManageActivitites_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageActivitites_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageActivitites_Btn.ForeColor = System.Drawing.Color.White;
            this.ManageActivitites_Btn.Location = new System.Drawing.Point(213, 215);
            this.ManageActivitites_Btn.Name = "ManageActivitites_Btn";
            this.ManageActivitites_Btn.Size = new System.Drawing.Size(114, 30);
            this.ManageActivitites_Btn.TabIndex = 212;
            this.ManageActivitites_Btn.Text = "Manage Activities";
            this.ManageActivitites_Btn.UseVisualStyleBackColor = false;
            this.ManageActivitites_Btn.Click += new System.EventHandler(this.ManageActivitites_Btn_Click);
            // 
            // Name_Lbl
            // 
            this.Name_Lbl.AutoSize = true;
            this.Name_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Lbl.Location = new System.Drawing.Point(76, 118);
            this.Name_Lbl.Name = "Name_Lbl";
            this.Name_Lbl.Size = new System.Drawing.Size(46, 17);
            this.Name_Lbl.TabIndex = 203;
            this.Name_Lbl.Text = "Name";
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.SystemColors.Control;
            this.Name_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.Name_TB.Location = new System.Drawing.Point(79, 139);
            this.Name_TB.Multiline = true;
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(296, 31);
            this.Name_TB.TabIndex = 207;
            this.Name_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // ShortName_TB
            // 
            this.ShortName_TB.BackColor = System.Drawing.SystemColors.Control;
            this.ShortName_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F);
            this.ShortName_TB.Location = new System.Drawing.Point(437, 139);
            this.ShortName_TB.Multiline = true;
            this.ShortName_TB.Name = "ShortName_TB";
            this.ShortName_TB.Size = new System.Drawing.Size(123, 31);
            this.ShortName_TB.TabIndex = 208;
            this.ShortName_TB.TextChanged += new System.EventHandler(this.ShortName_TB_TextChanged);
            // 
            // MaxMrks_Lbl
            // 
            this.MaxMrks_Lbl.AutoSize = true;
            this.MaxMrks_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxMrks_Lbl.Location = new System.Drawing.Point(434, 118);
            this.MaxMrks_Lbl.Name = "MaxMrks_Lbl";
            this.MaxMrks_Lbl.Size = new System.Drawing.Size(84, 17);
            this.MaxMrks_Lbl.TabIndex = 205;
            this.MaxMrks_Lbl.Text = "Short Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Activities";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ActivityDataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 378);
            this.panel1.TabIndex = 10;
            // 
            // ActivityDataGrid
            // 
            this.ActivityDataGrid.AllowUserToAddRows = false;
            this.ActivityDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ActivityDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ActivityDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ActivityDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActivityDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.ActivityDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivityDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ActivityDataGrid.ColumnHeadersHeight = 50;
            this.ActivityDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo_DGV,
            this.SerialNumber,
            this.login_username,
            this.user_firstname,
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
            this.ActivityDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ActivityDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActivityDataGrid.DoubleBuffered = true;
            this.ActivityDataGrid.EnableHeadersVisualStyles = false;
            this.ActivityDataGrid.GridColor = System.Drawing.Color.White;
            this.ActivityDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ActivityDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ActivityDataGrid.Location = new System.Drawing.Point(0, 0);
            this.ActivityDataGrid.Name = "ActivityDataGrid";
            this.ActivityDataGrid.ReadOnly = true;
            this.ActivityDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivityDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ActivityDataGrid.RowHeadersVisible = false;
            this.ActivityDataGrid.RowHeadersWidth = 50;
            this.ActivityDataGrid.RowTemplate.Height = 25;
            this.ActivityDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActivityDataGrid.Size = new System.Drawing.Size(690, 378);
            this.ActivityDataGrid.TabIndex = 9;
            this.ActivityDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActivityDataGrid_CellContentClick);
            // 
            // SrNo_DGV
            // 
            this.SrNo_DGV.HeaderText = "Sr. No";
            this.SrNo_DGV.Name = "SrNo_DGV";
            this.SrNo_DGV.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SerialNumber.DataPropertyName = "Id";
            this.SerialNumber.HeaderText = "Sr.No";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Visible = false;
            this.SerialNumber.Width = 71;
            // 
            // login_username
            // 
            this.login_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.login_username.DataPropertyName = "Name";
            this.login_username.HeaderText = "Name";
            this.login_username.Name = "login_username";
            this.login_username.ReadOnly = true;
            // 
            // user_firstname
            // 
            this.user_firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.user_firstname.DataPropertyName = "ShortName";
            this.user_firstname.HeaderText = "Short Name";
            this.user_firstname.Name = "user_firstname";
            this.user_firstname.ReadOnly = true;
            this.user_firstname.Width = 99;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuCustomLabel27);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.bunifuCustomLabel14);
            this.panel3.Controls.Add(this.bunifuCustomLabel25);
            this.panel3.Controls.Add(this.FilterShortName_TB);
            this.panel3.Controls.Add(this.FilterName_TB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 50);
            this.panel3.TabIndex = 8;
            // 
            // bunifuCustomLabel27
            // 
            this.bunifuCustomLabel27.AutoSize = true;
            this.bunifuCustomLabel27.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel27.Location = new System.Drawing.Point(11, 16);
            this.bunifuCustomLabel27.Name = "bunifuCustomLabel27";
            this.bunifuCustomLabel27.Size = new System.Drawing.Size(106, 21);
            this.bunifuCustomLabel27.TabIndex = 55;
            this.bunifuCustomLabel27.Text = "Apply Filters";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OBE_Desktop.Properties.Resources.view;
            this.pictureBox1.Location = new System.Drawing.Point(120, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 21);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(371, 16);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(84, 17);
            this.bunifuCustomLabel14.TabIndex = 19;
            this.bunifuCustomLabel14.Text = "Short Name";
            // 
            // bunifuCustomLabel25
            // 
            this.bunifuCustomLabel25.AutoSize = true;
            this.bunifuCustomLabel25.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel25.Location = new System.Drawing.Point(144, 19);
            this.bunifuCustomLabel25.Name = "bunifuCustomLabel25";
            this.bunifuCustomLabel25.Size = new System.Drawing.Size(46, 17);
            this.bunifuCustomLabel25.TabIndex = 17;
            this.bunifuCustomLabel25.Text = "Name";
            // 
            // FilterShortName_TB
            // 
            this.FilterShortName_TB.Location = new System.Drawing.Point(461, 9);
            this.FilterShortName_TB.Multiline = true;
            this.FilterShortName_TB.Name = "FilterShortName_TB";
            this.FilterShortName_TB.Size = new System.Drawing.Size(68, 29);
            this.FilterShortName_TB.TabIndex = 16;
            // 
            // FilterName_TB
            // 
            this.FilterName_TB.Location = new System.Drawing.Point(199, 12);
            this.FilterName_TB.Multiline = true;
            this.FilterName_TB.Name = "FilterName_TB";
            this.FilterName_TB.Size = new System.Drawing.Size(163, 29);
            this.FilterName_TB.TabIndex = 16;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 464);
            this.Controls.Add(this.BackgroundPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Activity";
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.Activity_TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.TabControl Activity_TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCustomLabel Name_Lbl;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox ShortName_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel MaxMrks_Lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Button ManageActivitites_Btn;
        private System.Windows.Forms.Button CreateActivity_Btn;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel27;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel25;
        private System.Windows.Forms.TextBox FilterName_TB;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ActivityDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FilterShortName_TB;
        private System.Windows.Forms.Label Name_errorLbl;
        private System.Windows.Forms.Label Name_errorFlag;
        private System.Windows.Forms.Label ShortName_errorLbl;
        private System.Windows.Forms.Label ShortName_errorFlag;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo_DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn login_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_firstname;
        private System.Windows.Forms.DataGridViewImageColumn View_DGV;
        private System.Windows.Forms.DataGridViewImageColumn Update_DGV;
        private System.Windows.Forms.DataGridViewImageColumn Delete_DGV;
    }
}