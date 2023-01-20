namespace OBE_Desktop
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginScreenMainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.Password_errorLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Email_errorLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ForgotPassword_Link = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ForgotPassword_Label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Close_Icon = new System.Windows.Forms.PictureBox();
            this.Loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UserName_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.copyright_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginScreenMainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Icon)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginScreenMainPanel
            // 
            this.loginScreenMainPanel.Controls.Add(this.rightPanel);
            this.loginScreenMainPanel.Controls.Add(this.leftPanel);
            this.loginScreenMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginScreenMainPanel.Location = new System.Drawing.Point(0, 0);
            this.loginScreenMainPanel.Name = "loginScreenMainPanel";
            this.loginScreenMainPanel.Size = new System.Drawing.Size(834, 521);
            this.loginScreenMainPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.rightPanel.Controls.Add(this.Password_errorLbl);
            this.rightPanel.Controls.Add(this.Email_errorLbl);
            this.rightPanel.Controls.Add(this.ForgotPassword_Link);
            this.rightPanel.Controls.Add(this.ForgotPassword_Label);
            this.rightPanel.Controls.Add(this.Password_TB);
            this.rightPanel.Controls.Add(this.Close_Icon);
            this.rightPanel.Controls.Add(this.Loginbtn);
            this.rightPanel.Controls.Add(this.UserName_TB);
            this.rightPanel.Controls.Add(this.bunifuCustomLabel2);
            this.rightPanel.Controls.Add(this.bunifuCustomLabel1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightPanel.ForeColor = System.Drawing.Color.White;
            this.rightPanel.Location = new System.Drawing.Point(417, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(417, 521);
            this.rightPanel.TabIndex = 1;
            // 
            // Password_errorLbl
            // 
            this.Password_errorLbl.AutoSize = true;
            this.Password_errorLbl.BackColor = System.Drawing.Color.Red;
            this.Password_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.Password_errorLbl.Location = new System.Drawing.Point(26, 314);
            this.Password_errorLbl.Name = "Password_errorLbl";
            this.Password_errorLbl.Size = new System.Drawing.Size(150, 15);
            this.Password_errorLbl.TabIndex = 12;
            this.Password_errorLbl.Text = "Please enter a valid password";
            this.Password_errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Email_errorLbl
            // 
            this.Email_errorLbl.AutoSize = true;
            this.Email_errorLbl.BackColor = System.Drawing.Color.Red;
            this.Email_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.Email_errorLbl.Location = new System.Drawing.Point(25, 249);
            this.Email_errorLbl.Name = "Email_errorLbl";
            this.Email_errorLbl.Size = new System.Drawing.Size(173, 15);
            this.Email_errorLbl.TabIndex = 11;
            this.Email_errorLbl.Text = "Please enter a valid email address\r\n";
            this.Email_errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ForgotPassword_Link
            // 
            this.ForgotPassword_Link.AutoSize = true;
            this.ForgotPassword_Link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPassword_Link.Font = new System.Drawing.Font("Franklin Gothic Book", 10F, System.Drawing.FontStyle.Underline);
            this.ForgotPassword_Link.Location = new System.Drawing.Point(81, 429);
            this.ForgotPassword_Link.Name = "ForgotPassword_Link";
            this.ForgotPassword_Link.Size = new System.Drawing.Size(276, 18);
            this.ForgotPassword_Link.TabIndex = 10;
            this.ForgotPassword_Link.Text = "no worries, click here to reset your password\r\n";
            this.ForgotPassword_Link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForgotPassword_Link.Click += new System.EventHandler(this.onForgotPasswordTextClick);
            this.ForgotPassword_Link.MouseHover += new System.EventHandler(this.ForgotPassword_MouseHover);
            // 
            // ForgotPassword_Label
            // 
            this.ForgotPassword_Label.AutoSize = true;
            this.ForgotPassword_Label.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword_Label.Location = new System.Drawing.Point(137, 403);
            this.ForgotPassword_Label.Name = "ForgotPassword_Label";
            this.ForgotPassword_Label.Size = new System.Drawing.Size(149, 21);
            this.ForgotPassword_Label.TabIndex = 9;
            this.ForgotPassword_Label.Text = "Forgot Password ?";
            this.ForgotPassword_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_TB
            // 
            this.Password_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Password_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Password_TB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Password_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_TB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TB.ForeColor = System.Drawing.Color.White;
            this.Password_TB.HintForeColor = System.Drawing.Color.LightGray;
            this.Password_TB.HintText = "";
            this.Password_TB.isPassword = true;
            this.Password_TB.LineFocusedColor = System.Drawing.Color.Lavender;
            this.Password_TB.LineIdleColor = System.Drawing.Color.White;
            this.Password_TB.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.Password_TB.LineThickness = 2;
            this.Password_TB.Location = new System.Drawing.Point(26, 263);
            this.Password_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Password_TB.MaxLength = 32767;
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(370, 46);
            this.Password_TB.TabIndex = 8;
            this.Password_TB.Text = "Password";
            this.Password_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password_TB.OnValueChanged += new System.EventHandler(this.Password_TB_OnValueChanged);
            this.Password_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onEnterKey);
            this.Password_TB.MouseEnter += new System.EventHandler(this.onHover);
            // 
            // Close_Icon
            // 
            this.Close_Icon.BackColor = System.Drawing.Color.Transparent;
            this.Close_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Icon.Image = global::OBE_Desktop.Properties.Resources.IconCloseRed;
            this.Close_Icon.Location = new System.Drawing.Point(379, 12);
            this.Close_Icon.Name = "Close_Icon";
            this.Close_Icon.Size = new System.Drawing.Size(26, 26);
            this.Close_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_Icon.TabIndex = 7;
            this.Close_Icon.TabStop = false;
            this.Close_Icon.Click += new System.EventHandler(this.onCloseIconClick);
            // 
            // Loginbtn
            // 
            this.Loginbtn.ActiveBorderThickness = 1;
            this.Loginbtn.ActiveCornerRadius = 20;
            this.Loginbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Loginbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.Loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loginbtn.BackgroundImage")));
            this.Loginbtn.ButtonText = "LOGIN";
            this.Loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Loginbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.Loginbtn.IdleBorderThickness = 1;
            this.Loginbtn.IdleCornerRadius = 20;
            this.Loginbtn.IdleFillColor = System.Drawing.Color.White;
            this.Loginbtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.Loginbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.Loginbtn.Location = new System.Drawing.Point(23, 333);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(377, 51);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // UserName_TB
            // 
            this.UserName_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserName_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserName_TB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserName_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName_TB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_TB.ForeColor = System.Drawing.Color.White;
            this.UserName_TB.HintForeColor = System.Drawing.Color.LightGray;
            this.UserName_TB.HintText = "Your Email Address";
            this.UserName_TB.isPassword = false;
            this.UserName_TB.LineFocusedColor = System.Drawing.Color.Lavender;
            this.UserName_TB.LineIdleColor = System.Drawing.Color.White;
            this.UserName_TB.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.UserName_TB.LineThickness = 2;
            this.UserName_TB.Location = new System.Drawing.Point(26, 199);
            this.UserName_TB.Margin = new System.Windows.Forms.Padding(4);
            this.UserName_TB.MaxLength = 32767;
            this.UserName_TB.Name = "UserName_TB";
            this.UserName_TB.Size = new System.Drawing.Size(370, 46);
            this.UserName_TB.TabIndex = 2;
            this.UserName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName_TB.OnValueChanged += new System.EventHandler(this.UserName_TB_OnValueChanged);
            this.UserName_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onEnterKey);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(99, 152);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(213, 21);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Please use your email address\r\n";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(79, 97);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(264, 34);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Faculty / Staff Login";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.copyright_Lbl);
            this.leftPanel.Controls.Add(this.bunifuCustomLabel6);
            this.leftPanel.Controls.Add(this.bunifuCustomLabel5);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(417, 521);
            this.leftPanel.TabIndex = 0;
            // 
            // copyright_Lbl
            // 
            this.copyright_Lbl.AutoSize = true;
            this.copyright_Lbl.Enabled = false;
            this.copyright_Lbl.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.copyright_Lbl.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.copyright_Lbl.Location = new System.Drawing.Point(76, 487);
            this.copyright_Lbl.Name = "copyright_Lbl";
            this.copyright_Lbl.Size = new System.Drawing.Size(266, 15);
            this.copyright_Lbl.TabIndex = 8;
            this.copyright_Lbl.Text = "All Rights Reserved 2020 © D-OBE Development Team";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(35, 97);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(343, 51);
            this.bunifuCustomLabel6.TabIndex = 8;
            this.bunifuCustomLabel6.Text = "D-OBE is desktop based Information system which facilitates \r\nInstitutes to manag" +
    "e quality of education using Outcome \r\nBased Education (OBE) Methodology.";
            this.bunifuCustomLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(103, 43);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(192, 42);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "DESKTOP OBE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::OBE_Desktop.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(25, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 311);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(this.loginScreenMainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.onLoginLoad);
            this.loginScreenMainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Icon)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginScreenMainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserName_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 Loginbtn;
        private System.Windows.Forms.PictureBox Close_Icon;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel copyright_Lbl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel ForgotPassword_Link;
        private Bunifu.Framework.UI.BunifuCustomLabel ForgotPassword_Label;
        private Bunifu.Framework.UI.BunifuCustomLabel Password_errorLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel Email_errorLbl;
    }
}

