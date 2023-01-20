namespace OBE_Desktop.MyInstitute_Section.CourseSectionUI.Students
{
    partial class ImportFromProgramBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFromProgramBatch));
            this.select_Btn = new System.Windows.Forms.Button();
            this.ProgramBatch_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SuspendLayout();
            // 
            // select_Btn
            // 
            this.select_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.select_Btn.FlatAppearance.BorderSize = 0;
            this.select_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select_Btn.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_Btn.ForeColor = System.Drawing.Color.White;
            this.select_Btn.Location = new System.Drawing.Point(41, 132);
            this.select_Btn.Name = "select_Btn";
            this.select_Btn.Size = new System.Drawing.Size(80, 30);
            this.select_Btn.TabIndex = 67;
            this.select_Btn.Text = "Select";
            this.select_Btn.UseVisualStyleBackColor = false;
            this.select_Btn.Click += new System.EventHandler(this.select_Btn_Click);
            // 
            // ProgramBatch_CB
            // 
            this.ProgramBatch_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProgramBatch_CB.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramBatch_CB.FormattingEnabled = true;
            this.ProgramBatch_CB.IntegralHeight = false;
            this.ProgramBatch_CB.Items.AddRange(new object[] {
            "Campus Admin",
            "Coordinator",
            "Coordinator-Faculty",
            "Department Admin",
            "Teacher / Faculty",
            "University Admin"});
            this.ProgramBatch_CB.Location = new System.Drawing.Point(38, 82);
            this.ProgramBatch_CB.Name = "ProgramBatch_CB";
            this.ProgramBatch_CB.Size = new System.Drawing.Size(311, 29);
            this.ProgramBatch_CB.TabIndex = 65;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(38, 55);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(121, 21);
            this.bunifuCustomLabel10.TabIndex = 66;
            this.bunifuCustomLabel10.Text = "Program Batches";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(32, 23);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(191, 21);
            this.bunifuCustomLabel2.TabIndex = 69;
            this.bunifuCustomLabel2.Text = "Select Program Batches";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator2.LineThickness = 10791;
            this.bunifuSeparator2.Location = new System.Drawing.Point(36, 25);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(313, 20);
            this.bunifuSeparator2.TabIndex = 68;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ImportFromProgramBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 180);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.select_Btn);
            this.Controls.Add(this.ProgramBatch_CB);
            this.Controls.Add(this.bunifuCustomLabel10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportFromProgramBatch";
            this.Text = "ImportFromProgramBatch";
            this.Load += new System.EventHandler(this.ImportFromProgramBatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select_Btn;
        private System.Windows.Forms.ComboBox ProgramBatch_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
    }
}