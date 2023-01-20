using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OBE_BEL.Admin_Section.UserBEL;
using OBE_BLL.AdminSection_BLL;

namespace OBE_Desktop
{
    public partial class ForgotPassword : Form
    {
        User_BLL _userBll = new User_BLL();
        Form_Alert NewAlertFrm = new Form_Alert();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }


        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void onCloseIconClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void onBackIconClick(object sender, EventArgs e)
        {
            this.Hide();
            Login loginWindow = new Login();
            loginWindow.Show();
        }

        private void SendRequest_Btn_Click(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void ValidateEmail()
        {
            string EmailRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            Regex re = new Regex(EmailRegex, RegexOptions.IgnoreCase);

            if (re.IsMatch(Email_TB.Text))
            {
                var _user = CheckInDatabase();
                if (_user != null)
                {
                    SendRequest(_user);
                }

            }
            else
            {
                Email_errorLbl.Visible = true;
            }
        }

        private User CheckInDatabase()
        {

            var Ent = _userBll.getUserByEmailBLL(Email_TB.Text);

            if (Ent != null)
            {
                return Ent;
            }
            else
            {
                NewAlertFrm.showAert("This Email is not registered in System", Form_Alert.enmType.Error);
                return null;
            }
        }

        private void SendRequest(User _user)
        {

            try
            {
                using (MailMessage _MailMessage = new MailMessage())
                {
                    string To, From, MessageBody;

                    To = Email_TB.Text;
                    From = "saqlainjan151@gmail.com";
                    MessageBody = "Dear " + _user.FirstName + ",\nYour Password is '" + _user.Password + "'.\n\nDon't share your password with others.\nThank You.\n\nRegards,\nD-OBE Admin";
                    _MailMessage.To.Add(To);
                    _MailMessage.From = new MailAddress(From);
                    _MailMessage.Body = MessageBody;
                    _MailMessage.Subject = "Your D-OBE Login Password";
                    

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = new NetworkCredential("saqlainjan151@gmail.com", "SMJA AAG");
                        smtp.EnableSsl = true;
                        smtp.Send(_MailMessage);
                        NewAlertFrm.showAert("Password has been emailed", Form_Alert.enmType.Success);
                        NewAlertFrm.showAert("Please check your email for the password", Form_Alert.enmType.Info);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            Email_errorLbl.Visible = false;
        }
    }
}
