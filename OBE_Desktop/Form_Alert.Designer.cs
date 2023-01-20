namespace OBE_Desktop
{
    partial class Form_Alert
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
            this.components = new System.ComponentModel.Container();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.AlertFormTimer = new System.Windows.Forms.Timer(this.components);
            this.AlertType_PictureBox = new System.Windows.Forms.PictureBox();
            this.Cancel_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AlertType_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.White;
            this.MessageLabel.Location = new System.Drawing.Point(65, 25);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(91, 17);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Text Message";
            // 
            // AlertFormTimer
            // 
            this.AlertFormTimer.Interval = 10;
            this.AlertFormTimer.Tick += new System.EventHandler(this.AlertFormTimer_Tick);
            // 
            // AlertType_PictureBox
            // 
            this.AlertType_PictureBox.Image = global::OBE_Desktop.Properties.Resources.Success;
            this.AlertType_PictureBox.InitialImage = null;
            this.AlertType_PictureBox.Location = new System.Drawing.Point(8, 12);
            this.AlertType_PictureBox.Name = "AlertType_PictureBox";
            this.AlertType_PictureBox.Size = new System.Drawing.Size(51, 43);
            this.AlertType_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AlertType_PictureBox.TabIndex = 2;
            this.AlertType_PictureBox.TabStop = false;
            // 
            // Cancel_PictureBox
            // 
            this.Cancel_PictureBox.Image = global::OBE_Desktop.Properties.Resources.Cancel;
            this.Cancel_PictureBox.InitialImage = null;
            this.Cancel_PictureBox.Location = new System.Drawing.Point(344, 21);
            this.Cancel_PictureBox.Name = "Cancel_PictureBox";
            this.Cancel_PictureBox.Size = new System.Drawing.Size(39, 25);
            this.Cancel_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cancel_PictureBox.TabIndex = 2;
            this.Cancel_PictureBox.TabStop = false;
            this.Cancel_PictureBox.Click += new System.EventHandler(this.Cancel_PictureBox_Click);
            // 
            // Form_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(388, 69);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel_PictureBox);
            this.Controls.Add(this.AlertType_PictureBox);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlertType_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cancel_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.PictureBox AlertType_PictureBox;
        private System.Windows.Forms.Timer AlertFormTimer;
        private System.Windows.Forms.PictureBox Cancel_PictureBox;
    }
}