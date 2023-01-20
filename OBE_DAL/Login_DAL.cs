using System.Linq;
using OBE_BEL.Admin_Section.UserBEL;

namespace OBE_DAL
{
    public class Login_DAL
    {
        public User LogginInDAL(string userName, string password)
        {
            using (ApplicationDbContext _dbContext = new OBE_DAL.ApplicationDbContext ())
            {
                var Ent = _dbContext.Users.Where((U => U.Email == userName && U.Password == password)).FirstOrDefault();

                return Ent;
                
            }
        }
    }
}
