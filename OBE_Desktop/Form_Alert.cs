using OBE_Desktop.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OBE_Desktop
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {

        }
        public enum enmAction
        {
            start,
            wait,
            close
        }
        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }
        public Form_Alert.enmAction action;
        private int x, y;

        

        private void AlertFormTimer_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case enmAction.wait:
                    AlertFormTimer.Interval = 5000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    AlertFormTimer.Interval = 1;
                    this.Opacity += 0.1;

                    if(this.x<this.Location.X)
                    {
                        this.Left--;

                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                           action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    AlertFormTimer.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity==0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void Cancel_PictureBox_Click(object sender, EventArgs e)
        {
            this.AlertFormTimer.Interval = 1;
            action = enmAction.close;
        }

        public void showAert(string msg,enmType type)
        {
            this.Opacity = 0.0;
            this.BringToFront();
            this.StartPosition = FormStartPosition.Manual;

            string fname;
            for (int i=1;i<12;i++)
            {
                fname = "Alert " + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];
                if(frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 20;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);

                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.MessageLabel.Text = msg;

            switch (type)
            {
                case enmType.Success:
                    this.AlertType_PictureBox.Image = Resources.Success;
                    this.BackColor = Color.SeaGreen;
                    break;
                case enmType.Warning:
                    this.AlertType_PictureBox.Image = Resources.Warning;
                    this.BackColor = Color.DarkOrange;
                    break;
                case enmType.Error:
                    this.AlertType_PictureBox.Image = Resources.Error;
                    this.BackColor = Color.DarkRed;
                    break;
                case enmType.Info:
                    this.AlertType_PictureBox.Image = Resources.Info;
                    this.BackColor = Color.RoyalBlue;
                    break;
            }
            
            this.Show();

            this.action = enmAction.start;
            this.AlertFormTimer.Interval = 1;
            this.AlertFormTimer.Start();
        }
    }
}
