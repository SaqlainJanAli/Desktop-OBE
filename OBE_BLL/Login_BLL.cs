using OBE_BEL.Admin_Section.UserBEL;
using OBE_DAL;

namespace OBE_BLL
{
    public class Login_BLL
    {
        Login_DAL _loginDAL = new Login_DAL();

        public User LogginInBLL(string UserName, string Password)
        {
            return _loginDAL.LogginInDAL(UserName, Password);
        }
    }
}
