namespace OBE_Desktop.Admin_Section.RolesUI
{
    partial class UpdateRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRole));
            this.Type_CB = new System.Windows.Forms.ComboBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Type_errorLbl = new System.Windows.Forms.Label();
            this.Name_errorLbl = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Type_errorFlag = new System.Windows.Forms.Label();
            this.Name_errorFlag = new System.Windows.Forms.Label();
            this.UpdateRole_Btn = new System.Windows.Forms.Button();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.RoleID_TB = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // Type_CB
            // 
            this.Type_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_CB.FormattingEnabled = true;
            this.Type_CB.IntegralHeight = false;
            this.Type_CB.Items.AddRange(new object[] {
            "Application",
            "University"});
            this.Type_CB.Location = new System.Drawing.Point(130, 290);
            this.Type_CB.Name = "Type_CB";
            this.Type_CB.Size = new System.Drawing.Size(296, 29);
            this.Type_CB.TabIndex = 16;
            this.Type_CB.SelectedIndexChanged += new System.EventHandler(this.Type_CB_SelectedIndexChanged);
            // 
            // Name_TB
            // 
            this.Name_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_TB.Location = new System.Drawing.Point(130, 193);
            this.Name_TB.Multiline = true;
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(296, 29);
            this.Name_TB.TabIndex = 17;
            this.Name_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // Type_errorLbl
            // 
            this.Type_errorLbl.AutoSize = true;
            this.Type_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Type_errorLbl.Location = new System.Drawing.Point(129, 317);
            this.Type_errorLbl.Name = "Type_errorLbl";
            this.Type_errorLbl.Size = new System.Drawing.Size(87, 15);
            this.Type_errorLbl.TabIndex = 19;
            this.Type_errorLbl.Text = "Type is required.";
            // 
            // Name_errorLbl
            // 
            this.Name_errorLbl.AutoSize = true;
            this.Name_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorLbl.ForeColor = System.Drawing.Color.Red;
            this.Name_errorLbl.Location = new System.Drawing.Point(129, 222);
            this.Name_errorLbl.Name = "Name_errorLbl";
            this.Name_errorLbl.Size = new System.Drawing.Size(93, 15);
            this.Name_errorLbl.TabIndex = 18;
            this.Name_errorLbl.Text = "Name is required.";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(57, 294);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(42, 21);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Type";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(-34, 180);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Name";
            // 
            // Type_errorFlag
            // 
            this.Type_errorFlag.AutoSize = true;
            this.Type_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Type_errorFlag.Location = new System.Drawing.Point(107, 277);
            this.Type_errorFlag.Name = "Type_errorFlag";
            this.Type_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Type_errorFlag.TabIndex = 15;
            this.Type_errorFlag.Text = "*";
            // 
            // Name_errorFlag
            // 
            this.Name_errorFlag.AutoSize = true;
            this.Name_errorFlag.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_errorFlag.ForeColor = System.Drawing.Color.Red;
            this.Name_errorFlag.Location = new System.Drawing.Point(103, 188);
            this.Name_errorFlag.Name = "Name_errorFlag";
            this.Name_errorFlag.Size = new System.Drawing.Size(20, 21);
            this.Name_errorFlag.TabIndex = 14;
            this.Name_errorFlag.Text = "*";
            // 
            // UpdateRole_Btn
            // 
            this.UpdateRole_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.UpdateRole_Btn.FlatAppearance.BorderSize = 0;
            this.UpdateRole_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateRole_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRole_Btn.ForeColor = System.Drawing.Color.White;
            this.UpdateRole_Btn.Location = new System.Drawing.Point(132, 382);
            this.UpdateRole_Btn.Name = "UpdateRole_Btn";
            this.UpdateRole_Btn.Size = new System.Drawing.Size(294, 34);
            this.UpdateRole_Btn.TabIndex = 13;
            this.UpdateRole_Btn.Text = "Update";
            this.UpdateRole_Btn.UseVisualStyleBackColor = false;
            this.UpdateRole_Btn.Click += new System.EventHandler(this.UpdateRole_Btn_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(57, 197);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(50, 21);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Name";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(57, 106);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(23, 21);
            this.bunifuCustomLabel4.TabIndex = 12;
            this.bunifuCustomLabel4.Text = "Id";
            // 
            // RoleID_TB
            // 
            this.RoleID_TB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleID_TB.Location = new System.Drawing.Point(130, 102);
            this.RoleID_TB.Multiline = true;
            this.RoleID_TB.Name = "RoleID_TB";
            this.RoleID_TB.Size = new System.Drawing.Size(296, 29);
            this.RoleID_TB.TabIndex = 17;
            this.RoleID_TB.TextChanged += new System.EventHandler(this.Name_TB_TextChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Blue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(190, 40);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(135, 28);
            this.bunifuCustomLabel5.TabIndex = 12;
            this.bunifuCustomLabel5.Text = "Update Role";
            // 
            // UpdateRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(539, 468);
            this.Controls.Add(this.Type_CB);
            this.Controls.Add(this.RoleID_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Type_errorLbl);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.Name_errorLbl);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Type_errorFlag);
            this.Controls.Add(this.Name_errorFlag);
            this.Controls.Add(this.UpdateRole_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateRole";
            this.Text = "UpdateRole";
            this.Load += new System.EventHandler(this.UpdateRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Type_CB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Type_errorLbl;
        private System.Windows.Forms.Label Name_errorLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label Type_errorFlag;
        private System.Windows.Forms.Label Name_errorFlag;
        private System.Windows.Forms.Button UpdateRole_Btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox RoleID_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}