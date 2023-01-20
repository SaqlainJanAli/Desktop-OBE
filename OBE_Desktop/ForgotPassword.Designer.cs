namespace OBE_Desktop
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.loginScreenMainPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.Email_errorLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Close_Icon = new System.Windows.Forms.PictureBox();
            this.SendRequest_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Email_TB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginScreenMainPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Icon)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.rightPanel.Controls.Add(this.Email_errorLbl);
            this.rightPanel.Controls.Add(this.Close_Icon);
            this.rightPanel.Controls.Add(this.SendRequest_Btn);
            this.rightPanel.Controls.Add(this.Email_TB);
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
            // Email_errorLbl
            // 
            this.Email_errorLbl.AutoSize = true;
            this.Email_errorLbl.BackColor = System.Drawing.Color.Red;
            this.Email_errorLbl.Font = new System.Drawing.Font("Franklin Gothic Book", 7F);
            this.Email_errorLbl.Location = new System.Drawing.Point(22, 308);
            this.Email_errorLbl.Name = "Email_errorLbl";
            this.Email_errorLbl.Size = new System.Drawing.Size(150, 14);
            this.Email_errorLbl.TabIndex = 12;
            this.Email_errorLbl.Text = "Please enter a valid email address\r\n";
            this.Email_errorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // SendRequest_Btn
            // 
            this.SendRequest_Btn.ActiveBorderThickness = 1;
            this.SendRequest_Btn.ActiveCornerRadius = 20;
            this.SendRequest_Btn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SendRequest_Btn.ActiveForecolor = System.Drawing.Color.White;
            this.SendRequest_Btn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SendRequest_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.SendRequest_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SendRequest_Btn.BackgroundImage")));
            this.SendRequest_Btn.ButtonText = "SEND REQUEST";
            this.SendRequest_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendRequest_Btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendRequest_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.SendRequest_Btn.IdleBorderThickness = 1;
            this.SendRequest_Btn.IdleCornerRadius = 20;
            this.SendRequest_Btn.IdleFillColor = System.Drawing.Color.White;
            this.SendRequest_Btn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.SendRequest_Btn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.SendRequest_Btn.Location = new System.Drawing.Point(18, 329);
            this.SendRequest_Btn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SendRequest_Btn.Name = "SendRequest_Btn";
            this.SendRequest_Btn.Size = new System.Drawing.Size(377, 51);
            this.SendRequest_Btn.TabIndex = 5;
            this.SendRequest_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendRequest_Btn.Click += new System.EventHandler(this.SendRequest_Btn_Click);
            // 
            // Email_TB
            // 
            this.Email_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_TB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_TB.ForeColor = System.Drawing.Color.White;
            this.Email_TB.HintForeColor = System.Drawing.Color.LightGray;
            this.Email_TB.HintText = "Your Email Address";
            this.Email_TB.isPassword = false;
            this.Email_TB.LineFocusedColor = System.Drawing.Color.Lavender;
            this.Email_TB.LineIdleColor = System.Drawing.Color.White;
            this.Email_TB.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.Email_TB.LineThickness = 2;
            this.Email_TB.Location = new System.Drawing.Point(23, 257);
            this.Email_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(370, 46);
            this.Email_TB.TabIndex = 2;
            this.Email_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Email_TB.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(30, 183);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(353, 42);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Please use your registered email address to recover\r\n your password\r\n";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(106, 114);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(220, 34);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Forgot Password";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Controls.Add(this.pictureBox3);
            this.leftPanel.Controls.Add(this.bunifuCustomLabel7);
            this.leftPanel.Controls.Add(this.bunifuCustomLabel6);
            this.leftPanel.Controls.Add(this.bunifuCustomLabel5);
            this.leftPanel.Controls.Add(this.pictureBox1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(417, 521);
            this.leftPanel.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::OBE_Desktop.Properties.Resources.backicon;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.onBackIconClick);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Enabled = false;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Franklin Gothic Book", 8F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(85, 485);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(228, 15);
            this.bunifuCustomLabel7.TabIndex = 8;
            this.bunifuCustomLabel7.Text = "All Rights Reserved 2020 © Muhammad Awais";
            this.bunifuCustomLabel7.Click += new System.EventHandler(this.bunifuCustomLabel7_Click);
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
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 521);
            this.Controls.Add(this.loginScreenMainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.loginScreenMainPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Icon)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginScreenMainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Email_TB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 SendRequest_Btn;
        private System.Windows.Forms.PictureBox Close_Icon;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel Email_errorLbl;
    }
}

