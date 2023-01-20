namespace OBE_Desktop.Reports.SemsterGPA
{
    partial class StudentSemesterGPA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSemesterGPA));
            this.StudentTranscript_RV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // StudentTranscript_RV
            // 
            this.StudentTranscript_RV.ActiveViewIndex = -1;
            this.StudentTranscript_RV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentTranscript_RV.Cursor = System.Windows.Forms.Cursors.Default;
            this.StudentTranscript_RV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentTranscript_RV.Location = new System.Drawing.Point(0, 0);
            this.StudentTranscript_RV.Name = "StudentTranscript_RV";
            this.StudentTranscript_RV.Size = new System.Drawing.Size(959, 607);
            this.StudentTranscript_RV.TabIndex = 0;
            this.StudentTranscript_RV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // StudentSemesterGPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 607);
            this.Controls.Add(this.StudentTranscript_RV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentSemesterGPA";
            this.Text = "Student Result Transcript";
            this.Load += new System.EventHandler(this.StudentSemesterGPA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer StudentTranscript_RV;
    }
}