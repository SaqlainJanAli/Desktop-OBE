namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Activity_Weights
{
    partial class UpdateClassActivityWeight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClassActivityWeight));
            this.updateActivity_Btn = new System.Windows.Forms.Button();
            this.Weight_NUD = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.weight_errorLbl = new System.Windows.Forms.Label();
            this.Activity_errorLbl = new System.Windows.Forms.Label();
            this.weight_errorFlag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Activity_errorFlag = new System.Windows.Forms.Label();
            this.Activity_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Id_TB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // updateActivity_Btn
            // 
            this.updateActivity_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.updateActivity_Btn.FlatAppearance.BorderSize = 0;
            this.updateActivity_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateActivity_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateActivity_Btn.ForeColor = System.Drawing.Color.White;
            this.updateActivity_Btn.Location = new System.Drawing.Point(32, 191);
            this.updateActivity_Btn.Name = "updateActivity_Btn";
            this.updateActivity_Btn.Size = new System.Drawing.Size(84, 30);
            this.updateActivity_Btn.TabIndex = 278;
            this.updateActivity_Btn.Text = "Update";
            this.updateActivity_Btn.UseVisualStyleBackColor = false;
            this.updateActivity_Btn.Click += new System.EventHandler(this.updateActivity_Btn_Click);
            // 
            // Weight_NUD
            // 
            this.Weight_NUD.DecimalPlaces = 2;
            this.Weight_NUD.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight_NUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Weight_NUD.Location = new System.Drawing.Point(287, 120);
            this.Weight_NUD.Name = "Weight_NUD";
            this.Weight_NUD.Size = new System.Drawing.Size(222, 26);
            this.Weight_NUD.TabIndex = 277;
            this.Weight_NUD.ValueChanged += new System.EventHandler(this.Weight_NUD_ValueChanged);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(284, 96);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(55, 21);
            this.bunifuCustomLabel10.TabIndex = 276;
            this.bunifuCustomLabel10.Text = "Weight";
            // 
            // weight_errorLbl
            // 
            this.weight_errorLbl.AutoSize = true;
            this.weight_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.weight_errorLbl.Location = new System.Drawing.Point(284, 149);
            this.weight_errorLbl.Name = "weight_errorLbl";
            this.weight_errorLbl.Size = new System.Drawing.Size(131, 15);
            this.weight_errorLbl.TabIndex = 274;
            this.weight_errorLbl.Text = "Weight should not be zero";
            // 
            // Activity_errorLbl
            // 
            this.Activity_errorLbl.AutoSize = true;
            this.Activity_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Activity_errorLbl.Location = new System.Drawing.Point(33, 149);
            this.Activity_errorLbl.Name = "Activity_errorLbl";
            this.Activity_errorLbl.Size = new System.Drawing.Size(98, 15);
            this.Activity_errorLbl.TabIndex = 275;
            this.Activity_errorLbl.Text = "Activity is required.";
            // 
            // weight_errorFlag
            // 
            this.weight_errorFlag.AutoSize = true;
            this.weight_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.weight_errorFlag.Location = new System.Drawing.Point(334, 90);
            this.weight_errorFlag.Name = "weight_errorFlag";
            this.weight_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.weight_errorFlag.TabIndex = 271;
            this.weight_errorFlag.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(128, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 272;
            this.label1.Text = "*";
            // 
            // Activity_errorFlag
            // 
            this.Activity_errorFlag.AutoSize = true;
            this.Activity_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Activity_errorFlag.Location = new System.Drawing.Point(80, 95);
            this.Activity_errorFlag.Name = "Activity_errorFlag";
            this.Activity_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Activity_errorFlag.TabIndex = 273;
            this.Activity_errorFlag.Text = "*";
            // 
            // Activity_CB
            // 
            this.Activity_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Activity_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity_CB.FormattingEnabled = true;
            this.Activity_CB.IntegralHeight = false;
            this.Activity_CB.Location = new System.Drawing.Point(32, 120);
            this.Activity_CB.Name = "Activity_CB";
            this.Activity_CB.Size = new System.Drawing.Size(226, 29);
            this.Activity_CB.TabIndex = 270;
            this.Activity_CB.SelectedIndexChanged += new System.EventHandler(this.Activity_CB_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(29, 100);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel1.TabIndex = 269;
            this.bunifuCustomLabel1.Text = "Activity";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(29, 71);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(185, 16);
            this.bunifuCustomLabel3.TabIndex = 268;
            this.bunifuCustomLabel3.Text = "Fields marked with       are required";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(29, 37);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(229, 21);
            this.bunifuCustomLabel9.TabIndex = 267;
            this.bunifuCustomLabel9.Text = "Update Class Activity Weight";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator1.LineThickness = 65535;
            this.bunifuSeparator1.Location = new System.Drawing.Point(27, 35);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(507, 26);
            this.bunifuSeparator1.TabIndex = 266;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Enabled = false;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(284, 175);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(68, 17);
            this.bunifuCustomLabel2.TabIndex = 269;
            this.bunifuCustomLabel2.Text = "Weight Id";
            this.bunifuCustomLabel2.Visible = false;
            // 
            // Id_TB
            // 
            this.Id_TB.Enabled = false;
            this.Id_TB.Location = new System.Drawing.Point(287, 195);
            this.Id_TB.Multiline = true;
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.Size = new System.Drawing.Size(100, 26);
            this.Id_TB.TabIndex = 279;
            this.Id_TB.Visible = false;
            // 
            // UpdateClassActivityWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 255);
            this.Controls.Add(this.Id_TB);
            this.Controls.Add(this.updateActivity_Btn);
            this.Controls.Add(this.Weight_NUD);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Controls.Add(this.weight_errorLbl);
            this.Controls.Add(this.Activity_errorLbl);
            this.Controls.Add(this.weight_errorFlag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Activity_errorFlag);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Activity_CB);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.bunifuSeparator1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateClassActivityWeight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateClassActivityWeight";
            this.Load += new System.EventHandler(this.UpdateClassActivityWeight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Weight_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateActivity_Btn;
        private System.Windows.Forms.NumericUpDown Weight_NUD;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Label weight_errorLbl;
        private System.Windows.Forms.Label Activity_errorLbl;
        private System.Windows.Forms.Label weight_errorFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Activity_errorFlag;
        private System.Windows.Forms.ComboBox Activity_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox Id_TB;
    }
}