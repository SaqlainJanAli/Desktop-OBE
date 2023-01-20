using System;
using System.Windows.Forms;
using OBE_BLL;
using System.Text.RegularExpressions;
using OBE_Desktop.MyInstitute_Section.InstituteUI;

namespace OBE_Desktop
{
    public partial class Login : Form
    {
        Login_BLL _loginBLL = new Login_BLL();
        Institute _instForm = new Institute();

        public Login()
        {
            InitializeComponent();
        }


        private void onCloseIconClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void onForgotPasswordTextClick(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPasswordWindow = new ForgotPassword();
            forgotPasswordWindow.Show();
        }

        private void ForgotPassword_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            validateLogin();
        }

        private void validateLogin()
        {
            string EmailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(EmailRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(UserName_TB.Text) && !string.IsNullOrWhiteSpace(Password_TB.Text))
            {
                LoggginIn();
            }
            else if (string.IsNullOrWhiteSpace(Password_TB.Text))
            {
                Password_errorLbl.Visible = true;
            }
            else
            {
                Email_errorLbl.Visible = true;

            }
        }

        private void LoggginIn()
        {
            var Ent = _loginBLL.LogginInBLL(UserName_TB.Text, Password_TB.Text);
            if (Ent == null)
            {
                _instForm.NotifyAlert("Invalid Login", Form_Alert.enmType.Error);
            }
            else
            {
                _instForm.NotifyAlert("Valid Login", Form_Alert.enmType.Success);
                this.Hide();
                Home _home = new Home(Ent);
                _home.Show();
            }
        }

        private void UserName_TB_OnValueChanged(object sender, EventArgs e)
        {
            
                
        }

        private void onLoginLoad(object sender, EventArgs e)
        {

            Email_errorLbl.Visible = false;
            Password_errorLbl.Visible = false;

            copyright_Lbl.Text = $"All Rights Reserved {DateTime.Now.Year} © D-OBE Development Team";

        }


        private void onEnterKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                validateLogin();
            }

        }

        private void Password_TB_OnValueChanged(object sender, EventArgs e)
        {
            Password_TB.isPassword = true;
        }

        private int _count;
        private void onHover(object sender, EventArgs e)
        {
            
            if (_count<1)
            {
                Password_TB.Text = null;
                Password_TB.isPassword = false;
                Password_TB.HintText = "Password";
                ++_count;
            }
        }
    }
}
